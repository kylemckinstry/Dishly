using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dishly.View
{
    public partial class Preferences : UserControl
    {
        // Stores excluded ingredients based on checked boxes
        public HashSet<string> ExcludedIngredients { get; private set; } = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        public Preferences()
        {
            InitializeComponent();
        }

        // Helper method to update the exclusion list based on checkbox status
        private void UpdateExcludedIngredients(CheckBox checkbox, string ingredient)
        {
            if (checkbox.Checked)
                ExcludedIngredients.Add(ingredient);
            else
                ExcludedIngredients.Remove(ingredient);
        }

        // Event handlers for each ingredient checkbox
        private void Chicken_CheckedChanged(object sender, EventArgs e) => UpdateExcludedIngredients((CheckBox)sender, "Chicken");
        private void Lamb_CheckedChanged(object sender, EventArgs e) => UpdateExcludedIngredients((CheckBox)sender, "Lamb");
        private void Beef_CheckedChanged(object sender, EventArgs e) => UpdateExcludedIngredients((CheckBox)sender, "Beef");
        private void Pork_CheckedChanged(object sender, EventArgs e) => UpdateExcludedIngredients((CheckBox)sender, "Pork");
        private void Fish_CheckedChanged(object sender, EventArgs e) => UpdateExcludedIngredients((CheckBox)sender, "Fish");
        private void Olive_Oil_CheckedChanged(object sender, EventArgs e) => UpdateExcludedIngredients((CheckBox)sender, "Olive Oil");
        private void Vinegar_CheckedChanged(object sender, EventArgs e) => UpdateExcludedIngredients((CheckBox)sender, "Vinegar");
        private void Garlic_CheckedChanged(object sender, EventArgs e) => UpdateExcludedIngredients((CheckBox)sender, "Garlic");
        private void Honey_CheckedChanged(object sender, EventArgs e) => UpdateExcludedIngredients((CheckBox)sender, "Honey");
        private void Butter_CheckedChanged(object sender, EventArgs e) => UpdateExcludedIngredients((CheckBox)sender, "Butter");
        private void Wheat_CheckedChanged(object sender, EventArgs e) => UpdateExcludedIngredients((CheckBox)sender, "Wheat");
        private void Milk_CheckedChanged(object sender, EventArgs e) => UpdateExcludedIngredients((CheckBox)sender, "Milk");
        private void Suggar_CheckedChanged(object sender, EventArgs e) => UpdateExcludedIngredients((CheckBox)sender, "Sugar");
        private void Pickles_CheckedChanged(object sender, EventArgs e) => UpdateExcludedIngredients((CheckBox)sender, "Pickles");
        private void Onions_CheckedChanged(object sender, EventArgs e) => UpdateExcludedIngredients((CheckBox)sender, "Onions");

        // Retains functionality for other UI elements if needed
        private void label2_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }

        // Retains functionality for "Browser" button
        private void browserButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}