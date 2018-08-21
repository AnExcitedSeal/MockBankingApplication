namespace BankApplicationTellers
{
    partial class BalanceManagementFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BalanceManagementFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customerIdTxtBox = new System.Windows.Forms.TextBox();
            this.CloseBttnImg = new System.Windows.Forms.PictureBox();
            this.customerIdLbl = new System.Windows.Forms.Label();
            this.submitBttn = new System.Windows.Forms.Button();
            this.amountLbl = new System.Windows.Forms.Label();
            this.amountUpDown = new System.Windows.Forms.NumericUpDown();
            this.methodDrpDwn = new System.Windows.Forms.ComboBox();
            this.methodLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBttnImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountUpDown)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(342, 387);
            this.panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(31, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 121);
            this.label3.TabIndex = 1;
            this.label3.Text = "Liberty Banking Update Balance\r\n";
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
            // customerIdTxtBox
            // 
            this.customerIdTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerIdTxtBox.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIdTxtBox.Location = new System.Drawing.Point(590, 27);
            this.customerIdTxtBox.MaxLength = 400;
            this.customerIdTxtBox.Name = "customerIdTxtBox";
            this.customerIdTxtBox.ShortcutsEnabled = false;
            this.customerIdTxtBox.Size = new System.Drawing.Size(291, 25);
            this.customerIdTxtBox.TabIndex = 13;
            // 
            // CloseBttnImg
            // 
            this.CloseBttnImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBttnImg.Image = ((System.Drawing.Image)(resources.GetObject("CloseBttnImg.Image")));
            this.CloseBttnImg.Location = new System.Drawing.Point(1017, 0);
            this.CloseBttnImg.Name = "CloseBttnImg";
            this.CloseBttnImg.Size = new System.Drawing.Size(66, 52);
            this.CloseBttnImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CloseBttnImg.TabIndex = 19;
            this.CloseBttnImg.TabStop = false;
            this.CloseBttnImg.Click += new System.EventHandler(this.CloseBttnImg_Click);
            // 
            // customerIdLbl
            // 
            this.customerIdLbl.AutoSize = true;
            this.customerIdLbl.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIdLbl.Location = new System.Drawing.Point(348, 14);
            this.customerIdLbl.Name = "customerIdLbl";
            this.customerIdLbl.Size = new System.Drawing.Size(237, 43);
            this.customerIdLbl.TabIndex = 21;
            this.customerIdLbl.Text = "Account NO - ";
            // 
            // submitBttn
            // 
            this.submitBttn.BackColor = System.Drawing.Color.Red;
            this.submitBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBttn.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBttn.Location = new System.Drawing.Point(723, 283);
            this.submitBttn.Name = "submitBttn";
            this.submitBttn.Size = new System.Drawing.Size(291, 92);
            this.submitBttn.TabIndex = 30;
            this.submitBttn.Text = "Submit";
            this.submitBttn.UseVisualStyleBackColor = false;
            this.submitBttn.Click += new System.EventHandler(this.submitBttn_Click);
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLbl.Location = new System.Drawing.Point(348, 187);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(138, 43);
            this.amountLbl.TabIndex = 32;
            this.amountLbl.Text = "Value - ";
            // 
            // amountUpDown
            // 
            this.amountUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amountUpDown.DecimalPlaces = 1;
            this.amountUpDown.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountUpDown.Location = new System.Drawing.Point(537, 201);
            this.amountUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.amountUpDown.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.amountUpDown.Name = "amountUpDown";
            this.amountUpDown.Size = new System.Drawing.Size(157, 28);
            this.amountUpDown.TabIndex = 33;
            this.amountUpDown.ThousandsSeparator = true;
            // 
            // methodDrpDwn
            // 
            this.methodDrpDwn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.methodDrpDwn.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.methodDrpDwn.FormattingEnabled = true;
            this.methodDrpDwn.Items.AddRange(new object[] {
            "Cash",
            "Cheque"});
            this.methodDrpDwn.Location = new System.Drawing.Point(537, 107);
            this.methodDrpDwn.Name = "methodDrpDwn";
            this.methodDrpDwn.Size = new System.Drawing.Size(157, 45);
            this.methodDrpDwn.TabIndex = 34;
            this.methodDrpDwn.Text = "None";
            // 
            // methodLbl
            // 
            this.methodLbl.AutoSize = true;
            this.methodLbl.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.methodLbl.Location = new System.Drawing.Point(348, 109);
            this.methodLbl.Name = "methodLbl";
            this.methodLbl.Size = new System.Drawing.Size(170, 43);
            this.methodLbl.TabIndex = 35;
            this.methodLbl.Text = "Method - ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(426, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 92);
            this.button1.TabIndex = 36;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BalanceManagementFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 387);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.methodLbl);
            this.Controls.Add(this.methodDrpDwn);
            this.Controls.Add(this.amountUpDown);
            this.Controls.Add(this.amountLbl);
            this.Controls.Add(this.submitBttn);
            this.Controls.Add(this.customerIdLbl);
            this.Controls.Add(this.CloseBttnImg);
            this.Controls.Add(this.customerIdTxtBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BalanceManagementFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Balance - Liberty Banking";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBttnImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox customerIdTxtBox;
        private System.Windows.Forms.PictureBox CloseBttnImg;
        private System.Windows.Forms.Label customerIdLbl;
        private System.Windows.Forms.Button submitBttn;
        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.NumericUpDown amountUpDown;
        private System.Windows.Forms.ComboBox methodDrpDwn;
        private System.Windows.Forms.Label methodLbl;
        private System.Windows.Forms.Button button1;
    }
}