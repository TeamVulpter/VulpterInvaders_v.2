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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvadersAttack));
            this.playerShip = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerShip)).BeginInit();
            this.SuspendLayout();
            // 
            // playerShip
            // 
            this.playerShip.ErrorImage = ((System.Drawing.Image)(resources.GetObject("playerShip.ErrorImage")));
            this.playerShip.Image = global::Game.Properties.Resources.pictureBox1_ErrorImage;
            this.playerShip.InitialImage = ((System.Drawing.Image)(resources.GetObject("playerShip.InitialImage")));
            this.playerShip.Location = new System.Drawing.Point(373, 516);
            this.playerShip.Name = "playerShip";
            this.playerShip.Size = new System.Drawing.Size(21, 35);
            this.playerShip.TabIndex = 0;
            this.playerShip.TabStop = false;
            // 
            // InvadersAttack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 563);
            this.Controls.Add(this.playerShip);
            this.Name = "InvadersAttack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvadersAttack";
            ((System.ComponentModel.ISupportInitialize)(this.playerShip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox playerShip;
    }
}