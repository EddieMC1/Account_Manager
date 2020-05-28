using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace AccountManager
{
    public partial class FrmAnmeldung : Form
    {
        Encryption enc = new Encryption();
        string passwort = "";

        public FrmAnmeldung()
        {
            InitializeComponent();
        }

        private void FrmAnmeldung_Load(object sender, EventArgs e)
        {
            txtMasterPass.Focus();

            this.ActiveControl = txtMasterPass;

            txtMasterPass.UseSystemPasswordChar = true;
        }

        private void btnAnmeldungOK_Click(object sender, EventArgs e)
        {
            this.passwort = txtMasterPass.Text;

            string encPassword = enc.EncryptMessage(passwort);

            if (enc.EncryptMessage(passwort).Equals(enc.EncryptMessage(Program.mainWindow.handler.GetMasterKey())))
            {
                this.DialogResult = DialogResult.OK;

                txtMasterPass.Text = "";
            }
            else
            {
                txtMasterPass.Text = "";

                MessageBox.Show("Das Master-Passwort ist falsch!");

                txtMasterPass.Text = "";
            }
        }

        public void txtMasterPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string passwort = txtMasterPass.Text;

                string encPassword = enc.EncryptMessage(passwort);

                //string passwort2 = handler.GetMasterKey();
                //string encPassword2 = enc.EncryptMessage(handler.GetMasterKey());

                if (enc.EncryptMessage(passwort).Equals(enc.EncryptMessage(Program.mainWindow.handler.GetMasterKey())))
                {
                    this.DialogResult = DialogResult.OK;

                    MessageBox.Show("PW Ok", "Accessful.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("PW false", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #region
        private void btnAnmeldungHelp_Click(object sender, EventArgs e)
        {
            string text = "A master password is required for authentication.";
            MessageBox.Show(text, "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion

        private void btnAnmeldungCancel_Click(object sender, EventArgs e)
        {
            Program.mainWindow.Close();
        }

        // Passwort maskieren/demaskieren
        private void picBxEncDec_Click(object sender, EventArgs e)
        {
            if (txtMasterPass.Text != null)
            {
                if (txtMasterPass.UseSystemPasswordChar == true)
                {
                    txtMasterPass.UseSystemPasswordChar = false;
                }
                else
                {
                    txtMasterPass.UseSystemPasswordChar = true;
                }
            }
        }
    }
}
