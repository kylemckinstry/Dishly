using Dishly.Model;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Dishly
{
    internal static class RecipeAPI
    {
        /// <summary>
        /// Fetches recipes that match the name.
        /// </summary>
        /// <param name="mealName">Search name</param>
        /// <returns>List of recipes matching name</returns>
        public static async Task<List<Recipe>> Fetch(string mealName, int count = -1, int offset = 0)
        {
            var apiUrl = $"https://www.themealdb.com/api/json/v1/1/search.php?s={mealName}";

            return await FetchByUrl(apiUrl, count, offset);
        }

        // Function to search by ingredients and filter 
        public static async Task<List<Recipe>> FetchByIngredientOnly(string ingredientName, int count = -1, int offset = 0)
        {
            // Fetch a broad set of recipes to filter by ingredient
            var allRecipes = await FetchByUrl("https://www.themealdb.com/api/json/v1/1/filter.php?i={ingredientName}", count, offset);

            // Filter recipes to include only those where any ingredient contains the search term
            return allRecipes.Where(recipe => recipe.Ingredients.Any(
                ingredient => ingredient.Name.IndexOf(ingredientName, StringComparison.OrdinalIgnoreCase) >= 0
            )).ToList();
        }

        // Function to search via meal name AND ingredient
        public static async Task<List<Recipe>> FetchWithFallback(string searchTerm, HashSet<string> excludedIngredients, int count = -1, int offset = 0)
        {
            // Step 1: Fetch recipes by meal name
            var recipes = await Fetch(searchTerm);

            // Step 2: If fewer than 8 recipes are found, fetch by ingredient
            if (recipes.Count < count)
            {
                var additionalRecipes = await FetchByIngredientOnly(searchTerm);

                var uniqueAdditionalRecipes = additionalRecipes
                    .Where(additionalRecipe => !recipes.Any(existingRecipe => existingRecipe == additionalRecipe));

                recipes.AddRange(uniqueAdditionalRecipes);
            }

            // Step 3: Filter out recipes that contain any excluded ingredient as a substring in their ingredient names
            var results = recipes.Where(recipe => !recipe.Ingredients.Any(ingredient =>
                excludedIngredients.Any(excluded => ingredient.Name.IndexOf(excluded, StringComparison.OrdinalIgnoreCase) >= 0)
            )).ToList();

            if (count < 0) count = results.Count;

            if (offset + count >= results.Count) count = results.Count - offset;

            if (offset >= results.Count) return new List<Recipe>();

            return results.GetRange(offset, count);
        }

        /// <summary>
        /// Fetches a recipe by id.
        /// </summary>
        /// <param name="mealId">Id of the recipe</param>
        /// <returns>A single recipe by id</returns>
        public static async Task<Recipe?> Fetch(int mealId)
        {
            var apiUrl = $"https://www.themealdb.com/api/json/v1/1/lookup.php?i={mealId}";

            var result = await FetchByUrl(apiUrl);

            return result.Count > 0 ? result[0] : null;
        }


        /// <summary>
        /// Fetches a random recipe
        /// </summary>
        /// <returns>A single recipe</returns>
        public static async Task<Recipe?> Fetch()
        {
            var apiUrl = $"https://www.themealdb.com/api/json/v1/1/random.php";

            var result = await FetchByUrl(apiUrl);

            return result.Count > 0 ? result[0] : null;
        }

        public static async Task<List<Recipe>> FetchRandom(int count = 1)
        {
            var results = new List<Recipe>();

            while (results.Count < count)
            {
                var result = await Fetch();

                if (result != null) results.Add(result);
            }

            return results;
        }

        /// <summary>
        /// Fetches recipes by category.
        /// </summary>
        /// <param name="category">Category for recipes to search</param>
        /// <returns>List of recipes in the category</returns>
        public static async Task<List<Recipe>> Fetch(MealCategory category, int count = -1, int offset = 0)
        {
            var apiUrl = $"https://www.themealdb.com/api/json/v1/1/filter.php?c={category.Name}";

            return await FetchByUrl(apiUrl, count, offset);
        }

        public static async Task<List<MealCategory>> FetchMealCategories()
        {
            var apiUrl = $"https://www.themealdb.com/api/json/v1/1/categories.php";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    var jsonResponse = await response.Content.ReadAsStringAsync();

                    var jsonDict = JsonConvert.DeserializeObject<
                        Dictionary<string,
                            List<Dictionary<string, string>>>>(jsonResponse);

                    if (jsonDict != null && jsonDict.TryGetValue("categories", out var categoryData))
                    {
                        var categories = new List<MealCategory>();

                        foreach (var category in categoryData)
                        {
                            if (!ExtractEntry(category, "strCategory", out var categoryName)) continue;
                            if (!ExtractEntry(category, "strCategoryThumb", out var categoryThumbUrl)) continue;
                            if (!ExtractEntry(category, "strCategoryDescription", out var categoryDescription)) continue;
                            if (!ExtractEntryAs<int>(category, "idCategory", out var categoryId)) continue;

                            var mealCategory = new MealCategory
                            {
                                Name = categoryName,
                                Id = categoryId,
                                Description = categoryDescription,
                                ThumbnailUrl = categoryThumbUrl,
                            };

                            categories.Add(mealCategory);
                        }

                        return categories;
                    }
                    else
                    {
                        //Commented out due to overlap with UI code and causing an error: As i setup the code to search both 
                        // Meal name and ingredients - after meal name this error would popup and THEN it would allow me to search for ingredients
                        //Debug.WriteLine("No recipes found for the provided meal name.");
                    }
                } 
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error fetching recipe: {ex.Message}");
                }
            }

            return new List<MealCategory>();
        }
        
        private static async Task<List<Recipe>> FetchByUrl(string url, int count = -1, int offset = 0)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    var jsonResponse = await response.Content.ReadAsStringAsync();

                    var jsonDict = JsonConvert.DeserializeObject<
                        Dictionary<string,
                            List<Dictionary<string, string>>>>(jsonResponse);

                    if (jsonDict != null && jsonDict.TryGetValue("meals", out var meals) && meals != null)
                    {
                        List<Recipe> recipes = new List<Recipe>();

                        if (count < 0 || count > meals.Count) count = meals.Count;

                        if (offset + count >= meals.Count) count = meals.Count - offset;

                        if (offset >= meals.Count) return new List<Recipe>(recipes);

                        var mealSelection = meals.GetRange(offset, count);

                        foreach (var meal in mealSelection)
                        {
                            if (!ExtractEntry(meal, "strMeal", out var recipeName)) continue;
                            if (!ExtractEntry(meal, "strMealThumb", out var recipeThumbUrl)) continue;
                            if (!ExtractEntryAs<int>(meal, "idMeal", out var recipeId)) continue;
                            if (!ExtractEntry(meal, "strInstructions", out var recipeInstructions)) continue;

                            // These shouldn't stop from adding a recipe
                            ExtractEntry(meal, "strCategory", out var recipeCategoryName);
                            ExtractEntry(meal, "strArea", out var recipeCuisine);
                            ExtractEntry(meal, "strTags", out var recipeTagsString);

                            var categoryId = DishlyDB.GetMealCategory(recipeCategoryName)?.Id;
                            var recipeTags = recipeTagsString.Split(',');

                            var recipe = new Recipe
                            {
                                Name = recipeName,
                                ThumbnailUrl = recipeThumbUrl,
                                Id = recipeId,
                                Steps = recipeInstructions,
                                CategoryId = categoryId ?? -1,
                                Cuisine = recipeCuisine,
                                Tags = recipeTags.ToList()
                            };


                            for (var i = 1; i <= Settings.MaxIngredientsPerRecipe; i++)
                            {
                                if (!ExtractEntry(meal, $"strIngredient{i}", out var ingredientName)) continue;
                                if (!ExtractEntry(meal, $"strMeasure{i}", out var ingredientMeasure)) continue;

                                var ingredient = new Ingredient
                                {
                                    Name = ingredientName,
                                    Measure = ingredientMeasure,
                                };

                                recipe.Ingredients.Add(ingredient);
                            }

                            recipes.Add(recipe);
                        }

                        return recipes;
                    }
                    else
                    {
                        //Commented out due to overlap with UI code and causing an error: As i setup the code to search both 
                        // Meal name and ingredients - after meal name this error would popup and THEN it would allow me to search for ingredients
                        //MessageBox.Show("No recipes found for the provided meal name.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching recipe: {ex.Message}");
                }
            }

            return new List<Recipe>();
        }

        private static bool ExtractEntry(Dictionary<string, string> entry, string name, out string result)
        {
            if (entry.TryGetValue(name, out var value)) 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    result = value;
                    return true;
                }
            }

            result = string.Empty;
            return false;
        }

        private static bool ExtractEntryAs<T>(Dictionary<string, string> entry, string name, out T result)
        {
            if (entry.TryGetValue(name, out var value))
            {
                if (!string.IsNullOrEmpty(value))
                {
                    result = (T)Convert.ChangeType(value, typeof(T));
                    return true;
                }
            }

            result = default;
            return false;
        }
    }
}
