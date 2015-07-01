namespace Game
{
    partial class GameOverForm
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
            this.RestartGame = new System.Windows.Forms.Button();
            this.ExitGame = new System.Windows.Forms.Button();
            this.GameOver = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RestartGame
            // 
            this.RestartGame.Location = new System.Drawing.Point(324, 359);
            this.RestartGame.Name = "RestartGame";
            this.RestartGame.Size = new System.Drawing.Size(115, 43);
            this.RestartGame.TabIndex = 0;
            this.RestartGame.Text = "Restart Game";
            this.RestartGame.UseVisualStyleBackColor = true;
            // 
            // ExitGame
            // 
            this.ExitGame.Location = new System.Drawing.Point(324, 429);
            this.ExitGame.Name = "ExitGame";
            this.ExitGame.Size = new System.Drawing.Size(115, 43);
            this.ExitGame.TabIndex = 1;
            this.ExitGame.Text = "Exit Game";
            this.ExitGame.UseVisualStyleBackColor = true;
            this.ExitGame.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // GameOver
            // 
            this.GameOver.AutoSize = true;
            this.GameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.GameOver.Location = new System.Drawing.Point(230, 164);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(320, 63);
            this.GameOver.TabIndex = 2;
            this.GameOver.Text = "Game Over!";
            // 
            // GameOverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(736, 563);
            this.Controls.Add(this.GameOver);
            this.Controls.Add(this.ExitGame);
            this.Controls.Add(this.RestartGame);
            this.ForeColor = System.Drawing.Color.Green;
            this.Name = "GameOverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameOverForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RestartGame;
        private System.Windows.Forms.Button ExitGame;
        private System.Windows.Forms.Label GameOver;
    }
}