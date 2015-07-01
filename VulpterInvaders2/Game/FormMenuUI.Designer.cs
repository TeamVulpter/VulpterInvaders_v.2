namespace Game
{
    partial class FormMenuUI
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
            this.Btn_StartNewGame = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playMusic = new System.Windows.Forms.Button();
            this.stopMusic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_StartNewGame
            // 
            this.Btn_StartNewGame.Location = new System.Drawing.Point(310, 462);
            this.Btn_StartNewGame.Name = "Btn_StartNewGame";
            this.Btn_StartNewGame.Size = new System.Drawing.Size(87, 36);
            this.Btn_StartNewGame.TabIndex = 0;
            this.Btn_StartNewGame.Text = "Start Game";
            this.Btn_StartNewGame.UseVisualStyleBackColor = true;
            this.Btn_StartNewGame.Click += new System.EventHandler(this.Btn_StartNewGame_Click);
            // 
            // playMusic
            // 
            this.playMusic.Location = new System.Drawing.Point(649, 12);
            this.playMusic.Name = "playMusic";
            this.playMusic.Size = new System.Drawing.Size(75, 23);
            this.playMusic.TabIndex = 2;
            this.playMusic.Text = "Play Music";
            this.playMusic.UseVisualStyleBackColor = true;
            this.playMusic.Click += new System.EventHandler(this.PlayMusic_Click);
            // 
            // stopMusic
            // 
            this.stopMusic.Location = new System.Drawing.Point(649, 51);
            this.stopMusic.Name = "stopMusic";
            this.stopMusic.Size = new System.Drawing.Size(75, 23);
            this.stopMusic.TabIndex = 3;
            this.stopMusic.Text = "Stop Music";
            this.stopMusic.UseVisualStyleBackColor = true;
            this.stopMusic.Click += new System.EventHandler(this.StopMusic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 50F);
            this.label1.Location = new System.Drawing.Point(57, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(654, 91);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vulpter ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Stout", 50F);
            this.label2.Location = new System.Drawing.Point(44, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(667, 91);
            this.label2.TabIndex = 5;
            this.label2.Text = "Invaders";
            // 
            // FormMenuUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 563);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopMusic);
            this.Controls.Add(this.playMusic);
            this.Controls.Add(this.Btn_StartNewGame);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "FormMenuUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

       
       

        #endregion

        private System.Windows.Forms.Button Btn_StartNewGame;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button playMusic;
        private System.Windows.Forms.Button stopMusic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}