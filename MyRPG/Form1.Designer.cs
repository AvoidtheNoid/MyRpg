namespace MyRPG
{
    partial class Game
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
            this.HPlbl = new System.Windows.Forms.Label();
            this.Goldlbl = new System.Windows.Forms.Label();
            this.Levellbl = new System.Windows.Forms.Label();
            this.Explbl = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HPlbl
            // 
            this.HPlbl.AutoSize = true;
            this.HPlbl.Location = new System.Drawing.Point(46, 33);
            this.HPlbl.Name = "HPlbl";
            this.HPlbl.Size = new System.Drawing.Size(68, 17);
            this.HPlbl.TabIndex = 0;
            this.HPlbl.Text = "Hit Points";
            // 
            // Goldlbl
            // 
            this.Goldlbl.AutoSize = true;
            this.Goldlbl.Location = new System.Drawing.Point(46, 60);
            this.Goldlbl.Name = "Goldlbl";
            this.Goldlbl.Size = new System.Drawing.Size(38, 17);
            this.Goldlbl.TabIndex = 1;
            this.Goldlbl.Text = "Gold";
            // 
            // Levellbl
            // 
            this.Levellbl.AutoSize = true;
            this.Levellbl.Location = new System.Drawing.Point(46, 117);
            this.Levellbl.Name = "Levellbl";
            this.Levellbl.Size = new System.Drawing.Size(42, 17);
            this.Levellbl.TabIndex = 3;
            this.Levellbl.Text = "Level";
            // 
            // Explbl
            // 
            this.Explbl.AutoSize = true;
            this.Explbl.Location = new System.Drawing.Point(46, 88);
            this.Explbl.Name = "Explbl";
            this.Explbl.Size = new System.Drawing.Size(78, 17);
            this.Explbl.TabIndex = 2;
            this.Explbl.Text = "Experience";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(135, 117);
            this.lblLevel.MinimumSize = new System.Drawing.Size(30, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(30, 17);
            this.lblLevel.TabIndex = 8;
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(135, 88);
            this.lblExp.MinimumSize = new System.Drawing.Size(30, 0);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(30, 17);
            this.lblExp.TabIndex = 7;
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(135, 60);
            this.lblGold.MinimumSize = new System.Drawing.Size(30, 0);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(30, 17);
            this.lblGold.TabIndex = 6;
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(135, 33);
            this.lblHP.MinimumSize = new System.Drawing.Size(30, 0);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(30, 17);
            this.lblHP.TabIndex = 5;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 538);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.Levellbl);
            this.Controls.Add(this.Explbl);
            this.Controls.Add(this.Goldlbl);
            this.Controls.Add(this.HPlbl);
            this.Name = "Game";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HPlbl;
        private System.Windows.Forms.Label Goldlbl;
        private System.Windows.Forms.Label Levellbl;
        private System.Windows.Forms.Label Explbl;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblHP;
    }
}

