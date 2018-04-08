namespace Wallet
{
    partial class ViewSmallWallet
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
            this.err_walletName = new System.Windows.Forms.ErrorProvider(this.components);
            this.smallWalletName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorShrtWltValue = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorShrtWltName = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_details = new System.Windows.Forms.ErrorProvider(this.components);
            this.shortTemplateDetails = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.smallWalletLastUpdationTime = new System.Windows.Forms.Label();
            this.smallWalletCreationTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.duplicateSmallWalletName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_walletName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorShrtWltValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorShrtWltName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_details)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // duplicateSmallWalletName
            // 
            this.duplicateSmallWalletName.ContainerControl = this;
            // 
            // err_walletName
            // 
            this.err_walletName.ContainerControl = this;
            // 
            // smallWalletName
            // 
            this.smallWalletName.Location = new System.Drawing.Point(139, 21);
            this.smallWalletName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.smallWalletName.Name = "smallWalletName";
            this.smallWalletName.Size = new System.Drawing.Size(250, 26);
            this.smallWalletName.TabIndex = 7;
            this.smallWalletName.TextChanged += new System.EventHandler(this.smallWalletName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wallet Name";
            // 
            // errorShrtWltValue
            // 
            this.errorShrtWltValue.ContainerControl = this;
            // 
            // errorShrtWltName
            // 
            this.errorShrtWltName.ContainerControl = this;
            // 
            // err_details
            // 
            this.err_details.ContainerControl = this;
            // 
            // shortTemplateDetails
            // 
            this.shortTemplateDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.shortTemplateDetails.Location = new System.Drawing.Point(35, 29);
            this.shortTemplateDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shortTemplateDetails.MultiSelect = false;
            this.shortTemplateDetails.Name = "shortTemplateDetails";
            this.shortTemplateDetails.Size = new System.Drawing.Size(628, 329);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.smallWalletLastUpdationTime);
            this.groupBox1.Controls.Add(this.smallWalletCreationTime);
            this.groupBox1.Controls.Add(this.shortTemplateDetails);
            this.groupBox1.Location = new System.Drawing.Point(17, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(695, 461);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // smallWalletLastUpdationTime
            // 
            this.smallWalletLastUpdationTime.AutoSize = true;
            this.smallWalletLastUpdationTime.Location = new System.Drawing.Point(20, 416);
            this.smallWalletLastUpdationTime.Name = "smallWalletLastUpdationTime";
            this.smallWalletLastUpdationTime.Size = new System.Drawing.Size(0, 20);
            this.smallWalletLastUpdationTime.TabIndex = 10;
            // 
            // smallWalletCreationTime
            // 
            this.smallWalletCreationTime.AutoSize = true;
            this.smallWalletCreationTime.Location = new System.Drawing.Point(20, 376);
            this.smallWalletCreationTime.Name = "smallWalletCreationTime";
            this.smallWalletCreationTime.Size = new System.Drawing.Size(0, 20);
            this.smallWalletCreationTime.TabIndex = 9;
            // 
            // ViewSmallWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 553);
            this.Controls.Add(this.smallWalletName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ViewSmallWallet";
            this.Text = "SmallWallet";
            ((System.ComponentModel.ISupportInitialize)(this.duplicateSmallWalletName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_walletName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorShrtWltValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorShrtWltName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_details)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider duplicateSmallWalletName;
        private System.Windows.Forms.TextBox smallWalletName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView shortTemplateDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ErrorProvider err_walletName;
        private System.Windows.Forms.ErrorProvider errorShrtWltValue;
        private System.Windows.Forms.ErrorProvider errorShrtWltName;
        private System.Windows.Forms.ErrorProvider err_details;
        private System.Windows.Forms.Label smallWalletLastUpdationTime;
        private System.Windows.Forms.Label smallWalletCreationTime;
    }
}