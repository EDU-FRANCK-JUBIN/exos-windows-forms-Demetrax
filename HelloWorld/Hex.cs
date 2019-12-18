using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Hex
    {
        public System.Drawing.PointF[] points;
        public float side;
        public float h;
        public float r;
        public float x;
        public float y;

        

        public Hex(float x, float y, float side)
        {
            this.side = side;
            this.x = x;
            this.y = y;
            CalculateVertices();
        }

        public Hex(PointF point, float side)
        {
            this.side = side;
            this.x = point.X;
            this.y = point.Y;
            CalculateVertices();
        }

        public void CalculateVertices()
        {
            h = HexaUtils.CalculateH(side);
            r = HexaUtils.CalculateR(side);

            points = new System.Drawing.PointF[6];
            points[0] = new PointF(x, y);
            points[1] = new PointF(x + r, y + h);
            points[2] = new PointF(x + r, y + side + h);
            points[3] = new PointF(x, y + side + h + h);
            points[4] = new PointF(x - r, y + side + h);
            points[5] = new PointF(x - r, y + h);

        }


    }
}
