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
            this.lblActionSelect = new System.Windows.Forms.Label();
            this.cboWeapons = new System.Windows.Forms.ComboBox();
            this.cboPotions = new System.Windows.Forms.ComboBox();
            this.btnUseWeapon = new System.Windows.Forms.Button();
            this.btnUsePotion = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.rtbLocation = new System.Windows.Forms.RichTextBox();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.dgvQuest = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuest)).BeginInit();
            this.SuspendLayout();
            // 
            // HPlbl
            // 
            this.HPlbl.AutoSize = true;
            this.HPlbl.Location = new System.Drawing.Point(11, 24);
            this.HPlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HPlbl.Name = "HPlbl";
            this.HPlbl.Size = new System.Drawing.Size(52, 13);
            this.HPlbl.TabIndex = 0;
            this.HPlbl.Text = "Hit Points";
            // 
            // Goldlbl
            // 
            this.Goldlbl.AutoSize = true;
            this.Goldlbl.Location = new System.Drawing.Point(11, 51);
            this.Goldlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Goldlbl.Name = "Goldlbl";
            this.Goldlbl.Size = new System.Drawing.Size(29, 13);
            this.Goldlbl.TabIndex = 1;
            this.Goldlbl.Text = "Gold";
            // 
            // Levellbl
            // 
            this.Levellbl.AutoSize = true;
            this.Levellbl.Location = new System.Drawing.Point(11, 104);
            this.Levellbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Levellbl.Name = "Levellbl";
            this.Levellbl.Size = new System.Drawing.Size(33, 13);
            this.Levellbl.TabIndex = 3;
            this.Levellbl.Text = "Level";
            // 
            // Explbl
            // 
            this.Explbl.AutoSize = true;
            this.Explbl.Location = new System.Drawing.Point(11, 78);
            this.Explbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Explbl.Name = "Explbl";
            this.Explbl.Size = new System.Drawing.Size(60, 13);
            this.Explbl.TabIndex = 2;
            this.Explbl.Text = "Experience";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(78, 104);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLevel.MinimumSize = new System.Drawing.Size(22, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(22, 13);
            this.lblLevel.TabIndex = 8;
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(78, 78);
            this.lblExp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExp.MinimumSize = new System.Drawing.Size(22, 0);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(22, 13);
            this.lblExp.TabIndex = 7;
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(78, 51);
            this.lblGold.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGold.MinimumSize = new System.Drawing.Size(22, 0);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(22, 13);
            this.lblGold.TabIndex = 6;
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(78, 24);
            this.lblHP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHP.MinimumSize = new System.Drawing.Size(22, 0);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(22, 13);
            this.lblHP.TabIndex = 5;
            // 
            // lblActionSelect
            // 
            this.lblActionSelect.AutoSize = true;
            this.lblActionSelect.Location = new System.Drawing.Point(694, 535);
            this.lblActionSelect.Name = "lblActionSelect";
            this.lblActionSelect.Size = new System.Drawing.Size(70, 13);
            this.lblActionSelect.TabIndex = 9;
            this.lblActionSelect.Text = "Select Action";
            // 
            // cboWeapons
            // 
            this.cboWeapons.FormattingEnabled = true;
            this.cboWeapons.Location = new System.Drawing.Point(544, 574);
            this.cboWeapons.Name = "cboWeapons";
            this.cboWeapons.Size = new System.Drawing.Size(121, 21);
            this.cboWeapons.TabIndex = 10;
            // 
            // cboPotions
            // 
            this.cboPotions.FormattingEnabled = true;
            this.cboPotions.Location = new System.Drawing.Point(544, 612);
            this.cboPotions.Name = "cboPotions";
            this.cboPotions.Size = new System.Drawing.Size(121, 21);
            this.cboPotions.TabIndex = 11;
            // 
            // btnUseWeapon
            // 
            this.btnUseWeapon.Location = new System.Drawing.Point(697, 573);
            this.btnUseWeapon.Name = "btnUseWeapon";
            this.btnUseWeapon.Size = new System.Drawing.Size(75, 23);
            this.btnUseWeapon.TabIndex = 12;
            this.btnUseWeapon.Text = "Use";
            this.btnUseWeapon.UseVisualStyleBackColor = true;
            this.btnUseWeapon.Click += new System.EventHandler(this.btnUseWeapon_Click);
            // 
            // btnUsePotion
            // 
            this.btnUsePotion.Location = new System.Drawing.Point(697, 613);
            this.btnUsePotion.Name = "btnUsePotion";
            this.btnUsePotion.Size = new System.Drawing.Size(75, 23);
            this.btnUsePotion.TabIndex = 13;
            this.btnUsePotion.Text = "Use";
            this.btnUsePotion.UseVisualStyleBackColor = true;
            this.btnUsePotion.Click += new System.EventHandler(this.btnUsePotion_Click);
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(612, 411);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(75, 23);
            this.btnNorth.TabIndex = 14;
            this.btnNorth.Text = "North";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(531, 440);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(75, 23);
            this.btnWest.TabIndex = 15;
            this.btnWest.Text = "West";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(693, 440);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(75, 23);
            this.btnEast.TabIndex = 16;
            this.btnEast.Text = "East";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(612, 469);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(75, 23);
            this.btnSouth.TabIndex = 17;
            this.btnSouth.Text = "South";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // rtbLocation
            // 
            this.rtbLocation.Location = new System.Drawing.Point(413, 27);
            this.rtbLocation.Name = "rtbLocation";
            this.rtbLocation.ReadOnly = true;
            this.rtbLocation.Size = new System.Drawing.Size(368, 111);
            this.rtbLocation.TabIndex = 18;
            this.rtbLocation.Text = "";
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(413, 144);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(368, 261);
            this.rtbMessages.TabIndex = 19;
            this.rtbMessages.Text = "";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventory.Location = new System.Drawing.Point(12, 137);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.Size = new System.Drawing.Size(312, 309);
            this.dgvInventory.TabIndex = 20;
            // 
            // dgvQuest
            // 
            this.dgvQuest.AllowUserToAddRows = false;
            this.dgvQuest.AllowUserToDeleteRows = false;
            this.dgvQuest.AllowUserToResizeRows = false;
            this.dgvQuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuest.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQuest.Location = new System.Drawing.Point(12, 452);
            this.dgvQuest.MultiSelect = false;
            this.dgvQuest.Name = "dgvQuest";
            this.dgvQuest.ReadOnly = true;
            this.dgvQuest.Size = new System.Drawing.Size(312, 189);
            this.dgvQuest.TabIndex = 21;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 648);
            this.Controls.Add(this.dgvQuest);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.rtbLocation);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.btnUsePotion);
            this.Controls.Add(this.btnUseWeapon);
            this.Controls.Add(this.cboPotions);
            this.Controls.Add(this.cboWeapons);
            this.Controls.Add(this.lblActionSelect);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.Levellbl);
            this.Controls.Add(this.Explbl);
            this.Controls.Add(this.Goldlbl);
            this.Controls.Add(this.HPlbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Game";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuest)).EndInit();
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
        private System.Windows.Forms.Label lblActionSelect;
        private System.Windows.Forms.ComboBox cboWeapons;
        private System.Windows.Forms.ComboBox cboPotions;
        private System.Windows.Forms.Button btnUseWeapon;
        private System.Windows.Forms.Button btnUsePotion;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.RichTextBox rtbLocation;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridView dgvQuest;
    }
}

