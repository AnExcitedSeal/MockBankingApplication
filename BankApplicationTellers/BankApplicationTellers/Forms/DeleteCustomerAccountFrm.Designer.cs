namespace BankApplicationTellers
{
    partial class DeleteCustomerAccountFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteCustomerAccountFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.windowStateImg = new System.Windows.Forms.PictureBox();
            this.CloseBttnImg = new System.Windows.Forms.PictureBox();
            this.accountNOLbl = new System.Windows.Forms.Label();
            this.accountNoTxtBox = new System.Windows.Forms.TextBox();
            this.mainMenuBttn = new System.Windows.Forms.Button();
            this.submitBttn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowStateImg)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(342, 373);
            this.panel1.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(31, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 132);
            this.label3.TabIndex = 1;
            this.label3.Text = "Liberty Banking Create Account";
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
            // windowStateImg
            // 
            this.windowStateImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.windowStateImg.Enabled = false;
            this.windowStateImg.Image = global::BankApplicationTellers.Properties.Resources.icons8_fit_to_width_filled_50;
            this.windowStateImg.Location = new System.Drawing.Point(831, 0);
            this.windowStateImg.Name = "windowStateImg";
            this.windowStateImg.Size = new System.Drawing.Size(66, 52);
            this.windowStateImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.windowStateImg.TabIndex = 24;
            this.windowStateImg.TabStop = false;
            // 
            // CloseBttnImg
            // 
            this.CloseBttnImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBttnImg.Image = ((System.Drawing.Image)(resources.GetObject("CloseBttnImg.Image")));
            this.CloseBttnImg.Location = new System.Drawing.Point(892, 0);
            this.CloseBttnImg.Name = "CloseBttnImg";
            this.CloseBttnImg.Size = new System.Drawing.Size(66, 52);
            this.CloseBttnImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CloseBttnImg.TabIndex = 23;
            this.CloseBttnImg.TabStop = false;
            this.CloseBttnImg.Click += new System.EventHandler(this.CloseBttnImg_Click);
            // 
            // accountNOLbl
            // 
            this.accountNOLbl.AutoSize = true;
            this.accountNOLbl.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNOLbl.Location = new System.Drawing.Point(348, 77);
            this.accountNOLbl.Name = "accountNOLbl";
            this.accountNOLbl.Size = new System.Drawing.Size(226, 43);
            this.accountNOLbl.TabIndex = 26;
            this.accountNOLbl.Text = "Account NO -";
            // 
            // accountNoTxtBox
            // 
            this.accountNoTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accountNoTxtBox.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNoTxtBox.Location = new System.Drawing.Point(600, 90);
            this.accountNoTxtBox.MaxLength = 400;
            this.accountNoTxtBox.Name = "accountNoTxtBox";
            this.accountNoTxtBox.ShortcutsEnabled = false;
            this.accountNoTxtBox.Size = new System.Drawing.Size(291, 25);
            this.accountNoTxtBox.TabIndex = 25;
            // 
            // mainMenuBttn
            // 
            this.mainMenuBttn.BackColor = System.Drawing.Color.Red;
            this.mainMenuBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainMenuBttn.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuBttn.Location = new System.Drawing.Point(338, 281);
            this.mainMenuBttn.Name = "mainMenuBttn";
            this.mainMenuBttn.Size = new System.Drawing.Size(324, 92);
            this.mainMenuBttn.TabIndex = 39;
            this.mainMenuBttn.Text = "Main Menu";
            this.mainMenuBttn.UseVisualStyleBackColor = false;
            this.mainMenuBttn.Click += new System.EventHandler(this.mainMenuBttn_Click);
            // 
            // submitBttn
            // 
            this.submitBttn.BackColor = System.Drawing.Color.Red;
            this.submitBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBttn.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBttn.Location = new System.Drawing.Point(635, 281);
            this.submitBttn.Name = "submitBttn";
            this.submitBttn.Size = new System.Drawing.Size(324, 92);
            this.submitBttn.TabIndex = 38;
            this.submitBttn.Text = "Submit";
            this.submitBttn.UseVisualStyleBackColor = false;
            this.submitBttn.Click += new System.EventHandler(this.submitBttn_Click);
            // 
            // DeleteCustomerAccountFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 373);
            this.Controls.Add(this.mainMenuBttn);
            this.Controls.Add(this.submitBttn);
            this.Controls.Add(this.accountNOLbl);
            this.Controls.Add(this.accountNoTxtBox);
            this.Controls.Add(this.windowStateImg);
            this.Controls.Add(this.CloseBttnImg);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteCustomerAccountFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Customer Account - Liberty Banking";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowStateImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBttnImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox windowStateImg;
        private System.Windows.Forms.PictureBox CloseBttnImg;
        private System.Windows.Forms.Label accountNOLbl;
        private System.Windows.Forms.TextBox accountNoTxtBox;
        private System.Windows.Forms.Button mainMenuBttn;
        private System.Windows.Forms.Button submitBttn;
    }
}