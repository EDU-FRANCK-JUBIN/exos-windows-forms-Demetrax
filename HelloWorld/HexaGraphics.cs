using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class HexaGraphics
    {
        public Univers univers;
        public float boardPixelWidth;
        public float boardPixelHeight;
        public int boardXOffset;
        public int boardYOffset;

        public HexaGraphics(Univers univer)
        {
            this.Initialize(univer, 0, 0);
        }

        public HexaGraphics(Univers univer, int xOffset, int yOffset)
        {
            this.Initialize(univer, xOffset, yOffset);
        }


        private void Initialize(Univers univer, int xOffset, int yOffset)
        {
            this.univers = univer;
            this.boardXOffset = xOffset;
            this.boardYOffset = yOffset;
        }

        public void Draw(Graphics graphics)
        {

            int width = Convert.ToInt32(Math.Ceiling(univers.pixelWidth));
            int height = Convert.ToInt32(System.Math.Ceiling(univers.pixelHeight));
            // seems to be needed to avoid bottom and right from being chopped off
            width += 1;
            height += 1;

            //
            // Create drawing objects
            //
            Bitmap bitmap = new Bitmap(width, height);
            Graphics bitmapGraphics = Graphics.FromImage(bitmap);
            Pen p = new Pen(Color.Black);
            SolidBrush sb = new SolidBrush(Color.Black);


            //
            // Draw Board background
            //
            sb = new SolidBrush(Color.White);
            bitmapGraphics.FillRectangle(sb, 0, 0, width, height);

            //
            // Draw Hex Background 
            //
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    //bitmapGraphics.DrawPolygon(p, board.Hexes[i, j].Points);
                    bitmapGraphics.FillPolygon(new SolidBrush(Color.Blue), univers.hexes[i, j].points);
                    Console.WriteLine("i : " + i + " j : " + j + "POiNT => " + univers.hexes[i, j].points[0]);
                }
            }


            //
            // Draw Hex Grid
            //
            p.Color = Color.DarkGray;
            p.Width = 1f;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    bitmapGraphics.DrawPolygon(p, univers.hexes[i, j].points);
                }
            }

            //
            // Draw Active Hex, if present
            //
            /*
            if (board.BoardState.ActiveHex != null)
            {
                p.Color = board.BoardState.ActiveHexBorderColor;
                p.Width = board.BoardState.ActiveHexBorderWidth;
                bitmapGraphics.DrawPolygon(p, board.BoardState.ActiveHex.Points);
            }
            */
            //
            // Draw internal bitmap to screen
            //
            graphics.DrawImage(bitmap, new Point(this.boardXOffset, this.boardYOffset));

            //
            // Release objects
            //
            bitmapGraphics.Dispose();
            bitmap.Dispose();

        }

    }
}
