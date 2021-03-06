﻿using System.Drawing;
using System.Drawing.Imaging;

namespace Game
{
    partial class InvadersAttack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvadersAttack));
            this.timerMovement = new System.Windows.Forms.Timer(this.components);
            this.shipEnemy = new System.Windows.Forms.Panel();
            this.bulletPanel = new System.Windows.Forms.Panel();
            this.playerShip = new System.Windows.Forms.PictureBox();
            this.invaderTwo = new System.Windows.Forms.Panel();
            this.invaderThree = new System.Windows.Forms.Panel();
            this.invaderFour = new System.Windows.Forms.Panel();
            this.invaderFive = new System.Windows.Forms.Panel();
            this.invaderSix = new System.Windows.Forms.Panel();
            this.invaderSeven = new System.Windows.Forms.Panel();
            this.invaderEight = new System.Windows.Forms.Panel();
            this.lives = new System.Windows.Forms.Label();
            this.scores = new System.Windows.Forms.Label();
            this.life_value = new System.Windows.Forms.Label();
            this.score_value = new System.Windows.Forms.Label();
            this.bulletEnemy = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.playerShip)).BeginInit();
            this.SuspendLayout();
            // 
            // timerMovement
            // 
            this.timerMovement.Enabled = true;
            this.timerMovement.Interval = 60;
            this.timerMovement.Tick += new System.EventHandler(this.TimerMovementsTick);
            // 
            // shipEnemy
            // 
            this.shipEnemy.BackColor = System.Drawing.Color.Transparent;
            this.shipEnemy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("shipEnemy.BackgroundImage")));
            this.shipEnemy.Location = new System.Drawing.Point(132, 66);
            this.shipEnemy.Name = "shipEnemy";
            this.shipEnemy.Size = new System.Drawing.Size(43, 36);
            this.shipEnemy.TabIndex = 2;
            // 
            // bulletPanel
            // 
            this.bulletPanel.BackColor = System.Drawing.Color.Transparent;
            this.bulletPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bulletPanel.BackgroundImage")));
            this.bulletPanel.Location = new System.Drawing.Point(479, 439);
            this.bulletPanel.Name = "bulletPanel";
            this.bulletPanel.Size = new System.Drawing.Size(28, 32);
            this.bulletPanel.TabIndex = 1;
            // 
            // playerShip
            // 
            this.playerShip.BackColor = System.Drawing.Color.Transparent;
            this.playerShip.ErrorImage = ((System.Drawing.Image)(resources.GetObject("playerShip.ErrorImage")));
            this.playerShip.Image = global::Game.Properties.Resources.heroShip;
            this.playerShip.InitialImage = global::Game.Properties.Resources.heroShip;
            this.playerShip.Location = new System.Drawing.Point(438, 477);
            this.playerShip.Name = "playerShip";
            this.playerShip.Size = new System.Drawing.Size(69, 84);
            this.playerShip.TabIndex = 0;
            this.playerShip.TabStop = false;
            // 
            // invaderTwo
            // 
            this.invaderTwo.BackColor = System.Drawing.Color.Transparent;
            this.invaderTwo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("invaderTwo.BackgroundImage")));
            this.invaderTwo.Location = new System.Drawing.Point(207, 66);
            this.invaderTwo.Name = "invaderTwo";
            this.invaderTwo.Size = new System.Drawing.Size(43, 36);
            this.invaderTwo.TabIndex = 3;
            // 
            // invaderThree
            // 
            this.invaderThree.BackColor = System.Drawing.Color.Transparent;
            this.invaderThree.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("invaderThree.BackgroundImage")));
            this.invaderThree.Location = new System.Drawing.Point(276, 66);
            this.invaderThree.Name = "invaderThree";
            this.invaderThree.Size = new System.Drawing.Size(43, 36);
            this.invaderThree.TabIndex = 4;
            // 
            // invaderFour
            // 
            this.invaderFour.BackColor = System.Drawing.Color.Transparent;
            this.invaderFour.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("invaderFour.BackgroundImage")));
            this.invaderFour.Location = new System.Drawing.Point(74, 63);
            this.invaderFour.Name = "invaderFour";
            this.invaderFour.Size = new System.Drawing.Size(43, 36);
            this.invaderFour.TabIndex = 5;
            // 
            // invaderFive
            // 
            this.invaderFive.BackColor = System.Drawing.Color.Transparent;
            this.invaderFive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("invaderFive.BackgroundImage")));
            this.invaderFive.Location = new System.Drawing.Point(12, 63);
            this.invaderFive.Name = "invaderFive";
            this.invaderFive.Size = new System.Drawing.Size(43, 36);
            this.invaderFive.TabIndex = 6;
            // 
            // invaderSix
            // 
            this.invaderSix.BackColor = System.Drawing.Color.Transparent;
            this.invaderSix.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("invaderSix.BackgroundImage")));
            this.invaderSix.Location = new System.Drawing.Point(479, 66);
            this.invaderSix.Name = "invaderSix";
            this.invaderSix.Size = new System.Drawing.Size(43, 36);
            this.invaderSix.TabIndex = 7;
            // 
            // invaderSeven
            // 
            this.invaderSeven.BackColor = System.Drawing.Color.Transparent;
            this.invaderSeven.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("invaderSeven.BackgroundImage")));
            this.invaderSeven.Location = new System.Drawing.Point(410, 66);
            this.invaderSeven.Name = "invaderSeven";
            this.invaderSeven.Size = new System.Drawing.Size(43, 36);
            this.invaderSeven.TabIndex = 8;
            // 
            // invaderEight
            // 
            this.invaderEight.BackColor = System.Drawing.Color.Transparent;
            this.invaderEight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("invaderEight.BackgroundImage")));
            this.invaderEight.Location = new System.Drawing.Point(341, 66);
            this.invaderEight.Name = "invaderEight";
            this.invaderEight.Size = new System.Drawing.Size(43, 36);
            this.invaderEight.TabIndex = 9;
            // 
            // lives
            // 
            this.lives.AutoSize = true;
            this.lives.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lives.ForeColor = System.Drawing.Color.Yellow;
            this.lives.Location = new System.Drawing.Point(560, 63);
            this.lives.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lives.Name = "lives";
            this.lives.Size = new System.Drawing.Size(63, 19);
            this.lives.TabIndex = 35;
            this.lives.Text = "Lives:";
            // 
            // scores
            // 
            this.scores.AutoSize = true;
            this.scores.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scores.ForeColor = System.Drawing.Color.Yellow;
            this.scores.Location = new System.Drawing.Point(560, 108);
            this.scores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scores.Name = "scores";
            this.scores.Size = new System.Drawing.Size(72, 19);
            this.scores.TabIndex = 36;
            this.scores.Text = "Scores:";
            // 
            // life_value
            // 
            this.life_value.AutoSize = true;
            this.life_value.BackColor = System.Drawing.Color.Transparent;
            this.life_value.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.life_value.ForeColor = System.Drawing.Color.Red;
            this.life_value.Location = new System.Drawing.Point(636, 66);
            this.life_value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.life_value.Name = "life_value";
            this.life_value.Size = new System.Drawing.Size(17, 19);
            this.life_value.TabIndex = 37;
            this.life_value.Text = "3";
            this.life_value.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // score_value
            // 
            this.score_value.AutoSize = true;
            this.score_value.BackColor = System.Drawing.Color.Transparent;
            this.score_value.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score_value.ForeColor = System.Drawing.Color.Red;
            this.score_value.Location = new System.Drawing.Point(636, 108);
            this.score_value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.score_value.Name = "score_value";
            this.score_value.Size = new System.Drawing.Size(17, 19);
            this.score_value.TabIndex = 38;
            this.score_value.Text = "0";
            this.score_value.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bulletEnemy
            // 
            this.bulletEnemy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bulletEnemy.BackgroundImage")));
            this.bulletEnemy.Location = new System.Drawing.Point(507, 193);
            this.bulletEnemy.Name = "bulletEnemy";
            this.bulletEnemy.Size = new System.Drawing.Size(19, 30);
            this.bulletEnemy.TabIndex = 39;
            // 
            // InvadersAttack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(736, 563);
            this.Controls.Add(this.bulletEnemy);
            this.Controls.Add(this.score_value);
            this.Controls.Add(this.life_value);
            this.Controls.Add(this.scores);
            this.Controls.Add(this.lives);
            this.Controls.Add(this.invaderEight);
            this.Controls.Add(this.invaderSeven);
            this.Controls.Add(this.invaderSix);
            this.Controls.Add(this.invaderFive);
            this.Controls.Add(this.invaderFour);
            this.Controls.Add(this.invaderThree);
            this.Controls.Add(this.invaderTwo);
            this.Controls.Add(this.shipEnemy);
            this.Controls.Add(this.bulletPanel);
            this.Controls.Add(this.playerShip);
            this.Name = "InvadersAttack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvadersAttack";
            ((System.ComponentModel.ISupportInitialize)(this.playerShip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.PictureBox playerShip;
        private System.Windows.Forms.Panel bulletPanel;
        private System.Windows.Forms.Panel shipEnemy;
        private System.Windows.Forms.Timer timerMovement;
        private System.Windows.Forms.Panel invaderTwo;
        private System.Windows.Forms.Panel invaderThree;
        private System.Windows.Forms.Panel invaderFour;
        private System.Windows.Forms.Panel invaderFive;
        private System.Windows.Forms.Panel invaderSix;
        private System.Windows.Forms.Panel invaderSeven;
        private System.Windows.Forms.Panel invaderEight;
        private System.Windows.Forms.Label lives;
        private System.Windows.Forms.Label scores;
        private System.Windows.Forms.Label life_value;
        private System.Windows.Forms.Label score_value;
        private System.Windows.Forms.Panel bulletEnemy;
    }
}