namespace BankApplicationTellers
{
    partial class AccountManagementFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountManagementFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deleteAccountBttn = new System.Windows.Forms.Button();
            this.updateAccountBttn = new System.Windows.Forms.Button();
            this.createAccountBttn = new System.Windows.Forms.Button();
            this.backBttn = new System.Windows.Forms.Button();
            this.infoBttnImg = new System.Windows.Forms.PictureBox();
            this.CloseBttnImg = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBttnImg)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(342, 640);
            this.panel1.TabIndex = 11;
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
            this.label3.Text = "Liberty Banking Account Management";
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
            // deleteAccountBttn
            // 
            this.deleteAccountBttn.BackColor = System.Drawing.Color.Red;
            this.deleteAccountBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAccountBttn.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAccountBttn.Location = new System.Drawing.Point(498, 354);
            this.deleteAccountBttn.Name = "deleteAccountBttn";
            this.deleteAccountBttn.Size = new System.Drawing.Size(399, 92);
            this.deleteAccountBttn.TabIndex = 28;
            this.deleteAccountBttn.Text = "Delete Customer Account";
            this.deleteAccountBttn.UseVisualStyleBackColor = false;
            this.deleteAccountBttn.Click += new System.EventHandler(this.deleteAccountBttn_Click_1);
            // 
            // updateAccountBttn
            // 
            this.updateAccountBttn.BackColor = System.Drawing.Color.Red;
            this.updateAccountBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateAccountBttn.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAccountBttn.Location = new System.Drawing.Point(498, 227);
            this.updateAccountBttn.Name = "updateAccountBttn";
            this.updateAccountBttn.Size = new System.Drawing.Size(399, 92);
            this.updateAccountBttn.TabIndex = 27;
            this.updateAccountBttn.Text = "Update Customer Account";
            this.updateAccountBttn.UseVisualStyleBackColor = false;
            // 
            // createAccountBttn
            // 
            this.createAccountBttn.BackColor = System.Drawing.Color.Red;
            this.createAccountBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAccountBttn.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountBttn.Location = new System.Drawing.Point(498, 92);
            this.createAccountBttn.Name = "createAccountBttn";
            this.createAccountBttn.Size = new System.Drawing.Size(399, 92);
            this.createAccountBttn.TabIndex = 26;
            this.createAccountBttn.Text = "Create Customer Account";
            this.createAccountBttn.UseVisualStyleBackColor = false;
            this.createAccountBttn.Click += new System.EventHandler(this.createAccountBttn_Click);
            // 
            // backBttn
            // 
            this.backBttn.BackColor = System.Drawing.Color.Red;
            this.backBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBttn.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBttn.Location = new System.Drawing.Point(498, 548);
            this.backBttn.Name = "backBttn";
            this.backBttn.Size = new System.Drawing.Size(399, 92);
            this.backBttn.TabIndex = 30;
            this.backBttn.Text = "Main Menu";
            this.backBttn.UseVisualStyleBackColor = false;
            this.backBttn.Click += new System.EventHandler(this.backBttn_Click);
            // 
            // infoBttnImg
            // 
            this.infoBttnImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.infoBttnImg.Image = global::BankApplicationTellers.Properties.Resources.icons8_about_50;
            this.infoBttnImg.Location = new System.Drawing.Point(1015, 588);
            this.infoBttnImg.Name = "infoBttnImg";
            this.infoBttnImg.Size = new System.Drawing.Size(66, 52);
            this.infoBttnImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.infoBttnImg.TabIndex = 29;
            this.infoBttnImg.TabStop = false;
            this.infoBttnImg.Click += new System.EventHandler(this.infoBttnImg_Click);
            // 
            // CloseBttnImg
            // 
            this.CloseBttnImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBttnImg.Image = ((System.Drawing.Image)(resources.GetObject("CloseBttnImg.Image")));
            this.CloseBttnImg.Location = new System.Drawing.Point(1015, 0);
            this.CloseBttnImg.Name = "CloseBttnImg";
            this.CloseBttnImg.Size = new System.Drawing.Size(66, 52);
            this.CloseBttnImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CloseBttnImg.TabIndex = 17;
            this.CloseBttnImg.TabStop = false;
            this.CloseBttnImg.Click += new System.EventHandler(this.CloseBttnImg_Click);
            // 
            // AccountManagementFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 640);
            this.Controls.Add(this.backBttn);
            this.Controls.Add(this.infoBttnImg);
            this.Controls.Add(this.deleteAccountBttn);
            this.Controls.Add(this.updateAccountBttn);
            this.Controls.Add(this.createAccountBttn);
            this.Controls.Add(this.CloseBttnImg);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccountManagementFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liberty Banking Account Management";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBttnImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBttnImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox CloseBttnImg;
        private System.Windows.Forms.Button deleteAccountBttn;
        private System.Windows.Forms.Button updateAccountBttn;
        private System.Windows.Forms.Button createAccountBttn;
        private System.Windows.Forms.PictureBox infoBttnImg;
        private System.Windows.Forms.Button backBttn;
    }
}