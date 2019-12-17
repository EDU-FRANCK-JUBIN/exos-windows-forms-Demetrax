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
    public partial class MainForm : Form
    {
        bool form2Active;
        Level2Form level2Form;

        public MainForm()
        {
            InitializeComponent();
            form2Active = false;
        }

        private void btDialogForm_Click(object sender, EventArgs e)
        {
            DialogForm dialogForm = new DialogForm();
            dialogForm.ShowDialog();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            if (form2Active)
            {
                level2Form.Recieved(tbSend.Text);
                Console.WriteLine("send");
            }
        }

        private void btReceive_Click(object sender, EventArgs e)
        {

        }


        private void btLevel2_Click(object sender, EventArgs e)
        {
            if (!form2Active)
            {
                level2Form = new Level2Form() { Owner = this };
                form2Active = true;
                level2Form.Show();
            }
        }

        private void btMdiForm_Click(object sender, EventArgs e)
        {
            MdiForm mdiForm = new MdiForm() { Owner = this };
            mdiForm.Show();
        }

        private void btPanelForm_Click(object sender, EventArgs e)
        {
            PanelForm panelForm = new PanelForm();
            panelForm.TopLevel = false;
            panelForm.AutoScroll = true;
            this.panForm.Controls.Add(panelForm);
            panelForm.Show();
        }

        public string getMessage()
        {
            return tbSend.Text;
        }

        public void closed()
        {
            form2Active = false;
        }
    }
}
