using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        } 

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(tb1.Text);
            float num2 = float.Parse(tb2.Text);

            float result = 0;

            string operators = comboBox1.SelectedItem.ToString();

            switch (operators)
            {
                case "+":
                    result = BasicCalculator.Add(num1, num2);
                    
                    break;
                case "-":
                    result = BasicCalculator.Subtract(num1, num2);
                    
                    break;
                case "*":
                    result = BasicCalculator.Multiply(num1, num2);
                    
                    break;
                case "/":
                    result = BasicCalculator.Divide(num1, num2);
                    
                    break;


            }
            lbAnswer.Text = result.ToString("F2");
        }
    }
}
