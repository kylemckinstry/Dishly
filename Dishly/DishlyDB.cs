using Dishly.Model;
using Newtonsoft.Json;

namespace Dishly
{
    public static class DishlyDB
    {
        private const string DataFolderName = "Data";

        private const string CategoriesFileName = "Categories.json";
        private const string FavoritesFileName = "Favorites.json";
        private const string ShoppingListFileName = "ShoppingList.json";
        private const string MyWeekFileName = "MyWeek.json";

        private static List<Recipe> _favorites = [];
        private static List<Ingredient> _shoppingList = [];
        private static List<MealCategory> _categories = [];
        private static Recipe?[,] _myWeek = new Recipe[7, 3];

        public static async Task LoadCategories()
        {
            _categories = await LoadJsonFile<MealCategory>(CategoriesFileName);

            if (_categories.Count > 0) return;

            _categories = await RecipeAPI.FetchMealCategories();

            await StoreJsonFile(CategoriesFileName, _categories);
        }

        public static async Task LoadFavorites()
        {
            _favorites = await LoadJsonFile<Recipe>(FavoritesFileName);
        }

        public static async Task StoreFavorites()
        {
            await StoreJsonFile(FavoritesFileName, _favorites);
        }

        public static async Task LoadShoppingList()
        {
            _shoppingList = await LoadJsonFile<Ingredient>(ShoppingListFileName);
        }

        public static async Task StoreShoppingList()
        {
            await StoreJsonFile(ShoppingListFileName, _shoppingList);
        }
         
        // Ingredients functions
        public static List<Ingredient> GetAllIngredientsInMyWeek()
        {
            List<Ingredient> allIngredients = new List<Ingredient>();

            // Collects all ingredients from MyWeek recipes
            foreach (var recipe in GetAllWeeklyRecipes())
            {
                allIngredients.AddRange(recipe.Ingredients);
            }

            // Processes and converts measurements to grams
            var processedIngredients = ProcessIngredientMeasures(allIngredients);

            // Creates a list of Ingredients with the updated Measure in grams
            List<Ingredient> ingredientsInGrams = processedIngredients
                .Select(item => new Ingredient
                {
                    Name = $"{item.Name}/s",
                    Measure = $"{item.MeasureInGrams}g"
                })
                .OrderBy(ingredient => ingredient.Name) // Sorts alphabetically
                .ToList();

            return ingredientsInGrams;
        }

        //The below will1 - 1. Clean up any spaces in the measure,
        //2: Separate the number and unit 3. Convert to grams
        public static List<(string Name, int MeasureInGrams)> ProcessIngredientMeasures(List<Ingredient> ingredients)
        {
            var processedIngredients = new List<(string Name, int MeasureInGrams)>();

            // Groups ingredients by name and process each group
            var groupedIngredients = ingredients.GroupBy(ingredient => ingredient.Name);

            foreach (var group in groupedIngredients)
            {
                string ingredientName = group.Key;
                int totalAmountInGrams = 0;

                foreach (var ingredient in group)
                {
                    // Cleans up any spaces in the measure
                    string cleanedMeasure = RemoveSpaces(ingredient.Measure);

                    // Separates thes number and unit
                    (int amount, string unit) = NumberExtractor(cleanedMeasure);

                    // Converts it to grams if there is a unit; otherwise, use the amount as-is
                    int measureInGrams = string.IsNullOrEmpty(unit) ? amount : ConvertToGrams(amount, unit);

                    // Sums the amounts for this ingredient
                    totalAmountInGrams += measureInGrams;
                }

                // Add the processed ingredient with the total measure in grams to the list
                processedIngredients.Add((ingredientName, totalAmountInGrams));
            }

            return processedIngredients;
        }

        // Removes spaces
        private static string RemoveSpaces(string measure)
        {
            return measure.Replace(" ", "");
        }

        // Extracts the numeric part and unit part of the measure
        private static (int, string) NumberExtractor(string measure)
        {
            // Separates the number and unit
            string numberPart = new string(measure.TakeWhile(char.IsDigit).ToArray());
            string unitPart = new string(measure.SkipWhile(char.IsDigit).ToArray()).ToLower(); // Ensure lowercase

            int amount = int.TryParse(numberPart, out int result) ? result : 0;
            return (amount, unitPart);
        }

        private static int ConvertToGrams(int amount, string unit)
        {
            // If the unit is empty, return the amount as-is without conversion
            if (string.IsNullOrWhiteSpace(unit))
            {
                return amount;
            }

            switch (unit)
            {
                case " ":
                    return amount;
                case "kg":
                    return amount * 1000;
                case "g":
                    return amount;
                case "mg":
                    return amount / 1000;
                case "lb":
                    return (int)(amount * 453.592);
                case "oz":
                    return (int)(amount * 28.3495);
                case "cup" or "cups":
                    return amount * 240;
                case "pinch" or "pinches" or "sprinkling" or "totaste" or "sprinking" or "Top":
                    amount = 10;
                    return amount;
                case "to serve" or "handful" or "toserve":
                    amount = 200;
                    return amount;
                case "tbs" or "tb" or "tblsp" or "tbsp":
                    return amount * 20;
                case "ts" or "tsp":
                    if (amount >= 1) { return amount * 6; }
                    else { amount = 5; return amount; };
                case "for frying":
                    return amount * 20;
                case "Chopped":
                    if (amount >= 1) { return amount * 150; }
                    else {amount = 150;return amount;};
                default:
                    return amount; // If unknown unit, return the amount unchanged
            }
        }

