namespace AccountManager
{
    partial class FrmAddEntry
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEntry));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblPfad = new System.Windows.Forms.Label();
            this.lblUeberschrift = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBxEntryButtons = new System.Windows.Forms.GroupBox();
            this.btnEntryCancel = new System.Windows.Forms.Button();
            this.btnEntryOK = new System.Windows.Forms.Button();
            this.bntEntryTools = new System.Windows.Forms.Button();
            this.imgIconTools = new System.Windows.Forms.ImageList(this.components);
            this.groupBxEntryKeys = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEntryNotes = new System.Windows.Forms.RichTextBox();
            this.lblEntryGroups = new System.Windows.Forms.Label();
            this.txtEntryGroup = new System.Windows.Forms.TextBox();
            this.lblEntryURL = new System.Windows.Forms.Label();
            this.txtEntryURL = new System.Windows.Forms.TextBox();
            this.picBxEntryPunkte = new System.Windows.Forms.PictureBox();
            this.txtEntryRepeat = new System.Windows.Forms.TextBox();
            this.txtEntryPassword = new System.Windows.Forms.TextBox();
            this.txtEntryTitle = new System.Windows.Forms.TextBox();
            this.txtEntryUsername = new System.Windows.Forms.TextBox();
            this.lblEntryUsername = new System.Windows.Forms.Label();
            this.lblEntyPassword = new System.Windows.Forms.Label();
            this.lblEntryRepeat = new System.Windows.Forms.Label();
            this.lblEntryTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBxEntryButtons.SuspendLayout();
            this.groupBxEntryKeys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxEntryPunkte)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.lblPfad);
            this.splitContainer1.Panel1.Controls.Add(this.lblUeberschrift);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBxEntryButtons);
            this.splitContainer1.Panel2.Controls.Add(this.groupBxEntryKeys);
            this.splitContainer1.Size = new System.Drawing.Size(514, 501);
            this.splitContainer1.SplitterDistance = 68;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblPfad
            // 
            this.lblPfad.AutoSize = true;
            this.lblPfad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPfad.ForeColor = System.Drawing.Color.White;
            this.lblPfad.Location = new System.Drawing.Point(99, 40);
            this.lblPfad.Name = "lblPfad";
            this.lblPfad.Size = new System.Drawing.Size(121, 16);
            this.lblPfad.TabIndex = 1;
            this.lblPfad.Text = "Create a new entry.";
            // 
            // lblUeberschrift
            // 
            this.lblUeberschrift.AutoSize = true;
            this.lblUeberschrift.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUeberschrift.ForeColor = System.Drawing.Color.White;
            this.lblUeberschrift.Location = new System.Drawing.Point(93, 12);
            this.lblUeberschrift.Name = "lblUeberschrift";
            this.lblUeberschrift.Size = new System.Drawing.Size(106, 25);
            this.lblUeberschrift.TabIndex = 0;
            this.lblUeberschrift.Text = "Add Entry";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBxEntryButtons
            // 
            this.groupBxEntryButtons.BackColor = System.Drawing.SystemColors.Control;
            this.groupBxEntryButtons.Controls.Add(this.btnEntryCancel);
            this.groupBxEntryButtons.Controls.Add(this.btnEntryOK);
            this.groupBxEntryButtons.Controls.Add(this.bntEntryTools);
            this.groupBxEntryButtons.Location = new System.Drawing.Point(0, 366);
            this.groupBxEntryButtons.Name = "groupBxEntryButtons";
            this.groupBxEntryButtons.Size = new System.Drawing.Size(513, 62);
            this.groupBxEntryButtons.TabIndex = 1;
            this.groupBxEntryButtons.TabStop = false;
            // 
            // btnEntryCancel
            // 
            this.btnEntryCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntryCancel.Location = new System.Drawing.Point(401, 19);
            this.btnEntryCancel.Name = "btnEntryCancel";
            this.btnEntryCancel.Size = new System.Drawing.Size(95, 29);
            this.btnEntryCancel.TabIndex = 1;
            this.btnEntryCancel.Text = "Cancel";
            this.btnEntryCancel.UseVisualStyleBackColor = true;
            this.btnEntryCancel.Click += new System.EventHandler(this.btnEntryCancel_Click);
            // 
            // btnEntryOK
            // 
            this.btnEntryOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntryOK.Location = new System.Drawing.Point(295, 19);
            this.btnEntryOK.Name = "btnEntryOK";
            this.btnEntryOK.Size = new System.Drawing.Size(95, 29);
            this.btnEntryOK.TabIndex = 0;
            this.btnEntryOK.Text = "OK";
            this.btnEntryOK.UseVisualStyleBackColor = true;
            this.btnEntryOK.Click += new System.EventHandler(this.btnEntryOK_Click);
            // 
            // bntEntryTools
            // 
            this.bntEntryTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntEntryTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntEntryTools.ImageIndex = 0;
            this.bntEntryTools.ImageList = this.imgIconTools;
            this.bntEntryTools.Location = new System.Drawing.Point(6, 19);
            this.bntEntryTools.Name = "bntEntryTools";
            this.bntEntryTools.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bntEntryTools.Size = new System.Drawing.Size(95, 29);
            this.bntEntryTools.TabIndex = 2;
            this.bntEntryTools.Text = "Tools";
            this.bntEntryTools.UseVisualStyleBackColor = true;
            // 
            // imgIconTools
            // 
            this.imgIconTools.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIconTools.ImageStream")));
            this.imgIconTools.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIconTools.Images.SetKeyName(0, "tools.png");
            // 
            // groupBxEntryKeys
            // 
            this.groupBxEntryKeys.BackColor = System.Drawing.Color.White;
            this.groupBxEntryKeys.Controls.Add(this.label1);
            this.groupBxEntryKeys.Controls.Add(this.txtEntryNotes);
            this.groupBxEntryKeys.Controls.Add(this.lblEntryGroups);
            this.groupBxEntryKeys.Controls.Add(this.txtEntryGroup);
            this.groupBxEntryKeys.Controls.Add(this.lblEntryURL);
            this.groupBxEntryKeys.Controls.Add(this.txtEntryURL);
            this.groupBxEntryKeys.Controls.Add(this.picBxEntryPunkte);
            this.groupBxEntryKeys.Controls.Add(this.txtEntryRepeat);
            this.groupBxEntryKeys.Controls.Add(this.txtEntryPassword);
            this.groupBxEntryKeys.Controls.Add(this.txtEntryTitle);
            this.groupBxEntryKeys.Controls.Add(this.txtEntryUsername);
            this.groupBxEntryKeys.Controls.Add(this.lblEntryUsername);
            this.groupBxEntryKeys.Controls.Add(this.lblEntyPassword);
            this.groupBxEntryKeys.Controls.Add(this.lblEntryRepeat);
            this.groupBxEntryKeys.Controls.Add(this.lblEntryTitle);
            this.groupBxEntryKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBxEntryKeys.Location = new System.Drawing.Point(6, 1);
            this.groupBxEntryKeys.Name = "groupBxEntryKeys";
            this.groupBxEntryKeys.Size = new System.Drawing.Size(505, 351);
            this.groupBxEntryKeys.TabIndex = 0;
            this.groupBxEntryKeys.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Notes:";
            // 
            // txtEntryNotes
            // 
            this.txtEntryNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntryNotes.Location = new System.Drawing.Point(113, 166);
            this.txtEntryNotes.Name = "txtEntryNotes";
            this.txtEntryNotes.Size = new System.Drawing.Size(377, 143);
            this.txtEntryNotes.TabIndex = 5;
            this.txtEntryNotes.Text = "";
            // 
            // lblEntryGroups
            // 
            this.lblEntryGroups.AutoSize = true;
            this.lblEntryGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryGroups.Location = new System.Drawing.Point(20, 320);
            this.lblEntryGroups.Name = "lblEntryGroups";
            this.lblEntryGroups.Size = new System.Drawing.Size(48, 16);
            this.lblEntryGroups.TabIndex = 13;
            this.lblEntryGroups.Text = "Group:";
            // 
            // txtEntryGroup
            // 
            this.txtEntryGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntryGroup.Location = new System.Drawing.Point(113, 317);
            this.txtEntryGroup.Name = "txtEntryGroup";
            this.txtEntryGroup.Size = new System.Drawing.Size(377, 22);
            this.txtEntryGroup.TabIndex = 6;
            // 
            // lblEntryURL
            // 
            this.lblEntryURL.AutoSize = true;
            this.lblEntryURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryURL.Location = new System.Drawing.Point(20, 139);
            this.lblEntryURL.Name = "lblEntryURL";
            this.lblEntryURL.Size = new System.Drawing.Size(38, 16);
            this.lblEntryURL.TabIndex = 11;
            this.lblEntryURL.Text = "URL:";
            // 
            // txtEntryURL
            // 
            this.txtEntryURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntryURL.Location = new System.Drawing.Point(113, 136);
            this.txtEntryURL.Name = "txtEntryURL";
            this.txtEntryURL.Size = new System.Drawing.Size(377, 22);
            this.txtEntryURL.TabIndex = 4;
            // 
            // picBxEntryPunkte
            // 
            this.picBxEntryPunkte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBxEntryPunkte.Image = ((System.Drawing.Image)(resources.GetObject("picBxEntryPunkte.Image")));
            this.picBxEntryPunkte.Location = new System.Drawing.Point(450, 76);
            this.picBxEntryPunkte.Name = "picBxEntryPunkte";
            this.picBxEntryPunkte.Size = new System.Drawing.Size(40, 22);
            this.picBxEntryPunkte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxEntryPunkte.TabIndex = 8;
            this.picBxEntryPunkte.TabStop = false;
            // 
            // txtEntryRepeat
            // 
            this.txtEntryRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntryRepeat.Location = new System.Drawing.Point(113, 106);
            this.txtEntryRepeat.Name = "txtEntryRepeat";
            this.txtEntryRepeat.Size = new System.Drawing.Size(377, 22);
            this.txtEntryRepeat.TabIndex = 3;
            // 
            // txtEntryPassword
            // 
            this.txtEntryPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntryPassword.Location = new System.Drawing.Point(113, 76);
            this.txtEntryPassword.Name = "txtEntryPassword";
            this.txtEntryPassword.Size = new System.Drawing.Size(329, 22);
            this.txtEntryPassword.TabIndex = 2;
            // 
            // txtEntryTitle
            // 
            this.txtEntryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntryTitle.Location = new System.Drawing.Point(113, 16);
            this.txtEntryTitle.Name = "txtEntryTitle";
            this.txtEntryTitle.Size = new System.Drawing.Size(377, 22);
            this.txtEntryTitle.TabIndex = 0;
            // 
            // txtEntryUsername
            // 
            this.txtEntryUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntryUsername.Location = new System.Drawing.Point(113, 46);
            this.txtEntryUsername.Name = "txtEntryUsername";
            this.txtEntryUsername.Size = new System.Drawing.Size(377, 22);
            this.txtEntryUsername.TabIndex = 1;
            // 
            // lblEntryUsername
            // 
            this.lblEntryUsername.AutoSize = true;
            this.lblEntryUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryUsername.Location = new System.Drawing.Point(20, 49);
            this.lblEntryUsername.Name = "lblEntryUsername";
            this.lblEntryUsername.Size = new System.Drawing.Size(77, 16);
            this.lblEntryUsername.TabIndex = 8;
            this.lblEntryUsername.Text = "User name:";
            // 
            // lblEntyPassword
            // 
            this.lblEntyPassword.AutoSize = true;
            this.lblEntyPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntyPassword.Location = new System.Drawing.Point(20, 79);
            this.lblEntyPassword.Name = "lblEntyPassword";
            this.lblEntyPassword.Size = new System.Drawing.Size(71, 16);
            this.lblEntyPassword.TabIndex = 9;
            this.lblEntyPassword.Text = "Password:";
            // 
            // lblEntryRepeat
            // 
            this.lblEntryRepeat.AutoSize = true;
            this.lblEntryRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryRepeat.Location = new System.Drawing.Point(20, 109);
            this.lblEntryRepeat.Name = "lblEntryRepeat";
            this.lblEntryRepeat.Size = new System.Drawing.Size(56, 16);
            this.lblEntryRepeat.TabIndex = 10;
            this.lblEntryRepeat.Text = "Repeat:";
            // 
            // lblEntryTitle
            // 
            this.lblEntryTitle.AutoSize = true;
            this.lblEntryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryTitle.Location = new System.Drawing.Point(20, 22);
            this.lblEntryTitle.Name = "lblEntryTitle";
            this.lblEntryTitle.Size = new System.Drawing.Size(37, 16);
            this.lblEntryTitle.TabIndex = 7;
            this.lblEntryTitle.Text = "Title:";
            // 
            // FrmAddEntry
            // 
            this.AcceptButton = this.btnEntryOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 501);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Entry";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBxEntryButtons.ResumeLayout(false);
            this.groupBxEntryKeys.ResumeLayout(false);
            this.groupBxEntryKeys.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxEntryPunkte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPfad;
        private System.Windows.Forms.Label lblUeberschrift;
        private System.Windows.Forms.GroupBox groupBxEntryKeys;
        private System.Windows.Forms.GroupBox groupBxEntryButtons;
        private System.Windows.Forms.Button btnEntryCancel;
        private System.Windows.Forms.Button btnEntryOK;
        private System.Windows.Forms.Button bntEntryTools;
        private System.Windows.Forms.ImageList imgIconTools;
        private System.Windows.Forms.TextBox txtEntryRepeat;
        private System.Windows.Forms.TextBox txtEntryPassword;
        private System.Windows.Forms.TextBox txtEntryTitle;
        private System.Windows.Forms.TextBox txtEntryUsername;
        private System.Windows.Forms.Label lblEntryUsername;
        private System.Windows.Forms.Label lblEntyPassword;
        private System.Windows.Forms.Label lblEntryRepeat;
        private System.Windows.Forms.Label lblEntryTitle;
        private System.Windows.Forms.PictureBox picBxEntryPunkte;
        private System.Windows.Forms.RichTextBox txtEntryNotes;
        private System.Windows.Forms.Label lblEntryGroups;
        private System.Windows.Forms.TextBox txtEntryGroup;
        private System.Windows.Forms.Label lblEntryURL;
        private System.Windows.Forms.TextBox txtEntryURL;
        private System.Windows.Forms.Label label1;
    }
}