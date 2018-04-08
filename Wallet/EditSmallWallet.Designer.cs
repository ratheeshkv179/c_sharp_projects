namespace Wallet
{
    partial class EditSmallWallet
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
            this.duplicateSmallWalletName = new System.Windows.Forms.ErrorProvider(this.components);
            this.shortTemplateDetails = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.err_walletName = new System.Windows.Forms.ErrorProvider(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.addDetailValue = new System.Windows.Forms.TextBox();
            this.addDetailName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.smallWalletName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.errorShrtWltName = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.err_details = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorShrtWltValue = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.smallWalletCreationTime = new System.Windows.Forms.Label();
            this.smallWalletLastUpdationTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.duplicateSmallWalletName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_walletName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorShrtWltName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorShrtWltValue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // duplicateSmallWalletName
            // 
            this.duplicateSmallWalletName.ContainerControl = this;
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
            // err_walletName
            // 
            this.err_walletName.ContainerControl = this;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(799, 30);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 35);
            this.button5.TabIndex = 9;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // addDetailValue
            // 
            this.addDetailValue.Location = new System.Drawing.Point(122, 100);
            this.addDetailValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addDetailValue.Name = "addDetailValue";
            this.addDetailValue.Size = new System.Drawing.Size(211, 26);
            this.addDetailValue.TabIndex = 7;
            // 
            // addDetailName
            // 
            this.addDetailName.Location = new System.Drawing.Point(122, 46);
            this.addDetailName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addDetailName.Name = "addDetailName";
            this.addDetailName.Size = new System.Drawing.Size(211, 26);
            this.addDetailName.TabIndex = 6;
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
            this.button3.Click += new System.EventHandler(this.deleteSelected_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(532, 30);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 35);
            this.button4.TabIndex = 8;
            this.button4.Text = "Clear All";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.clearAllDetails_click);
            // 
            // smallWalletName
            // 
            this.smallWalletName.Location = new System.Drawing.Point(147, 25);
            this.smallWalletName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.smallWalletName.Name = "smallWalletName";
            this.smallWalletName.Size = new System.Drawing.Size(250, 26);
            this.smallWalletName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wallet Name";
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
            this.button2.Click += new System.EventHandler(this.addDetails_Click);
            // 
            // errorShrtWltName
            // 
            this.errorShrtWltName.ContainerControl = this;
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
            this.button1.Click += new System.EventHandler(this.clearDetails_Click);
            // 
            // err_details
            // 
            this.err_details.ContainerControl = this;
            // 
            // errorShrtWltValue
            // 
            this.errorShrtWltValue.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.smallWalletLastUpdationTime);
            this.groupBox1.Controls.Add(this.smallWalletCreationTime);
            this.groupBox1.Controls.Add(this.shortTemplateDetails);
            this.groupBox1.Controls.Add(this.addDetailValue);
            this.groupBox1.Controls.Add(this.addDetailName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(25, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(945, 401);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Details";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(651, 30);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(141, 35);
            this.button6.TabIndex = 10;
            this.button6.Text = "Delete Wallet";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // smallWalletCreationTime
            // 
            this.smallWalletCreationTime.AutoSize = true;
            this.smallWalletCreationTime.Location = new System.Drawing.Point(7, 272);
            this.smallWalletCreationTime.Name = "smallWalletCreationTime";
            this.smallWalletCreationTime.Size = new System.Drawing.Size(0, 20);
            this.smallWalletCreationTime.TabIndex = 9;
            // 
            // smallWalletLastUpdationTime
            // 
            this.smallWalletLastUpdationTime.AutoSize = true;
            this.smallWalletLastUpdationTime.Location = new System.Drawing.Point(7, 313);
            this.smallWalletLastUpdationTime.Name = "smallWalletLastUpdationTime";
            this.smallWalletLastUpdationTime.Size = new System.Drawing.Size(0, 20);
            this.smallWalletLastUpdationTime.TabIndex = 10;
            // 
            // EditSmallWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 502);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.smallWalletName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditSmallWallet";
            this.Text = "EditSmallWallet";
            ((System.ComponentModel.ISupportInitialize)(this.duplicateSmallWalletName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_walletName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorShrtWltName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorShrtWltValue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider duplicateSmallWalletName;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox smallWalletName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView shortTemplateDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox addDetailValue;
        private System.Windows.Forms.TextBox addDetailName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider err_walletName;
        private System.Windows.Forms.ErrorProvider errorShrtWltName;
        private System.Windows.Forms.ErrorProvider err_details;
        private System.Windows.Forms.ErrorProvider errorShrtWltValue;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label smallWalletLastUpdationTime;
        private System.Windows.Forms.Label smallWalletCreationTime;
    }
}