        //MyWeek functions
        public static async Task LoadMyWeek()
        {
            Directory.CreateDirectory(DataFolderName);

            var filePath = Path.Combine(DataFolderName, MyWeekFileName);

            if (File.Exists(filePath))
            {
                var fileContent = await File.ReadAllTextAsync(filePath);

                var json = JsonConvert.DeserializeObject<Recipe[,]>(fileContent);

                if (json != null)
                {
                    if (json.GetLength(0) == 7 && json.GetLength(1) == 3)
                    {
                        _myWeek = json;
                    }
                }
            }
        }

        public static async Task StoreMyWeek()
        {
            Directory.CreateDirectory(DataFolderName);

            var filePath = Path.Combine(DataFolderName, MyWeekFileName);

            var json = JsonConvert.SerializeObject(_myWeek);

            await File.WriteAllTextAsync(filePath, json);
        }

        private static async Task<List<T>> LoadJsonFile<T>(string fileName)
        {
            Directory.CreateDirectory(DataFolderName);

            var filePath = Path.Combine(DataFolderName, fileName);

            if (File.Exists(filePath))
            {
                var fileContent = await File.ReadAllTextAsync(filePath);

                var json = JsonConvert.DeserializeObject<List<T>>(fileContent);

                if (json != null)
                {
                    return json;
                }
            }

            return new List<T>();
        }
        
        private static async Task StoreJsonFile(string fileName, object value)
        {
            Directory.CreateDirectory(DataFolderName);

            var filePath = Path.Combine(DataFolderName, fileName);

            var json = JsonConvert.SerializeObject(value);

            await File.WriteAllTextAsync(filePath, json);
        }
        
        public static MealCategory? GetMealCategory(string name)
        {
            return _categories.FirstOrDefault(category => category.Name == name);
        }

        public static MealCategory? GetMealCategory(int id)
        {
            return _categories.FirstOrDefault(category => category.Id == id);
        }

        // Favourites functions

        public static event Action FavoritesChanged;

        public static void AddToFavorites(Recipe recipe)
        {
            if (recipe == null || IsFavorite(recipe)) return;

            _favorites.Add(recipe);
            FavoritesChanged?.Invoke();
        }

        public static void RemoveFromFavorites(Recipe recipe)
        {
            _favorites.RemoveAll(r => r == recipe);
            FavoritesChanged?.Invoke();
        }

        public static bool IsFavorite(Recipe recipe)
        {
            return _favorites.Any(r => r == recipe);
        }

        public static void AddToShoppingList(Ingredient ingredient)
        {
            _shoppingList.Add(ingredient);
        }


        // Ingredients/shopping list functions

        public static void AddToShoppingList(Recipe recipe)
        {
            _shoppingList.AddRange(recipe.Ingredients);
        }

        public static void RemoveFromShoppingList(int index)
        {
            if (index < 0 || index >= _shoppingList.Count) return;

            _shoppingList.RemoveAt(index);
        }

        public static void ClearShoppingList()
        {
            _shoppingList.Clear();
        }


        //MyWeek functions continued

        public static void AddToMyWeek(Recipe recipe, int day, int mealTime)
        {
            _myWeek[day, mealTime] = recipe;
        }

        public static void RemoveSpecificFromMyWeek(int day, int mealTime)
        {
            _myWeek[day, mealTime] = null;
        }

        public static void RemoveFromMyWeek(Recipe recipe)
        {
            var days = _myWeek.GetLength(0);
            var meals = _myWeek.GetLength(1);

            for (var i = 0; i < days; i++)
            {
                for (var j = 0; j < meals; j++)
                {
                    if (_myWeek[i, j] == recipe) 
                    {
                        _myWeek[i, j] = null;
                    }
                }
            }
        }

        public static List<Recipe> GetAllWeeklyRecipes()
        {
            var recipes = new List<Recipe>();
            var days = _myWeek.GetLength(0);
            var meals = _myWeek.GetLength(1);

            for (var i = 0; i < days; i++)
            {
                for (var j = 0; j < meals; j++)
                {
                    var recipe = _myWeek[i, j];
                    if (recipe != null)
                    {
                        recipes.Add(recipe);
                    }
                }
            }

            return recipes;
        }

        public static Recipe? GetFromMyWeek(int day, int mealTime) 
        {
            return _myWeek[day, mealTime]; 
        }

        public static bool IsInMyWeek(Recipe recipe)
        {
            var days = _myWeek.GetLength(0);
            var meals = _myWeek.GetLength(1);

            for (var i = 0; i < days; i++)
            {
                for (var j = 0;  j < meals; j++)
                {
                    if (_myWeek[i, j] == recipe) return true;
                }
            }

            return false;
        }

        public static List<Recipe> GetAllFavorites()
        {
            return _favorites;
        }
    }
}
