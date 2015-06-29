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
            ((System.ComponentModel.ISupportInitialize)(this.playerShip)).BeginInit();
            this.SuspendLayout();
            // 
            // timerMovement
            // 
            this.timerMovement.Enabled = true;
            this.timerMovement.Interval = 40;
            this.timerMovement.Tick += new System.EventHandler(this.TimerMovementsTick);
            // 
            // shipEnemy
            // 
            this.shipEnemy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("shipEnemy.BackgroundImage")));
            this.shipEnemy.Location = new System.Drawing.Point(331, 66);
            this.shipEnemy.Name = "shipEnemy";
            this.shipEnemy.Size = new System.Drawing.Size(43, 36);
            this.shipEnemy.TabIndex = 2;
            // 
            // bulletPanel
            // 
            this.bulletPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bulletPanel.BackgroundImage")));
            this.bulletPanel.Location = new System.Drawing.Point(479, 439);
            this.bulletPanel.Name = "bulletPanel";
            this.bulletPanel.Size = new System.Drawing.Size(28, 32);
            this.bulletPanel.TabIndex = 1;
            // 
            // playerShip
            // 
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
            this.invaderTwo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("invaderTwo.BackgroundImage")));
            this.invaderTwo.Location = new System.Drawing.Point(410, 66);
            this.invaderTwo.Name = "invaderTwo";
            this.invaderTwo.Size = new System.Drawing.Size(43, 36);
            this.invaderTwo.TabIndex = 3;
            // 
            // invaderThree
            // 
            this.invaderThree.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("invaderThree.BackgroundImage")));
            this.invaderThree.Location = new System.Drawing.Point(490, 66);
            this.invaderThree.Name = "invaderThree";
            this.invaderThree.Size = new System.Drawing.Size(43, 36);
            this.invaderThree.TabIndex = 4;
            // 
            // invaderFour
            // 
            this.invaderFour.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("invaderFour.BackgroundImage")));
            this.invaderFour.Location = new System.Drawing.Point(264, 66);
            this.invaderFour.Name = "invaderFour";
            this.invaderFour.Size = new System.Drawing.Size(43, 36);
            this.invaderFour.TabIndex = 5;
            // 
            // invaderFive
            // 
            this.invaderFive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("invaderFive.BackgroundImage")));
            this.invaderFive.Location = new System.Drawing.Point(490, 136);
            this.invaderFive.Name = "invaderFive";
            this.invaderFive.Size = new System.Drawing.Size(43, 36);
            this.invaderFive.TabIndex = 6;
            // 
            // invaderSix
            // 
            this.invaderSix.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("invaderSix.BackgroundImage")));
            this.invaderSix.Location = new System.Drawing.Point(410, 136);
            this.invaderSix.Name = "invaderSix";
            this.invaderSix.Size = new System.Drawing.Size(43, 36);
            this.invaderSix.TabIndex = 7;
            // 
            // invaderSeven
            // 
            this.invaderSeven.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("invaderSeven.BackgroundImage")));
            this.invaderSeven.Location = new System.Drawing.Point(331, 136);
            this.invaderSeven.Name = "invaderSeven";
            this.invaderSeven.Size = new System.Drawing.Size(43, 36);
            this.invaderSeven.TabIndex = 8;
            // 
            // invaderEight
            // 
            this.invaderEight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("invaderEight.BackgroundImage")));
            this.invaderEight.Location = new System.Drawing.Point(264, 136);
            this.invaderEight.Name = "invaderEight";
            this.invaderEight.Size = new System.Drawing.Size(43, 36);
            this.invaderEight.TabIndex = 9;
            // 
            // InvadersAttack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 563);
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
    }
}