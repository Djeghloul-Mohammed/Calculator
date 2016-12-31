using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double resultevalue = 0;
        string operationperformed = "";
        public Form1()
        {
           
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox_result.Text== "0")
            {
                textBox_result.Clear();
            }
            Button button = (Button)sender;
            textBox_result.Text = textBox_result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationperformed = button.Text;
            resultevalue = double.Parse(textBox_result.Text);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            resultevalue = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch(operationperformed)
            {

                case "+":
                    textBox_result.Text = (resultevalue + double.Parse(textBox_result.Text)).ToString();
                    break;
                case "-":
                    textBox_result.Text = (resultevalue + double.Parse(textBox_result.Text)).ToString();
                    break;
                case "*":
                    textBox_result.Text = (resultevalue + double.Parse(textBox_result.Text)).ToString();
                    break;
                case "/":
                    textBox_result.Text = (resultevalue + double.Parse(textBox_result.Text)).ToString();
                    break;
            }
        }
    }
}
