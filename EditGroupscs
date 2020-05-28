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
    public partial class FrmAddGroup : Form
    {
        public FrmAddGroup()
        {
            InitializeComponent();
        }

        private void btnAddGroupCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuItemNotes_Click(object sender, EventArgs e)
        {
            EnableNotes();
        }

        private void MenuItemGeneral_Click(object sender, EventArgs e)
        {
            EnableGeneral();
        }

        private void EnableGeneral()
        {
            richTxtAddGroupNotes.Visible = false;
            lblAddGroupNotes.Visible = false;

            lblAddGroupName.Visible = true;
            lblAddGroupIcon.Visible = true;
            checkBxExpires.Visible = true;
            txtAddGroupName.Visible = true;
            picBxAddGroupIcon.Visible = true;
            dateTimeAddGroup.Visible = true;

            MenuItemGeneral.BackColor = Color.White;
            MenuItemNotes.BackColor = SystemColors.Control;
        }

        private void EnableNotes()
        {
            richTxtAddGroupNotes.Visible = true;
            lblAddGroupNotes.Visible = true;

            lblAddGroupName.Visible = false;
            lblAddGroupIcon.Visible = false;
            checkBxExpires.Visible = false;
            txtAddGroupName.Visible = false;
            picBxAddGroupIcon.Visible = false;
            dateTimeAddGroup.Visible = false;

            MenuItemNotes.BackColor = Color.White;
            MenuItemGeneral.BackColor = SystemColors.Control;
        }
    }
}
