namespace AccountManager
{
    partial class FrmEditGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditGroup));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblEditGroupPfad = new System.Windows.Forms.Label();
            this.lblEditGroupUeberschrift = new System.Windows.Forms.Label();
            this.picBxEditGroup = new System.Windows.Forms.PictureBox();
            this.groupBxAddGroup = new System.Windows.Forms.GroupBox();
            this.richTxtEditGroupNotes = new System.Windows.Forms.RichTextBox();
            this.lblEditGroupNotes = new System.Windows.Forms.Label();
            this.txtEditGroupName = new System.Windows.Forms.TextBox();
            this.lblEditGroupName = new System.Windows.Forms.Label();
            this.btnEditGroupOK = new System.Windows.Forms.Button();
            this.btnEditGroupCancel = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.MenuItemEditGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditNotes = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxEditGroup)).BeginInit();
            this.groupBxAddGroup.SuspendLayout();
            this.menuStrip2.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.lblEditGroupPfad);
            this.splitContainer1.Panel1.Controls.Add(this.lblEditGroupUeberschrift);
            this.splitContainer1.Panel1.Controls.Add(this.picBxEditGroup);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBxAddGroup);
            this.splitContainer1.Panel2.Controls.Add(this.btnEditGroupOK);
            this.splitContainer1.Panel2.Controls.Add(this.btnEditGroupCancel);
            this.splitContainer1.Panel2.Controls.Add(this.menuStrip2);
            this.splitContainer1.Size = new System.Drawing.Size(439, 286);
            this.splitContainer1.SplitterDistance = 64;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblEditGroupPfad
            // 
            this.lblEditGroupPfad.AutoSize = true;
            this.lblEditGroupPfad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditGroupPfad.ForeColor = System.Drawing.Color.White;
            this.lblEditGroupPfad.Location = new System.Drawing.Point(98, 37);
            this.lblEditGroupPfad.Name = "lblEditGroupPfad";
            this.lblEditGroupPfad.Size = new System.Drawing.Size(279, 16);
            this.lblEditGroupPfad.TabIndex = 5;
            this.lblEditGroupPfad.Text = "Edit properties of the currently selected group.";
            // 
            // lblEditGroupUeberschrift
            // 
            this.lblEditGroupUeberschrift.AutoSize = true;
            this.lblEditGroupUeberschrift.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditGroupUeberschrift.ForeColor = System.Drawing.Color.White;
            this.lblEditGroupUeberschrift.Location = new System.Drawing.Point(91, 9);
            this.lblEditGroupUeberschrift.Name = "lblEditGroupUeberschrift";
            this.lblEditGroupUeberschrift.Size = new System.Drawing.Size(114, 25);
            this.lblEditGroupUeberschrift.TabIndex = 4;
            this.lblEditGroupUeberschrift.Text = "Edit Group";
            // 
            // picBxEditGroup
            // 
            this.picBxEditGroup.Image = ((System.Drawing.Image)(resources.GetObject("picBxEditGroup.Image")));
            this.picBxEditGroup.Location = new System.Drawing.Point(0, 0);
            this.picBxEditGroup.Name = "picBxEditGroup";
            this.picBxEditGroup.Size = new System.Drawing.Size(85, 62);
            this.picBxEditGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxEditGroup.TabIndex = 2;
            this.picBxEditGroup.TabStop = false;
            // 
            // groupBxAddGroup
            // 
            this.groupBxAddGroup.BackColor = System.Drawing.Color.White;
            this.groupBxAddGroup.Controls.Add(this.richTxtEditGroupNotes);
            this.groupBxAddGroup.Controls.Add(this.lblEditGroupNotes);
            this.groupBxAddGroup.Controls.Add(this.txtEditGroupName);
            this.groupBxAddGroup.Controls.Add(this.lblEditGroupName);
            this.groupBxAddGroup.Location = new System.Drawing.Point(3, 27);
            this.groupBxAddGroup.Name = "groupBxAddGroup";
            this.groupBxAddGroup.Size = new System.Drawing.Size(433, 145);
            this.groupBxAddGroup.TabIndex = 19;
            this.groupBxAddGroup.TabStop = false;
            // 
            // richTxtEditGroupNotes
            // 
            this.richTxtEditGroupNotes.BackColor = System.Drawing.Color.White;
            this.richTxtEditGroupNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtEditGroupNotes.Location = new System.Drawing.Point(0, 5);
            this.richTxtEditGroupNotes.Name = "richTxtEditGroupNotes";
            this.richTxtEditGroupNotes.Size = new System.Drawing.Size(433, 113);
            this.richTxtEditGroupNotes.TabIndex = 14;
            this.richTxtEditGroupNotes.Text = "";
            this.richTxtEditGroupNotes.Visible = false;
            // 
            // lblEditGroupNotes
            // 
            this.lblEditGroupNotes.AutoSize = true;
            this.lblEditGroupNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditGroupNotes.Location = new System.Drawing.Point(6, 121);
            this.lblEditGroupNotes.Name = "lblEditGroupNotes";
            this.lblEditGroupNotes.Size = new System.Drawing.Size(208, 16);
            this.lblEditGroupNotes.TabIndex = 13;
            this.lblEditGroupNotes.Text = "Notes are shown in group tooltips.";
            this.lblEditGroupNotes.Visible = false;
            // 
            // txtEditGroupName
            // 
            this.txtEditGroupName.Location = new System.Drawing.Point(97, 58);
            this.txtEditGroupName.Name = "txtEditGroupName";
            this.txtEditGroupName.Size = new System.Drawing.Size(313, 20);
            this.txtEditGroupName.TabIndex = 2;
            // 
            // lblEditGroupName
            // 
            this.lblEditGroupName.AutoSize = true;
            this.lblEditGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditGroupName.Location = new System.Drawing.Point(13, 59);
            this.lblEditGroupName.Name = "lblEditGroupName";
            this.lblEditGroupName.Size = new System.Drawing.Size(48, 16);
            this.lblEditGroupName.TabIndex = 0;
            this.lblEditGroupName.Text = "Name:";
            // 
            // btnEditGroupOK
            // 
            this.btnEditGroupOK.AutoSize = true;
            this.btnEditGroupOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditGroupOK.Location = new System.Drawing.Point(227, 180);
            this.btnEditGroupOK.Name = "btnEditGroupOK";
            this.btnEditGroupOK.Size = new System.Drawing.Size(90, 27);
            this.btnEditGroupOK.TabIndex = 14;
            this.btnEditGroupOK.Text = "OK";
            this.btnEditGroupOK.UseVisualStyleBackColor = true;
            this.btnEditGroupOK.Click += new System.EventHandler(this.btnEditGroupOK_Click);
            // 
            // btnEditGroupCancel
            // 
            this.btnEditGroupCancel.AutoSize = true;
            this.btnEditGroupCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditGroupCancel.Location = new System.Drawing.Point(328, 180);
            this.btnEditGroupCancel.Name = "btnEditGroupCancel";
            this.btnEditGroupCancel.Size = new System.Drawing.Size(90, 27);
            this.btnEditGroupCancel.TabIndex = 15;
            this.btnEditGroupCancel.Text = "Cancel";
            this.btnEditGroupCancel.UseVisualStyleBackColor = true;
            this.btnEditGroupCancel.Click += new System.EventHandler(this.btnAddGroupCancel_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemEditGeneral,
            this.MenuItemEditNotes});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(439, 24);
            this.menuStrip2.TabIndex = 18;
            this.menuStrip2.Text = "menuStripEditGroup";
            // 
            // MenuItemEditGeneral
            // 
            this.MenuItemEditGeneral.BackColor = System.Drawing.Color.White;
            this.MenuItemEditGeneral.Name = "MenuItemEditGeneral";
            this.MenuItemEditGeneral.Size = new System.Drawing.Size(59, 20);
            this.MenuItemEditGeneral.Text = "General";
            this.MenuItemEditGeneral.Click += new System.EventHandler(this.MenuItemGeneral_Click);
            // 
            // MenuItemEditNotes
            // 
            this.MenuItemEditNotes.Name = "MenuItemEditNotes";
            this.MenuItemEditNotes.Size = new System.Drawing.Size(50, 20);
            this.MenuItemEditNotes.Text = "Notes";
            this.MenuItemEditNotes.Click += new System.EventHandler(this.MenuItemEditNotes_Click);
            // 
            // FrmEditGroup
            // 
            this.AcceptButton = this.btnEditGroupOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 286);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip2;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Group";
            this.Load += new System.EventHandler(this.FrmEditGroup_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBxEditGroup)).EndInit();
            this.groupBxAddGroup.ResumeLayout(false);
            this.groupBxAddGroup.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox picBxEditGroup;
        private System.Windows.Forms.Label lblEditGroupPfad;
        private System.Windows.Forms.Label lblEditGroupUeberschrift;
        private System.Windows.Forms.Button btnEditGroupOK;
        private System.Windows.Forms.Button btnEditGroupCancel;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditGeneral;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditNotes;
        private System.Windows.Forms.GroupBox groupBxAddGroup;
        private System.Windows.Forms.Label lblEditGroupNotes;
        private System.Windows.Forms.TextBox txtEditGroupName;
        private System.Windows.Forms.Label lblEditGroupName;
        private System.Windows.Forms.RichTextBox richTxtEditGroupNotes;
    }
}