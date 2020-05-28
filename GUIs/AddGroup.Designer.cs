namespace AccountManager
{
    partial class FrmAddGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddGroup));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblAnmeldungPfad = new System.Windows.Forms.Label();
            this.lblAnmeldungUeberschrift = new System.Windows.Forms.Label();
            this.picBxAnmeldungLogo = new System.Windows.Forms.PictureBox();
            this.groupBxAddGroup = new System.Windows.Forms.GroupBox();
            this.lblAddGroupNotes = new System.Windows.Forms.Label();
            this.richTxtAddGroupNotes = new System.Windows.Forms.RichTextBox();
            this.txtAddGroupName = new System.Windows.Forms.TextBox();
            this.lblAddGroupName = new System.Windows.Forms.Label();
            this.btnAddGroupOK = new System.Windows.Forms.Button();
            this.btnAddGroupCancel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNotes = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxAnmeldungLogo)).BeginInit();
            this.groupBxAddGroup.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.lblAnmeldungUeberschrift);
            this.splitContainer1.Panel1.Controls.Add(this.picBxAnmeldungLogo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBxAddGroup);
            this.splitContainer1.Panel2.Controls.Add(this.btnAddGroupOK);
            this.splitContainer1.Panel2.Controls.Add(this.btnAddGroupCancel);
            this.splitContainer1.Panel2.Controls.Add(this.menuStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(439, 286);
            this.splitContainer1.SplitterDistance = 64;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblAnmeldungPfad
            // 
            this.lblAnmeldungPfad.AutoSize = true;
            this.lblAnmeldungPfad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnmeldungPfad.ForeColor = System.Drawing.Color.White;
            this.lblAnmeldungPfad.Location = new System.Drawing.Point(103, 36);
            this.lblAnmeldungPfad.Name = "lblAnmeldungPfad";
            this.lblAnmeldungPfad.Size = new System.Drawing.Size(159, 16);
            this.lblAnmeldungPfad.TabIndex = 3;
            this.lblAnmeldungPfad.Text = "Create a new entry group.";
            // 
            // lblAnmeldungUeberschrift
            // 
            this.lblAnmeldungUeberschrift.AutoSize = true;
            this.lblAnmeldungUeberschrift.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnmeldungUeberschrift.ForeColor = System.Drawing.Color.White;
            this.lblAnmeldungUeberschrift.Location = new System.Drawing.Point(91, 9);
            this.lblAnmeldungUeberschrift.Name = "lblAnmeldungUeberschrift";
            this.lblAnmeldungUeberschrift.Size = new System.Drawing.Size(115, 25);
            this.lblAnmeldungUeberschrift.TabIndex = 2;
            this.lblAnmeldungUeberschrift.Text = "Add Group";
            // 
            // picBxAnmeldungLogo
            // 
            this.picBxAnmeldungLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBxAnmeldungLogo.Image")));
            this.picBxAnmeldungLogo.Location = new System.Drawing.Point(0, 0);
            this.picBxAnmeldungLogo.Name = "picBxAnmeldungLogo";
            this.picBxAnmeldungLogo.Size = new System.Drawing.Size(85, 62);
            this.picBxAnmeldungLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxAnmeldungLogo.TabIndex = 1;
            this.picBxAnmeldungLogo.TabStop = false;
            // 
            // groupBxAddGroup
            // 
            this.groupBxAddGroup.BackColor = System.Drawing.Color.White;
            this.groupBxAddGroup.Controls.Add(this.lblAddGroupNotes);
            this.groupBxAddGroup.Controls.Add(this.richTxtAddGroupNotes);
            this.groupBxAddGroup.Controls.Add(this.txtAddGroupName);
            this.groupBxAddGroup.Controls.Add(this.lblAddGroupName);
            this.groupBxAddGroup.Location = new System.Drawing.Point(3, 21);
            this.groupBxAddGroup.Name = "groupBxAddGroup";
            this.groupBxAddGroup.Size = new System.Drawing.Size(433, 145);
            this.groupBxAddGroup.TabIndex = 11;
            this.groupBxAddGroup.TabStop = false;
            // 
            // lblAddGroupNotes
            // 
            this.lblAddGroupNotes.AutoSize = true;
            this.lblAddGroupNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddGroupNotes.Location = new System.Drawing.Point(6, 121);
            this.lblAddGroupNotes.Name = "lblAddGroupNotes";
            this.lblAddGroupNotes.Size = new System.Drawing.Size(208, 16);
            this.lblAddGroupNotes.TabIndex = 13;
            this.lblAddGroupNotes.Text = "Notes are shown in group tooltips.";
            this.lblAddGroupNotes.Visible = false;
            // 
            // richTxtAddGroupNotes
            // 
            this.richTxtAddGroupNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtAddGroupNotes.Location = new System.Drawing.Point(0, 6);
            this.richTxtAddGroupNotes.Name = "richTxtAddGroupNotes";
            this.richTxtAddGroupNotes.Size = new System.Drawing.Size(433, 111);
            this.richTxtAddGroupNotes.TabIndex = 12;
            this.richTxtAddGroupNotes.Text = "";
            this.richTxtAddGroupNotes.Visible = false;
            // 
            // txtAddGroupName
            // 
            this.txtAddGroupName.Location = new System.Drawing.Point(93, 59);
            this.txtAddGroupName.Name = "txtAddGroupName";
            this.txtAddGroupName.Size = new System.Drawing.Size(322, 20);
            this.txtAddGroupName.TabIndex = 2;
            // 
            // lblAddGroupName
            // 
            this.lblAddGroupName.AutoSize = true;
            this.lblAddGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddGroupName.Location = new System.Drawing.Point(9, 60);
            this.lblAddGroupName.Name = "lblAddGroupName";
            this.lblAddGroupName.Size = new System.Drawing.Size(48, 16);
            this.lblAddGroupName.TabIndex = 0;
            this.lblAddGroupName.Text = "Name:";
            // 
            // btnAddGroupOK
            // 
            this.btnAddGroupOK.AutoSize = true;
            this.btnAddGroupOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGroupOK.Location = new System.Drawing.Point(227, 177);
            this.btnAddGroupOK.Name = "btnAddGroupOK";
            this.btnAddGroupOK.Size = new System.Drawing.Size(90, 27);
            this.btnAddGroupOK.TabIndex = 9;
            this.btnAddGroupOK.Text = "OK";
            this.btnAddGroupOK.UseVisualStyleBackColor = true;
            this.btnAddGroupOK.Click += new System.EventHandler(this.btnAddGroupOK_Click);
            // 
            // btnAddGroupCancel
            // 
            this.btnAddGroupCancel.AutoSize = true;
            this.btnAddGroupCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGroupCancel.Location = new System.Drawing.Point(328, 177);
            this.btnAddGroupCancel.Name = "btnAddGroupCancel";
            this.btnAddGroupCancel.Size = new System.Drawing.Size(90, 27);
            this.btnAddGroupCancel.TabIndex = 10;
            this.btnAddGroupCancel.Text = "Cancel";
            this.btnAddGroupCancel.UseVisualStyleBackColor = true;
            this.btnAddGroupCancel.Click += new System.EventHandler(this.btnAddGroupCancel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemGeneral,
            this.MenuItemNotes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(439, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStripAddGroup";
            // 
            // MenuItemGeneral
            // 
            this.MenuItemGeneral.BackColor = System.Drawing.Color.White;
            this.MenuItemGeneral.Name = "MenuItemGeneral";
            this.MenuItemGeneral.Size = new System.Drawing.Size(59, 20);
            this.MenuItemGeneral.Text = "General";
            this.MenuItemGeneral.Click += new System.EventHandler(this.MenuItemGeneral_Click);
            // 
            // MenuItemNotes
            // 
            this.MenuItemNotes.BackColor = System.Drawing.SystemColors.Control;
            this.MenuItemNotes.Name = "MenuItemNotes";
            this.MenuItemNotes.Size = new System.Drawing.Size(50, 20);
            this.MenuItemNotes.Text = "Notes";
            this.MenuItemNotes.Click += new System.EventHandler(this.MenuItemNotes_Click);
            // 
            // FrmAddGroup
            // 
            this.AcceptButton = this.btnAddGroupOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 286);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Group";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBxAnmeldungLogo)).EndInit();
            this.groupBxAddGroup.ResumeLayout(false);
            this.groupBxAddGroup.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox picBxAnmeldungLogo;
        private System.Windows.Forms.Label lblAnmeldungPfad;
        private System.Windows.Forms.Label lblAnmeldungUeberschrift;
        private System.Windows.Forms.GroupBox groupBxAddGroup;
        private System.Windows.Forms.Button btnAddGroupOK;
        private System.Windows.Forms.Button btnAddGroupCancel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemGeneral;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNotes;
        private System.Windows.Forms.Label lblAddGroupName;
        private System.Windows.Forms.TextBox txtAddGroupName;
        private System.Windows.Forms.Label lblAddGroupNotes;
        private System.Windows.Forms.RichTextBox richTxtAddGroupNotes;
    }
}