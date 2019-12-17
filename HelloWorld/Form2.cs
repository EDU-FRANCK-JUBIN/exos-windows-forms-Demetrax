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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string infoUser = teName.Text + " " + teAdress.Text;
            MessageBox.Show(infoUser, "Info");
        }

        private void buCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void liCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sectedItem = liCity.GetItemText(liCity.SelectedItem);
            MessageBox.Show(sectedItem, "Ville");
        }
    }
}
