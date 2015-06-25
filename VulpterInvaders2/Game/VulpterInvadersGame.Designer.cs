﻿using System.Windows.Forms;
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VulpterInvadersGame));
            this.health = new System.Windows.Forms.Label();
            this.lives = new System.Windows.Forms.Label();
            this.scores = new System.Windows.Forms.Label();
            this.ObsticleTimer = new System.Windows.Forms.Timer(this.components);
            this.Obsticle = new System.Windows.Forms.PictureBox();
            this.brick19 = new System.Windows.Forms.PictureBox();
            this.brick18 = new System.Windows.Forms.PictureBox();
            this.brick17 = new System.Windows.Forms.PictureBox();
            this.brick16 = new System.Windows.Forms.PictureBox();
            this.brick15 = new System.Windows.Forms.PictureBox();
            this.brick14 = new System.Windows.Forms.PictureBox();
            this.brick13 = new System.Windows.Forms.PictureBox();
            this.brick12 = new System.Windows.Forms.PictureBox();
            this.brick11 = new System.Windows.Forms.PictureBox();
            this.brick10 = new System.Windows.Forms.PictureBox();
            this.brick9 = new System.Windows.Forms.PictureBox();
            this.brick8 = new System.Windows.Forms.PictureBox();
            this.brick7 = new System.Windows.Forms.PictureBox();
            this.brick6 = new System.Windows.Forms.PictureBox();
            this.brick5 = new System.Windows.Forms.PictureBox();
            this.brick4 = new System.Windows.Forms.PictureBox();
            this.brick3 = new System.Windows.Forms.PictureBox();
            this.brick2 = new System.Windows.Forms.PictureBox();
            this.brick1 = new System.Windows.Forms.PictureBox();
            this.hero = new System.Windows.Forms.PictureBox();
            this.brick = new System.Windows.Forms.PictureBox();
            this.Obsticle5 = new System.Windows.Forms.PictureBox();
            this.Obsticle4 = new System.Windows.Forms.PictureBox();
            this.Obsticle3 = new System.Windows.Forms.PictureBox();
            this.Obsticle2 = new System.Windows.Forms.PictureBox();
            this.health_value = new System.Windows.Forms.Label();
            this.life_value = new System.Windows.Forms.Label();
            this.score_value = new System.Windows.Forms.Label();
            this.door = new System.Windows.Forms.PictureBox();
            this.item1 = new System.Windows.Forms.PictureBox();
            this.item2 = new System.Windows.Forms.PictureBox();
            this.item3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Obsticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obsticle5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obsticle4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obsticle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obsticle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item3)).BeginInit();
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
            // ObsticleTimer
            // 
            this.ObsticleTimer.Enabled = true;
            this.ObsticleTimer.Interval = 30;
            this.ObsticleTimer.Tick += new System.EventHandler(this.ObsticleTimer_Tick);
            // 
            // Obsticle
            // 
            this.Obsticle.BackgroundImage = global::Game.Properties.Resources.Bricks;
            this.Obsticle.ErrorImage = global::Game.Properties.Resources.Bricks1;
            this.Obsticle.Location = new System.Drawing.Point(67, 401);
            this.Obsticle.Name = "Obsticle";
            this.Obsticle.Size = new System.Drawing.Size(47, 23);
            this.Obsticle.TabIndex = 28;
            this.Obsticle.TabStop = false;
            this.Obsticle.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // brick19
            // 
            this.brick19.ErrorImage = ((System.Drawing.Image)(resources.GetObject("brick19.ErrorImage")));
            this.brick19.Image = ((System.Drawing.Image)(resources.GetObject("brick19.Image")));
            this.brick19.Location = new System.Drawing.Point(422, 24);
            this.brick19.Name = "brick19";
            this.brick19.Size = new System.Drawing.Size(101, 20);
            this.brick19.TabIndex = 27;
            this.brick19.TabStop = false;
            // 
            // brick18
            // 
            this.brick18.ErrorImage = ((System.Drawing.Image)(resources.GetObject("brick18.ErrorImage")));
            this.brick18.Image = ((System.Drawing.Image)(resources.GetObject("brick18.Image")));
            this.brick18.Location = new System.Drawing.Point(329, 24);
            this.brick18.Name = "brick18";
            this.brick18.Size = new System.Drawing.Size(101, 20);
            this.brick18.TabIndex = 26;
            this.brick18.TabStop = false;
            // 
            // brick17
            // 
            this.brick17.ErrorImage = ((System.Drawing.Image)(resources.GetObject("brick17.ErrorImage")));
            this.brick17.Image = ((System.Drawing.Image)(resources.GetObject("brick17.Image")));
            this.brick17.Location = new System.Drawing.Point(235, 24);
            this.brick17.Name = "brick17";
            this.brick17.Size = new System.Drawing.Size(101, 20);
            this.brick17.TabIndex = 25;
            this.brick17.TabStop = false;
            // 
            // brick16
            // 
            this.brick16.ErrorImage = ((System.Drawing.Image)(resources.GetObject("brick16.ErrorImage")));
            this.brick16.Image = ((System.Drawing.Image)(resources.GetObject("brick16.Image")));
            this.brick16.Location = new System.Drawing.Point(139, 24);
            this.brick16.Name = "brick16";
            this.brick16.Size = new System.Drawing.Size(101, 20);
            this.brick16.TabIndex = 24;
            this.brick16.TabStop = false;
            // 
            // brick15
            // 
            this.brick15.ErrorImage = ((System.Drawing.Image)(resources.GetObject("brick15.ErrorImage")));
            this.brick15.Image = ((System.Drawing.Image)(resources.GetObject("brick15.Image")));
            this.brick15.Location = new System.Drawing.Point(503, 38);
            this.brick15.Name = "brick15";
            this.brick15.Size = new System.Drawing.Size(20, 96);
            this.brick15.TabIndex = 23;
            this.brick15.TabStop = false;
            // 
            // brick14
            // 
            this.brick14.ErrorImage = ((System.Drawing.Image)(resources.GetObject("brick14.ErrorImage")));
            this.brick14.Image = ((System.Drawing.Image)(resources.GetObject("brick14.Image")));
            this.brick14.Location = new System.Drawing.Point(503, 126);
            this.brick14.Name = "brick14";
            this.brick14.Size = new System.Drawing.Size(20, 96);
            this.brick14.TabIndex = 22;
            this.brick14.TabStop = false;
            // 
            // brick13
            // 
            this.brick13.ErrorImage = ((System.Drawing.Image)(resources.GetObject("brick13.ErrorImage")));
            this.brick13.Image = ((System.Drawing.Image)(resources.GetObject("brick13.Image")));
            this.brick13.Location = new System.Drawing.Point(503, 217);
            this.brick13.Name = "brick13";
            this.brick13.Size = new System.Drawing.Size(20, 96);
            this.brick13.TabIndex = 21;
            this.brick13.TabStop = false;
            // 
            // brick12
            // 
            this.brick12.ErrorImage = ((System.Drawing.Image)(resources.GetObject("brick12.ErrorImage")));
            this.brick12.Image = ((System.Drawing.Image)(resources.GetObject("brick12.Image")));
            this.brick12.Location = new System.Drawing.Point(503, 310);
            this.brick12.Name = "brick12";
            this.brick12.Size = new System.Drawing.Size(20, 96);
            this.brick12.TabIndex = 20;
            this.brick12.TabStop = false;
            // 
            // brick11
            // 
            this.brick11.ErrorImage = ((System.Drawing.Image)(resources.GetObject("brick11.ErrorImage")));
            this.brick11.Image = ((System.Drawing.Image)(resources.GetObject("brick11.Image")));
            this.brick11.Location = new System.Drawing.Point(503, 401);
            this.brick11.Name = "brick11";
            this.brick11.Size = new System.Drawing.Size(20, 96);
            this.brick11.TabIndex = 19;
            this.brick11.TabStop = false;
            // 
            // brick10
            // 
            this.brick10.ErrorImage = ((System.Drawing.Image)(resources.GetObject("brick10.ErrorImage")));
            this.brick10.Image = ((System.Drawing.Image)(resources.GetObject("brick10.Image")));
            this.brick10.Location = new System.Drawing.Point(422, 492);
            this.brick10.Name = "brick10";
            this.brick10.Size = new System.Drawing.Size(101, 20);
            this.brick10.TabIndex = 18;
            this.brick10.TabStop = false;
            // 
            // brick9
            // 
            this.brick9.ErrorImage = ((System.Drawing.Image)(resources.GetObject("brick9.ErrorImage")));
            this.brick9.Image = ((System.Drawing.Image)(resources.GetObject("brick9.Image")));
            this.brick9.Location = new System.Drawing.Point(329, 492);
            this.brick9.Name = "brick9";
            this.brick9.Size = new System.Drawing.Size(101, 20);
            this.brick9.TabIndex = 17;
            this.brick9.TabStop = false;
            // 
            // brick8
            // 
            this.brick8.ErrorImage = ((System.Drawing.Image)(resources.GetObject("brick8.ErrorImage")));
            this.brick8.Image = ((System.Drawing.Image)(resources.GetObject("brick8.Image")));
            this.brick8.Location = new System.Drawing.Point(235, 492);
            this.brick8.Name = "brick8";
            this.brick8.Size = new System.Drawing.Size(101, 20);
            this.brick8.TabIndex = 16;
            this.brick8.TabStop = false;
            // 
            // brick7
            // 
            this.brick7.ErrorImage = ((System.Drawing.Image)(resources.GetObject("brick7.ErrorImage")));
            this.brick7.Image = ((System.Drawing.Image)(resources.GetObject("brick7.Image")));
            this.brick7.Location = new System.Drawing.Point(139, 492);
            this.brick7.Name = "brick7";
            this.brick7.Size = new System.Drawing.Size(101, 20);
            this.brick7.TabIndex = 15;
            this.brick7.TabStop = false;
            // 
            // brick6
            // 
            this.brick6.ErrorImage = ((System.Drawing.Image)(resources.GetObject("brick6.ErrorImage")));
            this.brick6.Image = ((System.Drawing.Image)(resources.GetObject("brick6.Image")));
            this.brick6.Location = new System.Drawing.Point(41, 492);
            this.brick6.Name = "brick6";
            this.brick6.Size = new System.Drawing.Size(101, 20);
            this.brick6.TabIndex = 14;
            this.brick6.TabStop = false;
            // 
            // brick5
            // 
            this.brick5.ErrorImage = ((System.Drawing.Image)(resources.GetObject("brick5.ErrorImage")));
            this.brick5.Image = ((System.Drawing.Image)(resources.GetObject("brick5.Image")));
            this.brick5.Location = new System.Drawing.Point(41, 401);
            this.brick5.Name = "brick5";
            this.brick5.Size = new System.Drawing.Size(20, 96);
            this.brick5.TabIndex = 13;
            this.brick5.TabStop = false;
            // 
            // brick4
            // 
            this.brick4.ErrorImage = ((System.Drawing.Image)(resources.GetObject("brick4.ErrorImage")));
            this.brick4.Image = ((System.Drawing.Image)(resources.GetObject("brick4.Image")));
            this.brick4.Location = new System.Drawing.Point(41, 310);
            this.brick4.Name = "brick4";
            this.brick4.Size = new System.Drawing.Size(20, 96);
            this.brick4.TabIndex = 12;
            this.brick4.TabStop = false;
            // 
            // brick3
            // 
            this.brick3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("brick3.ErrorImage")));
            this.brick3.Image = ((System.Drawing.Image)(resources.GetObject("brick3.Image")));
            this.brick3.Location = new System.Drawing.Point(41, 217);
            this.brick3.Name = "brick3";
            this.brick3.Size = new System.Drawing.Size(20, 96);
            this.brick3.TabIndex = 11;
            this.brick3.TabStop = false;
            // 
            // brick2
            // 
            this.brick2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("brick2.ErrorImage")));
            this.brick2.Image = ((System.Drawing.Image)(resources.GetObject("brick2.Image")));
            this.brick2.Location = new System.Drawing.Point(41, 126);
            this.brick2.Name = "brick2";
            this.brick2.Size = new System.Drawing.Size(20, 96);
            this.brick2.TabIndex = 10;
            this.brick2.TabStop = false;
            // 
            // brick1
            // 
            this.brick1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("brick1.ErrorImage")));
            this.brick1.Image = ((System.Drawing.Image)(resources.GetObject("brick1.Image")));
            this.brick1.Location = new System.Drawing.Point(41, 38);
            this.brick1.Name = "brick1";
            this.brick1.Size = new System.Drawing.Size(20, 96);
            this.brick1.TabIndex = 9;
            this.brick1.TabStop = false;
            // 
            // hero
            // 
            this.hero.ErrorImage = ((System.Drawing.Image)(resources.GetObject("hero.ErrorImage")));
            this.hero.Image = ((System.Drawing.Image)(resources.GetObject("hero.Image")));
            this.hero.InitialImage = ((System.Drawing.Image)(resources.GetObject("hero.InitialImage")));
            this.hero.Location = new System.Drawing.Point(266, 439);
            this.hero.Name = "hero";
            this.hero.Size = new System.Drawing.Size(38, 40);
            this.hero.TabIndex = 8;
            this.hero.TabStop = false;
            this.hero.Click += new System.EventHandler(this.hero_Click);
            // 
            // brick
            // 
            this.brick.ErrorImage = ((System.Drawing.Image)(resources.GetObject("brick.ErrorImage")));
            this.brick.Image = ((System.Drawing.Image)(resources.GetObject("brick.Image")));
            this.brick.Location = new System.Drawing.Point(41, 24);
            this.brick.Name = "brick";
            this.brick.Size = new System.Drawing.Size(101, 20);
            this.brick.TabIndex = 7;
            this.brick.TabStop = false;
            // 
            // Obsticle5
            // 
            this.Obsticle5.BackgroundImage = global::Game.Properties.Resources.Bricks;
            this.Obsticle5.ErrorImage = global::Game.Properties.Resources.Bricks1;
            this.Obsticle5.Location = new System.Drawing.Point(114, 53);
            this.Obsticle5.Name = "Obsticle5";
            this.Obsticle5.Size = new System.Drawing.Size(47, 23);
            this.Obsticle5.TabIndex = 29;
            this.Obsticle5.TabStop = false;
            // 
            // Obsticle4
            // 
            this.Obsticle4.BackgroundImage = global::Game.Properties.Resources.Bricks;
            this.Obsticle4.ErrorImage = global::Game.Properties.Resources.Bricks1;
            this.Obsticle4.Location = new System.Drawing.Point(67, 153);
            this.Obsticle4.Name = "Obsticle4";
            this.Obsticle4.Size = new System.Drawing.Size(47, 23);
            this.Obsticle4.TabIndex = 30;
            this.Obsticle4.TabStop = false;
            // 
            // Obsticle3
            // 
            this.Obsticle3.BackgroundImage = global::Game.Properties.Resources.Bricks;
            this.Obsticle3.ErrorImage = global::Game.Properties.Resources.Bricks1;
            this.Obsticle3.Location = new System.Drawing.Point(67, 243);
            this.Obsticle3.Name = "Obsticle3";
            this.Obsticle3.Size = new System.Drawing.Size(47, 23);
            this.Obsticle3.TabIndex = 31;
            this.Obsticle3.TabStop = false;
            this.Obsticle3.Click += new System.EventHandler(this.Obsticle3_Click);
            // 
            // Obsticle2
            // 
            this.Obsticle2.BackgroundImage = global::Game.Properties.Resources.Bricks;
            this.Obsticle2.ErrorImage = global::Game.Properties.Resources.Bricks1;
            this.Obsticle2.Location = new System.Drawing.Point(450, 339);
            this.Obsticle2.Name = "Obsticle2";
            this.Obsticle2.Size = new System.Drawing.Size(47, 23);
            this.Obsticle2.TabIndex = 32;
            this.Obsticle2.TabStop = false;
            // 
            // health_value
            // 
            this.health_value.AutoSize = true;
            this.health_value.BackColor = System.Drawing.Color.Transparent;
            this.health_value.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.health_value.ForeColor = System.Drawing.Color.Red;
            this.health_value.Location = new System.Drawing.Point(652, 22);
            this.health_value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.health_value.Name = "health_value";
            this.health_value.Size = new System.Drawing.Size(33, 19);
            this.health_value.TabIndex = 33;
            this.health_value.Text = "150";
            this.health_value.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // life_value
            // 
            this.life_value.AutoSize = true;
            this.life_value.BackColor = System.Drawing.Color.Transparent;
            this.life_value.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.life_value.ForeColor = System.Drawing.Color.Red;
            this.life_value.Location = new System.Drawing.Point(652, 50);
            this.life_value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.life_value.Name = "life_value";
            this.life_value.Size = new System.Drawing.Size(17, 19);
            this.life_value.TabIndex = 34;
            this.life_value.Text = "3";
            this.life_value.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // score_value
            // 
            this.score_value.AutoSize = true;
            this.score_value.BackColor = System.Drawing.Color.Transparent;
            this.score_value.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score_value.ForeColor = System.Drawing.Color.Red;
            this.score_value.Location = new System.Drawing.Point(652, 80);
            this.score_value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.score_value.Name = "score_value";
            this.score_value.Size = new System.Drawing.Size(17, 19);
            this.score_value.TabIndex = 35;
            this.score_value.Text = "0";
            this.score_value.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // door
            // 
            this.door.BackColor = System.Drawing.Color.Transparent;
            this.door.Image = ((System.Drawing.Image)(resources.GetObject("door.Image")));
            this.door.Location = new System.Drawing.Point(484, 48);
            this.door.Margin = new System.Windows.Forms.Padding(0);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(16, 36);
            this.door.TabIndex = 36;
            this.door.TabStop = false;
            // 
            // item1
            // 
            this.item1.BackColor = System.Drawing.Color.Transparent;
            this.item1.Image = ((System.Drawing.Image)(resources.GetObject("item1.Image")));
            this.item1.Location = new System.Drawing.Point(450, 192);
            this.item1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(22, 18);
            this.item1.TabIndex = 37;
            this.item1.TabStop = false;
            // 
            // item2
            // 
            this.item2.BackColor = System.Drawing.Color.Transparent;
            this.item2.Image = ((System.Drawing.Image)(resources.GetObject("item2.Image")));
            this.item2.Location = new System.Drawing.Point(385, 192);
            this.item2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.item2.Name = "item2";
            this.item2.Size = new System.Drawing.Size(22, 18);
            this.item2.TabIndex = 38;
            this.item2.TabStop = false;
            // 
            // item3
            // 
            this.item3.BackColor = System.Drawing.Color.Transparent;
            this.item3.Image = ((System.Drawing.Image)(resources.GetObject("item3.Image")));
            this.item3.Location = new System.Drawing.Point(322, 192);
            this.item3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.item3.Name = "item3";
            this.item3.Size = new System.Drawing.Size(22, 18);
            this.item3.TabIndex = 39;
            this.item3.TabStop = false;
            // 
            // VulpterInvadersGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(736, 563);
            this.Controls.Add(this.item3);
            this.Controls.Add(this.item2);
            this.Controls.Add(this.item1);
            this.Controls.Add(this.door);
            this.Controls.Add(this.score_value);
            this.Controls.Add(this.life_value);
            this.Controls.Add(this.health_value);
            this.Controls.Add(this.Obsticle2);
            this.Controls.Add(this.Obsticle3);
            this.Controls.Add(this.Obsticle4);
            this.Controls.Add(this.Obsticle5);
            this.Controls.Add(this.Obsticle);
            this.Controls.Add(this.brick19);
            this.Controls.Add(this.brick18);
            this.Controls.Add(this.brick17);
            this.Controls.Add(this.brick16);
            this.Controls.Add(this.brick15);
            this.Controls.Add(this.brick14);
            this.Controls.Add(this.brick13);
            this.Controls.Add(this.brick12);
            this.Controls.Add(this.brick11);
            this.Controls.Add(this.brick10);
            this.Controls.Add(this.brick9);
            this.Controls.Add(this.brick8);
            this.Controls.Add(this.brick7);
            this.Controls.Add(this.brick6);
            this.Controls.Add(this.brick5);
            this.Controls.Add(this.brick4);
            this.Controls.Add(this.brick3);
            this.Controls.Add(this.brick2);
            this.Controls.Add(this.brick1);
            this.Controls.Add(this.hero);
            this.Controls.Add(this.scores);
            this.Controls.Add(this.lives);
            this.Controls.Add(this.health);
            this.Controls.Add(this.brick);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "VulpterInvadersGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VulpterInvader.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Obsticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obsticle5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obsticle4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obsticle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obsticle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label health;
        private System.Windows.Forms.Label lives;
        private System.Windows.Forms.Label scores;
        private System.Windows.Forms.PictureBox brick;
        private System.Windows.Forms.PictureBox hero;
        private PictureBox brick1;
        private PictureBox brick2;
        private PictureBox brick3;
        private PictureBox brick4;
        private PictureBox brick5;
        private PictureBox brick6;
        private PictureBox brick7;
        private PictureBox brick8;
        private PictureBox brick9;
        private PictureBox brick10;
        private PictureBox brick11;
        private PictureBox brick12;
        private PictureBox brick13;
        private PictureBox brick14;
        private PictureBox brick15;
        private PictureBox brick16;
        private PictureBox brick17;
        private PictureBox brick18;
        private PictureBox brick19;
        private Timer ObsticleTimer;
        private PictureBox Obsticle;
        private PictureBox Obsticle5;
        private PictureBox Obsticle4;
        private PictureBox Obsticle3;
        private PictureBox Obsticle2;
        private Label health_value;
        private Label life_value;
        private Label score_value;
        private PictureBox door;
        private PictureBox item1;
        private PictureBox item2;
        private PictureBox item3;
    }
}

