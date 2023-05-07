using System;

namespace TrainerShadowFlear
{
    partial class Trainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trainer));
            this.labelHp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelMana = new System.Windows.Forms.Label();
            this.labelGold = new System.Windows.Forms.Label();
            this.labelExpCharacter = new System.Windows.Forms.Label();
            this.labelFireBall = new System.Windows.Forms.Label();
            this.labelMine = new System.Windows.Forms.Label();
            this.BoxHp = new System.Windows.Forms.CheckBox();
            this.CBoxMana = new System.Windows.Forms.CheckBox();
            this.CBoxMine = new System.Windows.Forms.CheckBox();
            this.CBoxExpCharacter = new System.Windows.Forms.CheckBox();
            this.CBoxExpFireBall = new System.Windows.Forms.CheckBox();
            this.labelStatusGame = new System.Windows.Forms.Label();
            this.BtnGold = new System.Windows.Forms.Button();
            this.txtGold = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.CbPower = new System.Windows.Forms.CheckBox();
            this.labelPower = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHp
            // 
            this.labelHp.AutoSize = true;
            this.labelHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHp.Location = new System.Drawing.Point(28, 325);
            this.labelHp.Name = "labelHp";
            this.labelHp.Size = new System.Drawing.Size(29, 17);
            this.labelHp.TabIndex = 0;
            this.labelHp.Text = "HP";
            this.labelHp.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 167);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelMana
            // 
            this.labelMana.AutoSize = true;
            this.labelMana.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMana.Location = new System.Drawing.Point(28, 356);
            this.labelMana.Name = "labelMana";
            this.labelMana.Size = new System.Drawing.Size(47, 17);
            this.labelMana.TabIndex = 4;
            this.labelMana.Text = "Mana";
            // 
            // labelGold
            // 
            this.labelGold.AutoSize = true;
            this.labelGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGold.Location = new System.Drawing.Point(28, 195);
            this.labelGold.Name = "labelGold";
            this.labelGold.Size = new System.Drawing.Size(42, 17);
            this.labelGold.TabIndex = 5;
            this.labelGold.Text = "Gold";
            // 
            // labelExpCharacter
            // 
            this.labelExpCharacter.AutoSize = true;
            this.labelExpCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpCharacter.Location = new System.Drawing.Point(28, 260);
            this.labelExpCharacter.Name = "labelExpCharacter";
            this.labelExpCharacter.Size = new System.Drawing.Size(110, 17);
            this.labelExpCharacter.TabIndex = 6;
            this.labelExpCharacter.Text = "Exp Character";
            // 
            // labelFireBall
            // 
            this.labelFireBall.AutoSize = true;
            this.labelFireBall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFireBall.Location = new System.Drawing.Point(28, 297);
            this.labelFireBall.Name = "labelFireBall";
            this.labelFireBall.Size = new System.Drawing.Size(94, 17);
            this.labelFireBall.TabIndex = 7;
            this.labelFireBall.Text = "Exp FireBall";
            // 
            // labelMine
            // 
            this.labelMine.AutoSize = true;
            this.labelMine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMine.Location = new System.Drawing.Point(28, 225);
            this.labelMine.Name = "labelMine";
            this.labelMine.Size = new System.Drawing.Size(42, 17);
            this.labelMine.TabIndex = 8;
            this.labelMine.Text = "Mine";
            // 
            // BoxHp
            // 
            this.BoxHp.AutoSize = true;
            this.BoxHp.Location = new System.Drawing.Point(156, 326);
            this.BoxHp.Name = "BoxHp";
            this.BoxHp.Size = new System.Drawing.Size(15, 14);
            this.BoxHp.TabIndex = 9;
            this.BoxHp.UseVisualStyleBackColor = true;
            this.BoxHp.CheckedChanged += new System.EventHandler(this.BoxHp_CheckedChanged);
            // 
            // CBoxMana
            // 
            this.CBoxMana.AutoSize = true;
            this.CBoxMana.Location = new System.Drawing.Point(156, 357);
            this.CBoxMana.Name = "CBoxMana";
            this.CBoxMana.Size = new System.Drawing.Size(15, 14);
            this.CBoxMana.TabIndex = 10;
            this.CBoxMana.UseVisualStyleBackColor = true;
            this.CBoxMana.CheckedChanged += new System.EventHandler(this.CBoxMana_CheckedChanged);
            // 
            // CBoxMine
            // 
            this.CBoxMine.AutoSize = true;
            this.CBoxMine.Location = new System.Drawing.Point(156, 228);
            this.CBoxMine.Name = "CBoxMine";
            this.CBoxMine.Size = new System.Drawing.Size(15, 14);
            this.CBoxMine.TabIndex = 12;
            this.CBoxMine.UseVisualStyleBackColor = true;
            this.CBoxMine.CheckedChanged += new System.EventHandler(this.CBoxMine_CheckedChanged);
            // 
            // CBoxExpCharacter
            // 
            this.CBoxExpCharacter.AutoSize = true;
            this.CBoxExpCharacter.Location = new System.Drawing.Point(156, 263);
            this.CBoxExpCharacter.Name = "CBoxExpCharacter";
            this.CBoxExpCharacter.Size = new System.Drawing.Size(15, 14);
            this.CBoxExpCharacter.TabIndex = 13;
            this.CBoxExpCharacter.UseVisualStyleBackColor = true;
            this.CBoxExpCharacter.CheckedChanged += new System.EventHandler(this.CBoxExpCharacter_CheckedChanged);
            // 
            // CBoxExpFireBall
            // 
            this.CBoxExpFireBall.AutoSize = true;
            this.CBoxExpFireBall.Location = new System.Drawing.Point(156, 300);
            this.CBoxExpFireBall.Name = "CBoxExpFireBall";
            this.CBoxExpFireBall.Size = new System.Drawing.Size(15, 14);
            this.CBoxExpFireBall.TabIndex = 14;
            this.CBoxExpFireBall.UseVisualStyleBackColor = true;
            this.CBoxExpFireBall.CheckedChanged += new System.EventHandler(this.CBoxExpFireBall_CheckedChanged);
            // 
            // labelStatusGame
            // 
            this.labelStatusGame.AutoSize = true;
            this.labelStatusGame.BackColor = System.Drawing.Color.White;
            this.labelStatusGame.ForeColor = System.Drawing.Color.Red;
            this.labelStatusGame.Location = new System.Drawing.Point(198, 153);
            this.labelStatusGame.Name = "labelStatusGame";
            this.labelStatusGame.Size = new System.Drawing.Size(37, 13);
            this.labelStatusGame.TabIndex = 15;
            this.labelStatusGame.Text = "..........";
            // 
            // BtnGold
            // 
            this.BtnGold.Location = new System.Drawing.Point(333, 190);
            this.BtnGold.Name = "BtnGold";
            this.BtnGold.Size = new System.Drawing.Size(75, 23);
            this.BtnGold.TabIndex = 16;
            this.BtnGold.Text = "Apply";
            this.BtnGold.UseVisualStyleBackColor = true;
            this.BtnGold.Click += new System.EventHandler(this.BtnGold_Click);
            // 
            // txtGold
            // 
            this.txtGold.Location = new System.Drawing.Point(156, 192);
            this.txtGold.Name = "txtGold";
            this.txtGold.Size = new System.Drawing.Size(100, 20);
            this.txtGold.TabIndex = 17;
            // 
            // CbPower
            // 
            this.CbPower.AutoSize = true;
            this.CbPower.Location = new System.Drawing.Point(156, 390);
            this.CbPower.Name = "CbPower";
            this.CbPower.Size = new System.Drawing.Size(15, 14);
            this.CbPower.TabIndex = 19;
            this.CbPower.UseVisualStyleBackColor = true;
            this.CbPower.CheckedChanged += new System.EventHandler(this.CbPower_CheckedChanged);
            // 
            // labelPower
            // 
            this.labelPower.AutoSize = true;
            this.labelPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPower.Location = new System.Drawing.Point(28, 389);
            this.labelPower.Name = "labelPower";
            this.labelPower.Size = new System.Drawing.Size(52, 17);
            this.labelPower.TabIndex = 18;
            this.labelPower.Text = "Power";
            // 
            // Trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(155)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(420, 431);
            this.Controls.Add(this.CbPower);
            this.Controls.Add(this.labelPower);
            this.Controls.Add(this.txtGold);
            this.Controls.Add(this.BtnGold);
            this.Controls.Add(this.labelStatusGame);
            this.Controls.Add(this.CBoxExpFireBall);
            this.Controls.Add(this.CBoxExpCharacter);
            this.Controls.Add(this.CBoxMine);
            this.Controls.Add(this.CBoxMana);
            this.Controls.Add(this.BoxHp);
            this.Controls.Add(this.labelMine);
            this.Controls.Add(this.labelFireBall);
            this.Controls.Add(this.labelExpCharacter);
            this.Controls.Add(this.labelGold);
            this.Controls.Add(this.labelMana);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelHp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Trainer";
            this.ShowIcon = false;
            this.Text = "Trainer";
            this.Load += new System.EventHandler(this.Trainer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label labelHp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelMana;
        private System.Windows.Forms.Label labelGold;
        private System.Windows.Forms.Label labelExpCharacter;
        private System.Windows.Forms.Label labelFireBall;
        private System.Windows.Forms.Label labelMine;
        private System.Windows.Forms.CheckBox BoxHp;
        private System.Windows.Forms.CheckBox CBoxMana;
        private System.Windows.Forms.CheckBox CBoxMine;
        private System.Windows.Forms.CheckBox CBoxExpCharacter;
        private System.Windows.Forms.CheckBox CBoxExpFireBall;
        private System.Windows.Forms.Label labelStatusGame;
        private System.Windows.Forms.Button BtnGold;
        private System.Windows.Forms.TextBox txtGold;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.CheckBox CbPower;
        private System.Windows.Forms.Label labelPower;
    }
}

