namespace BankApplicationTellers
{
    partial class TellerMainMenuFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TellerMainMenuFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.accountManagementBttn = new System.Windows.Forms.Button();
            this.balanceManagementBttn = new System.Windows.Forms.Button();
            this.viewCustomerBttn = new System.Windows.Forms.Button();
            this.staffManagementBttn = new System.Windows.Forms.Button();
            this.thisAccountBttnImg = new System.Windows.Forms.PictureBox();
            this.infoBttnImg = new System.Windows.Forms.PictureBox();
            this.windowStateImg = new System.Windows.Forms.PictureBox();
            this.CloseBttnImg = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thisAccountBttnImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBttnImg)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(342, 640);
            this.panel1.TabIndex = 10;
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
            this.label3.Text = "Liberty Banking Main Menu";
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
            // accountManagementBttn
            // 
            this.accountManagementBttn.BackColor = System.Drawing.Color.Red;
            this.accountManagementBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountManagementBttn.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountManagementBttn.Location = new System.Drawing.Point(498, 92);
            this.accountManagementBttn.Name = "accountManagementBttn";
            this.accountManagementBttn.Size = new System.Drawing.Size(399, 92);
            this.accountManagementBttn.TabIndex = 19;
            this.accountManagementBttn.Text = "Customer Account Management";
            this.accountManagementBttn.UseVisualStyleBackColor = false;
            this.accountManagementBttn.Click += new System.EventHandler(this.accountManagementBttn_Click);
            // 
            // balanceManagementBttn
            // 
            this.balanceManagementBttn.BackColor = System.Drawing.Color.Red;
            this.balanceManagementBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.balanceManagementBttn.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceManagementBttn.Location = new System.Drawing.Point(498, 227);
            this.balanceManagementBttn.Name = "balanceManagementBttn";
            this.balanceManagementBttn.Size = new System.Drawing.Size(399, 92);
            this.balanceManagementBttn.TabIndex = 20;
            this.balanceManagementBttn.Text = "Customer Balance Management";
            this.balanceManagementBttn.UseVisualStyleBackColor = false;
            this.balanceManagementBttn.Click += new System.EventHandler(this.balanceManagementBttn_Click);
            // 
            // viewCustomerBttn
            // 
            this.viewCustomerBttn.BackColor = System.Drawing.Color.Red;
            this.viewCustomerBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewCustomerBttn.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCustomerBttn.Location = new System.Drawing.Point(498, 354);
            this.viewCustomerBttn.Name = "viewCustomerBttn";
            this.viewCustomerBttn.Size = new System.Drawing.Size(399, 92);
            this.viewCustomerBttn.TabIndex = 21;
            this.viewCustomerBttn.Text = "View Customer";
            this.viewCustomerBttn.UseVisualStyleBackColor = false;
            this.viewCustomerBttn.Click += new System.EventHandler(this.viewCustomerBttn_Click);
            // 
            // staffManagementBttn
            // 
            this.staffManagementBttn.BackColor = System.Drawing.Color.Red;
            this.staffManagementBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffManagementBttn.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffManagementBttn.Location = new System.Drawing.Point(498, 478);
            this.staffManagementBttn.Name = "staffManagementBttn";
            this.staffManagementBttn.Size = new System.Drawing.Size(399, 92);
            this.staffManagementBttn.TabIndex = 25;
            this.staffManagementBttn.Text = "Staff Management";
            this.staffManagementBttn.UseVisualStyleBackColor = false;
            this.staffManagementBttn.Click += new System.EventHandler(this.staffManagementBttn_Click);
            // 
            // thisAccountBttnImg
            // 
            this.thisAccountBttnImg.Image = global::BankApplicationTellers.Properties.Resources.icons8_user_48;
            this.thisAccountBttnImg.Location = new System.Drawing.Point(348, 590);
            this.thisAccountBttnImg.Name = "thisAccountBttnImg";
            this.thisAccountBttnImg.Size = new System.Drawing.Size(67, 50);
            this.thisAccountBttnImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.thisAccountBttnImg.TabIndex = 24;
            this.thisAccountBttnImg.TabStop = false;
            this.thisAccountBttnImg.Click += new System.EventHandler(this.thisAccountBttnImg_Click);
            // 
            // infoBttnImg
            // 
            this.infoBttnImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.infoBttnImg.Image = global::BankApplicationTellers.Properties.Resources.icons8_about_50;
            this.infoBttnImg.Location = new System.Drawing.Point(1016, 588);
            this.infoBttnImg.Name = "infoBttnImg";
            this.infoBttnImg.Size = new System.Drawing.Size(66, 52);
            this.infoBttnImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.infoBttnImg.TabIndex = 22;
            this.infoBttnImg.TabStop = false;
            this.infoBttnImg.Click += new System.EventHandler(this.infoBttnImg_Click);
            // 
            // windowStateImg
            // 
            this.windowStateImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.windowStateImg.Enabled = false;
            this.windowStateImg.Image = global::BankApplicationTellers.Properties.Resources.icons8_fit_to_width_filled_50;
            this.windowStateImg.Location = new System.Drawing.Point(955, 0);
            this.windowStateImg.Name = "windowStateImg";
            this.windowStateImg.Size = new System.Drawing.Size(66, 52);
            this.windowStateImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.windowStateImg.TabIndex = 18;
            this.windowStateImg.TabStop = false;
            this.windowStateImg.Click += new System.EventHandler(this.windowStateImg_Click);
            // 
            // CloseBttnImg
            // 
            this.CloseBttnImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBttnImg.Image = ((System.Drawing.Image)(resources.GetObject("CloseBttnImg.Image")));
            this.CloseBttnImg.Location = new System.Drawing.Point(1016, 0);
            this.CloseBttnImg.Name = "CloseBttnImg";
            this.CloseBttnImg.Size = new System.Drawing.Size(66, 52);
            this.CloseBttnImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CloseBttnImg.TabIndex = 17;
            this.CloseBttnImg.TabStop = false;
            this.CloseBttnImg.Click += new System.EventHandler(this.CloseBttnImg_Click);
            // 
            // TellerMainMenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 640);
            this.Controls.Add(this.staffManagementBttn);
            this.Controls.Add(this.thisAccountBttnImg);
            this.Controls.Add(this.infoBttnImg);
            this.Controls.Add(this.viewCustomerBttn);
            this.Controls.Add(this.balanceManagementBttn);
            this.Controls.Add(this.accountManagementBttn);
            this.Controls.Add(this.windowStateImg);
            this.Controls.Add(this.CloseBttnImg);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TellerMainMenuFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liberty Banking Main Menu";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thisAccountBttnImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBttnImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowStateImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBttnImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox windowStateImg;
        private System.Windows.Forms.PictureBox CloseBttnImg;
        private System.Windows.Forms.Button accountManagementBttn;
        private System.Windows.Forms.Button balanceManagementBttn;
        private System.Windows.Forms.Button viewCustomerBttn;
        private System.Windows.Forms.PictureBox infoBttnImg;
        private System.Windows.Forms.PictureBox thisAccountBttnImg;
        private System.Windows.Forms.Button staffManagementBttn;
    }
}