namespace AccountManager
{
    partial class FrmUebersicht
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUebersicht));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.picBxAddGroup = new System.Windows.Forms.PictureBox();
            this.picBxMenuInfo = new System.Windows.Forms.PictureBox();
            this.picBxSecurity = new System.Windows.Forms.PictureBox();
            this.picBxNewEntry = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemChanceKey = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLockWorkspace = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAddGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDeleteGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEmptyBin = new System.Windows.Forms.ToolStripMenuItem();
            this.entryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAddEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAboutApp = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeViewFolder = new System.Windows.Forms.TreeView();
            this.imgOrdner = new System.Windows.Forms.ImageList(this.components);
            this.listViewEntrys = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.URL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgAccounts = new System.Windows.Forms.ImageList(this.components);
            this.imgMenu = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxAddGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxMenuInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxSecurity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxNewEntry)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.picBxAddGroup);
            this.splitContainer1.Panel1.Controls.Add(this.picBxMenuInfo);
            this.splitContainer1.Panel1.Controls.Add(this.picBxSecurity);
            this.splitContainer1.Panel1.Controls.Add(this.picBxNewEntry);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.HSplit;
            // 
            // picBxAddGroup
            // 
            resources.ApplyResources(this.picBxAddGroup, "picBxAddGroup");
            this.picBxAddGroup.Name = "picBxAddGroup";
            this.picBxAddGroup.TabStop = false;
            this.picBxAddGroup.Click += new System.EventHandler(this.picBxAddGroup_Click);
            // 
            // picBxMenuInfo
            // 
            resources.ApplyResources(this.picBxMenuInfo, "picBxMenuInfo");
            this.picBxMenuInfo.Name = "picBxMenuInfo";
            this.picBxMenuInfo.TabStop = false;
            this.picBxMenuInfo.Click += new System.EventHandler(this.picBxMenuInfo_Click);
            // 
            // picBxSecurity
            // 
            resources.ApplyResources(this.picBxSecurity, "picBxSecurity");
            this.picBxSecurity.Name = "picBxSecurity";
            this.picBxSecurity.TabStop = false;
            this.picBxSecurity.Click += new System.EventHandler(this.picBxSecurity_Click);
            // 
            // picBxNewEntry
            // 
            resources.ApplyResources(this.picBxNewEntry, "picBxNewEntry");
            this.picBxNewEntry.Name = "picBxNewEntry";
            this.picBxNewEntry.TabStop = false;
            this.picBxNewEntry.Click += new System.EventHandler(this.picBxNewEntry_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.groupToolStripMenuItem,
            this.entryToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemChanceKey,
            this.MenuItemLockWorkspace,
            this.MenuItemExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // MenuItemChanceKey
            // 
            resources.ApplyResources(this.MenuItemChanceKey, "MenuItemChanceKey");
            this.MenuItemChanceKey.Name = "MenuItemChanceKey";
            this.MenuItemChanceKey.Click += new System.EventHandler(this.MenuItemChanceKey_Click);
            // 
            // MenuItemLockWorkspace
            // 
            resources.ApplyResources(this.MenuItemLockWorkspace, "MenuItemLockWorkspace");
            this.MenuItemLockWorkspace.Name = "MenuItemLockWorkspace";
            this.MenuItemLockWorkspace.Click += new System.EventHandler(this.MenuItemLockWorkspace_Click);
            // 
            // MenuItemExit
            // 
            resources.ApplyResources(this.MenuItemExit, "MenuItemExit");
            this.MenuItemExit.Name = "MenuItemExit";
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAddGroup,
            this.MenuItemEditGroup,
            this.MenuItemDeleteGroup,
            this.MenuItemEmptyBin});
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            resources.ApplyResources(this.groupToolStripMenuItem, "groupToolStripMenuItem");
            // 
            // MenuItemAddGroup
            // 
            resources.ApplyResources(this.MenuItemAddGroup, "MenuItemAddGroup");
            this.MenuItemAddGroup.Name = "MenuItemAddGroup";
            this.MenuItemAddGroup.Click += new System.EventHandler(this.picBxAddGroup_Click);
            // 
            // MenuItemEditGroup
            // 
            resources.ApplyResources(this.MenuItemEditGroup, "MenuItemEditGroup");
            this.MenuItemEditGroup.Name = "MenuItemEditGroup";
            this.MenuItemEditGroup.Click += new System.EventHandler(this.MenuItemEditGroup_Click);
            // 
            // MenuItemDeleteGroup
            // 
            resources.ApplyResources(this.MenuItemDeleteGroup, "MenuItemDeleteGroup");
            this.MenuItemDeleteGroup.Name = "MenuItemDeleteGroup";
            this.MenuItemDeleteGroup.Click += new System.EventHandler(this.DeleteGroup);
            // 
            // MenuItemEmptyBin
            // 
            this.MenuItemEmptyBin.Name = "MenuItemEmptyBin";
            resources.ApplyResources(this.MenuItemEmptyBin, "MenuItemEmptyBin");
            this.MenuItemEmptyBin.Click += new System.EventHandler(this.EmptyRecycleBin);
            // 
            // entryToolStripMenuItem
            // 
            this.entryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAddEntry,
            this.MenuItemEditEntry,
            this.toolStripMenuItem2});
            this.entryToolStripMenuItem.Name = "entryToolStripMenuItem";
            resources.ApplyResources(this.entryToolStripMenuItem, "entryToolStripMenuItem");
            // 
            // MenuItemAddEntry
            // 
            resources.ApplyResources(this.MenuItemAddEntry, "MenuItemAddEntry");
            this.MenuItemAddEntry.Name = "MenuItemAddEntry";
            this.MenuItemAddEntry.Click += new System.EventHandler(this.addEntryToolStripMenuItem_Click);
            // 
            // MenuItemEditEntry
            // 
            resources.ApplyResources(this.MenuItemEditEntry, "MenuItemEditEntry");
            this.MenuItemEditEntry.Name = "MenuItemEditEntry";
            this.MenuItemEditEntry.Click += new System.EventHandler(this.MenuItemEditEntry_Click);
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAboutApp});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // MenuItemAboutApp
            // 
            resources.ApplyResources(this.MenuItemAboutApp, "MenuItemAboutApp");
            this.MenuItemAboutApp.Name = "MenuItemAboutApp";
            this.MenuItemAboutApp.Click += new System.EventHandler(this.MenuItemAboutApp_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Cursor = System.Windows.Forms.Cursors.VSplit;
            resources.ApplyResources(this.splitContainer2, "splitContainer2");
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.treeViewFolder);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listViewEntrys);
            // 
            // treeViewFolder
            // 
            this.treeViewFolder.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.treeViewFolder, "treeViewFolder");
            this.treeViewFolder.FullRowSelect = true;
            this.treeViewFolder.ImageList = this.imgOrdner;
            this.treeViewFolder.Name = "treeViewFolder";
            this.treeViewFolder.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewFolder_NodeMouseClick);
            this.treeViewFolder.DoubleClick += new System.EventHandler(this.treeViewFolder_DoubleClick);
            // 
            // imgOrdner
            // 
            this.imgOrdner.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgOrdner.ImageStream")));
            this.imgOrdner.TransparentColor = System.Drawing.Color.Transparent;
            this.imgOrdner.Images.SetKeyName(0, "folder_bank.jpg");
            this.imgOrdner.Images.SetKeyName(1, "korb2.png");
            // 
            // listViewEntrys
            // 
            this.listViewEntrys.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewEntrys.AllowColumnReorder = true;
            this.listViewEntrys.AllowDrop = true;
            this.listViewEntrys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewEntrys.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.UserName,
            this.Password,
            this.URL,
            this.Note});
            this.listViewEntrys.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewEntrys.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.listViewEntrys, "listViewEntrys");
            this.listViewEntrys.FullRowSelect = true;
            this.listViewEntrys.GridLines = true;
            this.listViewEntrys.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("listViewEntrys.Groups"))),
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("listViewEntrys.Groups1"))),
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("listViewEntrys.Groups2"))),
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("listViewEntrys.Groups3"))),
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("listViewEntrys.Groups4"))),
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("listViewEntrys.Groups5")))});
            this.listViewEntrys.HideSelection = false;
            this.listViewEntrys.LabelEdit = true;
            this.listViewEntrys.MultiSelect = false;
            this.listViewEntrys.Name = "listViewEntrys";
            this.listViewEntrys.SmallImageList = this.imgAccounts;
            this.listViewEntrys.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewEntrys.UseCompatibleStateImageBehavior = false;
            this.listViewEntrys.View = System.Windows.Forms.View.Details;
            this.listViewEntrys.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // Title
            // 
            resources.ApplyResources(this.Title, "Title");
            // 
            // UserName
            // 
            resources.ApplyResources(this.UserName, "UserName");
            // 
            // Password
            // 
            resources.ApplyResources(this.Password, "Password");
            // 
            // URL
            // 
            resources.ApplyResources(this.URL, "URL");
            // 
            // Note
            // 
            resources.ApplyResources(this.Note, "Note");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEntryToolStripMenuItem,
            this.editEntryToolStripMenuItem,
            this.deleteEntryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // addEntryToolStripMenuItem
            // 
            this.addEntryToolStripMenuItem.Name = "addEntryToolStripMenuItem";
            resources.ApplyResources(this.addEntryToolStripMenuItem, "addEntryToolStripMenuItem");
            this.addEntryToolStripMenuItem.Click += new System.EventHandler(this.addEntryToolStripMenuItem_Click_1);
            // 
            // editEntryToolStripMenuItem
            // 
            this.editEntryToolStripMenuItem.Name = "editEntryToolStripMenuItem";
            resources.ApplyResources(this.editEntryToolStripMenuItem, "editEntryToolStripMenuItem");
            this.editEntryToolStripMenuItem.Click += new System.EventHandler(this.editEntryToolStripMenuItem_Click);
            // 
            // deleteEntryToolStripMenuItem
            // 
            this.deleteEntryToolStripMenuItem.Name = "deleteEntryToolStripMenuItem";
            resources.ApplyResources(this.deleteEntryToolStripMenuItem, "deleteEntryToolStripMenuItem");
            // 
            // imgAccounts
            // 
            this.imgAccounts.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgAccounts.ImageStream")));
            this.imgAccounts.TransparentColor = System.Drawing.Color.Transparent;
            this.imgAccounts.Images.SetKeyName(0, "kee2.jpg");
            this.imgAccounts.Images.SetKeyName(1, "key1.png");
            // 
            // imgMenu
            // 
            this.imgMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMenu.ImageStream")));
            this.imgMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMenu.Images.SetKeyName(0, "new.png");
            this.imgMenu.Images.SetKeyName(1, "schloss.png");
            this.imgMenu.Images.SetKeyName(2, "kreis_kreus.png");
            this.imgMenu.Images.SetKeyName(3, "lupe.png");
            this.imgMenu.Images.SetKeyName(4, "keyPlus.png");
            this.imgMenu.Images.SetKeyName(5, "key_minus.png");
            // 
            // FrmUebersicht
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmUebersicht";
            this.Load += new System.EventHandler(this.FrmUebersicht_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBxAddGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxMenuInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxSecurity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxNewEntry)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ImageList imgOrdner;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader UserName;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader URL;
        private System.Windows.Forms.ColumnHeader Note;
        public System.Windows.Forms.ImageList imgAccounts;
        private System.Windows.Forms.PictureBox picBxNewEntry;
        private System.Windows.Forms.PictureBox picBxSecurity;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLockWorkspace;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAboutApp;
        private System.Windows.Forms.ImageList imgMenu;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAddGroup;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditGroup;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDeleteGroup;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEmptyBin;
        private System.Windows.Forms.ToolStripMenuItem MenuItemChanceKey;
        private System.Windows.Forms.PictureBox picBxMenuInfo;
        private System.Windows.Forms.PictureBox picBxAddGroup;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem entryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAddEntry;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditEntry;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        public System.Windows.Forms.TreeView treeViewFolder;
        public System.Windows.Forms.ListView listViewEntrys;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEntryToolStripMenuItem;
    }
}