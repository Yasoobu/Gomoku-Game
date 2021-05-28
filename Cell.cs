using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomoku
{
    class Cell : Button
    {
        int r;
        int c;
        public int color;
        public bool isOpen;

        public Cell(int ri, int ci, int W, int H, int Dimensions)
        {
            r = ri;
            c = ci;
            isOpen = false;
            color = -1;
            this.Width = W / Dimensions;
            this.Height = H / Dimensions;
            this.Margin = new Padding(0);
        }

        public void Occupy(int Turn)
        {
            color = Turn;
            isOpen = true;
        }

        public void UnOccupy()
        {
            color = -1;
            isOpen = false;
        }
    }
}
