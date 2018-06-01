using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoaibsySimpleCalculator1
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation,prev;
        bool operatorPress;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_clicked(object sender, EventArgs e)
        {
             if ((result.Text == "0")|| (operatorPress=true))
            {
                result.Clear();
            }
            Button b = (Button)sender; 
            result.Text = result.Text + b.Text;
            prev= result.Text;


        }

        private void btnc_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            previous.Clear();
        }

        private void opeartorClicked(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operatorPress = true;
           result.Text = operation;
            previous.Text = prev + operation;
        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":

                    previous.Text = previous.Text + result.Text;

                    result.Text = (value + Double.Parse(result.Text)).ToString();
break;
                case "-":

                    previous.Text = previous.Text + result.Text;
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":

                    previous.Text = previous.Text + result.Text;
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    previous.Text = previous.Text + result.Text;
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
            Button bn = (Button)sender;
            previous.Text = previous.Text + bn.Text;

            operatorPress = false;
        }
    }
}
