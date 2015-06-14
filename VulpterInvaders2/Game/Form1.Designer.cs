namespace Game
{
    partial class Form1
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
            this.health = new System.Windows.Forms.Label();
            this.lives = new System.Windows.Forms.Label();
            this.scores = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // health
            // 
            this.health.AutoSize = true;
            this.health.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.health.ForeColor = System.Drawing.Color.Blue;
            this.health.Location = new System.Drawing.Point(780, 30);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(87, 23);
            this.health.TabIndex = 0;
            this.health.Text = "Health:";
            this.health.Click += new System.EventHandler(this.label1_Click);
            // 
            // lives
            // 
            this.lives.AutoSize = true;
            this.lives.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lives.ForeColor = System.Drawing.Color.Blue;
            this.lives.Location = new System.Drawing.Point(780, 65);
            this.lives.Name = "lives";
            this.lives.Size = new System.Drawing.Size(76, 23);
            this.lives.TabIndex = 2;
            this.lives.Text = "Lives:";
            this.lives.Click += new System.EventHandler(this.label3_Click);
            // 
            // scores
            // 
            this.scores.AutoSize = true;
            this.scores.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scores.ForeColor = System.Drawing.Color.Blue;
            this.scores.Location = new System.Drawing.Point(780, 100);
            this.scores.Name = "scores";
            this.scores.Size = new System.Drawing.Size(87, 23);
            this.scores.TabIndex = 3;
            this.scores.Text = "Scores:";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.start.ForeColor = System.Drawing.Color.Blue;
            this.start.Location = new System.Drawing.Point(838, 633);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(104, 34);
            this.start.TabIndex = 4;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(982, 693);
            this.Controls.Add(this.start);
            this.Controls.Add(this.scores);
            this.Controls.Add(this.lives);
            this.Controls.Add(this.health);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "VulpterInvader.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label health;
        private System.Windows.Forms.Label lives;
        private System.Windows.Forms.Label scores;
        private System.Windows.Forms.Button start;
    }
}

