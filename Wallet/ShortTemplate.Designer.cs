﻿namespace Wallet
{
    partial class ShortTemplate
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.shortTemplateDetails = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shortTemDetailValue = new System.Windows.Forms.TextBox();
            this.shortTemDetailName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorShrtWltName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorShrtWltValue = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.smallWalletName = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.saveShortTemplate = new System.Windows.Forms.Button();
            this.err_walletName = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_details = new System.Windows.Forms.ErrorProvider(this.components);
            this.duplicateSmallWalletName = new System.Windows.Forms.ErrorProvider(this.components);
            this.smallWalletCreationTime = new System.Windows.Forms.Label();
            this.smallWalletLastUpdationTime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorShrtWltName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorShrtWltValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_walletName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duplicateSmallWalletName)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.smallWalletLastUpdationTime);
            this.groupBox1.Controls.Add(this.smallWalletCreationTime);
            this.groupBox1.Controls.Add(this.shortTemplateDetails);
            this.groupBox1.Controls.Add(this.shortTemDetailValue);
            this.groupBox1.Controls.Add(this.shortTemDetailName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(18, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(945, 401);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // shortTemplateDetails
            // 
            this.shortTemplateDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.shortTemplateDetails.Location = new System.Drawing.Point(392, 20);
            this.shortTemplateDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shortTemplateDetails.MultiSelect = false;
            this.shortTemplateDetails.Name = "shortTemplateDetails";
            this.shortTemplateDetails.Size = new System.Drawing.Size(493, 313);
            this.shortTemplateDetails.TabIndex = 8;
            this.shortTemplateDetails.UseCompatibleStateImageBehavior = false;
            this.shortTemplateDetails.SelectedIndexChanged += new System.EventHandler(this.shortTemplateDetails_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "Name";
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 165;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "Value";
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 165;
            // 
            // shortTemDetailValue
            // 
            this.shortTemDetailValue.Location = new System.Drawing.Point(122, 100);
            this.shortTemDetailValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shortTemDetailValue.Name = "shortTemDetailValue";
            this.shortTemDetailValue.Size = new System.Drawing.Size(211, 26);
            this.shortTemDetailValue.TabIndex = 7;
            this.shortTemDetailValue.TextChanged += new System.EventHandler(this.shortTemDetailValue_TextChanged);
            // 
            // shortTemDetailName
            // 
            this.shortTemDetailName.Location = new System.Drawing.Point(122, 46);
            this.shortTemDetailName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shortTemDetailName.Name = "shortTemDetailName";
            this.shortTemDetailName.Size = new System.Drawing.Size(211, 26);
            this.shortTemDetailName.TabIndex = 6;
            this.shortTemDetailName.TextChanged += new System.EventHandler(this.shortTemDetailName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Value";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(774, 343);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.deleteShortTemDetails);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 162);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.addShortTemDetails);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 163);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Clear All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.clear_shorttemdetails);
            // 
            // errorShrtWltName
            // 
            this.errorShrtWltName.ContainerControl = this;
            // 
            // errorShrtWltValue
            // 
            this.errorShrtWltValue.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Wallet Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // smallWalletName
            // 
            this.smallWalletName.Location = new System.Drawing.Point(140, 35);
            this.smallWalletName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.smallWalletName.Name = "smallWalletName";
            this.smallWalletName.Size = new System.Drawing.Size(250, 26);
            this.smallWalletName.TabIndex = 2;
            this.smallWalletName.TextChanged += new System.EventHandler(this.smallWalletNameChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(670, 40);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "Clear All";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.smallWallet_clearAllData);
            // 
            // saveShortTemplate
            // 
            this.saveShortTemplate.Location = new System.Drawing.Point(792, 40);
            this.saveShortTemplate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveShortTemplate.Name = "saveShortTemplate";
            this.saveShortTemplate.Size = new System.Drawing.Size(112, 35);
            this.saveShortTemplate.TabIndex = 4;
            this.saveShortTemplate.Text = "Save";
            this.saveShortTemplate.UseVisualStyleBackColor = true;
            this.saveShortTemplate.Click += new System.EventHandler(this.smallWalletSaveData);
            // 
            // err_walletName
            // 
            this.err_walletName.ContainerControl = this;
            // 
            // err_details
            // 
            this.err_details.ContainerControl = this;
            // 
            // duplicateSmallWalletName
            // 
            this.duplicateSmallWalletName.ContainerControl = this;
            // 
            // smallWalletCreationTime
            // 
            this.smallWalletCreationTime.AutoSize = true;
            this.smallWalletCreationTime.Location = new System.Drawing.Point(12, 280);
            this.smallWalletCreationTime.Name = "smallWalletCreationTime";
            this.smallWalletCreationTime.Size = new System.Drawing.Size(0, 20);
            this.smallWalletCreationTime.TabIndex = 9;
            // 
            // smallWalletLastUpdationTime
            // 
            this.smallWalletLastUpdationTime.AutoSize = true;
            this.smallWalletLastUpdationTime.Location = new System.Drawing.Point(12, 327);
            this.smallWalletLastUpdationTime.Name = "smallWalletLastUpdationTime";
            this.smallWalletLastUpdationTime.Size = new System.Drawing.Size(0, 20);
            this.smallWalletLastUpdationTime.TabIndex = 10;
            // 
            // ShortTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 504);
            this.Controls.Add(this.saveShortTemplate);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.smallWalletName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ShortTemplate";
            this.Text = "Small Wallet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorShrtWltName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorShrtWltValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_walletName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duplicateSmallWalletName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView shortTemplateDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox shortTemDetailValue;
        private System.Windows.Forms.TextBox shortTemDetailName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorShrtWltName;
        private System.Windows.Forms.ErrorProvider errorShrtWltValue;
        private System.Windows.Forms.TextBox smallWalletName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveShortTemplate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ErrorProvider err_walletName;
        private System.Windows.Forms.ErrorProvider err_details;
        private System.Windows.Forms.ErrorProvider duplicateSmallWalletName;
        private System.Windows.Forms.Label smallWalletLastUpdationTime;
        private System.Windows.Forms.Label smallWalletCreationTime;
    }
}