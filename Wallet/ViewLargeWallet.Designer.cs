namespace Wallet
{
    partial class ViewLargeWallet
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
            this.components = new System.ComponentModel.Container();
            this.err_l_walletName = new System.Windows.Forms.ErrorProvider(this.components);
            this.duplicateLargeWalletName = new System.Windows.Forms.ErrorProvider(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.l_address = new System.Windows.Forms.TextBox();
            this.l_ifsc = new System.Windows.Forms.TextBox();
            this.l_accNumber = new System.Windows.Forms.TextBox();
            this.l_bankName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.l_in_tx_pwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.l_cc_expDate = new System.Windows.Forms.MaskedTextBox();
            this.l_cc_cvv = new System.Windows.Forms.MaskedTextBox();
            this.l_cc_cardNumber = new System.Windows.Forms.MaskedTextBox();
            this.l_cc_pin = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.l_dc_expDate = new System.Windows.Forms.MaskedTextBox();
            this.l_dc_cvv = new System.Windows.Forms.MaskedTextBox();
            this.l_dc_pin = new System.Windows.Forms.MaskedTextBox();
            this.l_dc_cardNumber = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.err_noDetails = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.l_in_tpin = new System.Windows.Forms.TextBox();
            this.l_in_pwd = new System.Windows.Forms.TextBox();
            this.l_in_username = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errorAdditionalDetailsValue = new System.Windows.Forms.ErrorProvider(this.components);
            this.large_walletName = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.l_additionalDetailsList = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorAdditionalDetailsName = new System.Windows.Forms.ErrorProvider(this.components);
            this.largeWalletCreationTime = new System.Windows.Forms.Label();
            this.largeWalletLastUpdationTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.err_l_walletName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duplicateLargeWalletName)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_noDetails)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorAdditionalDetailsValue)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorAdditionalDetailsName)).BeginInit();
            this.SuspendLayout();
            // 
            // err_l_walletName
            // 
            this.err_l_walletName.ContainerControl = this;
            // 
            // duplicateLargeWalletName
            // 
            this.duplicateLargeWalletName.ContainerControl = this;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Card Number";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.l_address);
            this.groupBox1.Controls.Add(this.l_ifsc);
            this.groupBox1.Controls.Add(this.l_accNumber);
            this.groupBox1.Controls.Add(this.l_bankName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(63, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 241);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bank Details";
            // 
            // l_address
            // 
            this.l_address.Location = new System.Drawing.Point(176, 143);
            this.l_address.Multiline = true;
            this.l_address.Name = "l_address";
            this.l_address.Size = new System.Drawing.Size(211, 79);
            this.l_address.TabIndex = 7;
            // 
            // l_ifsc
            // 
            this.l_ifsc.Location = new System.Drawing.Point(176, 106);
            this.l_ifsc.Name = "l_ifsc";
            this.l_ifsc.Size = new System.Drawing.Size(211, 26);
            this.l_ifsc.TabIndex = 6;
            // 
            // l_accNumber
            // 
            this.l_accNumber.Location = new System.Drawing.Point(176, 71);
            this.l_accNumber.Name = "l_accNumber";
            this.l_accNumber.Size = new System.Drawing.Size(211, 26);
            this.l_accNumber.TabIndex = 5;
            // 
            // l_bankName
            // 
            this.l_bankName.Location = new System.Drawing.Point(176, 34);
            this.l_bankName.Name = "l_bankName";
            this.l_bankName.Size = new System.Drawing.Size(211, 26);
            this.l_bankName.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "IFSC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Account Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bank Name";
            // 
            // l_in_tx_pwd
            // 
            this.l_in_tx_pwd.Location = new System.Drawing.Point(148, 106);
            this.l_in_tx_pwd.Name = "l_in_tx_pwd";
            this.l_in_tx_pwd.Size = new System.Drawing.Size(262, 26);
            this.l_in_tx_pwd.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name";
            // 
            // l_cc_expDate
            // 
            this.l_cc_expDate.Location = new System.Drawing.Point(148, 74);
            this.l_cc_expDate.Mask = "00/00";
            this.l_cc_expDate.Name = "l_cc_expDate";
            this.l_cc_expDate.Size = new System.Drawing.Size(100, 26);
            this.l_cc_expDate.TabIndex = 13;
            // 
            // l_cc_cvv
            // 
            this.l_cc_cvv.Location = new System.Drawing.Point(148, 145);
            this.l_cc_cvv.Mask = "000";
            this.l_cc_cvv.Name = "l_cc_cvv";
            this.l_cc_cvv.Size = new System.Drawing.Size(100, 26);
            this.l_cc_cvv.TabIndex = 12;
            // 
            // l_cc_cardNumber
            // 
            this.l_cc_cardNumber.Location = new System.Drawing.Point(148, 38);
            this.l_cc_cardNumber.Mask = "0000-0000-0000-0000";
            this.l_cc_cardNumber.Name = "l_cc_cardNumber";
            this.l_cc_cardNumber.Size = new System.Drawing.Size(262, 26);
            this.l_cc_cardNumber.TabIndex = 12;
            // 
            // l_cc_pin
            // 
            this.l_cc_pin.Location = new System.Drawing.Point(148, 109);
            this.l_cc_pin.Mask = "0000";
            this.l_cc_pin.Name = "l_cc_pin";
            this.l_cc_pin.Size = new System.Drawing.Size(100, 26);
            this.l_cc_pin.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 142);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 20);
            this.label16.TabIndex = 7;
            this.label16.Text = "CVV";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 111);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 20);
            this.label17.TabIndex = 6;
            this.label17.Text = "PIN";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 75);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 20);
            this.label18.TabIndex = 5;
            this.label18.Text = "Expiry Date";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 20);
            this.label19.TabIndex = 4;
            this.label19.Text = "Card Number";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.l_dc_expDate);
            this.groupBox4.Controls.Add(this.l_dc_cvv);
            this.groupBox4.Controls.Add(this.l_dc_pin);
            this.groupBox4.Controls.Add(this.l_dc_cardNumber);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(63, 362);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(412, 210);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Debit Card Details";
            // 
            // l_dc_expDate
            // 
            this.l_dc_expDate.Location = new System.Drawing.Point(142, 74);
            this.l_dc_expDate.Mask = "00/00";
            this.l_dc_expDate.Name = "l_dc_expDate";
            this.l_dc_expDate.Size = new System.Drawing.Size(100, 26);
            this.l_dc_expDate.TabIndex = 11;
            // 
            // l_dc_cvv
            // 
            this.l_dc_cvv.Location = new System.Drawing.Point(142, 145);
            this.l_dc_cvv.Mask = "000";
            this.l_dc_cvv.Name = "l_dc_cvv";
            this.l_dc_cvv.Size = new System.Drawing.Size(100, 26);
            this.l_dc_cvv.TabIndex = 10;
            // 
            // l_dc_pin
            // 
            this.l_dc_pin.Location = new System.Drawing.Point(142, 109);
            this.l_dc_pin.Mask = "0000";
            this.l_dc_pin.Name = "l_dc_pin";
            this.l_dc_pin.Size = new System.Drawing.Size(100, 26);
            this.l_dc_pin.TabIndex = 9;
            // 
            // l_dc_cardNumber
            // 
            this.l_dc_cardNumber.Location = new System.Drawing.Point(142, 38);
            this.l_dc_cardNumber.Mask = "0000-0000-0000-0000";
            this.l_dc_cardNumber.Name = "l_dc_cardNumber";
            this.l_dc_cardNumber.Size = new System.Drawing.Size(244, 26);
            this.l_dc_cardNumber.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 142);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "CVV";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "PIN";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Expiry Date";
            // 
            // err_noDetails
            // 
            this.err_noDetails.ContainerControl = this;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.l_cc_expDate);
            this.groupBox3.Controls.Add(this.l_cc_cvv);
            this.groupBox3.Controls.Add(this.l_cc_cardNumber);
            this.groupBox3.Controls.Add(this.l_cc_pin);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Location = new System.Drawing.Point(520, 362);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(453, 210);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Credit Card Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.l_in_tpin);
            this.groupBox2.Controls.Add(this.l_in_tx_pwd);
            this.groupBox2.Controls.Add(this.l_in_pwd);
            this.groupBox2.Controls.Add(this.l_in_username);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(520, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 202);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Internet Banking Details";
            // 
            // l_in_tpin
            // 
            this.l_in_tpin.Location = new System.Drawing.Point(148, 143);
            this.l_in_tpin.Name = "l_in_tpin";
            this.l_in_tpin.Size = new System.Drawing.Size(262, 26);
            this.l_in_tpin.TabIndex = 7;
            // 
            // l_in_pwd
            // 
            this.l_in_pwd.Location = new System.Drawing.Point(148, 69);
            this.l_in_pwd.Name = "l_in_pwd";
            this.l_in_pwd.Size = new System.Drawing.Size(262, 26);
            this.l_in_pwd.TabIndex = 5;
            // 
            // l_in_username
            // 
            this.l_in_username.Location = new System.Drawing.Point(148, 32);
            this.l_in_username.Name = "l_in_username";
            this.l_in_username.Size = new System.Drawing.Size(262, 26);
            this.l_in_username.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "TPIN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tx Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Username";
            // 
            // errorAdditionalDetailsValue
            // 
            this.errorAdditionalDetailsValue.ContainerControl = this;
            // 
            // large_walletName
            // 
            this.large_walletName.Location = new System.Drawing.Point(135, 50);
            this.large_walletName.Name = "large_walletName";
            this.large_walletName.Size = new System.Drawing.Size(340, 26);
            this.large_walletName.TabIndex = 27;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.l_additionalDetailsList);
            this.groupBox5.Location = new System.Drawing.Point(62, 591);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(910, 378);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Additional Details";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // l_additionalDetailsList
            // 
            this.l_additionalDetailsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colValue});
            this.l_additionalDetailsList.Location = new System.Drawing.Point(25, 43);
            this.l_additionalDetailsList.MultiSelect = false;
            this.l_additionalDetailsList.Name = "l_additionalDetailsList";
            this.l_additionalDetailsList.Size = new System.Drawing.Size(538, 205);
            this.l_additionalDetailsList.TabIndex = 7;
            this.l_additionalDetailsList.UseCompatibleStateImageBehavior = false;
            this.l_additionalDetailsList.View = System.Windows.Forms.View.Details;
            this.l_additionalDetailsList.SelectedIndexChanged += new System.EventHandler(this.l_additionalDetailsList_SelectedIndexChanged);
            // 
            // colName
            // 
            this.colName.Tag = "Name";
            this.colName.Text = "Name";
            this.colName.Width = 158;
            // 
            // colValue
            // 
            this.colValue.Tag = "Value";
            this.colValue.Text = "Value";
            this.colValue.Width = 145;
            // 
            // errorAdditionalDetailsName
            // 
            this.errorAdditionalDetailsName.ContainerControl = this;
            // 
            // largeWalletCreationTime
            // 
            this.largeWalletCreationTime.AutoSize = true;
            this.largeWalletCreationTime.Location = new System.Drawing.Point(59, 870);
            this.largeWalletCreationTime.Name = "largeWalletCreationTime";
            this.largeWalletCreationTime.Size = new System.Drawing.Size(9, 20);
            this.largeWalletCreationTime.TabIndex = 28;
            this.largeWalletCreationTime.Text = "\r\n";
            // 
            // largeWalletLastUpdationTime
            // 
            this.largeWalletLastUpdationTime.AutoSize = true;
            this.largeWalletLastUpdationTime.Location = new System.Drawing.Point(59, 907);
            this.largeWalletLastUpdationTime.Name = "largeWalletLastUpdationTime";
            this.largeWalletLastUpdationTime.Size = new System.Drawing.Size(0, 20);
            this.largeWalletLastUpdationTime.TabIndex = 29;
            // 
            // ViewLargeWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1030, 1038);
            this.Controls.Add(this.largeWalletLastUpdationTime);
            this.Controls.Add(this.largeWalletCreationTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.large_walletName);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ViewLargeWallet";
            this.Text = "ViewLargeWallet";
            this.Load += new System.EventHandler(this.ViewLargeWallet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err_l_walletName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duplicateLargeWalletName)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_noDetails)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorAdditionalDetailsValue)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorAdditionalDetailsName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider err_l_walletName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox l_address;
        private System.Windows.Forms.TextBox l_ifsc;
        private System.Windows.Forms.TextBox l_accNumber;
        private System.Windows.Forms.TextBox l_bankName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MaskedTextBox l_dc_expDate;
        private System.Windows.Forms.MaskedTextBox l_dc_cvv;
        private System.Windows.Forms.MaskedTextBox l_dc_pin;
        private System.Windows.Forms.MaskedTextBox l_dc_cardNumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox l_cc_expDate;
        private System.Windows.Forms.MaskedTextBox l_cc_cvv;
        private System.Windows.Forms.MaskedTextBox l_cc_cardNumber;
        private System.Windows.Forms.MaskedTextBox l_cc_pin;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox l_in_tpin;
        private System.Windows.Forms.TextBox l_in_tx_pwd;
        private System.Windows.Forms.TextBox l_in_pwd;
        private System.Windows.Forms.TextBox l_in_username;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox large_walletName;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView l_additionalDetailsList;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colValue;
        private System.Windows.Forms.ErrorProvider duplicateLargeWalletName;
        private System.Windows.Forms.ErrorProvider err_noDetails;
        private System.Windows.Forms.ErrorProvider errorAdditionalDetailsValue;
        private System.Windows.Forms.ErrorProvider errorAdditionalDetailsName;
        private System.Windows.Forms.Label largeWalletCreationTime;
        private System.Windows.Forms.Label largeWalletLastUpdationTime;
    }
}