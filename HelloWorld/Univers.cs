using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Univers
    {
        public Hex[,] hexes;
        public int width;
        public int height;
        public int xOffset;
        public int yOffset;
        public int side;
        public float pixelWidth;
        public float pixelHeight;
        public System.Drawing.Color backgroundColor;
        /// <param name="width">Board width</param>
        /// <param name="height">Board height</param>
        /// <param name="side">Hexagon side length</param>
        /// <param name="orientation">Orientation of the hexagons</param>
        public Univers(int width, int height, int side)
        {
            Initialize(width, height, side, 0, 0);
        }

        /// <param name="width">Board width</param>
        /// <param name="height">Board height</param>
        /// <param name="side">Hexagon side length</param>
        /// <param name="orientation">Orientation of the hexagons</param>
        /// <param name="xOffset">X coordinate offset</param>
        /// <param name="yOffset">Y coordinate offset</param>
        public Univers(int width, int height, int side, int xOffset, int yOffset)
        {
            Initialize(width, height, side, xOffset, yOffset);
        }

        /// <summary>
        /// Sets internal fields and creates board
        /// </summary>
        /// <param name="width">Board width</param>
        /// <param name="height">Board height</param>
        /// <param name="side">Hexagon side length</param>
        /// <param name="orientation">Orientation of the hexagons</param>
        /// <param name="xOffset">X coordinate offset</param>
        /// <param name="yOffset">Y coordinate offset</param>

        private void Initialize(int width, int height, int side, int xOffset, int yOffset)
        {
            this.width = width;
            this.height = height;
            this.xOffset = xOffset;
            this.yOffset = yOffset;
            this.side = side;
            hexes = new Hex[height, width]; //opposite of what we'd expect

            float h = HexaUtils.CalculateH(side); // short side
            float r = HexaUtils.CalculateR(side); // long side

            //
            // Calculate pixel info..remove?
            // because of staggering, need to add an extra r/h
            float hexWidth = 0;
            float hexHeight = 0;
            
            hexWidth = r + r;
            hexHeight = side + h;
            this.pixelWidth = (width * hexWidth) + r;
            this.pixelHeight = (height * hexHeight) + h;
                 

            bool inTopRow = false;
            bool inBottomRow = false;
            bool inLeftColumn = false;
            bool inRightColumn = false;
            bool isTopLeft = false;
            bool isTopRight = false;
            bool isBotomLeft = false;
            bool isBottomRight = false;


            // i = y coordinate (rows), j = x coordinate (columns) of the hex tiles 2D plane
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    // Set position booleans
                    #region Position Booleans
                    if (i == 0)
                    {
                        inTopRow = true;
                    }
                    else
                    {
                        inTopRow = false;
                    }

                    //if (i == height - 1)
                    //{
                    //    inBottomRow = true;
                    //}
                    //else
                    //{
                    //    inBottomRow = false;
                    //}

                    //if (j == 0)
                    //{
                    //    inLeftColumn = true;
                    //}
                    //else
                    //{
                    //    inLeftColumn = false;
                    //}

                    //if (j == width - 1)
                    //{
                    //    inRightColumn = true;
                    //}
                    //else
                    //{
                    //    inRightColumn = false;
                    //}

                    //if (inTopRow && inLeftColumn)
                    //{
                    //    isTopLeft = true;
                    //}
                    //else
                    //{
                    //    isTopLeft = false;
                    //}

                    //if (inTopRow && inRightColumn)
                    //{
                    //    isTopRight = true;
                    //}
                    //else
                    //{
                    //    isTopRight = false;
                    //}

                    //if (inBottomRow && inLeftColumn)
                    //{
                    //    isBotomLeft = true;
                    //}
                    //else
                    //{
                    //    isBotomLeft = false;
                    //}

                    //if (inBottomRow && inRightColumn)
                    //{
                    //    isBottomRight = true;
                    //}
                    //else
                    //{
                    //    isBottomRight = false;
                    //}
                    #endregion

                    //
                    // Calculate Hex positions
                    //
                    int ind = i - 6;
                    int jnd = j - 6;

                    if (isTopLeft)
                    {
                        hexes[0, 0] = new Hex(width/2, height/2, side);

                    }
                    else
                    {
                        float newX = r * 2 * ind + width / 2;
                        float newY = r + height / 2 + r * 2 * jnd;
                        hexes[i, j] = new Hex(newX, newY, side);
                        
                    }


                }
            }



        }

        public bool PointInBoardRectangle(System.Drawing.Point point)
        {
            return PointInBoardRectangle(point.X, point.Y);
        }

        public bool PointInBoardRectangle(int x, int y)
        {
            //
            // Quick check to see if X,Y coordinate is even in the bounding rectangle of the board.
            // Can produce a false positive because of the staggerring effect of hexes around the edge
            // of the board, but can be used to rule out an x,y point.
            //
            int topLeftX = 0 + xOffset;
            int topLeftY = 0 + yOffset;
            float bottomRightX = topLeftX + pixelWidth;
            float bottomRightY = topLeftY + pixelHeight;


            if (x > topLeftX && x < bottomRightX && y > topLeftY && y < bottomRightY)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /*public Hex FindHexMouseClick(System.Drawing.Point point)
        {
            return FindHexMouseClick(point.X, point.Y);
        }

        public Hex FindHexMouseClick(int x, int y)
        {
            Hex target = null;

            if (PointInBoardRectangle(x, y))
            {
                for (int i = 0; i < hexes.GetLength(0); i++)
                {
                    for (int j = 0; j < hexes.GetLength(1); j++)
                    {
                        if (Math.InsidePolygon(hexes[i, j].Points, 6, new System.Drawing.PointF(x, y)))
                        {
                            target = hexes[i, j];
                            break;
                        }
                    }

                    if (target != null)
                    {
                        break;
                    }
                }

            }

            return target;

        }*/

    }
}
