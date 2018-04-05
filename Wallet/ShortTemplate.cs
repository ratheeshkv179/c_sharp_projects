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
    public partial class ShortTemplate : Form
    {
        public ShortTemplate()
        {
            InitializeComponent();
            shortTemplateDetails.View = View.Details;
            shortTemplateDetails.GridLines = true;
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

            string[] data = { shortTemDetailName.Text, shortTemDetailValue.Text };
            ListViewItem item = new ListViewItem(data);
            shortTemplateDetails.Items.Add(item);
        }
    }
}
