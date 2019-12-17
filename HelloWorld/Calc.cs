using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
            tbHisto.Enabled = false;
            tbInput.Enabled = false;
        }

        #region number

        private void btnZero_Click(object sender, EventArgs e)
        {
            tbInput.Text += 0;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            tbInput.Text += 1;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            tbInput.Text += 2;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            tbInput.Text += 3;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            tbInput.Text += 4;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            tbInput.Text += 5;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            tbInput.Text += 6;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            tbInput.Text += 7;
        }

        private void btnHeight_Click(object sender, EventArgs e)
        {
            tbInput.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbInput.Text += 9;
        }


        #endregion

        #region Operators 
        private void btnDivi_Click(object sender, EventArgs e)
        {
            tbHisto.Text += tbInput.Text + "/";
            tbInput.Text = "";
        }

        private void btnMutl_Click(object sender, EventArgs e)
        {
            tbHisto.Text += tbInput.Text + "*";
            tbInput.Text = "";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            tbHisto.Text += tbInput.Text + "-";
            tbInput.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbHisto.Text += tbInput.Text + "+";
            tbInput.Text = "";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            tbHisto.Text += tbInput.Text;
            try
            {
                var v = dt.Compute(tbHisto.Text, "");
                tbInput.Text = v.ToString();
                tbHisto.Text += "=";
            } catch (System.DivideByZeroException)
            {
                MessageBox.Show("Divisions par zero impossible");
            }
        }

        #endregion

        #region other

        private void btnChange_Click(object sender, EventArgs e)
        {
            float number = float.Parse(tbInput.Text) * -1;
            tbInput.Text = number.ToString();
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (!tbInput.Text.Contains("."))
            {
                tbInput.Text += ".";
            }
            
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            tbInput.Text = "";
            tbHisto.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            tbInput.Text = "";
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            if (tbInput.Text.Length > 0)
            {
                int lastChar = tbInput.Text.Length - 1;
                tbInput.Text = tbInput.Text.Remove(lastChar, 1);
            }
        }

        #endregion
    }
}
