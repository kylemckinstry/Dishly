using Dishly.Model;
using System.Data;
using System.Text;

namespace Dishly.View
{
    public partial class MyWeek : UserControl
    {
        public MyWeek()
        {
            InitializeComponent();
            InitializePanelMapping();
            InitializeRemoveButtonTags();
        }

        public Dictionary<(DayOfWeek, MyWeek.MealTime), Panel> PanelMapping => panelMapping;

        // Enum to define meal times
        public enum MealTime
        {
            Breakfast = 0,
            Lunch = 1,
            Dinner = 2
        }

        public void InitializeRemoveButtonTags()
        {
            subRemoveButton.Tag = (DayOfWeek.Sunday, MealTime.Breakfast);
            sulRemoveButton.Tag = (DayOfWeek.Sunday, MealTime.Lunch);
            sudRemoveButton.Tag = (DayOfWeek.Sunday, MealTime.Dinner);

            mbRemoveButton.Tag = (DayOfWeek.Monday, MealTime.Breakfast);
            mlRemoveButton.Tag = (DayOfWeek.Monday, MealTime.Lunch);
            mdRemoveButton.Tag = (DayOfWeek.Monday, MealTime.Dinner);

            tbRemoveButton.Tag = (DayOfWeek.Tuesday, MealTime.Breakfast);
            tlRemoveButton.Tag = (DayOfWeek.Tuesday, MealTime.Lunch);
            tdRemoveButton.Tag = (DayOfWeek.Tuesday, MealTime.Dinner);

            wbRemoveButton.Tag = (DayOfWeek.Wednesday, MealTime.Breakfast);
            wlRemoveButton.Tag = (DayOfWeek.Wednesday, MealTime.Lunch);
            wdRemoveButton.Tag = (DayOfWeek.Wednesday, MealTime.Dinner);

            thbRemoveButton.Tag = (DayOfWeek.Thursday, MealTime.Breakfast);
            thlRemoveButton.Tag = (DayOfWeek.Thursday, MealTime.Lunch);
            thdRemoveButton.Tag = (DayOfWeek.Thursday, MealTime.Dinner);

            fbRemoveButton.Tag = (DayOfWeek.Friday, MealTime.Breakfast);
            flRemoveButton.Tag = (DayOfWeek.Friday, MealTime.Lunch);
            fdRemoveButton.Tag = (DayOfWeek.Friday, MealTime.Dinner);

            sbRemoveButton.Tag = (DayOfWeek.Saturday, MealTime.Breakfast);
            slRemoveButton.Tag = (DayOfWeek.Saturday, MealTime.Lunch);
            sdRemoveButton.Tag = (DayOfWeek.Saturday, MealTime.Dinner);
        }

        // Method to retrieve a recipe for a specific day and meal time
        public Recipe? GetRecipeForDay(DayOfWeek day, MealTime mealTime)
        {
            int dayIndex = (int)day;
            int mealTimeIndex = (int)mealTime;

            return DishlyDB.GetFromMyWeek(dayIndex, mealTimeIndex); //GetFromMyWeek(0,0)
        }

        // Method to get all recipes in the weekly plan
        public List<Recipe> GetAllRecipes()
        {
            return DishlyDB.GetAllWeeklyRecipes();
        }

        // Panel mapping dictionary to associate days and meal times with panels
        private Dictionary<(DayOfWeek, MyWeek.MealTime), Panel> panelMapping;

