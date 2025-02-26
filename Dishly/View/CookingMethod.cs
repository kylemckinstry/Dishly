using Dishly.Model;
using Dishly.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Dishly.View.MyWeek;

namespace Dishly
{
    public partial class CookingMethod : UserControl
    {
        private Recipe currentRecipe;
        private MyWeek myWeekInstance;

        public CookingMethod() : this(new MyWeek())
        {
            // Parameterless constructor for the designer
        }

        public CookingMethod(MyWeek week)
        {
            InitializeComponent();
            myWeekInstance = week;
            InitializeComboBox();
        }

        public void SetWeekInstance(MyWeek week)
        {
            myWeekInstance = week;
        }

        public void LoadRecipe(Recipe recipe)
        {
            currentRecipe = recipe;

            try
            {
                pictureBox1.LoadAsync(recipe.ThumbnailUrl);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load image: " + ex.Message, "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ingredientsListBox.Items.Clear();
            ingredientsListBox.Items.AddRange(recipe.GetIngredientsListFormatted.ToArray());

            tagsText.Text = recipe.GetTagsFormatted;
            categoryText.Text = DishlyDB.GetMealCategory(recipe.CategoryId)?.Name ?? "None";
            cuisineText.Text = recipe.Cuisine;

            cookingInstructionTextBox.Text = recipe.Steps;

            RecipeName.Text = recipe.Name;
        }

        // Sets combo box items
        private class ComboBoxItem
        {
            public DayOfWeek Day { get; set; }
            public MyWeek.MealTime Meal { get; set; }

            public override string ToString() => $"{Day} - {Meal}";
        }

        private void InitializeComboBox()
        {
            myWeekComboBox.Items.Clear();

            // Gets all days of the week
            var days = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>().ToList();
            foreach (var day in days)
            {
                // Iterates through all meal times
                foreach (MyWeek.MealTime meal in Enum.GetValues(typeof(MyWeek.MealTime)))
                {
                    // Adds a new ComboBoxItem with day and meal combination
                    var comboBoxItem = new ComboBoxItem { Day = day, Meal = meal };
                    myWeekComboBox.Items.Add(comboBoxItem);
                }
            }

            // Ensures there are items in the ComboBox
            if (myWeekComboBox.Items.Count > 0)
            {
                myWeekComboBox.SelectedIndex = 0; // Sets the default index to the first item
            }
            else
            {
                myWeekComboBox.SelectedIndex = -1; // Sets to -1 to indicate no valid selection
            }
        }

        // Adds recipe to MyWeek at selected day/meal time
        private void addToWeekButton_Click(object sender, EventArgs e)
        {
            if (currentRecipe == null)
            {
                MessageBox.Show("No recipe is currently loaded.");
                return;
            }

            var selectedItem = myWeekComboBox.SelectedItem as ComboBoxItem;
            if (selectedItem == null)
            {
                MessageBox.Show("Invalid selection.");
                return;
            }

            var selectedDay = selectedItem.Day;
            var selectedMealTime = selectedItem.Meal;

            DishlyDB.AddToMyWeek(currentRecipe, (int)selectedDay, (int)selectedMealTime);
            MessageBox.Show($"{currentRecipe.Name} has been added to {selectedItem.Day} {selectedItem.Meal}");
        }

        // Removes recipe from MyWeek array
        private void removeFromWeekButton_Click(object sender, EventArgs e)
        {

            if (DishlyDB.IsInMyWeek(currentRecipe))
            {
                MessageBox.Show($"{currentRecipe.Name} has been removed from your week.\nWe didn't want to eat it anyway!");
            } else {
                MessageBox.Show($"{currentRecipe.Name} was not found in your week.");
            }

            DishlyDB.RemoveFromMyWeek(currentRecipe);

        }

        private void browserButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;  // Hide itself
        }

        private void myWeekButton_Click(object sender, EventArgs e)
        {
            RecipeBrowserForm mainForm = this.FindForm() as RecipeBrowserForm;
            mainForm.ShowMyWeekPage();

            // Calls DisplayWeeklyPlan to refresh the panels with any newly assigned recipes
            myWeekInstance.DisplayWeeklyPlan();
        }

        private void RecipeName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


