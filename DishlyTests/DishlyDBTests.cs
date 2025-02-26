using Dishly.Model;
using System.Diagnostics;
using Dishly;

namespace DishlyTests
{
    [TestFixture]
    public class DishlyDBTests
    {
        [Test]
        public async Task LoadAndStoreFavorites_ShouldPersistFavorites()
        {
            var recipe = new Recipe { Id = 1, Name = "Test Recipe" };
            DishlyDB.AddToFavorites(recipe);

            await DishlyDB.StoreFavorites();
            await DishlyDB.LoadFavorites();
            var favorites = DishlyDB.GetAllFavorites();

            Assert.That(favorites.Contains(recipe));
        }

        [Test]
        public void AddToMyWeek_ShouldStoreRecipeInCorrectSlot()
        {
            var recipe = new Recipe { Id = 1, Name = "Test Recipe" };

            DishlyDB.AddToMyWeek(recipe, day: 1, mealTime: 1);
            var result = DishlyDB.GetFromMyWeek(day: 1, mealTime: 1);

            Assert.That(recipe == result);
        }

        [Test]
        public void AddToFavorites_ShouldTriggerFavoritesChangedEvent()
        {
            var favoritesChanged = false;
            DishlyDB.FavoritesChanged += () => favoritesChanged = true;

            var recipe = new Recipe { Id = 1, Name = "Test Recipe" };

            DishlyDB.AddToFavorites(recipe);

            Assert.That(favoritesChanged);
        }

        [Test]
        public void ProcessIngredientMeasures_ShouldConvertUnitsToGrams()
        {
            var ingredients = new List<Ingredient>
            {
                new Ingredient { Name = "Sugar", Measure = "1 kg" },
                new Ingredient { Name = "Salt", Measure = "500 g" }
            };

            var processed = DishlyDB.ProcessIngredientMeasures(ingredients);

            Assert.That(1000 == processed.Find(i => i.Name == "Sugar").MeasureInGrams);
            Assert.That(500 == processed.Find(i => i.Name == "Salt").MeasureInGrams);
        }
    }
}