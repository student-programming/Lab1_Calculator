using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmCalc : Form
    {
        private Calculator calculator = new Calculator();
        public frmCalc()
        {
            InitializeComponent();
        }

        private void tbNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void number_Click(object sender, EventArgs e)
        {
            tbNumber2.Text = tbNumber2.Text + (sender as Button).Text;
        }

        private void C_Click(object sender, EventArgs e)
        {
            calculator = new Calculator();
            tbNumber2.Text = "";
        }

        private void Action_Click(object sender, EventArgs e)
        {
            calculator.Method = (sender as Button).Text;
            calculator.First = Convert.ToDouble(tbNumber2.Text);
            tbNumber2.Text = "";
        }

        private void Result_Click(object sender, EventArgs e)
        {
            double second = Convert.ToDouble(tbNumber2.Text);
            double result = calculator.Action(second);
            tbNumber2.Text = result.ToString();
        }
    }
}
