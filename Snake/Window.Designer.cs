namespace Snake
{
    partial class Window
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
            this.m_Timer = new System.Windows.Forms.Timer(this.components);
            this.m_RestartBtn = new System.Windows.Forms.Button();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_Timer
            // 
            this.m_Timer.Interval = 300;
            this.m_Timer.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // m_RestartBtn
            // 
            this.m_RestartBtn.Enabled = false;
            this.m_RestartBtn.Location = new System.Drawing.Point(0, 0);
            this.m_RestartBtn.Name = "m_RestartBtn";
            this.m_RestartBtn.Size = new System.Drawing.Size(75, 30);
            this.m_RestartBtn.TabIndex = 0;
            this.m_RestartBtn.Text = "Restart";
            this.m_RestartBtn.UseVisualStyleBackColor = true;
            this.m_RestartBtn.Click += new System.EventHandler(this.OnRestartBtnClick);
            // 
            // scoreLbl
            // 
            this.scoreLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Location = new System.Drawing.Point(198, 5);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(72, 20);
            this.scoreLbl.TabIndex = 1;
            this.scoreLbl.Text = "Score : 0";
            // 
            // SnakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 424);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.m_RestartBtn);
            this.DoubleBuffered = true;
            this.Name = "SnakeGame";
            this.ShowIcon = false;
            this.Text = "Snake";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer m_Timer;
        private System.Windows.Forms.Button m_RestartBtn;
        private System.Windows.Forms.Label scoreLbl;
    }
}

