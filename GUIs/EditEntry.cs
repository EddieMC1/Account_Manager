using AccountManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountManagerAssistent
{
    public partial class FrmEditEntry : Form
    {
        private string title;
        private Entry entry;
        private Entry beforeEntry;

        public FrmEditEntry(Entry entry)
        {
            InitializeComponent();
            txtEditTitle.Focus();
            this.ActiveControl = txtEditTitle;
            this.entry = entry;
        }

        private void FrmEditEntry_Load(object sender, EventArgs e)
        {
            loadContent();
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditOK_Click(object sender, EventArgs e)
        {
            Entry entry = new Entry(txtEditTitle.Text, txtEditUsername.Text, txtEditPassword.Text, txtEditURL.Text, txtEditNotes.Text, txtEditGroup.Text);

            if (entry != null)
            {
                Program.mainWindow.handler.UpdateEntry(entry, beforeEntry);

                ListView.ListViewItemCollection items = Program.mainWindow.listViewEntrys.Items;

                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i].Text.Equals(beforeEntry.Title))
                    {
                        ListViewItem item = new ListViewItem(entry.Title);
                        item.SubItems.Add(entry.Username);
                        item.SubItems.Add(entry.Password);
                        item.SubItems.Add(entry.Url);
                        item.SubItems.Add(entry.Notes);
                        item.ImageIndex = 0;

                        Program.mainWindow.listViewEntrys.Items[i] = item;

                        Program.mainWindow.handler.EntryList[i] = entry;
                    }
                }

                //List<Entry> list = Program.mainWindow.handler.EntryList;
                //updateListContent(list);
                this.Close();
            }
        }

        private void loadContent()
        {
            txtEditTitle.Text = entry.Title;
            txtEditUsername.Text = entry.Username;
            txtEditPassword.Text = entry.Password;
            txtEditRepeat.Text = entry.Password;
            txtEditURL.Text = entry.Url;
            txtEditNotes.Text = entry.Notes;
            txtEditGroup.Text = entry.Group_name;
            beforeEntry = entry;
        }
    }
}