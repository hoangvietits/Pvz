using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pvz
{
    class Floor
    {
        static int yRaw = 60; // chieu cao hang duoi cung 
        static int xStart = 250; // vi tri cua cot dau tien ben trai 
        static int ScreenWidth = 1024; // do rong man hinh
        static int ScreenHeight = 624; //chieu cao man hinh
        static int SquareWidth = 80; // do rong o
        static int SquareHeight = 100; // chieu cao o


        public static int YtoRow(int y)
        {
            if ((y < yRaw) && (y >= yRaw + 5 * SquareHeight))
            {
                return -1;
            }
            return (y - yRaw) / SquareHeight;
        }

        public static int XtoCol(int x)
        {
            if ((x < xStart) || (x >= xStart + SquareWidth * 9))
            {
                return -1;
            }
            return (x - xStart) / SquareWidth;
        }

        public static int RowtoY(int row)
        {
            return row * SquareHeight + yRaw;
        }
        public static int ColToX(int col)
        {
            return col * SquareWidth + xStart;
        }
        public static int GetScreenWidth()
        {
            return ScreenWidth;
        }
        public static int GetScreenHeight()
        {
            return ScreenHeight;  
        }
    }
}
