using System;

namespace Rock_Paper_Scissors_Game
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
            this.label2 = new System.Windows.Forms.Label();
            this.CompScorelbl = new System.Windows.Forms.Label();
            this.PlScorelbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComputerChoicelbl = new System.Windows.Forms.Label();
            this.PlayerChoicelbl = new System.Windows.Forms.Label();
            this.showRulesbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ComputerChoicePicture = new System.Windows.Forms.PictureBox();
            this.PlayerChoicePicture = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Resetbtn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerChoicePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerChoicePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(482, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 37);
            this.label2.TabIndex = 23;
            this.label2.Text = "Welcome to game";
            // 
            // CompScorelbl
            // 
            this.CompScorelbl.AutoSize = true;
            this.CompScorelbl.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompScorelbl.Location = new System.Drawing.Point(588, 139);
            this.CompScorelbl.Name = "CompScorelbl";
            this.CompScorelbl.Size = new System.Drawing.Size(31, 37);
            this.CompScorelbl.TabIndex = 22;
            this.CompScorelbl.Text = "0";
            // 
            // PlScorelbl
            // 
            this.PlScorelbl.AutoSize = true;
            this.PlScorelbl.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlScorelbl.Location = new System.Drawing.Point(552, 139);
            this.PlScorelbl.Name = "PlScorelbl";
            this.PlScorelbl.Size = new System.Drawing.Size(31, 37);
            this.PlScorelbl.TabIndex = 21;
            this.PlScorelbl.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(545, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 32);
            this.label3.TabIndex = 20;
            this.label3.Text = "Score";
            // 
            // ComputerChoicelbl
            // 
            this.ComputerChoicelbl.AutoSize = true;
            this.ComputerChoicelbl.Font = new System.Drawing.Font("Palatino Linotype", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerChoicelbl.Location = new System.Drawing.Point(615, 46);
            this.ComputerChoicelbl.Name = "ComputerChoicelbl";
            this.ComputerChoicelbl.Size = new System.Drawing.Size(189, 32);
            this.ComputerChoicelbl.TabIndex = 17;
            this.ComputerChoicelbl.Text = "Computer choice";
            // 
            // PlayerChoicelbl
            // 
            this.PlayerChoicelbl.AutoSize = true;
            this.PlayerChoicelbl.Font = new System.Drawing.Font("Palatino Linotype", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerChoicelbl.Location = new System.Drawing.Point(347, 46);
            this.PlayerChoicelbl.Name = "PlayerChoicelbl";
            this.PlayerChoicelbl.Size = new System.Drawing.Size(134, 32);
            this.PlayerChoicelbl.TabIndex = 16;
            this.PlayerChoicelbl.Text = "Your choice";
            // 
            // showRulesbtn
            // 
            this.showRulesbtn.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showRulesbtn.Location = new System.Drawing.Point(11, 2);
            this.showRulesbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showRulesbtn.Name = "showRulesbtn";
            this.showRulesbtn.Size = new System.Drawing.Size(188, 39);
            this.showRulesbtn.TabIndex = 15;
            this.showRulesbtn.Text = "Show Rules";
            this.showRulesbtn.UseVisualStyleBackColor = true;
            this.showRulesbtn.Click += new System.EventHandler(this.showRulesbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 46);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(314, 422);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(188, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 34);
            this.label6.TabIndex = 5;
            this.label6.Text = "Scissors";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Rock_Paper_Scissors_Game.Properties.Resources.paper;
            this.pictureBox2.Location = new System.Drawing.Point(5, 286);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Paper";
            this.pictureBox2.Click += new System.EventHandler(this.ShowChoices);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Rock_Paper_Scissors_Game.Properties.Resources.rock;
            this.pictureBox1.Location = new System.Drawing.Point(5, 161);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Rock";
            this.pictureBox1.Click += new System.EventHandler(this.ShowChoices);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(188, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "Paper";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rock";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Rock_Paper_Scissors_Game.Properties.Resources.scissors;
            this.pictureBox3.Location = new System.Drawing.Point(5, 36);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(178, 120);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "Scissors";
            this.pictureBox3.Click += new System.EventHandler(this.ShowChoices);
            // 
            // ComputerChoicePicture
            // 
            this.ComputerChoicePicture.Location = new System.Drawing.Point(647, 89);
            this.ComputerChoicePicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComputerChoicePicture.Name = "ComputerChoicePicture";
            this.ComputerChoicePicture.Size = new System.Drawing.Size(178, 120);
            this.ComputerChoicePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ComputerChoicePicture.TabIndex = 19;
            this.ComputerChoicePicture.TabStop = false;
            // 
            // PlayerChoicePicture
            // 
            this.PlayerChoicePicture.Location = new System.Drawing.Point(353, 89);
            this.PlayerChoicePicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayerChoicePicture.Name = "PlayerChoicePicture";
            this.PlayerChoicePicture.Size = new System.Drawing.Size(178, 120);
            this.PlayerChoicePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerChoicePicture.TabIndex = 18;
            this.PlayerChoicePicture.TabStop = false;
            this.PlayerChoicePicture.Click += new System.EventHandler(this.PlayerChoicePicture_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(492, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 32);
            this.label9.TabIndex = 27;
            this.label9.Text = "All choices";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(656, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 27);
            this.label8.TabIndex = 26;
            this.label8.Text = "Computer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(537, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 27);
            this.label7.TabIndex = 25;
            this.label7.Text = "Player";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 27);
            this.label1.TabIndex = 24;
            this.label1.Text = "Round";
            // 
            // Resetbtn
            // 
            this.Resetbtn.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resetbtn.Location = new System.Drawing.Point(11, 482);
            this.Resetbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(188, 39);
            this.Resetbtn.TabIndex = 28;
            this.Resetbtn.Text = "Reset";
            this.Resetbtn.UseVisualStyleBackColor = true;
            this.Resetbtn.Click += new System.EventHandler(this.Resetbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(920, 574);
            this.Controls.Add(this.Resetbtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CompScorelbl);
            this.Controls.Add(this.PlScorelbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComputerChoicePicture);
            this.Controls.Add(this.PlayerChoicePicture);
            this.Controls.Add(this.ComputerChoicelbl);
            this.Controls.Add(this.PlayerChoicelbl);
            this.Controls.Add(this.showRulesbtn);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors Game";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerChoicePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerChoicePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void PlayerChoicePicture_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CompScorelbl;
        private System.Windows.Forms.Label PlScorelbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ComputerChoicePicture;
        private System.Windows.Forms.PictureBox PlayerChoicePicture;
        private System.Windows.Forms.Label ComputerChoicelbl;
        private System.Windows.Forms.Label PlayerChoicelbl;
        private System.Windows.Forms.Button showRulesbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Resetbtn;
    }
}

