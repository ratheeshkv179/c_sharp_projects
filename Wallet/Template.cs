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
    public partial class Template : Form
    {
        string walletId = "";
        public Template()
        {
            InitializeComponent();
            l_additionalDetailsList.View = View.Details;
            save_largeWallet.Text = "Save";
            largeWalletCreationTime.Text = "";
            largeWalletLastUpdationTime.Text = "";
        }

        public Template(string walletName)
        {
            InitializeComponent();
            l_additionalDetailsList.Items.Clear();
            l_additionalDetailsList.View = View.Details;
            save_largeWallet.Text = "Update";
            walletId = "";
            large_walletName.Text = walletName;


            Program.cmd = new System.Data.SqlClient.SqlCommand("select creationtime, lastupdate, additional_details, bank_name, bank_accountnumber, bank_ifsc, bank_address, ibank_username, ibank_password, ibank_txpassword, ibank_tpin, debitcard_number, debitcard_expdate, debitcard_pin, debitcard_cvv, creditcard_number, creditcard_expdate, creditcard_pin, creditcard_cvv,id from Wallet where walletname='" + walletName + "'", Program.conn);
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
                walletId = reader.GetValue(19).ToString();

            }
            Program.conn.Close();



        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void clearAllDetails_Click(object sender, EventArgs e)
        {
            errorAdditionalDetailsName.Clear();
            errorAdditionalDetailsValue.Clear();
            l_additionalDetailsName.Text = "";
            l_additionalDetailsValue.Text = "";
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void additionalDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addDetail_Click(object sender, EventArgs e)
        {

        }

        private void clearAllDetails_Click_1(object sender, EventArgs e)
        {
            l_additionalDetailsName.Text = "";
            l_additionalDetailsValue.Text = "";
        }

        private void additionalDetails_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void additionalDetails_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void addDetails_Click(object sender, EventArgs e)
        {

        }

        private void clearAll_click(object sender, EventArgs e)
        {
            l_additionalDetailsList.Items.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void largeTemplate_clearAll_click(object sender, EventArgs e)
        {
            err_l_walletName.Clear();
            errorAdditionalDetailsValue.Clear();
            errorAdditionalDetailsName.Clear();

            large_walletName.Text = "";
            l_bankName.Text = "";
            l_accNumber.Text = "";
            l_ifsc.Text = "";
            l_address.Text = "";

            l_in_username.Text = "";
            l_in_tx_pwd.Text = "";
            l_in_tpin.Text = "";
            l_in_pwd.Text = "";

            l_dc_cardNumber.Text = "";
            l_dc_expDate.Text = "";
            l_dc_pin.Text = "";
            l_dc_cvv.Text = "";

            l_cc_cardNumber.Text = "";
            l_cc_cvv.Text = "";
            l_cc_expDate.Text = "";
            l_cc_pin.Text = "";

            l_additionalDetailsName.Text = "";
            l_additionalDetailsValue.Text = "";
        }

        private void saveLargeTemplate(object sender, EventArgs e)
        {
            if (save_largeWallet.Text.Trim()=="Save")
            {

            

            if (large_walletName.Text.Trim().Length == 0)
            {
                err_l_walletName.SetError(large_walletName, "Wallet Name cannot be empty");
                return;
            }
            else
            {
                err_l_walletName.Clear();
            }

            if (l_bankName.Text.Trim().Length == 0 &&
            l_accNumber.Text.Trim().Length == 0 &&
            l_ifsc.Text.Trim().Length == 0 &&
            l_address.Text.Trim().Length == 0 &&
            l_in_username.Text.Trim().Length == 0 &&
            l_in_tx_pwd.Text.Trim().Length == 0 &&
            l_in_tpin.Text.Trim().Length == 0 &&
            l_in_pwd.Text.Trim().Length == 0 &&
                l_additionalDetailsList.Items.Count == 0)
            {
                err_noDetails.SetError(save_largeWallet, "No Details : Wallet Cannot be saved");
                return;
            }
            err_noDetails.Clear();
            string additionalDetails = "";
            foreach (ListViewItem item in l_additionalDetailsList.Items)
            {
                additionalDetails += item.SubItems[0].Text + "++" + item.SubItems[1].Text;
                additionalDetails += "&&";
            }

            Program.cmd = new System.Data.SqlClient.SqlCommand("select count(*) from Wallet where walletname =  '" + large_walletName.Text + "'", Program.conn);
            Program.conn.Open();
            SqlDataReader reader = Program.cmd.ExecuteReader();
            bool duplicate = false;

            if (reader.Read())
            {
                Object count = reader.GetValue(0);
                if ((int)count > 0)
                {
                    duplicate = true;
                    duplicateLargeWalletName.SetError(large_walletName, "Wallet Name already Exists");
                }
            }
            Program.conn.Close();

            if (duplicate)
            {
                return;
            }

            duplicateLargeWalletName.Clear();
            //shortTemplateDetails
            string format = "yyyy-MM-dd HH:mm:ss";
            Program.cmd = new System.Data.SqlClient.SqlCommand("INSERT INTO Wallet(walletname," +
                " creationtime, lastupdate, type_of_wallet, userid, additional_details," +
                " bank_name, bank_accountnumber, bank_ifsc, bank_address, ibank_username," +
                " ibank_password, ibank_txpassword, ibank_tpin, debitcard_number, debitcard_expdate, " +
                " debitcard_pin, debitcard_cvv, creditcard_number, creditcard_expdate, creditcard_pin, creditcard_cvv) " +
                " VALUES('" + large_walletName.Text + "', '" + (DateTime.Now).ToString(format) + "', '" + (DateTime.Now).ToString(format) + "', 'Large', 1, '" + additionalDetails + "'," +
                " '" + l_bankName.Text + "', '" +l_accNumber.Text + "','"+l_ifsc.Text + "','"+l_address.Text + "','"+l_in_username.Text + "','"+l_in_pwd.Text + "'," +
                " '"+l_in_tx_pwd.Text + "','"+l_in_tpin.Text + "','"+l_dc_cardNumber.Text + "','"+l_dc_expDate.Text + "','"+l_dc_pin.Text + "','"+l_dc_cvv.Text + "'," +
                "'"+l_cc_cardNumber.Text + "','"+l_cc_expDate.Text + "','"+l_cc_pin.Text + "','"+l_cc_cvv.Text+"')", Program.conn);
            Program.conn.Open();
            Program.cmd.ExecuteNonQuery();
            Program.conn.Close();
            MessageBox.Show("Wallet Saved");
            this.Close();
            }
            else if (save_largeWallet.Text.Trim() == "Update")
            {

                if (large_walletName.Text.Trim().Length == 0)
                {
                    err_l_walletName.SetError(large_walletName, "Wallet Name cannot be empty");
                    return;
                }
                else
                {
                    err_l_walletName.Clear();
                }

                if (l_bankName.Text.Trim().Length == 0 &&
                l_accNumber.Text.Trim().Length == 0 &&
                l_ifsc.Text.Trim().Length == 0 &&
                l_address.Text.Trim().Length == 0 &&
                l_in_username.Text.Trim().Length == 0 &&
                l_in_tx_pwd.Text.Trim().Length == 0 &&
                l_in_tpin.Text.Trim().Length == 0 &&
                l_in_pwd.Text.Trim().Length == 0 &&
                    l_additionalDetailsList.Items.Count == 0)
                {
                    err_noDetails.SetError(save_largeWallet, "No Details : Wallet Cannot be saved");
                    return;
                }
                err_noDetails.Clear();
                string additionalDetails = "";
                foreach (ListViewItem item in l_additionalDetailsList.Items)
                {
                    additionalDetails += item.SubItems[0].Text + "++" + item.SubItems[1].Text;
                    additionalDetails += "&&";
                }
                //shortTemplateDetails
                string format = "yyyy-MM-dd HH:mm:ss";
                Program.cmd = new System.Data.SqlClient.SqlCommand("UPDATE Wallet SET walletname='"+ large_walletName.Text + "'," +
                    " lastupdate='"+ (DateTime.Now).ToString(format)  + "', additional_details='"+ additionalDetails  + "'," +
                    " bank_name='"+ l_bankName.Text + "', bank_accountnumber='"+ l_accNumber.Text  + "', bank_ifsc='" + l_ifsc.Text  + "', bank_address='"+ l_address.Text + "', ibank_username='"+ l_in_username.Text + "'," +
                    " ibank_password='"+ l_in_pwd.Text  + "', ibank_txpassword='"+ l_in_tx_pwd.Text + "', ibank_tpin='"+ l_in_tpin.Text + "', debitcard_number='"+ l_dc_cardNumber.Text + "', debitcard_expdate='"+ l_dc_expDate.Text + "', " +
                    " debitcard_pin='" + l_dc_pin.Text + "', debitcard_cvv='"+ l_dc_cvv.Text + "', creditcard_number='"+ l_cc_cardNumber.Text+"', creditcard_expdate='"+ l_cc_expDate.Text  + "', creditcard_pin='"+ l_cc_pin.Text + "', creditcard_cvv='"+ l_cc_cvv.Text + "' where id="+walletId, Program.conn);
                Program.conn.Open();
                Program.cmd.ExecuteNonQuery();
                Program.conn.Close();
                MessageBox.Show("Wallet Updated");
                this.Close();


            }


        }

        private void clear_adn_detailsFields(object sender, EventArgs e)
        {
            l_additionalDetailsName.Text = "";
            l_additionalDetailsValue.Text = "";
        }

        private void large_addAdnDetails(object sender, EventArgs e)
        {
            if (l_additionalDetailsName.Text.Trim().Length == 0)
            {
                errorAdditionalDetailsName.SetError(l_additionalDetailsName,"Name field cannot be empty");
                return;
            }
            else
            {
                errorAdditionalDetailsName.Clear();
            }

            if (l_additionalDetailsValue.Text.Trim().Length == 0)
            {
                errorAdditionalDetailsValue.SetError(l_additionalDetailsValue, "Value field cannot be empty");
                return;
            }
            else
            {
                errorAdditionalDetailsValue.Clear();
            }

            string[] data = { l_additionalDetailsName.Text, l_additionalDetailsValue.Text };
            ListViewItem item = new ListViewItem(data);
            l_additionalDetailsList.Items.Add(item);
        }

        private void delete_large_adnDetails(object sender, EventArgs e)
        {
            foreach (int x in l_additionalDetailsList.SelectedIndices)
            {
                l_additionalDetailsList.Items.RemoveAt(x);
            }
        }

        private void l_adnDetailsNameChanged(object sender, EventArgs e)
        {
            errorAdditionalDetailsName.Clear();
        }

        private void l_adnDetailsValueChanged(object sender, EventArgs e)
        {
            errorAdditionalDetailsValue.Clear();
        }

        private void l_walletName_changed(object sender, EventArgs e)
        {
            err_l_walletName.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void l_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void l_ifsc_TextChanged(object sender, EventArgs e)
        {

        }

        private void l_accNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void l_bankName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void l_cc_expDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void l_cc_cvv_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void l_cc_cardNumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void l_cc_pin_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void l_dc_expDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void l_dc_cvv_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void l_dc_pin_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void l_dc_cardNumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void l_in_tpin_TextChanged(object sender, EventArgs e)
        {

        }

        private void l_in_tx_pwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void l_in_pwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void l_in_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
