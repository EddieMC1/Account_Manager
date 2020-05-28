namespace AccountManager
{
    partial class FrmAnmeldung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnmeldung));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblAnmeldungPfad = new System.Windows.Forms.Label();
            this.picBxAnmeldungLogo = new System.Windows.Forms.PictureBox();
            this.lblAnmeldungUeberschrift = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAnmeldungOK = new System.Windows.Forms.Button();
            this.btnAnmeldungHelp = new System.Windows.Forms.Button();
            this.btnAnmeldungCancel = new System.Windows.Forms.Button();
            this.picBxEncDec = new System.Windows.Forms.PictureBox();
            this.txtMasterPass = new System.Windows.Forms.TextBox();
            this.checkBxMasterPasswort = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxAnmeldungLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxEncDec)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.lblAnmeldungPfad);
            this.splitContainer1.Panel1.Controls.Add(this.picBxAnmeldungLogo);
            this.splitContainer1.Panel1.Controls.Add(this.lblAnmeldungUeberschrift);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.picBxEncDec);
            this.splitContainer1.Panel2.Controls.Add(this.txtMasterPass);
            this.splitContainer1.Panel2.Controls.Add(this.checkBxMasterPasswort);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Size = new System.Drawing.Size(479, 225);
            this.splitContainer1.SplitterDistance = 64;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblAnmeldungPfad
            // 
            this.lblAnmeldungPfad.AutoSize = true;
            this.lblAnmeldungPfad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnmeldungPfad.ForeColor = System.Drawing.Color.White;
            this.lblAnmeldungPfad.Location = new System.Drawing.Point(100, 36);
            this.lblAnmeldungPfad.Name = "lblAnmeldungPfad";
            this.lblAnmeldungPfad.Size = new System.Drawing.Size(97, 16);
            this.lblAnmeldungPfad.TabIndex = 1;
            this.lblAnmeldungPfad.Text = "Authentification";
            // 
            // picBxAnmeldungLogo
            // 
            this.picBxAnmeldungLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBxAnmeldungLogo.Image")));
            this.picBxAnmeldungLogo.Location = new System.Drawing.Point(2, 1);
            this.picBxAnmeldungLogo.Name = "picBxAnmeldungLogo";
            this.picBxAnmeldungLogo.Size = new System.Drawing.Size(85, 62);
            this.picBxAnmeldungLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxAnmeldungLogo.TabIndex = 0;
            this.picBxAnmeldungLogo.TabStop = false;
            // 
            // lblAnmeldungUeberschrift
            // 
            this.lblAnmeldungUeberschrift.AutoSize = true;
            this.lblAnmeldungUeberschrift.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnmeldungUeberschrift.ForeColor = System.Drawing.Color.White;
            this.lblAnmeldungUeberschrift.Location = new System.Drawing.Point(93, 9);
            this.lblAnmeldungUeberschrift.Name = "lblAnmeldungUeberschrift";
            this.lblAnmeldungUeberschrift.Size = new System.Drawing.Size(178, 25);
            this.lblAnmeldungUeberschrift.TabIndex = 0;
            this.lblAnmeldungUeberschrift.Text = "Enter Master Key";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAnmeldungOK);
            this.groupBox1.Controls.Add(this.btnAnmeldungHelp);
            this.groupBox1.Controls.Add(this.btnAnmeldungCancel);
            this.groupBox1.Location = new System.Drawing.Point(0, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 70);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // btnAnmeldungOK
            // 
            this.btnAnmeldungOK.Location = new System.Drawing.Point(261, 23);
            this.btnAnmeldungOK.Name = "btnAnmeldungOK";
            this.btnAnmeldungOK.Size = new System.Drawing.Size(100, 25);
            this.btnAnmeldungOK.TabIndex = 3;
            this.btnAnmeldungOK.Text = "OK";
            this.btnAnmeldungOK.UseVisualStyleBackColor = true;
            this.btnAnmeldungOK.Click += new System.EventHandler(this.btnAnmeldungOK_Click);
            // 
            // btnAnmeldungHelp
            // 
            this.btnAnmeldungHelp.Location = new System.Drawing.Point(12, 23);
            this.btnAnmeldungHelp.Name = "btnAnmeldungHelp";
            this.btnAnmeldungHelp.Size = new System.Drawing.Size(80, 25);
            this.btnAnmeldungHelp.TabIndex = 2;
            this.btnAnmeldungHelp.Text = "Help";
            this.btnAnmeldungHelp.UseVisualStyleBackColor = true;
            this.btnAnmeldungHelp.Click += new System.EventHandler(this.btnAnmeldungHelp_Click);
            // 
            // btnAnmeldungCancel
            // 
            this.btnAnmeldungCancel.Location = new System.Drawing.Point(367, 23);
            this.btnAnmeldungCancel.Name = "btnAnmeldungCancel";
            this.btnAnmeldungCancel.Size = new System.Drawing.Size(100, 25);
            this.btnAnmeldungCancel.TabIndex = 4;
            this.btnAnmeldungCancel.Text = "Cancel";
            this.btnAnmeldungCancel.UseVisualStyleBackColor = true;
            this.btnAnmeldungCancel.Click += new System.EventHandler(this.btnAnmeldungCancel_Click);
            // 
            // picBxEncDec
            // 
            this.picBxEncDec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBxEncDec.Image = ((System.Drawing.Image)(resources.GetObject("picBxEncDec.Image")));
            this.picBxEncDec.Location = new System.Drawing.Point(426, 37);
            this.picBxEncDec.Name = "picBxEncDec";
            this.picBxEncDec.Size = new System.Drawing.Size(41, 22);
            this.picBxEncDec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxEncDec.TabIndex = 7;
            this.picBxEncDec.TabStop = false;
            this.picBxEncDec.Click += new System.EventHandler(this.picBxEncDec_Click);
            // 
            // txtMasterPass
            // 
            this.txtMasterPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasterPass.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMasterPass.Location = new System.Drawing.Point(168, 37);
            this.txtMasterPass.Name = "txtMasterPass";
            this.txtMasterPass.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtMasterPass.Size = new System.Drawing.Size(252, 22);
            this.txtMasterPass.TabIndex = 5;
            this.txtMasterPass.UseSystemPasswordChar = true;
            this.txtMasterPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMasterPass_KeyDown);
            // 
            // checkBxMasterPasswort
            // 
            this.checkBxMasterPasswort.AutoSize = true;
            this.checkBxMasterPasswort.Checked = true;
            this.checkBxMasterPasswort.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBxMasterPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBxMasterPasswort.Location = new System.Drawing.Point(12, 37);
            this.checkBxMasterPasswort.Name = "checkBxMasterPasswort";
            this.checkBxMasterPasswort.Size = new System.Drawing.Size(150, 20);
            this.checkBxMasterPasswort.TabIndex = 0;
            this.checkBxMasterPasswort.Text = "Master Password:";
            this.checkBxMasterPasswort.UseVisualStyleBackColor = true;
            // 
            // FrmAnmeldung
            // 
            this.AcceptButton = this.btnAnmeldungOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(479, 225);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnmeldung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open Database";
            this.Load += new System.EventHandler(this.FrmAnmeldung_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBxAnmeldungLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBxEncDec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox picBxAnmeldungLogo;
        private System.Windows.Forms.Label lblAnmeldungPfad;
        private System.Windows.Forms.Label lblAnmeldungUeberschrift;
        private System.Windows.Forms.PictureBox picBxEncDec;
        private System.Windows.Forms.TextBox txtMasterPass;
        private System.Windows.Forms.Button btnAnmeldungCancel;
        private System.Windows.Forms.Button btnAnmeldungOK;
        private System.Windows.Forms.Button btnAnmeldungHelp;
        private System.Windows.Forms.CheckBox checkBxMasterPasswort;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}