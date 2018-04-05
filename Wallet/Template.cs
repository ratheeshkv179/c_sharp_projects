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
    public partial class Template : Form
    {
        public Template()
        {
            InitializeComponent();

            additionalDetails.View = View.Details;

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
            additionalDetailsName.Text = "";
            additionalDetailsValue.Text = "";
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
            additionalDetailsName.Text = "";
            additionalDetailsValue.Text = "";
        }

        private void additionalDetails_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void additionalDetails_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void addDetails_Click(object sender, EventArgs e)
        {
            if (additionalDetailsName.Text.Trim().Length == 0)
            {
                errorAdditionalDetailsName.SetError(additionalDetailsName, "Name cannot be empty");
                return;
            }
            else
            {
                errorAdditionalDetailsName.Clear();
            }

            if (additionalDetailsValue.Text.Trim().Length == 0)
            {
                errorAdditionalDetailsValue.SetError(additionalDetailsValue, "Value cannot be empty");
                return;
            }
            else
            {
                errorAdditionalDetailsValue.Clear();
            }
            /*
            if (additionalDetailsName.Text.Trim().Length==0 || additionalDetailsValue.Text.Trim().Length ==0)
            {
                MessageBox.Show("Fields Cannot be Empty");
                return;
            }
            */

            string []data = { additionalDetailsName.Text, additionalDetailsValue.Text};
            ListViewItem item = new ListViewItem(data);
            additionalDetails.Items.Add(item);
        }

        private void clearAll_click(object sender, EventArgs e)
        {
            additionalDetails.Items.Clear();

        }
    }
}
