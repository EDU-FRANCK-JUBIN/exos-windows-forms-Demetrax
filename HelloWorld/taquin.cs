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
    public partial class Taquin : Form
    {
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
        public Taquin()
        {
            InitializeComponent();
        }

        int[,] grid = new int[3,3];
        List<int> tabTemp = new List<int>();
        int[] tabResult = new int[9];
        List<PictureBox> listPictureBox = new List<PictureBox>();
        int n = 3;
        int compteur = 0;
        #region buton
        private void btnShuffle_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            timer.Start();
            List<Bitmap> lstOriginalPictureList = new List<Bitmap>();
            lstOriginalPictureList.Add(Properties.Resources._1);
            lstOriginalPictureList.Add(Properties.Resources._2);
            lstOriginalPictureList.Add(Properties.Resources._3);
            lstOriginalPictureList.Add(Properties.Resources._4);
            lstOriginalPictureList.Add(Properties.Resources._5);
            lstOriginalPictureList.Add(Properties.Resources._6);
            lstOriginalPictureList.Add(Properties.Resources._7);
            lstOriginalPictureList.Add(Properties.Resources._8);
            lstOriginalPictureList.Add(Properties.Resources._null);

            for (int i = 0; i < 9; i++)
            {
                tabTemp.Add(i+1);
            }
            

            for (int i = 0; i < gbTaquin.Controls.Count; i++)
            {
                int ind = rand.Next(0, lstOriginalPictureList.Count);
                ((PictureBox)gbTaquin.Controls[i]).Image = lstOriginalPictureList[ind];
                listPictureBox.Add((PictureBox)gbTaquin.Controls[i]);
                Console.WriteLine(gbTaquin.Controls[i].Name);
                tabResult[i] = tabTemp[ind];
                lstOriginalPictureList.RemoveAt(ind);
                tabTemp.RemoveAt(ind);
            }

            for (int i = 0; i < 9; i++)
            {
                if (tabResult[i] == 9)
                {
                    grid[i / n, i % n] = 0;
                }
                else
                {
                    grid[i / n, i % n] = 1;
                }
            }
            compteur = 0;
            ShowGrid();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            laTimer.Text = timer.Elapsed.ToString().Substring(0,8);
            
        }

        #region move
        private void pictureMove_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            int nbCase = int.Parse(pictureBox.Name[pictureBox.Name.Length - 1].ToString()) - 2;
            //PictureBox10
            nbCase = (nbCase < 0) ? 8 : nbCase;
            Console.WriteLine("Case n°"+nbCase);
            
            if (nbCase / 3 == 0)
            {
                //case Down
                if (grid[(nbCase / 3) + 1, (nbCase % 3)] == 0)
                {
                    grid[nbCase / 3, nbCase % 3] = 0;
                    grid[(nbCase / 3) + 1, (nbCase % 3)] = 1;
                    int caseNull = ((nbCase / 3) + 1) * 3 + (nbCase % 3);
                    MoveAndCheck(nbCase, caseNull);
                }
                HorizontalMove(nbCase);
            }

                
            else if (nbCase / 3 == 1)
            {
                //case Up
                if (grid[(nbCase / 3) - 1, (nbCase % 3)] == 0)
                {
                    grid[nbCase / 3, nbCase % 3] = 0;
                    grid[(nbCase / 3) - 1, (nbCase % 3)] = 1;
                    
                    int caseNull = ((nbCase / 3) - 1) * 3 + (nbCase % 3);
                    MoveAndCheck(nbCase, caseNull);
                }
                //case Down
                if (grid[(nbCase / 3) + 1, (nbCase % 3)] == 0)
                {
                    grid[nbCase / 3, nbCase % 3] = 0;
                    grid[(nbCase / 3) + 1, (nbCase % 3)] = 1;
                    
                    int caseNull = ((nbCase / 3) + 1) * 3 + (nbCase % 3);
                    MoveAndCheck(nbCase, caseNull);
                }

                HorizontalMove(nbCase);
            }

            else if (nbCase / 3 == 2)
                {
                //case Up
                if (grid[(nbCase / 3) - 1, (nbCase % 3)] == 0)
                {
                    grid[nbCase / 3, nbCase % 3] = 0;
                    grid[(nbCase / 3) - 1, (nbCase % 3)] = 1;
                    int caseNull = ((nbCase / 3) - 1) * 3 + (nbCase % 3);
                    MoveAndCheck(nbCase, caseNull);
                }
                HorizontalMove(nbCase);
            }
        }

    private void HorizontalMove(int nbCase)
        {
            //test possibility
            if (nbCase % 3 == 0)
            {
                //case Right
                if (grid[(nbCase / 3), (nbCase % 3) + 1] == 0)
                {
                    grid[nbCase / 3, nbCase % 3] = 0;
                    grid[(nbCase / 3), (nbCase % 3) + 1] = 1;
                    int caseNull = nbCase + 1;
                    MoveAndCheck(nbCase, caseNull);
                }
            }

            else if (nbCase % 3 == 1)
            {
                //case Right
                if (grid[(nbCase / 3), (nbCase % 3) + 1] == 0)
                {
                    grid[nbCase / 3, nbCase % 3] = 0;
                    grid[(nbCase / 3), (nbCase % 3) + 1] = 1;
                    int caseNull = nbCase + 1;
                    MoveAndCheck(nbCase, caseNull);
                }
                //case Left
                if (grid[(nbCase / 3), (nbCase % 3) - 1] == 0)
                {
                    grid[nbCase / 3, nbCase % 3] = 0;
                    grid[(nbCase / 3), (nbCase % 3) - 1] = 1;
                    int caseNull = nbCase - 1;
                    MoveAndCheck(nbCase, caseNull);
                }
            }

            else if(nbCase % 3 == 2)
            {
                //case Left
                if (grid[(nbCase / 3), (nbCase % 3) - 1] == 0)
                {
                    grid[nbCase / 3, nbCase % 3] = 0;
                    grid[(nbCase / 3), (nbCase % 3) - 1] = 1;
                    int caseNull = nbCase - 1;
                    MoveAndCheck(nbCase, caseNull);
                }
            }
        }

        private void MoveAndCheck(int caseClick, int caseNull)
        {
            ShowGrid();
            compteur++;
            laNbmove.Text = compteur.ToString();
            int temp = tabResult[caseClick];
            tabResult[caseClick] = tabResult[caseNull];
            tabResult[caseNull] = temp;
            Bitmap tempImage = (Bitmap)listPictureBox[caseClick].Image;
            listPictureBox[caseClick].Image = listPictureBox[caseNull].Image;
            listPictureBox[caseNull].Image = tempImage;
            string checkOrder = "";
            for (int i = 0; i < 9; i++) {
                checkOrder += tabResult[i];
            }
            Console.WriteLine(checkOrder);
            if (checkOrder.Equals("123456789"))
            {
                MessageBox.Show("YEAAAH VICTORY !!!!", "Win");
            }
        }
        #endregion

        private void ShowGrid()
        {
            Console.WriteLine("----------");
            for(int i = 0; i < 3; i++)
            {
                string row = "--";
                string row2 = "--";
                for (int j = 0; j < 3; j++)
                {
                    row += "-" + grid[i,j] + "-";
                    row2 += tabResult[i * 3 + j];
                }
                row += "--";
                row2 += "--";
                Console.WriteLine(row+"||||"+row2);
            }
            Console.WriteLine("----------");
        }
    }
}
