using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            
            selectWallet.Show();
            walletAction.Text = "Edit";
            details.Hide();
            wallet_names.Items.Clear();

            Program.cmd = new System.Data.SqlClient.SqlCommand("select Wallet.walletname from Wallet", Program.conn);
            Program.conn.Open();
            SqlDataReader reader = Program.cmd.ExecuteReader();

            while (reader.Read())
            {
                wallet_names.Items.Add(reader.GetValue(0));
            }
            Program.conn.Close();
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
            
            selectWallet.Show();
            walletAction.Text = "View";
            details.Hide();
            wallet_names.Items.Clear();

            Program.cmd = new System.Data.SqlClient.SqlCommand("select Wallet.walletname from Wallet", Program.conn);
            Program.conn.Open();
            SqlDataReader reader = Program.cmd.ExecuteReader();

            while (reader.Read())
            {
                wallet_names.Items.Add(reader.GetValue(0));
            }
            Program.conn.Close();

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void edit_view_wallet(object sender, EventArgs e)
        {
            if (walletAction.Text == "View")
            {
                Program.cmd = new System.Data.SqlClient.SqlCommand("select type_of_wallet from Wallet where walletname='" + wallet_names.Text + "'", Program.conn);
                Program.conn.Open();
                SqlDataReader reader = Program.cmd.ExecuteReader();

                if (reader.Read())
                {
                    if (reader.GetValue(0).ToString().Trim().Equals("Small"))
                    {
                        Program.conn.Close();
                        new ViewSmallWallet(wallet_names.Text).Show();
                    }
                    else if (reader.GetValue(0).ToString().Trim().Equals("Large"))
                    {
                        Program.conn.Close();
                        new ViewLargeWallet(wallet_names.Text).Show();
                    }
                }
            }
            else if (walletAction.Text == "Edit")
            {
                Program.cmd = new System.Data.SqlClient.SqlCommand("select type_of_wallet from Wallet where walletname='" + wallet_names.Text + "'", Program.conn);
                Program.conn.Open();
                SqlDataReader reader = Program.cmd.ExecuteReader();

                if (reader.Read())
                {
                    if (reader.GetValue(0).ToString().Trim().Equals("Small"))
                    {
                        Program.conn.Close();
                        new ShortTemplate(wallet_names.Text).Show();
                    }
                    else if (reader.GetValue(0).ToString().Trim().Equals("Large"))
                    {
                        Program.conn.Close();
                        new Template(wallet_names.Text).Show();
                    }
                }
            }
            else if (walletAction.Text == "Delete")
            {
                DialogResult result = MessageBox.Show("Are you sure to delete Wallet : "+ wallet_names.Text,"Delete Wallet", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Program.cmd = new System.Data.SqlClient.SqlCommand("delete from Wallet where walletname='"+ wallet_names.Text + "'", Program.conn);
                    Program.conn.Open();
                    Program.cmd.ExecuteNonQuery();
                    Program.conn.Close();
                    wallet_names.Items.Clear();
                    Program.cmd = new System.Data.SqlClient.SqlCommand("select Wallet.walletname from Wallet", Program.conn);
                    Program.conn.Open();
                    SqlDataReader reader = Program.cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        wallet_names.Items.Add(reader.GetValue(0));
                    }
                    Program.conn.Close();
                    wallet_names.Text = "";
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            selectWallet.Show();
            walletAction.Text = "Delete";
            details.Hide();
            wallet_names.Items.Clear();

            Program.cmd = new System.Data.SqlClient.SqlCommand("select Wallet.walletname from Wallet", Program.conn);
            Program.conn.Open();
            SqlDataReader reader = Program.cmd.ExecuteReader();

            while (reader.Read())
            {
                wallet_names.Items.Add(reader.GetValue(0));
            }
            Program.conn.Close();
        }
    }
}
