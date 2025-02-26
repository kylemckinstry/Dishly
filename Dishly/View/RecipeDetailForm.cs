using Dishly.Model;

namespace Dishly.View
{
    public partial class RecipeDetailForm : UserControl
    {
        private Recipe currentRecipe;
        private MyWeek myWeekInstance;

        public RecipeDetailForm()
        {
            InitializeComponent();

            myWeekInstance = this.Controls.OfType<MyWeek>().FirstOrDefault();

            if (myWeekInstance == null)
            {
                myWeekInstance = new MyWeek();
            }
        }

        public RecipeDetailForm(MyWeek week)
        {
            InitializeComponent();
            myWeekInstance = week;
        }

        // Method to set data from the main panel click
        public void SetPanelData(Recipe recipe)
        {
            currentRecipe = recipe;

            // Sets the image
            pictureBox1.LoadAsync(recipe.ThumbnailUrl);

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Ensures the image fits within the PictureBox
            pictureBox1.LoadAsync(recipe.ThumbnailUrl);

            // Sets the ingredients text
            ingredientsListBox.Items.Clear();
            ingredientsListBox.Items.AddRange(recipe.GetIngredientsListFormatted.ToArray());

            // Sets the nutrition text
            tagsText.Text = recipe.GetTagsFormatted;
            categoryText.Text = DishlyDB.GetMealCategory(recipe.CategoryId)?.Name ?? "None";
            cuisineText.Text = recipe.Cuisine;

            UpdateFavoriteButtonText();

            //Sets the name text 
            textBox1.Text = recipe.Name;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
 
        private void cookingInstructionsButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            var parentForm = this.FindForm() as RecipeBrowserForm;
            if (parentForm != null)
            {
                // Shows CookingMethod and loads the current recipe
                parentForm.ShowCookingMethod(myWeekInstance);
                parentForm.cookingMethod1.LoadRecipe(currentRecipe); // Passes the current recipe
            }
            else
            {
                MessageBox.Show("Parent form not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void favoriteButton_Click(object sender, EventArgs e)
        {
            var isFavorite = DishlyDB.IsFavorite(currentRecipe);

            if (isFavorite)
            {
                DishlyDB.RemoveFromFavorites(currentRecipe);
                MessageBox.Show($"{currentRecipe.Name} has been removed from your favourites.");
            }
            else
            {
                DishlyDB.AddToFavorites(currentRecipe);
                MessageBox.Show($"{currentRecipe.Name} has been added to your favourites.");
            }

            UpdateFavoriteButtonText();
        }

        private void UpdateFavoriteButtonText()
        {
            var isFavorite = DishlyDB.IsFavorite(currentRecipe);

            favoriteButton.Text = isFavorite ? "Remove Favorite" : "Favorite";

            if (isFavorite)
            {
                favoriteButton.BackColor = Color.Salmon;
            }
            else
            {
                favoriteButton.BackColor = Color.FromArgb(56, 163, 165);
            }
        }


    }
}
