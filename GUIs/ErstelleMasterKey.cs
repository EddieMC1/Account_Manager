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
    public partial class FrmCreatePassword : Form
    {
        //HandlerDB handler = new HandlerDB();

        public FrmCreatePassword()
        {
            InitializeComponent();
            this.checkBxCreatePassSetzen.Checked = true;
            this.ActiveControl = txtMasterPass;
            txtMasterPass.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCreatePassword_Load(object sender, EventArgs e)
        {
            if (checkBxCreatePassSetzen.Checked == true)
            {
                txtMasterPass.Enabled = true;
                txtMasterRepeat.Enabled = true;
            }
            else
            {
                txtMasterPass.Enabled = false;
                txtMasterRepeat.Enabled = false;
            }
        }

        private void btnCreateOK_Click(object sender, EventArgs e)
        {
            if (txtMasterPass.Text.Equals(txtMasterRepeat.Text))
            {
                string new_Master_PW = txtMasterPass.Text;
                Program.mainWindow.handler.SetMasterKey(new_Master_PW);
            }
            else
            {
                MessageBox.Show("The password do not match!");
            }
        }

        private void checkBxCreatePassSetzen_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBxCreatePassSetzen.Checked == true)
            {
                txtMasterPass.Enabled = true;
                txtMasterRepeat.Enabled = true;
            }
            else
            {
                txtMasterPass.Enabled = false;
                txtMasterRepeat.Enabled = false;
            }
        }
    }
}
