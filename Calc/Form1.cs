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
    public partial class Form1 : Form
     {
        private Calculator20 calculator=new Calculator20();

        public Form1()
        {
            InitializeComponent();
        }

        private void number_Click(object sender, EventArgs e)
        {
           tbNumber.Text = tbNumber. Text + (sender as Button).Text;
        }

        private void c_Clisk(object sender, EventArgs e)
        {
            calculator = new Calculator20();
            tbNumber.Text = "";
        }
        private void Action_Click(object sender, EventArgs e)
        {
            calculator.Method = (sender as Button).Text ;
            calculator.First = Convert.ToDouble(tbNumber.Text);
            tbNumber.Text = "";
        }
        private void Result_Clisk(object sender, EventArgs e)
        {
            double second = Convert.ToDouble(tbNumber.Text);
            double result = calculator.Action(second);
            tbNumber.Text = result.ToString();
        }
    }
}