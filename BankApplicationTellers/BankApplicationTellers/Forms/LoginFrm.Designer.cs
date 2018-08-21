namespace BankApplicationTellers
{
    partial class LoginFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CloseBttnImg = new System.Windows.Forms.PictureBox();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitBttn = new System.Windows.Forms.Button();
            this.countLbl = new System.Windows.Forms.Label();
            this.capsLockLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBttnImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 501);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(31, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 114);
            this.label3.TabIndex = 1;
            this.label3.Text = "Welcome to Liberty Banking!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CloseBttnImg
            // 
            this.CloseBttnImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBttnImg.Image = ((System.Drawing.Image)(resources.GetObject("CloseBttnImg.Image")));
            this.CloseBttnImg.Location = new System.Drawing.Point(1049, 0);
            this.CloseBttnImg.Name = "CloseBttnImg";
            this.CloseBttnImg.Size = new System.Drawing.Size(66, 52);
            this.CloseBttnImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CloseBttnImg.TabIndex = 15;
            this.CloseBttnImg.TabStop = false;
            this.CloseBttnImg.Click += new System.EventHandler(this.CloseBttnImg_Click);
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.passwordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxtBox.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBox.HideSelection = false;
            this.passwordTxtBox.Location = new System.Drawing.Point(651, 243);
            this.passwordTxtBox.MaxLength = 100;
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.Size = new System.Drawing.Size(291, 25);
            this.passwordTxtBox.TabIndex = 14;
            this.passwordTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTxtBox_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 43);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password";
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.usernameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTxtBox.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtBox.Location = new System.Drawing.Point(651, 99);
            this.usernameTxtBox.MaxLength = 100;
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(291, 25);
            this.usernameTxtBox.TabIndex = 12;
            this.usernameTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameTxtBox_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 43);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username";
            // 
            // SubmitBttn
            // 
            this.SubmitBttn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SubmitBttn.BackColor = System.Drawing.Color.Red;
            this.SubmitBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SubmitBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitBttn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.SubmitBttn.FlatAppearance.BorderSize = 0;
            this.SubmitBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitBttn.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBttn.Location = new System.Drawing.Point(340, 397);
            this.SubmitBttn.Name = "SubmitBttn";
            this.SubmitBttn.Size = new System.Drawing.Size(775, 104);
            this.SubmitBttn.TabIndex = 10;
            this.SubmitBttn.Text = "Login";
            this.SubmitBttn.UseVisualStyleBackColor = false;
            this.SubmitBttn.Click += new System.EventHandler(this.SubmitBttn_Click);
            // 
            // countLbl
            // 
            this.countLbl.AutoSize = true;
            this.countLbl.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLbl.ForeColor = System.Drawing.Color.Red;
            this.countLbl.Location = new System.Drawing.Point(348, 370);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(85, 24);
            this.countLbl.TabIndex = 17;
            this.countLbl.Text = "Tries 0/5";
            // 
            // capsLockLbl
            // 
            this.capsLockLbl.AutoSize = true;
            this.capsLockLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.capsLockLbl.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capsLockLbl.ForeColor = System.Drawing.Color.Red;
            this.capsLockLbl.Location = new System.Drawing.Point(554, 309);
            this.capsLockLbl.Name = "capsLockLbl";
            this.capsLockLbl.Size = new System.Drawing.Size(388, 61);
            this.capsLockLbl.TabIndex = 18;
            this.capsLockLbl.Text = "CAPS LOCK IS ON";
            this.capsLockLbl.Visible = false;
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1115, 501);
            this.Controls.Add(this.capsLockLbl);
            this.Controls.Add(this.countLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CloseBttnImg);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubmitBttn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liberty Banking Login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBttnImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox CloseBttnImg;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubmitBttn;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.Label capsLockLbl;
    }
}

