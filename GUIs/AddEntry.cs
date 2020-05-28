using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountManager
{
    public partial class FrmAddEntry : Form
    {
        public FrmAddEntry()
        {
            InitializeComponent();
            this.ActiveControl = txtEntryTitle;
            txtEntryTitle.Focus();
        }

        public FrmAddEntry(string group_name)
        {
            InitializeComponent();

            txtEntryGroup.Text = group_name;
        }

        private void btnEntryCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntryOK_Click(object sender, EventArgs e)
        {
            Entry entry = new Entry(txtEntryTitle.Text, txtEntryUsername.Text, txtEntryPassword.Text, txtEntryURL.Text, txtEntryNotes.Text, txtEntryGroup.Text);

            if (entry != null)
            {
                Program.mainWindow.handler.EntryList.Add(entry);

                Program.mainWindow.handler.SetEntryDB(entry);

                ListViewItem item = new ListViewItem(entry.Title);

                item.SubItems.Add(entry.Username);
                item.SubItems.Add(entry.Password);
                item.SubItems.Add(entry.Url);
                item.SubItems.Add(entry.Notes);
                item.ImageIndex = 0;

                Program.mainWindow.listViewEntrys.Items.Add(item);

                this.Close();
            }
        }
    }
}
