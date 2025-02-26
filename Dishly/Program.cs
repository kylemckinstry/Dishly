using System.Diagnostics;

namespace Dishly
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();

            MainAsync().GetAwaiter().GetResult();
        }

        static async Task MainAsync()
        {
            await DishlyDB.LoadCategories();
            await DishlyDB.LoadFavorites();
            await DishlyDB.LoadShoppingList();
            await DishlyDB.LoadMyWeek();

            Application.Run(new RecipeBrowserForm());
        }
    }
}