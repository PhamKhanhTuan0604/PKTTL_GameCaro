using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKTTL_GameCaro
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;
        public Panel ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }

        private List<Player> player;

        public List<Player> Player
        {
            get { return player;}
            set { player = value; }
        }

        private int currentPlayer;

        public int CurrentPlayer
        {
            get { return currentPlayer; }
            set { currentPlayer = value; }
        }

        private PictureBox playerMark;

        public PictureBox PlayerMark
        {
            get { return playerMark; }
            set { playerMark = value;  }
        }

        private List<List<Button>> matrix;
        private object pnlChessBoard;

        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

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

        private Stack<PlayInfo> playTimeLine;

        public Stack<PlayInfo> PlayTimeLine
        {
            get { return playTimeLine; }
            set { playTimeLine = value;  }
        }


        #endregion

        #region Initialize
        public ChessBoardManager(Panel chessBoard, PictureBox mark)
        {
            this.chessBoard = chessBoard;
            this.PlayerMark = mark;
            this.player = new List<Player>() {
                new Player("playerX",Image.FromFile(Application.StartupPath + "\\Resource\\Caro_X.png")),
                new Player("playerO",Image.FromFile(Application.StartupPath + "\\Resource\\Caro_O.png"))
            };

        }
        #endregion

        #region Methods
        public void DrawChessBoard()
        {
            PlayTimeLine = new Stack<PlayInfo>();
            ChessBoard.Enabled = true;
            ChessBoard.Controls.Clear();

            CurrentPlayer = 0;
            ChangePlayer();

            Matrix = new List<List<Button>>();
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < cons.CHESS_BOARD_HEIGHT; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < cons.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = cons.CHESS_WIDTH,
                        Height = cons.CHESS_HEIGHT,
                        Location = new Point(oldButton.Location.X + cons.CHESS_WIDTH, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()  // Xác định thằng button nằm ở hàng nào
                    };

                    btn.Click += btn_Click;

                    ChessBoard.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    oldButton = btn;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + cons.CHESS_HEIGHT);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }

        }

        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.BackgroundImage != null) {
                return;
            }
            Mark(btn);
            Sound();

            PlayTimeLine.Push(new PlayInfo(GetChessPoint(btn), CurrentPlayer));

            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;

            ChangePlayer();

            if (playerMarked != null)
                playerMarked(this, new EventArgs());

            if (isEndGame(btn))
            {
                EndGame();
            }


        }

        public bool Undo()
        {
            if (PlayTimeLine.Count <= 0)
                return false;

            PlayInfo oldPoint = PlayTimeLine.Pop();
            Button btn = Matrix[oldPoint.Point.Y][oldPoint.Point.X];
            btn.BackgroundImage = null;

            if (PlayTimeLine.Count <= 0)
            {
                CurrentPlayer = 0;
            }    
            else
            {
                oldPoint = PlayTimeLine.Peek();
                CurrentPlayer = oldPoint.CurrentPlayer == 1 ? 0 : 1;
            }    
            ChangePlayer();
            return true;
        }

        public void EndGame()
        {
            if(endedGame != null) // Hàm được ủy thác, kiểm tra xem có ủy thác chưa, chưa sẽ bị lỗi
            {
                endedGame(this, new EventArgs());
            }    
        }

        private bool isEndGame(Button btn)
        {

            return isEndHorizontal(btn) || isEndVertical(btn) || isEndPrimary(btn) || isEndSub(btn);
        }

        private Point GetChessPoint(Button btn)
        {
            //Lấy tọa độ button
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);


            Point point = new Point(horizontal, vertical);
            return point;
        }

        //Kết thúc hàng ngang
        private bool isEndHorizontal(Button btn) 
        {
            Point point = GetChessPoint(btn);
            int countLeft = 0;
            for(int i = point.X; i >= 0 ; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                    break;
            }    
            int countRight = 0;
            for (int i = point.X + 1; i < cons.CHESS_BOARD_WIDTH; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                    break;
            }

            return countLeft + countRight == 5;
        }

        //Kết thúc hàng dọc
        private bool isEndVertical(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            int countBottom = 0;
            for (int i = point.Y + 1; i < cons.CHESS_BOARD_HEIGHT; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 5;

        }

        //Kết thúc chéo chính
        private bool isEndPrimary(Button btn)
        {
            //Tọa độ cùng tăng cùng giảm
            Point point = GetChessPoint(btn);
            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.Y - i < 0 || point.X - i < 0)
                    break;
                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            int countBottom = 0;
            for (int i = 1; i < cons.CHESS_BOARD_WIDTH - point.X; i++)
            {
                if (point.Y + i >= cons.CHESS_BOARD_HEIGHT || point.X + i >= cons.CHESS_BOARD_WIDTH)
                    break;
                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 5;

        }

        //Kết thúc chéo phụ
        private bool isEndSub(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i > cons.CHESS_BOARD_WIDTH || point.Y - i < 0)
                    break;
                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            int countBottom = 0;
            for (int i = 1; i < cons.CHESS_BOARD_WIDTH - point.X; i++)
            {
                if (point.Y + i >= cons.CHESS_BOARD_HEIGHT || point.X - i < 0)
                    break;
                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 5;
        }

        private void Mark(Button btn)
        {
            btn.BackgroundImage = Player[CurrentPlayer].Mark;

        }
        private void ChangePlayer()
        {
            PlayerMark.Image = Player[CurrentPlayer].Mark;
        }

        private void Sound()
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.click_sound);
            player.Play();
        }
        #endregion
    }
}