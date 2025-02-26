using Dishly.Model;
using Dishly.View;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Reflection;

namespace Dishly
{
    public partial class RecipeBrowserForm : Form
    {
        private const int ItemsPerPage = 8;

        private int _currentPage = 1;
        private string _searchTerm;

        public RecipeBrowserForm()
        {
            InitializeComponent();

            FormClosing += new FormClosingEventHandler(MainForm_FormClosing);

            Load += new EventHandler(RecipeBrowserForm_Load);

            //creates Favourites userControl
            favourites1 = new Favourites();
            this.Controls.Add(favourites1);
            favourites1.Visible = false;
            favourites1.AutoSize = true;

            //creates MyWeek userControl
            myWeek1 = new MyWeek();
            this.Controls.Add(myWeek1);
            myWeek1.Visible = false;

            //creates preferences userControl
            preferences1 = new Preferences();
            this.Controls.Add(preferences1);
            preferences1.Visible = false;

            //creates IngredientsList userControl
            ingredientsList1 = new IngredientsList();
            this.Controls.Add(ingredientsList1);
            ingredientsList1.Visible = false;

            //creates CookingMethod userControl
            cookingMethod1 = new CookingMethod();
            this.Controls.Add(cookingMethod1);
            cookingMethod1.Visible = false;

            //creates RecipeDetailForm userControl
            recipeDetail1 = new View.RecipeDetailForm();
            recipeDetail1.Visible = false;
            recipeDetail1.BringToFront();

            recipeDetail1.Location = new Point(
                (this.ClientSize.Width - recipeDetail1.Width) / 2,
                (this.ClientSize.Height - recipeDetail1.Height) / 2
            );

            this.Controls.Add(recipeDetail1);

            hideRecipePanels();

            // RoundedCorners
            mainPanel2.Paint += (s, e) => RoundedCorners(mainPanel2, e);
            mainPanel3.Paint += (s, e) => RoundedCorners(mainPanel3, e);
            mainPanel4.Paint += (s, e) => RoundedCorners(mainPanel4, e);
            mainPanel5.Paint += (s, e) => RoundedCorners(mainPanel5, e);
            mainPanel6.Paint += (s, e) => RoundedCorners(mainPanel6, e);
            mainPanel7.Paint += (s, e) => RoundedCorners(mainPanel7, e);
            mainPanel8.Paint += (s, e) => RoundedCorners(mainPanel8, e);
            mainPanel9.Paint += (s, e) => RoundedCorners(mainPanel9, e);

            // Docks userControls for responsiveness
            favourites1.Dock = DockStyle.Fill;
            myWeek1.Dock = DockStyle.Fill;
            preferences1.Dock = DockStyle.Fill;
            ingredientsList1.Dock = DockStyle.Fill;
            cookingMethod1.Dock = DockStyle.Fill;

            showNextButton.Visible = false;
            showPreviousButton.Visible = false;
        }

        public void ShowCookingMethod(MyWeek weekInstance)
        {
            cookingMethod1.SetWeekInstance(weekInstance);
            cookingMethod1.Visible = true;
            cookingMethod1.BringToFront();
        }

        private void ShowMyWeekControl()
        {
            if (myWeek1 == null)
            {
                myWeek1 = new MyWeek();
                this.Controls.Add(myWeek1);
            }

            myWeek1.DisplayWeeklyPlan();
            myWeek1.Visible = true;
            myWeek1.BringToFront();
        }

        private void MainForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            try
            {
                var savingTask = Task.Run(async () =>
                {
                    await DishlyDB.StoreFavorites();
                    await DishlyDB.StoreShoppingList();
                    await DishlyDB.StoreMyWeek();
                });

                savingTask.Wait();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving data: " + ex.Message);
            }
        }

        private void favouritesButton_Click(object sender, EventArgs e)
        {
            ShowFavouritesPage();
        }

        public void ShowFavouritesPage()
        {
            HideAllPages();
            favourites1.Visible = true;
            favourites1.BringToFront();
            favourites1.DisplayFavourites();

        }

        private void myWeekButton_Click(object sender, EventArgs e)
        {
            ShowMyWeekPage();
        }

        public void ShowMyWeekPage()
        {
            HideAllPages();
            ShowMyWeekControl();
        }


        public void ShowIngredientsList()
        {
            HideAllPages();
            ingredientsList1.Visible = true;
            ingredientsList1.BringToFront();
        }

        private void HideAllPages()
        {
            myWeek1.Visible = false;
            favourites1.Visible = false;
            preferences1.Visible = false;
            ingredientsList1.Visible = false;
            cookingMethod1.Visible = false;
        }

        private void preferencesButton_Click(object sender, EventArgs e)
        {
            preferences1.Visible = true;
            preferences1.BringToFront();
        }

