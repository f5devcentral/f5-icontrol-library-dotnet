namespace iControl.Dialogs
{
    partial class ConnectionDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EndpointTextBox = new System.Windows.Forms.TextBox();
            this.OKLinkLabel = new System.Windows.Forms.LinkLabel();
            this.CancelLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.HostnameComboBox = new System.Windows.Forms.ComboBox();
            this.SaveConfigCheckBox = new System.Windows.Forms.CheckBox();
            this.ClearLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProxyUserTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ProxyPassTextBox = new System.Windows.Forms.TextBox();
            this.UseProxyCheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ProxyAddressTextBox = new System.Windows.Forms.TextBox();
            this.ProxyPortTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hostname";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PortTextBox
            // 
            this.PortTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.PortTextBox.Location = new System.Drawing.Point(272, 16);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(40, 20);
            this.PortTextBox.TabIndex = 3;
            this.PortTextBox.Text = "443";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.UsernameTextBox.Location = new System.Drawing.Point(100, 69);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(144, 20);
            this.UsernameTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.PasswordTextBox.Location = new System.Drawing.Point(100, 93);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(144, 20);
            this.PasswordTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Endpoint";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EndpointTextBox
            // 
            this.EndpointTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.EndpointTextBox.Location = new System.Drawing.Point(100, 43);
            this.EndpointTextBox.Name = "EndpointTextBox";
            this.EndpointTextBox.Size = new System.Drawing.Size(144, 20);
            this.EndpointTextBox.TabIndex = 2;
            this.EndpointTextBox.Text = "/iControl/iControlPortal.cgi";
            // 
            // OKLinkLabel
            // 
            this.OKLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.OKLinkLabel.Location = new System.Drawing.Point(260, 61);
            this.OKLinkLabel.Name = "OKLinkLabel";
            this.OKLinkLabel.Size = new System.Drawing.Size(40, 16);
            this.OKLinkLabel.TabIndex = 7;
            this.OKLinkLabel.TabStop = true;
            this.OKLinkLabel.Text = "OK";
            this.OKLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OKLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OKLinkLabel_LinkClicked);
            // 
            // CancelLinkLabel
            // 
            this.CancelLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.CancelLinkLabel.Location = new System.Drawing.Point(260, 85);
            this.CancelLinkLabel.Name = "CancelLinkLabel";
            this.CancelLinkLabel.Size = new System.Drawing.Size(40, 16);
            this.CancelLinkLabel.TabIndex = 8;
            this.CancelLinkLabel.TabStop = true;
            this.CancelLinkLabel.Text = "Cancel";
            this.CancelLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CancelLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CancelLinkLabel_LinkClicked);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = ":";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HostnameComboBox
            // 
            this.HostnameComboBox.FormattingEnabled = true;
            this.HostnameComboBox.Location = new System.Drawing.Point(112, 15);
            this.HostnameComboBox.Name = "HostnameComboBox";
            this.HostnameComboBox.Size = new System.Drawing.Size(144, 21);
            this.HostnameComboBox.TabIndex = 1;
            this.HostnameComboBox.SelectedIndexChanged += new System.EventHandler(this.HostnameComboBox_SelectedIndexChanged);
            // 
            // SaveConfigCheckBox
            // 
            this.SaveConfigCheckBox.AutoSize = true;
            this.SaveConfigCheckBox.Checked = true;
            this.SaveConfigCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SaveConfigCheckBox.Location = new System.Drawing.Point(100, 203);
            this.SaveConfigCheckBox.Name = "SaveConfigCheckBox";
            this.SaveConfigCheckBox.Size = new System.Drawing.Size(143, 17);
            this.SaveConfigCheckBox.TabIndex = 18;
            this.SaveConfigCheckBox.Text = "Save Connection Details";
            this.SaveConfigCheckBox.UseVisualStyleBackColor = true;
            // 
            // ClearLinkLabel
            // 
            this.ClearLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ClearLinkLabel.Location = new System.Drawing.Point(249, 202);
            this.ClearLinkLabel.Name = "ClearLinkLabel";
            this.ClearLinkLabel.Size = new System.Drawing.Size(67, 16);
            this.ClearLinkLabel.TabIndex = 19;
            this.ClearLinkLabel.TabStop = true;
            this.ClearLinkLabel.Text = "Clear History";
            this.ClearLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClearLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClearLinkLabel_LinkClicked);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(4, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "History";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ProxyUserTextBox);
            this.groupBox1.Controls.Add(this.ClearLinkLabel);
            this.groupBox1.Controls.Add(this.UsernameTextBox);
            this.groupBox1.Controls.Add(this.SaveConfigCheckBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ProxyPassTextBox);
            this.groupBox1.Controls.Add(this.EndpointTextBox);
            this.groupBox1.Controls.Add(this.UseProxyCheckBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PasswordTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.OKLinkLabel);
            this.groupBox1.Controls.Add(this.CancelLinkLabel);
            this.groupBox1.Controls.Add(this.ProxyAddressTextBox);
            this.groupBox1.Controls.Add(this.ProxyPortTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ProxyUserTextBox
            // 
            this.ProxyUserTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ProxyUserTextBox.Enabled = false;
            this.ProxyUserTextBox.Location = new System.Drawing.Point(101, 142);
            this.ProxyUserTextBox.Name = "ProxyUserTextBox";
            this.ProxyUserTextBox.Size = new System.Drawing.Size(144, 20);
            this.ProxyUserTextBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(5, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Username";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(5, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Password";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProxyPassTextBox
            // 
            this.ProxyPassTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ProxyPassTextBox.Enabled = false;
            this.ProxyPassTextBox.Location = new System.Drawing.Point(101, 166);
            this.ProxyPassTextBox.Name = "ProxyPassTextBox";
            this.ProxyPassTextBox.PasswordChar = '*';
            this.ProxyPassTextBox.Size = new System.Drawing.Size(144, 20);
            this.ProxyPassTextBox.TabIndex = 16;
            // 
            // UseProxyCheckBox
            // 
            this.UseProxyCheckBox.AutoSize = true;
            this.UseProxyCheckBox.Location = new System.Drawing.Point(33, 120);
            this.UseProxyCheckBox.Name = "UseProxyCheckBox";
            this.UseProxyCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UseProxyCheckBox.Size = new System.Drawing.Size(52, 17);
            this.UseProxyCheckBox.TabIndex = 9;
            this.UseProxyCheckBox.Text = "Proxy";
            this.UseProxyCheckBox.UseVisualStyleBackColor = true;
            this.UseProxyCheckBox.CheckedChanged += new System.EventHandler(this.UseProxyCheckBox_CheckedChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(243, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 32);
            this.label8.TabIndex = 11;
            this.label8.Text = ":";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProxyAddressTextBox
            // 
            this.ProxyAddressTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ProxyAddressTextBox.Enabled = false;
            this.ProxyAddressTextBox.Location = new System.Drawing.Point(101, 118);
            this.ProxyAddressTextBox.Name = "ProxyAddressTextBox";
            this.ProxyAddressTextBox.Size = new System.Drawing.Size(144, 20);
            this.ProxyAddressTextBox.TabIndex = 10;
            // 
            // ProxyPortTextBox
            // 
            this.ProxyPortTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ProxyPortTextBox.Enabled = false;
            this.ProxyPortTextBox.Location = new System.Drawing.Point(261, 118);
            this.ProxyPortTextBox.Name = "ProxyPortTextBox";
            this.ProxyPortTextBox.Size = new System.Drawing.Size(40, 20);
            this.ProxyPortTextBox.TabIndex = 12;
            this.ProxyPortTextBox.Text = "8080";
            // 
            // ConnectionDialog
            // 
            this.AcceptButton = this.OKLinkLabel;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.CancelLinkLabel;
            this.ClientSize = new System.Drawing.Size(350, 242);
            this.Controls.Add(this.HostnameComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connect to BIG-IP";
            this.Load += new System.EventHandler(this.ConnectionDialog_Load);
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.ConnectionDialog_HelpButtonClicked);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EndpointTextBox;

        private System.Windows.Forms.LinkLabel OKLinkLabel;
        private System.Windows.Forms.LinkLabel CancelLinkLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox HostnameComboBox;
        private System.Windows.Forms.CheckBox SaveConfigCheckBox;
        private System.Windows.Forms.LinkLabel ClearLinkLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox UseProxyCheckBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox ProxyPortTextBox;
		private System.Windows.Forms.TextBox ProxyAddressTextBox;
		private System.Windows.Forms.TextBox ProxyUserTextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox ProxyPassTextBox;
    
    }
}
