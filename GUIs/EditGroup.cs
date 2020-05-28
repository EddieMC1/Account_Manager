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
    public partial class FrmEditGroup : Form
    {
        private string group_name;

        public FrmEditGroup(string group_name)
        {
            InitializeComponent();

            txtEditGroupName.Focus();

            this.group_name = group_name;

            this.ActiveControl = txtEditGroupName;    
        }

        private void FrmEditGroup_Load(object sender, EventArgs e)
        {
            txtEditGroupName.Text = group_name;

            richTxtEditGroupNotes.Text = Program.mainWindow.handler.GetGroupNotes(group_name);

        }

        private void btnAddGroupCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuItemGeneral_Click(object sender, EventArgs e)
        {
            EnableGeneral();
        }

        private void MenuItemEditNotes_Click(object sender, EventArgs e)
        {
            EnableNotes();
        }

        private void EnableGeneral()
        {
            richTxtEditGroupNotes.Visible = false;
            lblEditGroupNotes.Visible = false;

            lblEditGroupName.Visible = true;
            txtEditGroupName.Visible = true;

            MenuItemEditGeneral.BackColor = Color.White;
            MenuItemEditNotes.BackColor = SystemColors.Control;
        }

        private void EnableNotes()
        {
            richTxtEditGroupNotes.Visible = true;
            lblEditGroupNotes.Visible = true;

            lblEditGroupName.Visible = false;
            txtEditGroupName.Visible = false;

            MenuItemEditGeneral.BackColor = SystemColors.Control;
            MenuItemEditNotes.BackColor =  Color.White;
        }

        private void btnEditGroupOK_Click(object sender, EventArgs e)
        {
            Program.mainWindow.handler.UpdateGroup(group_name, txtEditGroupName.Text, richTxtEditGroupNotes.Text);

            Program.mainWindow.loadTwo();

            this.Close();
        }

        
    }
}