        // Shuffle button click to load random recipes
        private async void shuffleButton_Click(object sender, EventArgs e)
        {
            await LoadRandomRecipes();
        }

        private async void RecipeBrowserForm_Load(object sender, EventArgs e)
        {
            await LoadRandomRecipes();
        }

        private async Task LoadRandomRecipes()
        {
            hideRecipePanels();
            clearRecipePlaceholders();

            pictureBox1.Image = null;

            var recipes = await RecipeAPI.FetchRandom(ItemsPerPage);

            if (recipes.Count > 0)
            {
                for (int i = 0; i < recipes.Count; i++)
                {
                    setRecipePlaceholder(i, recipes[i]);
                }
            }
            else
            {
                textBox1.Text = "No recipes found.";
            }
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            showNextButton.Visible = false;
            _currentPage = 0;

            _searchTerm = mainSearchBox.Text.Trim();

            // Input Validation -  Minimumum: ensure it's not empty and has at least 3 characters
            if (string.IsNullOrEmpty(_searchTerm) || _searchTerm.Length < 2)
            {
                MessageBox.Show("Please enter a search term with at least 2 characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exits the method if the input is invalid
            }

            // Input Validation - Special characters: allows only commas, letters, numbers, and spaces but nothing else
            if (!System.Text.RegularExpressions.Regex.IsMatch(_searchTerm, @"^[\w\s,]*$"))
            {
                MessageBox.Show("Please use only letters, numbers, spaces, and commas in your search!", "Invalid Character Used", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Input Validation - Word count: ensure search has fewer than 50 words
            int wordCount = _searchTerm.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            if (wordCount > 50)
            {
                MessageBox.Show("An error has occured", "Word Limit Exceeded (50)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hide and clear recipe panels
            hideRecipePanels();
            clearRecipePlaceholders();
            pictureBox1.Image = null;
            textBox1.Text = "";  // Clears any previous text in the textbox

            // Gets excluded ingredients from Preferences
            var excludedIngredients = preferences1.ExcludedIngredients;

            // Fetches recipes, passing the excluded ingredients to RecipeAPI
            var recipes = await RecipeAPI.FetchWithFallback(_searchTerm, excludedIngredients, ItemsPerPage);

            // Displays results if any recipes are found
            if (recipes.Count > 0)
            {
                int recipeCount = Math.Min(recipes.Count, 8);
                for (int i = 0; i < recipeCount; i++)
                {
                    setRecipePlaceholder(i, recipes[i]);
                }

                if (recipes.Count >= ItemsPerPage)
                {
                    showNextButton.Visible = true;
                }
            }
            else
            {
                textBox1.Text = "No recipes found for the specified search term.";
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            Recipe? recipe = clickedPictureBox.Tag as Recipe;

            if (recipe != null)
            {
                if (recipeDetail1 == null)
                {
                    MessageBox.Show("There was an error displaying the recipe details.");
                    return;
                }

                recipeDetail1.SetPanelData(recipe);
                recipeDetail1.Visible = true;
                recipeDetail1.BringToFront();
            }
            else
            {
                MessageBox.Show("There was an error loading the recipe");
            }
        }

        private void setRecipePlaceholder(int index, Recipe recipe)
        {
            switch (index)
            {
                case 0:
                    // Shows panel 2 and set the contents for recipe 1
                    mainPanel2.Visible = true;
                    textBox1.Text = recipe.Name;
                    pictureBox1.LoadAsync(recipe.ThumbnailUrl);
                    pictureBox1.Tag = recipe;
                    break;

                case 1:
                    // Shows panel 3 and set the contents for recipe 2
                    mainPanel3.Visible = true;
                    textBox3.Text = recipe.Name;
                    pictureBox2.LoadAsync(recipe.ThumbnailUrl);
                    pictureBox2.Tag = recipe;
                    break;

                case 2:
                    // Shows panel 4 and set the contents for recipe 3
                    mainPanel4.Visible = true;
                    textBox5.Text = recipe.Name;
                    pictureBox3.LoadAsync(recipe.ThumbnailUrl);
                    pictureBox3.Tag = recipe;
                    break;

                case 3:
                    // Shows panel 5 and set the contents for recipe 4
                    mainPanel5.Visible = true;
                    textBox7.Text = recipe.Name;
                    pictureBox4.LoadAsync(recipe.ThumbnailUrl);
                    pictureBox4.Tag = recipe;
                    break;

                case 4:
                    // Shows panel 6 and set the contents for recipe 5
                    mainPanel6.Visible = true;
                    textBox9.Text = recipe.Name;
                    pictureBox5.LoadAsync(recipe.ThumbnailUrl);
                    pictureBox5.Tag = recipe;
                    break;

                case 5:
                    // Shows panel 7 and set the contents for recipe 6
                    mainPanel7.Visible = true;
                    textBox11.Text = recipe.Name;
                    pictureBox6.LoadAsync(recipe.ThumbnailUrl);
                    pictureBox6.Tag = recipe;
                    break;

                case 6:
                    // Shows panel 8 and set the contents for recipe 7
                    mainPanel8.Visible = true;
                    textBox13.Text = recipe.Name;
                    pictureBox7.LoadAsync(recipe.ThumbnailUrl);
                    pictureBox7.Tag = recipe;
                    break;

                case 7:
                    // Shows panel 9 and set the contents for recipe 8
                    mainPanel9.Visible = true;
                    textBox15.Text = recipe.Name;
                    pictureBox8.LoadAsync(recipe.ThumbnailUrl);
                    pictureBox8.Tag = recipe;
                    break;

                default:
                    // Setup default break to handle errors
                    break;
            }
        }

        private void hideRecipePanels()
        {
            mainPanel2.Visible = false;
            mainPanel3.Visible = false;
            mainPanel4.Visible = false;
            mainPanel5.Visible = false;
            mainPanel6.Visible = false;
            mainPanel7.Visible = false;
            mainPanel8.Visible = false;
            mainPanel9.Visible = false;
        }

        private void RoundedCorners(Panel panel, PaintEventArgs e)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 20;
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();

                panel.Region = new Region(path);
            }
        }

        private void clearRecipePlaceholders()
        {
            // Clears recipe 1 placeholders
            textBox1.Text = "Loading recipe...";
            pictureBox2.Image = null;

            // Clears recipe 2 placeholders
            textBox3.Text = "Loading recipe...";
            pictureBox2.Image = null;

            // Clears recipe 3 placeholders
            textBox5.Text = "Loading recipe...";
            pictureBox3.Image = null;

            // Clears recipe 4 placeholders
            textBox7.Text = "Loading recipe...";
            pictureBox4.Image = null;

            // Clears recipe 5 placeholders
            textBox9.Text = "Loading recipe...";
            pictureBox5.Image = null;

            // Clears recipe 6 placeholders
            textBox11.Text = "Loading recipe...";
            pictureBox6.Image = null;

            // Clears recipe 7 placeholders
            textBox13.Text = "Loading recipe...";
            pictureBox7.Image = null;

            // Clears recipe 8 placeholders
            textBox15.Text = "Loading recipe...";
            pictureBox8.Image = null;
        }

        private void shoppingListButton_Click(object sender, EventArgs e)
        {
            ingredientsList1.Visible = true;
            ingredientsList1.BringToFront();
        }

        private async void showNextButton_Click(object sender, EventArgs e)
        {
            showNextButton.Visible = false;
            showPreviousButton.Visible = false;
            hideRecipePanels();
            clearRecipePlaceholders();
            _currentPage++;

            var excludedIngredients = preferences1.ExcludedIngredients;

            // Fetches recipes, passing the excluded ingredients to RecipeAPI
            var recipes = await RecipeAPI.FetchWithFallback(_searchTerm, excludedIngredients, ItemsPerPage, ItemsPerPage * _currentPage);

            // Displays results if any recipes are found
            if (recipes.Count > 0)
            {
                int recipeCount = Math.Min(recipes.Count, 8);
                for (int i = 0; i < recipeCount; i++)
                {
                    setRecipePlaceholder(i, recipes[i]);
                }

                showNextButton.Visible = recipes.Count >= ItemsPerPage;
                showPreviousButton.Visible = _currentPage > 0;
            }
            else
            {
                textBox1.Text = "No recipes found for the specified search term.";
            }
        }

        private async void showPreviousButton_Click(object sender, EventArgs e)
        {
            showNextButton.Visible = false;
            showPreviousButton.Visible = false;
            hideRecipePanels();
            clearRecipePlaceholders();
            _currentPage--;

            var excludedIngredients = preferences1.ExcludedIngredients;

            // Fetches recipes, passing the excluded ingredients to RecipeAPI
            var recipes = await RecipeAPI.FetchWithFallback(_searchTerm, excludedIngredients, ItemsPerPage, ItemsPerPage * _currentPage);

            // Displays results if any recipes are found
            if (recipes.Count > 0)
            {
                int recipeCount = Math.Min(recipes.Count, 8);
                for (int i = 0; i < recipeCount; i++)
                {
                    setRecipePlaceholder(i, recipes[i]);
                }

                showNextButton.Visible = recipes.Count >= ItemsPerPage;
                showPreviousButton.Visible = _currentPage > 0;
            }
            else
            {
                textBox1.Text = "No recipes found for the specified search term.";
            }
        }
    }
}