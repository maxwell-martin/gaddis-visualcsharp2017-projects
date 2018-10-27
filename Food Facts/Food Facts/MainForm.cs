using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Facts
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            NutritionForm nutritionInfo = new NutritionForm();

            if (bananaRadioButton.Checked)
            {
                nutritionInfo.foodLabel.Text = "Banana";
                nutritionInfo.caloriesLabel.Text = "100";
                nutritionInfo.fatGramsLabel.Text = "0.4";
                nutritionInfo.carbGramsLabel.Text = "27";
            }
            else if (popcornRadioButton.Checked)
            {
                nutritionInfo.foodLabel.Text = "1 cup air-popped popcorn";
                nutritionInfo.caloriesLabel.Text = "31";
                nutritionInfo.fatGramsLabel.Text = "0.4";
                nutritionInfo.carbGramsLabel.Text = "6";
            }
            else if (muffinRadioButton.Checked)
            {
                nutritionInfo.foodLabel.Text = "1 large blueberry muffin";
                nutritionInfo.caloriesLabel.Text = "385";
                nutritionInfo.fatGramsLabel.Text = "9";
                nutritionInfo.carbGramsLabel.Text = "67";
            }

            nutritionInfo.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
