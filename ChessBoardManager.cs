using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{   
    public class ChessBoardManager
    {
        #region Properties
        private Panel panelChessBoard;
        private List<Player> players;
        private int currentPlayer;
        private TextBox textBoxPlayerName;
        private PictureBox pictureBoxMark;
        private List<List<Button>> matrix;

        private event EventHandler playerMarked;
        public event EventHandler PlayerMarked
        {
            add { playerMarked += value; }
            remove { playerMarked -= value; }
        }

        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add { endedGame += value; }
            remove { endedGame -= value; }
        }

        public Panel PanelChessBoard { get => panelChessBoard; set => panelChessBoard = value; }
        public List<Player> Players { get => players; set => players = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        public TextBox TextBoxPlayerName { get => textBoxPlayerName; set => textBoxPlayerName = value; }
        public PictureBox PictureBoxMark { get => pictureBoxMark; set => pictureBoxMark = value; }
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }





        #endregion

        public ChessBoardManager(Panel chessBoard, TextBox textBoxPlayerName, PictureBox pictureBoxMark)
        {
            this.PanelChessBoard = chessBoard;
            this.TextBoxPlayerName = textBoxPlayerName;
            this.PictureBoxMark = pictureBoxMark;
            this.Players = new List<Player>()
            {
                new Player("Player1", Image.FromFile(Application.StartupPath + "\\img\\X.png")),
                new Player("Player2", Image.FromFile(Application.StartupPath + "\\img\\O.png")),
            };
            
        }
        

        #region Method

        public void DrawChessBoard()
        {
            panelChessBoard.Enabled = true;
            panelChessBoard.Controls.Clear();
            Matrix = new List<List<Button>>();
            CurrentPlayer = 0;
            ChangePlayer();
            
            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Const.ChessRow; i++)
            {
                for (int j = 0; j < Const.ChessCol; j++)
                {
                    Matrix.Add(new List<Button>());
                    Button btn = new Button()
                    {
                        Width = Const.ChessWidth,
                        Height = Const.ChessWidth,
                        Location = new Point(oldBtn.Location.X + oldBtn.Width, oldBtn.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };

                    btn.Click += Btn_Click;
                    panelChessBoard.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    oldBtn = btn;
                }
                oldBtn.Location = new Point(0, oldBtn.Location.Y + oldBtn.Height);
                oldBtn.Height = 0;
                oldBtn.Width = 0;
            }


        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            if (btn.BackgroundImage != null)
            {
                return;
            }
            Mark(btn);
            ChangePlayer();
            if (playerMarked != null)
            {
                playerMarked(this, new EventArgs());
            }

            if (isEndGame(btn))
            {
                EndGame();
            }

            
        }
        private void Mark( Button btn)
        {
            btn.BackgroundImage = Players[CurrentPlayer].Mark;

            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
        }

        private void ChangePlayer()
        {
            TextBoxPlayerName.Text = Players[CurrentPlayer].Name;
            PictureBoxMark.Image = Players[CurrentPlayer].Mark;
        }

        private bool isEndGame(Button btn)
        {
            return isEndGameHorizontal(btn) || isEndGameVectical(btn) || isEndGameDiagonalLine(btn) || isEndGameDiagonalLineSub(btn);
        }

        private Point GetCheckPoint(Button btn)
        {
            

            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);
            Point point = new Point(horizontal,vertical);
            return point;
        }
        private bool isEndGameHorizontal(Button btn)
        {
            Point point = GetCheckPoint(btn);
            int countLeft = 0;           
            for (int i = point.X; i >= 0 ;i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                } else
                {
                    break;
                }
            }
            int countRight = 0;
            for (int i = point.X+1; i <= Const.ChessRow; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                {
                    break;
                }
            }

            return countLeft+ countRight == 5;
        }
        private bool isEndGameVectical(Button btn)
        {
            Point point = GetCheckPoint(btn);
            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                {
                    break;
                }
            }
            int countBottom = 0;
            for (int i = point.Y + 1; i < Const.ChessRow; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                {
                    break;
                }
            }

            return countTop + countBottom == 5;
        }

        private bool isEndGameDiagonalLine(Button btn)
        {
            Point point = GetCheckPoint(btn);
            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                {
                    break;
                }
                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                {
                    break;
                }
            }
            int countBottom = 0;
            for (int i = 1; i <= Const.ChessCol; i++)
            {
                if (point.X + i >= Const.ChessCol ||point.Y + i >= Const.ChessRow) 
                {
                    break;
                }
                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                {
                    break;
                }
            }

            return countTop + countBottom == 5;
        }

        private bool isEndGameDiagonalLineSub(Button btn)
        {
            Point point = GetCheckPoint(btn);
            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X + i >= Const.ChessCol || point.Y - i < 0)
                {
                    break;
                }
                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                {
                    break;
                }
            }
            int countBottom = 0;
            for (int i = 1; i <= Const.ChessCol; i++)
            {
                if (point.X - i < 0 || point.Y + i >= Const.ChessRow)
                {
                    break;
                }
                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                {
                    break;
                }
            }

            return countTop + countBottom == 5;
        }


        public void EndGame()
        {
            if (endedGame != null)
            {
                endedGame(this, new EventArgs());
            }
        }
        #endregion
    }
}
