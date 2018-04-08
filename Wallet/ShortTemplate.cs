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
    public partial class ShortTemplate : Form
    {
        string walletId = "";

        public ShortTemplate()
        {
            InitializeComponent();
            shortTemplateDetails.View = View.Details;
            shortTemplateDetails.GridLines = true;
            smallWalletCreationTime.Text = "";
            smallWalletLastUpdationTime.Text = "";
            saveShortTemplate.Text = "Save";
        }

        public ShortTemplate(string walletName)
        {
            walletId = "";
            InitializeComponent();
            shortTemplateDetails.View = View.Details;
            shortTemplateDetails.GridLines = true;
            saveShortTemplate.Text = "Update";

            shortTemplateDetails.GridLines = true;
            smallWalletName.Text = walletName;

            Program.cmd = new System.Data.SqlClient.SqlCommand("select creationtime, lastupdate, additional_details,id from Wallet where walletname='" + walletName + "'", Program.conn);
            Program.conn.Open();
            SqlDataReader reader = Program.cmd.ExecuteReader();
            if (reader.Read())
            {
                smallWalletCreationTime.Text = "Created at     : " + reader.GetValue(0).ToString();
                smallWalletLastUpdationTime.Text = "Last Update at : " + reader.GetValue(1).ToString();
                string details = reader.GetValue(2).ToString();
                walletId = reader.GetValue(3).ToString();
                string[] rows = details.Split(new string[] { "&&" }, StringSplitOptions.None);

                for (var i = 0; i < rows.Length - 1; i++)
                {
                    string[] data = rows[i].Split(new string[] { "++" }, StringSplitOptions.None);
                    ListViewItem item = new ListViewItem(data);
                    shortTemplateDetails.Items.Add(item);
                }
            }
            Program.conn.Close();


        }

        private void clear_shorttemdetails(object sender, EventArgs e)
        {
            shortTemDetailName.Text = "";
            shortTemDetailValue.Text = "";
        }

        private void deleteShortTemDetails(object sender, EventArgs e)
        {
            foreach (int x in shortTemplateDetails.SelectedIndices) {
                shortTemplateDetails.Items.RemoveAt(x);
            }
          //  shortTemplateDetails.SelectedIndices.Remove(2);
        }

        private void addShortTemDetails(object sender, EventArgs e)
        {
            if (shortTemDetailName.Text.Trim().Length == 0)
            {
                errorShrtWltName.SetError(shortTemDetailName,"Name Field cannot be empty");
                return;
            }
            else
            {
                errorShrtWltName.Clear();
            }

            if (shortTemDetailValue.Text.Trim().Length == 0)
            {
                errorShrtWltName.SetError(shortTemDetailValue, "Value Field cannot be empty");
                return;
            }
            else
            {
                errorShrtWltValue.Clear();
            }
            err_details.Clear();
            string[] data = { shortTemDetailName.Text, shortTemDetailValue.Text };
            ListViewItem item = new ListViewItem(data);
            shortTemplateDetails.Items.Add(item);
        }

        private void smallWallet_clearAllData(object sender, EventArgs e)
        {
            smallWalletName.Text = "";
            shortTemDetailName.Text = "";
            shortTemDetailValue.Text = "";
        }

        private void smallWalletSaveData(object sender, EventArgs e)
        {
            MessageBox.Show(saveShortTemplate.Text);

            if (saveShortTemplate.Text.Trim() == "Save")
            {
            if (smallWalletName.Text.Trim().Length == 0)
            {
                err_walletName.SetError(smallWalletName, "Wallet Name cannot be empty");
                return;
            }

           else if (shortTemplateDetails.Items.Count == 0)
            {
                err_walletName.Clear();
                err_details.SetError(shortTemplateDetails, "No Details added");
                return;
            }
            err_walletName.Clear();
            err_details.Clear();

            string additional_details = "";
            foreach (ListViewItem item in shortTemplateDetails.Items)
            {
                additional_details += item.SubItems[0].Text + "++" + item.SubItems[1].Text;
                additional_details += "&&";
                
            }

            Program.cmd = new System.Data.SqlClient.SqlCommand("select count(*) from Wallet where walletname =  '" + smallWalletName.Text + "'", Program.conn);
            Program.conn.Open();
            SqlDataReader reader =  Program.cmd.ExecuteReader();
            bool duplicate = false;

            if (reader.Read())
            {
                Object count = reader.GetValue(0);
                if ((int)count > 0)
                {
                    duplicate = true;
                    duplicateSmallWalletName.SetError(smallWalletName, "Wallet Name already Exists");
                }
            }
            Program.conn.Close();

            if (duplicate)
            {
                return;
            }

            duplicateSmallWalletName.Clear();
            string format = "yyyy-MM-dd HH:mm:ss";
            Program.cmd = new System.Data.SqlClient.SqlCommand("INSERT INTO Wallet(walletname, creationtime, lastupdate, type_of_wallet, userid, additional_details) VALUES('"+smallWalletName.Text+ "', '" + (DateTime.Now).ToString(format) + "', '" + (DateTime.Now).ToString(format) + "', 'Small', 1, '"+additional_details+"'  )", Program.conn);
            Program.conn.Open();
            Program.cmd.ExecuteNonQuery();
            Program.conn.Close();
            MessageBox.Show("Wallet Saved");
            this.Close();
            }
            else if (saveShortTemplate.Text.Trim() == "Update")
            {




                if (smallWalletName.Text.Trim().Length == 0)
                {
                    err_walletName.SetError(smallWalletName, "Wallet Name cannot be empty");
                    return;
                }

                else if (shortTemplateDetails.Items.Count == 0)
                {
                    err_walletName.Clear();
                    err_details.SetError(shortTemplateDetails, "No Details added");
                    return;
                }
                err_walletName.Clear();
                err_details.Clear();

                string additional_details = "";
                foreach (ListViewItem item in shortTemplateDetails.Items)
                {
                    additional_details += item.SubItems[0].Text + "++" + item.SubItems[1].Text;
                    additional_details += "&&";

                }

                string format = "yyyy-MM-dd HH:mm:ss";
                
                Program.cmd = new System.Data.SqlClient.SqlCommand("UPDATE Wallet SET walletname='"+ smallWalletName.Text + "', lastupdate='"+ (DateTime.Now).ToString(format) + "', additional_details='"+ additional_details  + "' where id="+walletId, Program.conn);
                Program.conn.Open();
                Program.cmd.ExecuteNonQuery();
                Program.conn.Close();
                MessageBox.Show("Wallet Updated");
                this.Close();
                walletId = "";

            }
        }

        private void smallWalletNameChanged(object sender, EventArgs e)
        {
            duplicateSmallWalletName.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void shortTemDetailValue_TextChanged(object sender, EventArgs e)
        {
            errorShrtWltName.Clear();
        }

        private void shortTemDetailName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void shortTemplateDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
