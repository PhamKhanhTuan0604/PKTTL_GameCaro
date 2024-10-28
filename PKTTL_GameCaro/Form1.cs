using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKTTL_GameCaro
{
    public partial class Form1 : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;
        #endregion
        public Form1()
        {
            InitializeComponent();

            
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ptrLogoDHSP_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ngườiChơiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Quit();
        }

        void newGame2()
        {
            ngườiChơiToolStripMenuItem.Enabled = true;
            ChessBoard.DrawChessBoard();
        }

        void Quit()
        {
            Application.Exit();
        }

        void Undo()
        {
            ChessBoard.Undo();
        }

        void EndGame()
        {
   
            tmCoolDown.Stop();
            pnlChessBoard.Enabled = false;
            ngườiChơiToolStripMenuItem.Enabled = false;
            MessageBox.Show("Trò chơi kết thúc");
        }

       //1 người chơi
        private void ngườiChơiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        //2 người chơi
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ChessBoard = new ChessBoardManager(pnlChessBoard, ptrLuotChoi);

            ChessBoard.EndedGame += ChessBoard_EndGame;
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;

            prcbCoolDown.Step = cons.COOL_DOWN_STEP;
            prcbCoolDown.Maximum = cons.COOL_DOWN_TIME;
            prcbCoolDown.Value = 0;
            tmCoolDown.Interval = cons.COOL_DOWN_INTERVAL;

            newGame2();

            
        }

        private void ptrLuotChoi_Click(object sender, EventArgs e)
        {

        }

        //undo
        private void ngườiChơiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        void ChessBoard_EndGame(object sender, EventArgs e)
        {
            EndGame();
        }
        void ChessBoard_PlayerMarked(object sender, EventArgs e)
        {
            tmCoolDown.Start();
            prcbCoolDown.Value = 0;
        }

        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát trò chơi?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                e.Cancel = true;
        }

        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            prcbCoolDown.PerformStep();
            if (prcbCoolDown.Value >= prcbCoolDown.Maximum)
            {
                EndGame();
            }    
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChessBoard = new ChessBoardManager(pnlChessBoard, ptrLuotChoi);

            ChessBoard.EndedGame += ChessBoard_EndGame;
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;

            prcbCoolDown.Step = cons.COOL_DOWN_STEP;
            prcbCoolDown.Maximum = cons.COOL_DOWN_TIME;
            prcbCoolDown.Value = 0;
            tmCoolDown.Interval = cons.COOL_DOWN_INTERVAL;

            newGame2();
        }
    }
}
