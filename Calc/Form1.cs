using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class frmCalc : Form
    {
        private Class1 calculator = new Class1();
        public frmCalc()
        {
            InitializeComponent();
        }

        private void number_Click(object sender, EventArgs e)
        {
            tbNumber2.Text = tbNumber2.Text + (sender as Button).Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            calculator = new Class1();
            tbNumber2.Text = "";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            calculator.Method = (sender as Button).Text;
            calculator.First = Convert.ToDouble(String.IsNullOrEmpty(tbNumber2.Text) ? "0": tbNumber2.Text);
            tbNumber2.Text = "";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double second = Convert.ToDouble(String.IsNullOrEmpty(tbNumber2.Text) ? "0" : tbNumber2.Text) ;
            double result = calculator.Action(second);
            tbNumber2.Text = result.ToString();
        }
    }
}
