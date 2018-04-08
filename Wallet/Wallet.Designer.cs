namespace Wallet
{
    partial class Wallet
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWalletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallWalletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeWalletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectWallet = new System.Windows.Forms.GroupBox();
            this.walletAction = new System.Windows.Forms.Button();
            this.wallet_names = new System.Windows.Forms.ComboBox();
            this.details = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.selectWallet.SuspendLayout();
            this.details.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addWalletToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // addWalletToolStripMenuItem
            // 
            this.addWalletToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallWalletToolStripMenuItem,
            this.largeWalletToolStripMenuItem});
            this.addWalletToolStripMenuItem.Name = "addWalletToolStripMenuItem";
            this.addWalletToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.addWalletToolStripMenuItem.Text = "New";
            this.addWalletToolStripMenuItem.Click += new System.EventHandler(this.addWalletToolStripMenuItem_Click);
            // 
            // smallWalletToolStripMenuItem
            // 
            this.smallWalletToolStripMenuItem.Name = "smallWalletToolStripMenuItem";
            this.smallWalletToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.smallWalletToolStripMenuItem.Text = "Small Wallet";
            this.smallWalletToolStripMenuItem.Click += new System.EventHandler(this.smallWalletToolStripMenuItem_Click);
            // 
            // largeWalletToolStripMenuItem
            // 
            this.largeWalletToolStripMenuItem.Name = "largeWalletToolStripMenuItem";
            this.largeWalletToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.largeWalletToolStripMenuItem.Text = "Large Wallet";
            this.largeWalletToolStripMenuItem.Click += new System.EventHandler(this.largeWalletToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.openToolStripMenuItem.Text = "View";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.exitToolStripMenuItem.Text = "Edit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // selectWallet
            // 
            this.selectWallet.Controls.Add(this.walletAction);
            this.selectWallet.Controls.Add(this.wallet_names);
            this.selectWallet.Location = new System.Drawing.Point(72, 66);
            this.selectWallet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectWallet.Name = "selectWallet";
            this.selectWallet.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectWallet.Size = new System.Drawing.Size(694, 188);
            this.selectWallet.TabIndex = 1;
            this.selectWallet.TabStop = false;
            this.selectWallet.Text = "Select Wallets";
            // 
            // walletAction
            // 
            this.walletAction.Location = new System.Drawing.Point(480, 86);
            this.walletAction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.walletAction.Name = "walletAction";
            this.walletAction.Size = new System.Drawing.Size(160, 35);
            this.walletAction.TabIndex = 1;
            this.walletAction.Text = "Open";
            this.walletAction.UseVisualStyleBackColor = true;
            this.walletAction.Click += new System.EventHandler(this.edit_view_wallet);
            // 
            // wallet_names
            // 
            this.wallet_names.DropDownHeight = 100;
            this.wallet_names.FormattingEnabled = true;
            this.wallet_names.IntegralHeight = false;
            this.wallet_names.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G"});
            this.wallet_names.Location = new System.Drawing.Point(72, 89);
            this.wallet_names.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wallet_names.Name = "wallet_names";
            this.wallet_names.Size = new System.Drawing.Size(367, 28);
            this.wallet_names.TabIndex = 0;
            this.wallet_names.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // details
            // 
            this.details.Controls.Add(this.label3);
            this.details.Controls.Add(this.label2);
            this.details.Controls.Add(this.label1);
            this.details.Location = new System.Drawing.Point(114, 263);
            this.details.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.details.Name = "details";
            this.details.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.details.Size = new System.Drawing.Size(622, 149);
            this.details.TabIndex = 2;
            this.details.TabStop = false;
            this.details.Text = "Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Version : 1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "mailto : ratheeshkv179@gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wallet : Free Software";
            // 
            // Wallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(843, 488);
            this.Controls.Add(this.details);
            this.Controls.Add(this.selectWallet);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Wallet";
            this.Text = "Wallet";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.selectWallet.ResumeLayout(false);
            this.details.ResumeLayout(false);
            this.details.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWalletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox selectWallet;
        private System.Windows.Forms.Button walletAction;
        private System.Windows.Forms.ComboBox wallet_names;
        private System.Windows.Forms.GroupBox details;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem smallWalletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeWalletToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

