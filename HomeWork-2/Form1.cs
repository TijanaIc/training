using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Homework";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            decimal sum;
            try
            {
                decimal num1 = Convert.ToDecimal(txtNum1.Text);
                decimal num2 = Convert.ToDecimal(txtNum2.Text);
                sum = num1 + num2;
                lblR.Text = sum.ToString();
            }

            catch (System.FormatException ex)
            {
                MessageBox.Show(String.Format("Please enter numbers! (Exception caught: {0} at {1})", ex.Message, DateTime.Now), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double r;
            r = Convert.ToDouble(txtRadius.Text);
            if (r == 0)
            {
                MessageBox.Show("The circle does not exist");
            }
            else
            {
                double area = r * r * Math.PI;
                area = Math.Round(area, 2);
                double perimeter = 2 * r * Math.PI;
                perimeter = Math.Round(perimeter, 2);
                lblA.Text = area.ToString();
                lblP.Text = perimeter.ToString();
            }


        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            decimal div = 0;
            try
            {
                decimal num1 = Convert.ToDecimal(txtNum1.Text);
                decimal num2 = Convert.ToDecimal(txtNum2.Text);
                if (num2 == 0)
                {
                    throw new MyDivideByZeroException("Divide by zero is not posible");
                }
                div = num1 / num2;
            }
            catch (MyDivideByZeroException ex)
            {
                MessageBox.Show(String.Format("{0} (Exception caught at {1})", ex.Message, DateTime.Now), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show(String.Format("Please enter numbers! (Exception caught: {0} at {1})", ex.Message, DateTime.Now), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (div != 0)
                {
                    div = Math.Round(div, 2);
                    lblR.Text = div.ToString();
                }
                else
                {
                    lblR.Text = "";
                }

            }
        }
    }
}
