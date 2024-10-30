using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String opPerformed = "";
        bool isOpPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || isOpPerformed) { textBox1.Clear(); }
            isOpPerformed = false;
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void opClick(object sender, EventArgs e)
        {
            Button  button = (Button)sender;
            opPerformed = button.Text;
            resultValue = Double.Parse(textBox1.Text);
            currentOp.Text = resultValue + " " + opPerformed;
            isOpPerformed = true;
        }

        private void clearEntry(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            currentOp.Text = "";
        }

        private void clear(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultValue = 0;
            currentOp.Text = "";
        }

        private void enter(object sender, EventArgs e)
        {
            switch(opPerformed)
            {
              case "+":
                    textBox1.Text =(resultValue + Double.Parse(textBox1.Text)).ToString();
                    break;
              case "-":
                    textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();
                    break;
               case "*":
                    textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();
                    break;
               case "/":
                    textBox1.Text = (resultValue / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;

            }
        }
    }
}
