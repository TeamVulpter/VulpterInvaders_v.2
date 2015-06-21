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
            this.Btn_NewPlayer = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Btn_Options = new System.Windows.Forms.Button();
            this.hero = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_StartNewGame
            // 
            this.Btn_StartNewGame.Location = new System.Drawing.Point(50, 200);
            this.Btn_StartNewGame.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_StartNewGame.Name = "Btn_StartNewGame";
            this.Btn_StartNewGame.Size = new System.Drawing.Size(116, 44);
            this.Btn_StartNewGame.TabIndex = 0;
            this.Btn_StartNewGame.Text = "Start Game";
            this.Btn_StartNewGame.UseVisualStyleBackColor = true;
            this.Btn_StartNewGame.Click += new System.EventHandler(this.Btn_StartNewGame_Click);
            // 
            // Btn_NewPlayer
            // 
            this.Btn_NewPlayer.Location = new System.Drawing.Point(250, 200);
            this.Btn_NewPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_NewPlayer.Name = "Btn_NewPlayer";
            this.Btn_NewPlayer.Size = new System.Drawing.Size(116, 44);
            this.Btn_NewPlayer.TabIndex = 1;
            this.Btn_NewPlayer.Text = "Create Player";
            this.Btn_NewPlayer.UseVisualStyleBackColor = true;
            this.Btn_NewPlayer.Click += new System.EventHandler(this.Btn_NewPlayer_Click);
            // 
            // Btn_Options
            // 
            this.Btn_Options.Location = new System.Drawing.Point(450, 200);
            this.Btn_Options.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Options.Name = "Btn_Options";
            this.Btn_Options.Size = new System.Drawing.Size(116, 44);
            this.Btn_Options.TabIndex = 2;
            this.Btn_Options.Text = "button1";
            this.Btn_Options.UseVisualStyleBackColor = true;
            // 
            // hero
            // 
            this.hero.ErrorImage = global::Game.Properties.Resources.HeroSingle;
            this.hero.Image = global::Game.Properties.Resources.HeroSingle;
            this.hero.InitialImage = global::Game.Properties.Resources.HeroSingle;
            this.hero.Location = new System.Drawing.Point(290, 140);
            this.hero.Margin = new System.Windows.Forms.Padding(4);
            this.hero.Name = "hero";
            this.hero.Size = new System.Drawing.Size(40, 40);
            this.hero.TabIndex = 9;
            this.hero.TabStop = false;
            // 
            // FormMenuUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 693);
            this.Controls.Add(this.hero);
            this.Controls.Add(this.Btn_Options);
            this.Controls.Add(this.Btn_NewPlayer);
            this.Controls.Add(this.Btn_StartNewGame);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenuUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuUI";
            this.Load += new System.EventHandler(this.FormMenuUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_StartNewGame;
        private System.Windows.Forms.Button Btn_NewPlayer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Btn_Options;
        private System.Windows.Forms.PictureBox hero;
    }
}