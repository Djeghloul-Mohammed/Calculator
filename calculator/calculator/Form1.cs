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
    }
}
