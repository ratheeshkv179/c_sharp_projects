using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wallet
{
    public partial class Wallet : Form
    {
        public Wallet()
        {
            InitializeComponent();
            selectWallet.Hide();
            details.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            details.Hide();
            selectWallet.Show();
            walletAction.Text = "Edit";
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectWallet.Hide();
            details.Show();
            //new About().Show();


        }

        private void addWalletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            details.Hide();
            selectWallet.Show();
            walletAction.Text = "Open";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void details_Enter(object sender, EventArgs e)
        {

        }

        private void smallWalletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectWallet.Hide();
            details.Show();
            new ShortTemplate().Show();
        }

        private void largeWalletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectWallet.Hide();
            details.Show();
            new Template().Show();
        }
    }
}
