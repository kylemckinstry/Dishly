using Dishly.Model;

namespace Dishly.View
{
    public partial class Favourites : UserControl
    {
        public Favourites()
        {
            InitializeComponent();
            DishlyDB.FavoritesChanged += OnFavoritesChanged;
            DisplayFavourites();

        }

        private void browserButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;  // Hides itself
        }

        public void DisplayFavourites()
        {
            // Gets all favourite recipes from the database
            var favouriteRecipes = DishlyDB.GetAllFavorites();

            // Ensures we don't exceed the number of panels available
            int panelCount = flowLayoutPanel1.Controls.Count;

            // Loops through all panels
            for (int i = 0; i < panelCount; i++)
            {
                var panel = flowLayoutPanel1.Controls[i] as Panel;

                if (i < favouriteRecipes.Count)
                {
                    var recipe = favouriteRecipes[i];

                    if (panel != null && recipe != null)
                    {
                        // Updates the panel with recipe details
                        UpdatePanelWithRecipe(panel, recipe);
                    }
                    else if (panel != null) // If the recipe is null, clear the panel
                    {
                        ClearPanel(panel);
                    }
                }
                else if (panel != null) // If there are more panels than favourite recipes, clear or hide excess panels
                {
                    ClearPanel(panel);
                }
            }
        }

        // Method to clear a panel's content
        private void ClearPanel(Panel panel)
        {
            var pictureBox = panel.Controls.OfType<PictureBox>().FirstOrDefault();
            var textBox = panel.Controls.OfType<TextBox>().FirstOrDefault();

            if (pictureBox != null)
            {
                pictureBox.ImageLocation = ""; // Clears the image
                pictureBox.Visible = false;
            }

            if (textBox != null)
            {
                textBox.Text = "No Recipe Selected";
                textBox.Visible = false;
            }
        }

        // Updates a panel with a recipe's information
        private void UpdatePanelWithRecipe(Panel panel, Recipe recipe)
        {
            var pictureBox = panel.Controls.OfType<PictureBox>().FirstOrDefault();
            var textBox = panel.Controls.OfType<TextBox>().FirstOrDefault();

            if (pictureBox != null)
            {
                pictureBox.ImageLocation = recipe?.ThumbnailUrl ?? ""; // Sets image URL if recipe exists
                pictureBox.Visible = !string.IsNullOrEmpty(recipe?.ThumbnailUrl); // Hides if no image

                // Assigns the Recipe to the Tag property
                pictureBox.Tag = recipe;
            }

            if (textBox != null)
            {
                textBox.Text = recipe?.Name ?? "No Recipe Selected";
                textBox.Visible = !string.IsNullOrEmpty(recipe?.Name);
            }
        }

        public void OnFavoritesChanged()
        {
            DisplayFavourites(); // Refreshes the favourites list
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            if (clickedPictureBox != null)
            {
                Recipe recipe = clickedPictureBox.Tag as Recipe;

                if (recipe != null)
                {
                    var parentForm = this.FindForm() as RecipeBrowserForm;

                    if (parentForm != null && parentForm.recipeDetail1 != null)
                    {
                        parentForm.recipeDetail1.SetPanelData(recipe);
                        parentForm.recipeDetail1.Visible = true;
                        parentForm.recipeDetail1.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Recipe detail panel is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                { 
                    MessageBox.Show("No recipe data available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Favourites_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void myWeekButton_Click(object sender, EventArgs e)
        {
            RecipeBrowserForm mainForm = this.FindForm() as RecipeBrowserForm;
            mainForm.ShowMyWeekPage();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
