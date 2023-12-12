using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class Form1 : Form
    {
        ChessBoardManager ChessBoard;
        public Form1()
        {
            InitializeComponent();
            ChessBoard = new ChessBoardManager(panelBoard, textBoxPlayerName, pictureBoxMark);

            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;
            progressBarCoolDown.Step = Const.coolDownStep;
            progressBarCoolDown.Maximum = Const.coolDownTime;
            progressBarCoolDown.Value = 0;

            timerCoolDown.Interval = Const.coolDownInterval;

            NewGame();

        }

        private void ChessBoard_PlayerMarked(object sender, EventArgs e)
        {
            timerCoolDown.Start();
            progressBarCoolDown.Value = 0;
        }

        private void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
        }

        private void timerCoolDown_Tick(object sender, EventArgs e)
        {
            progressBarCoolDown.PerformStep();
            if (progressBarCoolDown.Value >= progressBarCoolDown.Maximum )
            {
                
                timerCoolDown.Stop();
                EndGame();
            }
        }

        void EndGame()
        {
            panelBoard.Enabled = false;
            timerCoolDown.Stop();
            MessageBox.Show("Game đấu đã kết thúc","Thông báo");
            
        }

        void NewGame()
        {
            timerCoolDown.Stop();
            ChessBoard.DrawChessBoard();
            progressBarCoolDown.Value = 0;
            
        }

        void Undo()
        {

        }

        void Quit()
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                Application.Exit();
        }
        


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }
               

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }
    }
}
