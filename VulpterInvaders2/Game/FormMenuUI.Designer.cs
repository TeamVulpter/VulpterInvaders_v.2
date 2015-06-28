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
            // FormMenuUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 563);
            this.Controls.Add(this.Btn_StartNewGame);
            this.Name = "FormMenuUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_StartNewGame;
        private System.Windows.Forms.Timer timer1;
    }
}