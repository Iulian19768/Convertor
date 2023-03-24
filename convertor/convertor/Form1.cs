using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace convertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public int MaxDropDownItems { get; set; }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            comboBox1.IntegralHeight = false;

            comboBox1.MaxDropDownItems = 4;

        }

        public double convert_Km2Mile(double m1)
        {
            return m1 * 0.62;
        }
        public double convert_Mile2KM(double m1)
        {
            return m1 * 1.60934;
        }
        public double convert_Celsius2Fah(double m1)
        {
            return m1 * 33.8;
        }
        public double convert_Fahrenheit2Celsius(double m1)
        {
            return m1 * -17.2222;
        }
        public double convert_feet2cm(double m1)
        {
            return m1 * 30.48;
        }
        public double convert_cm2feet(double m1)
        {
            return m1 * 0.0328084;
        }
        public double convert_pounds2kg(double m1)
        {
            return m1 * 0.453592;
        }
        public double convert_kg2pounds(double m1)
        {
            return m1 * 2.20462;
        }


        private void convert_Click(object sender, EventArgs e)
        {
            string valoare1 = txt1.Text.ToString();
            double value1 = (double)Convert.ToDouble(valoare1);

            if (comboBox1.Text == "Km" && comboBox2.Text == "Mile")
            {
                output.Text = Convert.ToString(convert_Km2Mile(value1));
            }
            else if (comboBox1.Text == "Mile" && comboBox2.Text == "Km")
            {
                output.Text = Convert.ToString(convert_Mile2KM(value1));
            }
            else if (comboBox1.Text == "Celsius" && comboBox2.Text == "Fahrenheit")
            {
                output.Text = Convert.ToString(convert_Celsius2Fah(value1));
            }
            else if (comboBox1.Text == "Fahrenheit" && comboBox2.Text == "Celsius")
            {
                output.Text = Convert.ToString(convert_Fahrenheit2Celsius(value1));
            }
            else if (comboBox1.Text == "Feet" && comboBox2.Text == "Cm")
            {
                output.Text = Convert.ToString(convert_feet2cm(value1));
            }
            else if (comboBox1.Text == "Cm" && comboBox2.Text == "Feet")
            {
                output.Text = Convert.ToString(convert_cm2feet(value1));
            }
            else if (comboBox1.Text == "Pounds" && comboBox2.Text == "Kg")
            {
                output.Text = Convert.ToString(convert_pounds2kg(value1));
            }
            else if (comboBox1.Text == "Kg" && comboBox2.Text == "Pounds")
            {
                output.Text = Convert.ToString(convert_kg2pounds(value1));
            }
            else
            {
                MessageBox.Show("Please enter valid data");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.IntegralHeight = false;
            comboBox2.MaxDropDownItems = 4;
        }
    }
}
