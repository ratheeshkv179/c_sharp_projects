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
    public partial class ViewLargeWallet : Form
    {
        public ViewLargeWallet(string walletName)
        {
            InitializeComponent();

            large_walletName.ReadOnly = true;
            large_walletName.Text = walletName;

            l_bankName.ReadOnly = true;
            l_accNumber.ReadOnly = true;
            l_address.ReadOnly = true;
            l_ifsc.ReadOnly = true;

            l_in_username.ReadOnly = true;
            l_in_tx_pwd.ReadOnly = true;
            l_in_tpin.ReadOnly = true;
            l_in_pwd.ReadOnly = true;

            l_dc_cardNumber.ReadOnly = true;
            l_dc_expDate.ReadOnly = true;
            l_dc_pin.ReadOnly = true;
            l_dc_cvv.ReadOnly = true;

            l_cc_cardNumber.ReadOnly = true;
            l_cc_expDate.ReadOnly = true;
            l_cc_pin.ReadOnly = true;
            l_cc_cvv.ReadOnly = true;


            l_additionalDetailsList.Items.Clear();
            l_additionalDetailsList.View = View.Details;



            Program.cmd = new System.Data.SqlClient.SqlCommand("select creationtime, lastupdate, additional_details, bank_name, bank_accountnumber, bank_ifsc, bank_address, ibank_username, ibank_password, ibank_txpassword, ibank_tpin, debitcard_number, debitcard_expdate, debitcard_pin, debitcard_cvv, creditcard_number, creditcard_expdate, creditcard_pin, creditcard_cvv from Wallet where walletname='" + walletName + "'", Program.conn);
            Program.conn.Open();
            SqlDataReader reader = Program.cmd.ExecuteReader();
            if (reader.Read())
            {
                largeWalletCreationTime.Text = "Created at     : " + reader.GetValue(0).ToString();
                largeWalletLastUpdationTime.Text = "Last Update at : " + reader.GetValue(1).ToString();
                string details = reader.GetValue(2).ToString();
                string[] rows = details.Split(new string[] { "&&" }, StringSplitOptions.None);

                for (var i = 0; i < rows.Length - 1; i++)
                {
                    string[] data = rows[i].Split(new string[] { "++" }, StringSplitOptions.None);
                    ListViewItem item = new ListViewItem(data);
                    l_additionalDetailsList.Items.Add(item);
                }

                l_bankName.Text = reader.GetValue(3).ToString();
                l_accNumber.Text = reader.GetValue(4).ToString();
                l_address.Text = reader.GetValue(6).ToString();
                l_ifsc.Text = reader.GetValue(5).ToString();

                l_in_username.Text = reader.GetValue(7).ToString();
                l_in_tx_pwd.Text = reader.GetValue(9).ToString();
                l_in_tpin.Text = reader.GetValue(10).ToString();
                l_in_pwd.Text = reader.GetValue(8).ToString();

                l_dc_cardNumber.Text = reader.GetValue(11).ToString();
                l_dc_expDate.Text = reader.GetValue(12).ToString();
                l_dc_pin.Text = reader.GetValue(13).ToString();
                l_dc_cvv.Text = reader.GetValue(14).ToString();

                l_cc_cardNumber.Text = reader.GetValue(15).ToString();
                l_cc_expDate.Text = reader.GetValue(16).ToString();
                l_cc_pin.Text = reader.GetValue(17).ToString();
                l_cc_cvv.Text = reader.GetValue(18).ToString();

            }
            Program.conn.Close();



            // largeWalletCreationTime
            // largeWalletLastUpdationTime
        }

        private void ViewLargeWallet_Load(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void l_additionalDetailsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
