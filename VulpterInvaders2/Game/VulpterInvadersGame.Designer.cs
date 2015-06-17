using System.Windows.Forms;
using Game.Classes.Matrix;
namespace Game
{
    partial class VulpterInvadersGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VulpterInvadersGame));
            this.health = new System.Windows.Forms.Label();
            this.lives = new System.Windows.Forms.Label();
            this.scores = new System.Windows.Forms.Label();
            this.brick = new System.Windows.Forms.PictureBox();
            this.hero = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.brick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).BeginInit();
            this.SuspendLayout();
            // 
            // health
            // 
            this.health.AutoSize = true;
            this.health.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.health.ForeColor = System.Drawing.Color.Blue;
            this.health.Location = new System.Drawing.Point(585, 24);
            this.health.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(72, 19);
            this.health.TabIndex = 0;
            this.health.Text = "Health:";
            this.health.Click += new System.EventHandler(this.label1_Click);
            // 
            // lives
            // 
            this.lives.AutoSize = true;
            this.lives.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lives.ForeColor = System.Drawing.Color.Blue;
            this.lives.Location = new System.Drawing.Point(585, 53);
            this.lives.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lives.Name = "lives";
            this.lives.Size = new System.Drawing.Size(63, 19);
            this.lives.TabIndex = 2;
            this.lives.Text = "Lives:";
            this.lives.Click += new System.EventHandler(this.label3_Click);
            // 
            // scores
            // 
            this.scores.AutoSize = true;
            this.scores.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scores.ForeColor = System.Drawing.Color.Blue;
            this.scores.Location = new System.Drawing.Point(585, 81);
            this.scores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scores.Name = "scores";
            this.scores.Size = new System.Drawing.Size(72, 19);
            this.scores.TabIndex = 3;
            this.scores.Text = "Scores:";
            // 
            // brick
            // 
            this.brick.ErrorImage = ((System.Drawing.Image)(resources.GetObject("brick.ErrorImage")));
            this.brick.Image = ((System.Drawing.Image)(resources.GetObject("brick.Image")));
            this.brick.Location = new System.Drawing.Point(41, 24);
            this.brick.Name = "brick";
            this.brick.Size = new System.Drawing.Size(20, 20);
            this.brick.TabIndex = 7;
            this.brick.TabStop = false;
            // 
            // hero
            // 
            this.hero.ErrorImage = global::Game.Properties.Resources.HeroSingle;
            this.hero.Image = global::Game.Properties.Resources.HeroSingle;
            this.hero.InitialImage = global::Game.Properties.Resources.HeroSingle;
            this.hero.Location = new System.Drawing.Point(149, 431);
            this.hero.Name = "hero";
            this.hero.Size = new System.Drawing.Size(37, 39);
            this.hero.TabIndex = 8;
            this.hero.TabStop = false;
            // 
            // VulpterInvadersGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(736, 563);
            this.Controls.Add(this.hero);
            this.Controls.Add(this.scores);
            this.Controls.Add(this.lives);
            this.Controls.Add(this.health);
            this.Controls.Add(this.brick);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "VulpterInvadersGame";
            this.Text = "VulpterInvader.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label health;
        private System.Windows.Forms.Label lives;
        private System.Windows.Forms.Label scores;
        private System.Windows.Forms.PictureBox brick;
        private System.Windows.Forms.PictureBox hero;
    }
}

