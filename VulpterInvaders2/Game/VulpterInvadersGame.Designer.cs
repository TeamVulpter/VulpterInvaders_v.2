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
            this.start = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.brick = new System.Windows.Forms.PictureBox();
            
            ((System.ComponentModel.ISupportInitialize)(this.brick)).BeginInit();
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
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.start.ForeColor = System.Drawing.Color.Blue;
            this.start.Location = new System.Drawing.Point(630, 508);
            this.start.Margin = new System.Windows.Forms.Padding(2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 32);
            this.start.TabIndex = 4;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(630, 459);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Create Hero";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // VulpterInvadersGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(736, 563);
            
            this.Controls.Add(this.button1);
            this.Controls.Add(this.start);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label health;
        private System.Windows.Forms.Label lives;
        private System.Windows.Forms.Label scores;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox brick;
    }
}

