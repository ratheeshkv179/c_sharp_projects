namespace Wallet
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shortTemDetailName = new System.Windows.Forms.TextBox();
            this.shortTemDetailValue = new System.Windows.Forms.TextBox();
            this.shortTemplateDetails = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorShrtWltName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorShrtWltValue = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorShrtWltName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorShrtWltValue)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.shortTemplateDetails);
            this.groupBox1.Controls.Add(this.shortTemDetailValue);
            this.groupBox1.Controls.Add(this.shortTemDetailName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 323);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Details";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Clear All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.clear_shorttemdetails);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.addShortTemDetails);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(516, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.deleteShortTemDetails);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Value";
            // 
            // shortTemDetailName
            // 
            this.shortTemDetailName.Location = new System.Drawing.Point(81, 30);
            this.shortTemDetailName.Name = "shortTemDetailName";
            this.shortTemDetailName.Size = new System.Drawing.Size(142, 20);
            this.shortTemDetailName.TabIndex = 6;
            // 
            // shortTemDetailValue
            // 
            this.shortTemDetailValue.Location = new System.Drawing.Point(81, 65);
            this.shortTemDetailValue.Name = "shortTemDetailValue";
            this.shortTemDetailValue.Size = new System.Drawing.Size(142, 20);
            this.shortTemDetailValue.TabIndex = 7;
            // 
            // shortTemplateDetails
            // 
            this.shortTemplateDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.shortTemplateDetails.Location = new System.Drawing.Point(258, 30);
            this.shortTemplateDetails.Name = "shortTemplateDetails";
            this.shortTemplateDetails.Size = new System.Drawing.Size(330, 247);
            this.shortTemplateDetails.TabIndex = 8;
            this.shortTemplateDetails.UseCompatibleStateImageBehavior = false;
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
            // errorShrtWltName
            // 
            this.errorShrtWltName.ContainerControl = this;
            // 
            // errorShrtWltValue
            // 
            this.errorShrtWltValue.ContainerControl = this;
            // 
            // ShortTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 375);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShortTemplate";
            this.Text = "Small Wallet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorShrtWltName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorShrtWltValue)).EndInit();
            this.ResumeLayout(false);

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
    }
}