using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cours
{
    public partial class Level2Form : Form
    {
        MainForm main;
        public Level2Form()
        {
            InitializeComponent();
        }

        private void Level2Form_Load(object sender, EventArgs e)
        {
            main = (MainForm)this.Owner;
        }

        private void btMyParent_Click(object sender, EventArgs e)
        {
            string s = this.Owner.Name;
            // Display the name in a message box.
            MessageBox.Show("My Owner.Name is " + s + ".");
        }

        public void Recieved(string text)
        {
            Console.WriteLine("test");
            tbReceive.Text = text;
        }

        private void btReceive_Click(object sender, EventArgs e)
        {
            tbReceive.Text = main.getMessage();
        }

        protected override void DestroyHandle()
        {
            main.closed();
            base.DestroyHandle();
        }

        
    }
}