        // Initialises the mapping between days, meal times, and panels
        private void InitializePanelMapping()
        {
            panelMapping = new Dictionary<(DayOfWeek, MyWeek.MealTime), Panel>
            {
                // Monday
                { (DayOfWeek.Monday, MealTime.Breakfast), monPanel1 },
                { (DayOfWeek.Monday, MealTime.Lunch), monPanel2 },
                { (DayOfWeek.Monday, MealTime.Dinner), monPanel3 },

                // Tuesday
                { (DayOfWeek.Tuesday, MealTime.Breakfast), tuesPanel1 },
                { (DayOfWeek.Tuesday, MealTime.Lunch), tuesPanel2 },
                { (DayOfWeek.Tuesday, MealTime.Dinner), tuesPanel3 },

                // Wednesday
                { (DayOfWeek.Wednesday, MealTime.Breakfast), wedPanel1 },
                { (DayOfWeek.Wednesday, MealTime.Lunch), wedPanel2 },
                { (DayOfWeek.Wednesday, MealTime.Dinner), wedPanel3 },

                // Thursday
                { (DayOfWeek.Thursday, MealTime.Breakfast), thursPanel1 },
                { (DayOfWeek.Thursday, MealTime.Lunch), thursPanel2 },
                { (DayOfWeek.Thursday, MealTime.Dinner), thursPanel3 },

                // Friday
                { (DayOfWeek.Friday, MealTime.Breakfast), friPanel1 },
                { (DayOfWeek.Friday, MealTime.Lunch), friPanel2 },
                { (DayOfWeek.Friday, MealTime.Dinner), friPanel3 },

                // Saturday
                { (DayOfWeek.Saturday, MealTime.Breakfast), satPanel1 },
                { (DayOfWeek.Saturday, MealTime.Lunch), satPanel2 },
                { (DayOfWeek.Saturday, MealTime.Dinner), satPanel3 },

                // Sunday
                { (DayOfWeek.Sunday, MealTime.Breakfast), sunPanel1 },
                { (DayOfWeek.Sunday, MealTime.Lunch), sunPanel2 },
                { (DayOfWeek.Sunday, MealTime.Dinner), sunPanel3 }
            };

            // Checks all panels in the mapping for null values
            foreach (var panel in panelMapping.Values)
            {
                if (panel == null)
                {
                    MessageBox.Show("One or more panels are not properly initialized.", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        // Method to update a panel with a recipe's information
        private void UpdatePanelWithRecipe(Panel panel, Recipe recipe)
        {
            var pictureBox = panel.Controls.OfType<PictureBox>().FirstOrDefault();
            var textBox = panel.Controls.OfType<TextBox>().FirstOrDefault();

            if (pictureBox != null)
            {
                // Sets image location if recipe exists
                pictureBox.ImageLocation = recipe?.ThumbnailUrl ?? "";

                // Makes the PictureBox visible only if there's an image
                pictureBox.Visible = !string.IsNullOrEmpty(recipe?.ThumbnailUrl);

                // Assigns the Recipe to the Tag property
                pictureBox.Tag = recipe;

                // Ensures that the image resizes to fit the PictureBox size within the panel
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (textBox != null)
            {
                // Sets the recipe name or a default text
                textBox.Text = recipe?.Name ?? "No Recipe Selected";

                // Makes the TextBox visible only if there's a name
                textBox.Visible = !string.IsNullOrEmpty(recipe?.Name);
            }
        }

        public void DisplayWeeklyPlan()
        {
            // Iterates through each entry in the PanelMapping dictionary
            foreach (var key in PanelMapping.Keys)
            {
                var day = key.Item1;
                var mealTime = key.Item2;

                // Retrieves the recipe for the current day and meal time
                var recipe = GetRecipeForDay(day, mealTime);

                // Gets the panel and updates it with the retrieved recipe
                if (PanelMapping.TryGetValue((day, mealTime), out Panel targetPanel))
                {
                    UpdatePanelWithRecipe(targetPanel, recipe);
                }
            }

        }

        private void browserButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void favouritesButton_Click(object sender, EventArgs e)
        {
            RecipeBrowserForm mainForm = this.FindForm() as RecipeBrowserForm;
            mainForm.ShowFavouritesPage();
        }

        private void IngredientsListButton_Click(object sender, EventArgs e)
        {
            RecipeBrowserForm mainForm = this.FindForm() as RecipeBrowserForm;
            mainForm.ShowIngredientsList();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            if (clickedPictureBox != null)
            {
                Recipe recipe = clickedPictureBox.Tag as Recipe;

                if (recipe != null)
                {
                    // Access the RecipeBrowserForm
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

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is ValueTuple<DayOfWeek, MealTime> tag)
            {
                var (day, mealTime) = tag;

                DishlyDB.RemoveSpecificFromMyWeek((int)day, (int)mealTime);

                DisplayWeeklyPlan();
            }
        }

        private void MyWeek_Load(object sender, EventArgs e)
        {

        }

    }
}