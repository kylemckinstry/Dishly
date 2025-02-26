using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dishly.Model;
using System.IO;

namespace Dishly.View
{
    public partial class IngredientsList : UserControl
    {
        public IngredientsList()
        {
            InitializeComponent();
        }

        // Refreshes the ingredient list page everytime it's accessed 
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            if (this.Visible)
            {
                LoadIngredientsFromMyWeek();
            }
        }

        // The below code will 1. clear the list, 2. Get all the ingredients using the Dishly function 
        // 3. Add each ingredient to the list through a loop 
        private void LoadIngredientsFromMyWeek()
        {
            listBox2.Items.Clear(); 

            var ingredients = DishlyDB.GetAllIngredientsInMyWeek();

            foreach (var ingredient in ingredients)
            {
                listBox2.Items.Add($"{ingredient.Measure} {ingredient.Name}");
            }
        }

        private void favouritesButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;  // Hides itself
        }

        private void browserButton_Click(object sender, EventArgs e)
        {
            RecipeBrowserForm mainForm = this.FindForm() as RecipeBrowserForm;
            mainForm.ShowMyWeekPage();
        }

        // Prints Shoppinglist.txt to relative Desktop path 
        private void button1_Click(object sender, EventArgs e)
        {
            // Gets the path to the Desktop folder
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "Shoppinglist.txt");

            using (TextWriter text1 = new StreamWriter(filePath))
            {
                foreach (var item in listBox2.Items)
                {
                    text1.WriteLine(item.ToString());
                }
            }

            MessageBox.Show("Shopping list printed!");
        }

        private void IngredientsList_Load(object sender, EventArgs e)
        {

        }

    }
}
