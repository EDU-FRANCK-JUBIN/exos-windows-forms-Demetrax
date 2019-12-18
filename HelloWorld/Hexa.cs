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
    public partial class Hexa : Form
    {
        Univers univers;
        HexaGraphics hexaGraphics;

        public Hexa()
        {
            InitializeComponent();
            this.univers = new Univers(Convert.ToInt32(panel1.Width),Convert.ToInt32(panel1.Height),20);
            this.hexaGraphics = new HexaGraphics(univers);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            //Get the middle of the panel
            /*var x_0 = panel1.Width / 2;
            var y_0 = panel1.Height / 2;

            Hex hex = new Hex(x_0, y_0, 30);

            SolidBrush sb = new SolidBrush(Color.DarkBlue);
            graphics.DrawPolygon(Pens.Red, hex.points);
            graphics.FillPolygon(sb, hex.points);*/

            hexaGraphics.Draw(e.Graphics);
        }

    }
}
