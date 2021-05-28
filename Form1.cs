using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomoku
{
    public partial class Form1 : Form
    {
        Cell[,] Board;
        int Dimensions = 19;
        int Turn=0;
        int WinCount=5;
        Color[] colors = { Color.Blue, Color.Red };

        Player[] Ps;

        public Form1()
        {
            InitializeComponent();
        }

        private void TurnChange()
        {
            if (Turn == 0)
                Turn = 1;
            else
                Turn = 0;
        }

        private bool VerticalWin(int wincount)
        {
            for(int row=0;row<Dimensions- wincount; row++)
            {
                for(int col=0;col<Dimensions;col++)
                {
                    bool match = true;
                    for(int i=0;i< wincount; i++)
                    {
                        if (Turn != Board[row+i,col].color)
                            match = false;
                    }
                    if (match) return true;
                }
            }
            return false;
        }

        private bool HorizontalWin(int wincount)
        {
            for (int row = 0; row < Dimensions; row++)
            {
                for (int col = 0; col < Dimensions- wincount; col++)
                {
                    bool match = true;
                    for (int i = 0; i < wincount; i++)
                    {
                        if (Turn != Board[row, col+i].color)
                            match = false;
                    }
                    if (match) return true;
                }
            }
            return false;
        }

        private bool DiagonalWin(int wincount)
        {
            for (int row = 0; row < Dimensions- wincount; row++)
            {
                for (int col = 0; col < Dimensions- wincount; col++)
                {
                    bool match = true;
                    for (int i = 0; i < wincount; i++)
                    {
                        if (Turn != Board[row + i, col+i].color)
                            match = false;
                    }
                    if (match) return true;
                }
            }

            for (int row = 0; row < Dimensions- wincount; row++)
            {
                for (int col = wincount; col < Dimensions- wincount; col++)
                {
                    bool match = true;
                    for (int i = 0; i < wincount; i++)
                    {
                        if (Turn != Board[row + i, col - i].color)
                            match = false;
                    }
                    if (match) return true;
                }
            }
            return false;
        }

        private bool CheckforWin(int i)
        {
            if(VerticalWin(i))
                return true;

            if(HorizontalWin(i))
                return true;

            if(DiagonalWin(i))
                return true;

            return false;
        }

        private bool CheckforDraw()
        {
            for(int i=0;i<Dimensions;i++)
            {
                for(int j=0;j<Dimensions;j++)
                {
                    if (Board[i, j].isOpen == false)
                        return false;
                }
            }
            return true;
        }

        private void MakeMove(Cell SelectedCell)
        {
            SelectedCell.BackColor = colors[Turn];
            SelectedCell.color = Turn;
            SelectedCell.isOpen = true;
            if (CheckforWin(WinCount))
            {
                MessageBox.Show("Player " + (Turn + 1) + " Wins");
                BoardPanel.Controls.Clear();
                TurnMsgLabel.Text = "";
                return;
            }
            if (CheckforDraw())
            {
                MessageBox.Show("Game Drawn.");
                BoardPanel.Controls.Clear();
                TurnMsgLabel.Text = "";
                return;
            }
        }

        private void TurnMsg()
        {
            TurnMsgLabel.Text = "Player " + (Turn + 1) + "'s Turn";
            if (Turn == 0)
                TurnMsgLabel.ForeColor = Color.Blue;
            else
                TurnMsgLabel.ForeColor = Color.Red;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Cell ClickedCell = (Cell)sender;
            if (ClickedCell.isOpen)
                return;
            MakeMove(ClickedCell);
            TurnChange();
            TurnMsg();
            ComputerMove();
            TurnChange();
            TurnMsg();
        }

        private void ComputerMove()
        {
            Cell SelectedCell=SelectBestMove();
            MakeMove(SelectedCell);
        }

        private Cell SelectBestMove()
        {
            int ri=-1, ci=-1;
            for (int i = WinCount; i >=0 ; i--)
            {
                for (int r = 0; r < Dimensions && ri == -1; r++)
                {
                    for (int c = 0; c < Dimensions && ci == -1; c++)
                    {
                        if (!Board[r, c].isOpen)
                        {
                            Board[r, c].Occupy(Turn);
                            if (CheckforWin(i))
                            {
                                ri = r;
                                ci = c;
                            }
                            Board[r, c].UnOccupy();
                        }
                    }
                }

                if (ri == -1 && ci == -1)
                {
                    TurnChange();
                    for (int r = 0; r < Dimensions && ri == -1; r++)
                    {
                        for (int c = 0; c < Dimensions && ci == -1; c++)
                        {
                            if (!Board[r, c].isOpen)
                            {
                                Board[r, c].Occupy(Turn);
                                if (CheckforWin(i))
                                {
                                    ri = r;
                                    ci = c;
                                }
                                Board[r, c].UnOccupy();
                            }
                        }
                    }
                    TurnChange();
                }
            }
            if (ri == -1 && ci == -1)
            {
                Random rand = new Random();
                do
                {
                    ri = rand.Next(Dimensions-1);
                    ci = rand.Next(Dimensions - 1);
                } while (Board[ri, ci].isOpen);
            }
            return Board[ri, ci];
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Turn = 0;
            Ps = new Player[2];
            BoardPanel.Controls.Clear();
            Board = new Cell[Dimensions, Dimensions];
            for (int ri = 0; ri < Dimensions; ri++)
            {
                for (int ci = 0; ci < Dimensions; ci++)
                {
                    Board[ri, ci] = new Cell(ri, ci, BoardPanel.Width, BoardPanel.Height, Dimensions);
                    Board[ri, ci].MouseDown += new MouseEventHandler(this.panel1_MouseDown);
                    BoardPanel.Controls.Add(Board[ri, ci]);
                }
            }
            Player1box.BackColor = Color.Blue;
            Player2box.BackColor = Color.Red;
            TurnMsgLabel.Text = "Player " + (Turn + 1) + "'s Turn";
            TurnMsgLabel.ForeColor = Color.Blue;
        }
    }
}
