using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_Job_Estimator
{
    public partial class Form1 : Form
    {
        const double ONE_HOUR_LABOR_PRICE = 20.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double wallSqFt = double.Parse(sqFtTextBox.Text);
                double paintPricePerGallon = double.Parse(priceTextBox.Text);

                double numberOfGallonsReq = wallSqFt / 115.0;
                gallonsLabel.Text = numberOfGallonsReq.ToString("n");

                double numberOfHoursLaborReq = (wallSqFt * 8.0) / 115.0;
                laborHoursLabel.Text = numberOfHoursLaborReq.ToString("n");

                double costOfPaint = paintPricePerGallon * numberOfGallonsReq;
                paintCostLabel.Text = costOfPaint.ToString("c");

                double costOfLabor = numberOfHoursLaborReq * 20.0;
                laborCostLabel.Text = costOfLabor.ToString("c");

                double totalCost = costOfPaint + costOfLabor;
                totalCostLabel.Text = totalCost.ToString("c");
            }
            catch (Exception ext)
            {
                MessageBox.Show(ext.Message);
            }
        }
    }
}
