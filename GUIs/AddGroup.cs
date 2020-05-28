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
    public partial class FrmAddGroup : Form
    {
        //HandlerDB handler = new HandlerDB();
        FrmUebersicht uebersicht = new FrmUebersicht();

        public FrmAddGroup()
        {
            InitializeComponent();
            txtAddGroupName.Focus();
            this.ActiveControl = txtAddGroupName;
        }
        private void FrmAddGroup_Load(object sender, EventArgs e)
        {
            List<Group> groupsGet = Program.mainWindow.handler.GetGroups();
        }

        #region Cancel_Click
        private void btnAddGroupCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Enable/Disable
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
            txtAddGroupName.Visible = true;

            MenuItemGeneral.BackColor = Color.White;
            MenuItemNotes.BackColor = SystemColors.Control;
        }

        private void EnableNotes()
        {
            richTxtAddGroupNotes.Visible = true;
            lblAddGroupNotes.Visible = true;

            lblAddGroupName.Visible = false;
            txtAddGroupName.Visible = false;

            MenuItemNotes.BackColor = Color.White;
            MenuItemGeneral.BackColor = SystemColors.Control;
        }
        #endregion

        private void btnAddGroupOK_Click(object sender, EventArgs e)
        {
            if ("Recycle Bin".Equals(txtAddGroupName.Text))
            {
                MessageBox.Show("Select a different name!");
                return;
            }

            Program.mainWindow.treeViewFolder.Nodes.Add(Program.mainWindow.CreateContextMenuGroups(txtAddGroupName.Text, false));

            Program.mainWindow.handler.GroupList.Add(new Group(txtAddGroupName.Text));

            Program.mainWindow.handler.SetGroups(txtAddGroupName.Text, richTxtAddGroupNotes.Text);

            this.Close();
        }
    }
}
