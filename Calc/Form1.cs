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
        private Calculator calculator = new Calculator();
        public frmCalc()
        {
            InitializeComponent();
        }

        private void number_Click(object sender, EventArgs e)
        {
            tdNumber.Text = tdNumber.Text + (sender as Button).Text;

        }

        
        private void Action_Click(object sender, EventArgs e)
        {
            calculator.Method = (sender as Button).Text;
            calculator.First = Convert.ToDouble(String.IsNullOrEmpty(tdNumber.Text) ? "0": tdNumber.Text);
            tdNumber.Text = "";
        }

        private void C_Click(object sender, EventArgs e)
        {
            calculator = new Calculator();
            tdNumber.Text = "";
        }

        private void Result_Click(object sender, EventArgs e)
        {
            double second = Convert.ToDouble(String.IsNullOrEmpty(tdNumber.Text) ? "0" : tdNumber.Text);
            double result = calculator.Action(second);
            tdNumber.Text = result.ToString();
        }
    }
}
