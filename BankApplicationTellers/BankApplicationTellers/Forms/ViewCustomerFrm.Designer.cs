namespace BankApplicationTellers
{
    partial class ViewCustomerFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCustomerFrm));
            this.windowStateImg = new System.Windows.Forms.PictureBox();
            this.CloseBttnImg = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.accountNOTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submitBttn = new System.Windows.Forms.Button();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.employeeNoTitleLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dobLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.overdraftLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.currrentBalLbl = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pinLbl = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.staffManagementBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.windowStateImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBttnImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowStateImg
            // 
            this.windowStateImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.windowStateImg.Enabled = false;
            this.windowStateImg.Image = global::BankApplicationTellers.Properties.Resources.icons8_fit_to_width_filled_50;
            this.windowStateImg.Location = new System.Drawing.Point(951, -1);
            this.windowStateImg.Name = "windowStateImg";
            this.windowStateImg.Size = new System.Drawing.Size(66, 52);
            this.windowStateImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.windowStateImg.TabIndex = 23;
            this.windowStateImg.TabStop = false;
            // 
            // CloseBttnImg
            // 
            this.CloseBttnImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBttnImg.Image = ((System.Drawing.Image)(resources.GetObject("CloseBttnImg.Image")));
            this.CloseBttnImg.Location = new System.Drawing.Point(1013, -1);
            this.CloseBttnImg.Name = "CloseBttnImg";
            this.CloseBttnImg.Size = new System.Drawing.Size(66, 52);
            this.CloseBttnImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CloseBttnImg.TabIndex = 22;
            this.CloseBttnImg.TabStop = false;
            this.CloseBttnImg.Click += new System.EventHandler(this.CloseBttnImg_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 476);
            this.panel1.TabIndex = 24;
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
            this.label3.Text = "Liberty Banking View Customer";
            // 
            // accountNOTxtBox
            // 
            this.accountNOTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.accountNOTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accountNOTxtBox.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNOTxtBox.Location = new System.Drawing.Point(579, 22);
            this.accountNOTxtBox.MaxLength = 100;
            this.accountNOTxtBox.Name = "accountNOTxtBox";
            this.accountNOTxtBox.Size = new System.Drawing.Size(184, 25);
            this.accountNOTxtBox.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 43);
            this.label1.TabIndex = 25;
            this.label1.Text = "Account NO -";
            // 
            // submitBttn
            // 
            this.submitBttn.BackColor = System.Drawing.Color.Red;
            this.submitBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBttn.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBttn.Location = new System.Drawing.Point(782, 11);
            this.submitBttn.Name = "submitBttn";
            this.submitBttn.Size = new System.Drawing.Size(139, 41);
            this.submitBttn.TabIndex = 37;
            this.submitBttn.Text = "Submit";
            this.submitBttn.UseVisualStyleBackColor = false;
            this.submitBttn.Click += new System.EventHandler(this.submitBttn_Click);
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLbl.Location = new System.Drawing.Point(623, 109);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(32, 37);
            this.firstNameLbl.TabIndex = 39;
            this.firstNameLbl.Text = "0";
            // 
            // employeeNoTitleLbl
            // 
            this.employeeNoTitleLbl.AutoSize = true;
            this.employeeNoTitleLbl.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNoTitleLbl.Location = new System.Drawing.Point(349, 109);
            this.employeeNoTitleLbl.Name = "employeeNoTitleLbl";
            this.employeeNoTitleLbl.Size = new System.Drawing.Size(178, 37);
            this.employeeNoTitleLbl.TabIndex = 38;
            this.employeeNoTitleLbl.Text = "First Name -";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLbl.Location = new System.Drawing.Point(623, 147);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(32, 37);
            this.lastNameLbl.TabIndex = 41;
            this.lastNameLbl.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(350, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 37);
            this.label4.TabIndex = 40;
            this.label4.Text = "Last Name - ";
            // 
            // dobLbl
            // 
            this.dobLbl.AutoSize = true;
            this.dobLbl.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLbl.Location = new System.Drawing.Point(623, 183);
            this.dobLbl.Name = "dobLbl";
            this.dobLbl.Size = new System.Drawing.Size(32, 37);
            this.dobLbl.TabIndex = 43;
            this.dobLbl.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(350, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 37);
            this.label6.TabIndex = 42;
            this.label6.Text = "Date of Birth - ";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLbl.Location = new System.Drawing.Point(623, 220);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(32, 37);
            this.addressLbl.TabIndex = 47;
            this.addressLbl.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(350, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 37);
            this.label8.TabIndex = 46;
            this.label8.Text = "Address - ";
            // 
            // overdraftLbl
            // 
            this.overdraftLbl.AutoSize = true;
            this.overdraftLbl.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overdraftLbl.Location = new System.Drawing.Point(623, 257);
            this.overdraftLbl.Name = "overdraftLbl";
            this.overdraftLbl.Size = new System.Drawing.Size(32, 37);
            this.overdraftLbl.TabIndex = 49;
            this.overdraftLbl.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(350, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 37);
            this.label10.TabIndex = 48;
            this.label10.Text = "Overdraft";
            // 
            // currrentBalLbl
            // 
            this.currrentBalLbl.AutoSize = true;
            this.currrentBalLbl.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currrentBalLbl.Location = new System.Drawing.Point(623, 294);
            this.currrentBalLbl.Name = "currrentBalLbl";
            this.currrentBalLbl.Size = new System.Drawing.Size(32, 37);
            this.currrentBalLbl.TabIndex = 51;
            this.currrentBalLbl.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(349, 294);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(255, 37);
            this.label14.TabIndex = 52;
            this.label14.Text = "Current Balance - ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pinLbl
            // 
            this.pinLbl.AutoSize = true;
            this.pinLbl.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinLbl.Location = new System.Drawing.Point(623, 331);
            this.pinLbl.Name = "pinLbl";
            this.pinLbl.Size = new System.Drawing.Size(32, 37);
            this.pinLbl.TabIndex = 55;
            this.pinLbl.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(350, 331);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 37);
            this.label16.TabIndex = 54;
            this.label16.Text = "PIN - ";
            // 
            // staffManagementBttn
            // 
            this.staffManagementBttn.BackColor = System.Drawing.Color.Red;
            this.staffManagementBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffManagementBttn.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffManagementBttn.Location = new System.Drawing.Point(680, 384);
            this.staffManagementBttn.Name = "staffManagementBttn";
            this.staffManagementBttn.Size = new System.Drawing.Size(399, 92);
            this.staffManagementBttn.TabIndex = 56;
            this.staffManagementBttn.Text = "Main Menu";
            this.staffManagementBttn.UseVisualStyleBackColor = false;
            this.staffManagementBttn.Click += new System.EventHandler(this.staffManagementBttn_Click);
            // 
            // ViewCustomerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 476);
            this.Controls.Add(this.staffManagementBttn);
            this.Controls.Add(this.pinLbl);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.currrentBalLbl);
            this.Controls.Add(this.overdraftLbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dobLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.employeeNoTitleLbl);
            this.Controls.Add(this.submitBttn);
            this.Controls.Add(this.accountNOTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.windowStateImg);
            this.Controls.Add(this.CloseBttnImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewCustomerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liberty Banking - View Customer";
            ((System.ComponentModel.ISupportInitialize)(this.windowStateImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBttnImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox windowStateImg;
        private System.Windows.Forms.PictureBox CloseBttnImg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox accountNOTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitBttn;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label employeeNoTitleLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dobLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label overdraftLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label currrentBalLbl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label pinLbl;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button staffManagementBttn;
    }
}