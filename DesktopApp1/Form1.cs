using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp1
{
    
    public partial class Form1 : Form
    {
        double height;
        double weight;
        double heightSq;
        string calcu;



        public Form1()
        {
            InitializeComponent();
        }


        private void WeightLabel_Click(object sender, EventArgs e)
        {

        }

        private void HeightTextField_TextChanged(object sender, EventArgs e)
        {
            try
            {
                height = Convert.ToInt32(HeightTextField.Text);
            }
            
            catch (FormatException)
            {
                
            }
        }

        private void WeightTextField_TextChanged(object sender, EventArgs e)
        {
            try
            {
                weight = Convert.ToInt32(WeightTextField.Text);
            }

            catch (FormatException)
            {
               
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (height <= 0 || weight <= 0)
                {
                ResultPrint.Text = "This is an invalid input";
                }

            else
            {
                try
                {
                    heightSq = Math.Pow((height/100), 2);
                    calcu = Convert.ToString(weight / heightSq);
                    ResultPrint.Text = "Your BMI Index is " + calcu.Substring(0,5) + ".";
                }

                catch (FormatException)
                {
                    ResultPrint.Text = "Please enter the Height and Weight values as numbers.";
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
