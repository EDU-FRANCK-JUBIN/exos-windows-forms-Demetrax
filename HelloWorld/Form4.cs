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
    public partial class Form4 : Form
    {
        public Form4()
        {
            List<Artiste> artistes = new List<Artiste>();
            InitializeComponent();
            
            
            for(int i=0; i<5; i++)
            {
                List<Chanson> listChansonsTemp = new List<Chanson>();
                
                for (int j=0; j<5; j++)
                {
                    Chanson chansTemp = new Chanson("chanson" + i + "-" + j);
                    listChansonsTemp.Add(chansTemp);
                }
                
                Artiste artisteTemp = new Artiste("artise" + i, listChansonsTemp);
                artistes.Add(artisteTemp);
            }

            dataGridView1.DataSource = artistes;
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGrid = (DataGridView)sender;
            Console.WriteLine(e.RowIndex);
            DataGridViewRow dataRow = dataGrid.Rows[e.RowIndex];
            Artiste artiste = new Artiste();
            artiste = (Artiste)dataRow.DataBoundItem;
            dataGridView2.DataSource = artiste.Chansons;
        }
    }
}
