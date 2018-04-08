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
    public partial class ViewSmallWallet : Form
    {
        public ViewSmallWallet(string walletName)
        {
            InitializeComponent();

            shortTemplateDetails.Items.Clear();
            shortTemplateDetails.View = View.Details;
            shortTemplateDetails.GridLines = true;
            smallWalletName.Text = walletName;
            smallWalletName.ReadOnly = true;

            Program.cmd = new System.Data.SqlClient.SqlCommand("select creationtime, lastupdate, additional_details from Wallet where walletname='" + walletName + "'", Program.conn);
            Program.conn.Open();
            SqlDataReader reader = Program.cmd.ExecuteReader();
            if (reader.Read())
            {
                smallWalletCreationTime.Text =     "Created at     : "+reader.GetValue(0).ToString();
                smallWalletLastUpdationTime.Text = "Last Update at : "+reader.GetValue(1).ToString();
                string details = reader.GetValue(2).ToString();
                string[] rows = details.Split(new string[] { "&&" }, StringSplitOptions.None);

                for (var i = 0;i<rows.Length-1;i++)
                {
                    string[] data = rows[i].Split(new string[] { "++" }, StringSplitOptions.None);
                    ListViewItem item = new ListViewItem(data);
                    shortTemplateDetails.Items.Add(item);
                }
            }
            Program.conn.Close();
        }

        private void smallWalletName_TextChanged(object sender, EventArgs e)
        {

        }

        private void shortTemplateDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
