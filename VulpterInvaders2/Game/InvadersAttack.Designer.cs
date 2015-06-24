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
            this.bulletPanel.Location = new System.Drawing.Point(457, 439);
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