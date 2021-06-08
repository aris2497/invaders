namespace invaders
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
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.gameOver_label = new System.Windows.Forms.Label();
            this.score_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // animationTimer
            // 
            this.animationTimer.Enabled = true;
            this.animationTimer.Interval = 33;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick_1);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // gameOver_label
            // 
            this.gameOver_label.AccessibleName = "gameOver_label";
            this.gameOver_label.AutoSize = true;
            this.gameOver_label.BackColor = System.Drawing.Color.Transparent;
            this.gameOver_label.ForeColor = System.Drawing.Color.Yellow;
            this.gameOver_label.Location = new System.Drawing.Point(388, 190);
            this.gameOver_label.Name = "gameOver_label";
            this.gameOver_label.Size = new System.Drawing.Size(71, 13);
            this.gameOver_label.TabIndex = 0;
            this.gameOver_label.Text = "GAME OVER";
            this.gameOver_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameOver_label.Visible = false;
            // 
            // score_label
            // 
            this.score_label.AccessibleName = "score_label";
            this.score_label.AutoSize = true;
            this.score_label.ForeColor = System.Drawing.Color.Yellow;
            this.score_label.Location = new System.Drawing.Point(13, 13);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(38, 13);
            this.score_label.TabIndex = 1;
            this.score_label.Text = "Score:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.gameOver_label);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label gameOver_label;
        private System.Windows.Forms.Label score_label;
    }
}

