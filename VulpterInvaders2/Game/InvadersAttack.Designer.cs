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
            this.playerShip = new System.Windows.Forms.PictureBox();
            this.bulletPanel = new System.Windows.Forms.Panel();
            this.shipEnemy = new System.Windows.Forms.Panel();
            this.timerMovement = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.playerShip)).BeginInit();
            this.SuspendLayout();
            // 
            // playerShip
            // 
            this.playerShip.ErrorImage = ((System.Drawing.Image)(resources.GetObject("playerShip.ErrorImage")));
            this.playerShip.Image = global::Game.Properties.Resources.pictureBox1_ErrorImage;
            this.playerShip.InitialImage = ((System.Drawing.Image)(resources.GetObject("playerShip.InitialImage")));
            this.playerShip.Location = new System.Drawing.Point(386, 516);
            this.playerShip.Name = "playerShip";
            this.playerShip.Size = new System.Drawing.Size(19, 35);
            this.playerShip.TabIndex = 0;
            this.playerShip.TabStop = false;
            // 
            // bulletPanel
            // 
            this.bulletPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bulletPanel.BackgroundImage")));
            this.bulletPanel.Location = new System.Drawing.Point(377, 463);
            this.bulletPanel.Name = "bulletPanel";
            this.bulletPanel.Size = new System.Drawing.Size(28, 32);
            this.bulletPanel.TabIndex = 1;
            // 
            // shipEnemy
            // 
            this.shipEnemy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("shipEnemy.BackgroundImage")));
            this.shipEnemy.Location = new System.Drawing.Point(331, 66);
            this.shipEnemy.Name = "shipEnemy";
            this.shipEnemy.Size = new System.Drawing.Size(43, 36);
            this.shipEnemy.TabIndex = 2;
            // 
            // timerMovement
            // 
            this.timerMovement.Enabled = true;
            this.timerMovement.Interval = 40;
            this.timerMovement.Tick += new System.EventHandler(this.TimerMovementsTick);
            // 
            // InvadersAttack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 563);
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
    }
}