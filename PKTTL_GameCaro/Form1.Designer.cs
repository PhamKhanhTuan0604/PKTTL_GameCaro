namespace PKTTL_GameCaro
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptrAvatar = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.prcbCoolDown = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.ptrLuotChoi = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnLogoDHSP = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngườiChơiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngườiChơiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tmCoolDown = new System.Windows.Forms.Timer(this.components);
            this.ptrLogoDHSP = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrAvatar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrLuotChoi)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrLogoDHSP)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.BackColor = System.Drawing.Color.White;
            this.pnlChessBoard.Location = new System.Drawing.Point(12, 31);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(847, 585);
            this.pnlChessBoard.TabIndex = 0;
            this.pnlChessBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ptrAvatar);
            this.panel2.Location = new System.Drawing.Point(877, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 284);
            this.panel2.TabIndex = 1;
            // 
            // ptrAvatar
            // 
            this.ptrAvatar.BackgroundImage = global::PKTTL_GameCaro.Properties.Resources.LOGO_Caro;
            this.ptrAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptrAvatar.Location = new System.Drawing.Point(3, 3);
            this.ptrAvatar.Name = "ptrAvatar";
            this.ptrAvatar.Size = new System.Drawing.Size(281, 281);
            this.ptrAvatar.TabIndex = 0;
            this.ptrAvatar.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.prcbCoolDown);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.ptrLuotChoi);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pnLogoDHSP);
            this.panel3.Location = new System.Drawing.Point(877, 343);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(305, 273);
            this.panel3.TabIndex = 3;
            // 
            // prcbCoolDown
            // 
            this.prcbCoolDown.Location = new System.Drawing.Point(26, 144);
            this.prcbCoolDown.Name = "prcbCoolDown";
            this.prcbCoolDown.Size = new System.Drawing.Size(256, 23);
            this.prcbCoolDown.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lượt chơi";
            // 
            // ptrLuotChoi
            // 
            this.ptrLuotChoi.Location = new System.Drawing.Point(182, 20);
            this.ptrLuotChoi.Name = "ptrLuotChoi";
            this.ptrLuotChoi.Size = new System.Drawing.Size(100, 100);
            this.ptrLuotChoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrLuotChoi.TabIndex = 2;
            this.ptrLuotChoi.TabStop = false;
            this.ptrLuotChoi.Click += new System.EventHandler(this.ptrLuotChoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "5 lines to win";
            // 
            // pnLogoDHSP
            // 
            this.pnLogoDHSP.BackColor = System.Drawing.SystemColors.Control;
            this.pnLogoDHSP.Location = new System.Drawing.Point(300, 254);
            this.pnLogoDHSP.Name = "pnLogoDHSP";
            this.pnLogoDHSP.Size = new System.Drawing.Size(93, 44);
            this.pnLogoDHSP.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1207, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnMenu
            // 
            this.mnMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.ngườiChơiToolStripMenuItem,
            this.ngườiChơiToolStripMenuItem1});
            this.mnMenu.Name = "mnMenu";
            this.mnMenu.Size = new System.Drawing.Size(60, 24);
            this.mnMenu.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // ngườiChơiToolStripMenuItem
            // 
            this.ngườiChơiToolStripMenuItem.Name = "ngườiChơiToolStripMenuItem";
            this.ngườiChơiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.ngườiChơiToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.ngườiChơiToolStripMenuItem.Text = "Undo";
            this.ngườiChơiToolStripMenuItem.Click += new System.EventHandler(this.ngườiChơiToolStripMenuItem_Click);
            // 
            // ngườiChơiToolStripMenuItem1
            // 
            this.ngườiChơiToolStripMenuItem1.Name = "ngườiChơiToolStripMenuItem1";
            this.ngườiChơiToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.ngườiChơiToolStripMenuItem1.Size = new System.Drawing.Size(179, 26);
            this.ngườiChơiToolStripMenuItem1.Text = "Quit";
            this.ngườiChơiToolStripMenuItem1.Click += new System.EventHandler(this.ngườiChơiToolStripMenuItem1_Click);
            // 
            // tmCoolDown
            // 
            this.tmCoolDown.Tick += new System.EventHandler(this.tmCoolDown_Tick);
            // 
            // ptrLogoDHSP
            // 
            this.ptrLogoDHSP.BackgroundImage = global::PKTTL_GameCaro.Properties.Resources.Logo_Trường_Đại_học_Sư_phạm_Thành_phố_Hồ_Chí_Minh_svg;
            this.ptrLogoDHSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptrLogoDHSP.Location = new System.Drawing.Point(1105, 601);
            this.ptrLogoDHSP.Name = "ptrLogoDHSP";
            this.ptrLogoDHSP.Size = new System.Drawing.Size(90, 40);
            this.ptrLogoDHSP.TabIndex = 0;
            this.ptrLogoDHSP.TabStop = false;
            this.ptrLogoDHSP.Click += new System.EventHandler(this.ptrLogoDHSP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1207, 644);
            this.Controls.Add(this.ptrLogoDHSP);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlChessBoard);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Game Caro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptrAvatar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrLuotChoi)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrLogoDHSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnLogoDHSP;
        private System.Windows.Forms.PictureBox ptrLogoDHSP;
        private System.Windows.Forms.PictureBox ptrAvatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnMenu;
        private System.Windows.Forms.ToolStripMenuItem ngườiChơiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngườiChơiToolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptrLuotChoi;
        private System.Windows.Forms.ProgressBar prcbCoolDown;
        private System.Windows.Forms.Timer tmCoolDown;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
    }
}

