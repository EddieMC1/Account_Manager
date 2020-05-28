using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using AccountManagerAssistent;
using System.Windows.Forms.VisualStyles;
using System.Linq.Expressions;

namespace AccountManager
{
    public partial class FrmUebersicht : Form
    {
        public HandlerDB handler = new HandlerDB();
        FrmAnmeldung anmeldung = new FrmAnmeldung();

        public FrmUebersicht()
        {
            InitializeComponent();
        }


        // Beim Load die Gruppen und Entries aus DB laden
        public void FrmUebersicht_Load(object sender, EventArgs e)
        {
            handler.GetEntryDB();

            // Start Login
            if (anmeldung.ShowDialog() == DialogResult.OK)
            {
                updateTreeView(handler);
            }
            else
            {
                treeViewFolder.Enabled = false;
                listViewEntrys.Enabled = false;
            }
            List<Group> groupGet = handler.GetGroups();
            
        }

        public void loadTwo()
        {
            
            updateTreeView(handler);
           
        }

        private void updateTreeView(HandlerDB handler)
        {
            treeViewFolder.Nodes.Clear();
           
            
            treeViewFolder.Nodes.Add(CreateContextMenuGroups("Recycle Bin", false));

            treeViewFolder.Nodes[0].ImageIndex = 1;
            treeViewFolder.Nodes[0].SelectedImageIndex = 1;

            foreach (Group group in handler.GetGroups())
            {
                treeViewFolder.Nodes.Add(CreateContextMenuGroups(group.Group_name, false));
            }

            //treeViewFolder.Nodes.Find("Recycle Bin", true)[0].ImageIndex = 1;
            //treeViewFolder.Nodes.Find("Recycle Bin", true)[0].SelectedImageIndex = 1;

            foreach (Group group in handler.GetRecycleBin())
            {
                treeViewFolder.Nodes[0].Nodes.Add(CreateContextMenuGroups(group.Group_name, true));
                //treeViewFolder.Nodes.Find("Recycle Bin", true)[0].Nodes.Add(CreateItem(group.Group_name));
            }

            //createContextMenuGroup();
        }

        // ----------------------------------------------------------
        public TreeNode CreateContextMenuGroups(string groupName, bool recycleBin)
        {
            ContextMenu menu = new ContextMenu();

            if (recycleBin)
            {
                MenuItem[] items = { new MenuItem("Restore Group"), new MenuItem("Delete Group") };
 
                items[1].Click += new EventHandler(this.DeletePermanent);
                items[0].Click += new EventHandler(this.RestoreGroup);

                menu.MenuItems.AddRange(items);
            }
            else
            {
                MenuItem[] items = { new MenuItem("Add Group"), new MenuItem("Edit Group"), new MenuItem("Delete Group") };

                
                items[0].Click += new EventHandler(this.AddGroup);
                items[1].Click += new EventHandler(this.EditGroup);
                items[2].Click += new EventHandler(this.DeleteGroup);

                menu.MenuItems.AddRange(items);
            }

            if (groupName.Equals("Recycle Bin"))
            {
                MenuItem emptyRecycleBinItem = new MenuItem("Empty Recycle Bin");

                emptyRecycleBinItem.Click += new EventHandler(this.EmptyRecycleBin);

                menu.MenuItems.Add(emptyRecycleBinItem);
            }

            //treeViewFolder.Nodes.Add(groupName, groupName);
            //treeViewFolder.Nodes.Find(groupName, true)[0].ContextMenu = menu;
            TreeNode node = new TreeNode(groupName);

            node.ContextMenu = menu;

            return node;

        }

        private void EmptyRecycleBin(object sender, EventArgs e)
        {
            handler.ClearRecycleBin();

            treeViewFolder.Nodes[0].Nodes.Clear();
        }

        private void AddGroup(object sender, EventArgs e)
        {
            new FrmAddGroup().Show();
        }
        private void EditGroup(object sender, EventArgs e)
        {
            new FrmEditGroup(treeViewFolder.SelectedNode.Text).Show();
        }

        private void DeleteGroup(object sender, EventArgs e)
        {
            if (treeViewFolder.SelectedNode == null)
            {
                MessageBox.Show("Select a group from the list!");
            }
            else
            {
                TreeNode node = treeViewFolder.SelectedNode;

                handler.MoveToTrash(node.Text);
                treeViewFolder.Nodes.Remove(node);
                treeViewFolder.Nodes[0].Nodes.Add(CreateContextMenuGroups(node.Text, true));
                //treeViewFolder.Nodes.RemoveByKey(node.Text);
                //treeViewFolder.Nodes.Find("Recycle Bin", true)[0].Nodes.Add(node);
            }
        }

        private void DeletePermanent(object sender, EventArgs e)
        {
            TreeNode node = treeViewFolder.SelectedNode;

            handler.DeleteGroupPermanent(node.Text);
            treeViewFolder.Nodes[0].Nodes.Remove(node);
        }

        private void RestoreGroup(object sender, EventArgs e)
        {
            TreeNode node = treeViewFolder.SelectedNode;

            handler.MoveToGroups(node.Text);
            treeViewFolder.Nodes[0].Nodes.Remove(node);
            treeViewFolder.Nodes.Add(CreateContextMenuGroups(node.Text, false));
            //treeViewFolder.Nodes.Find("Recycle Bin", true)[0].Nodes.RemoveByKey(node.Text);
            //treeViewFolder.Nodes.Add(node.Text);
        }

        private void addEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddEntry addEntry = new FrmAddEntry();
            addEntry.Show();
        }

        #region doubleClick
        private void treeViewFolder_DoubleClick(object sender, EventArgs e)
        {
            // führe GetSubNodes aus (von Gruppenname)
            // diese als Subknoten in treeView eintragen


            //    string group_name = this.treeViewHierarchie.SelectedNode.Text;
            //    handler.GetEntryDB(group_name);


            // irgendwie herausfinden, ob Ober- oder Unterknoten ausgewählt ist
            //if(Oberknoten)
            //{
            //
            //foreach(Entry ent in handler.EntryList)
            //{
            //    if(!treeViewHierarchie.SelectedNode.Nodes.Contains(title)
            //    { 
            //        treeViewHierarchie.SelectedNode.Nodes.Add(ent.Title);
            //    }
            //}
            //}
            //else if(Kindknoten)
            //{
            //    schleife durch entryList machen und nach title selektieren und in ListView einfügen


            //if (this.treeViewHierarchie.SelectedNode != null)
            //{
            //    string group_name = this.treeViewHierarchie.SelectedNode.Text;
            //    handler.GetSubNodes(group_name);
            //}

            //return;
        }
        #endregion

        #region Info
        private void MenuItemAboutApp_Click(object sender, EventArgs e)
        {
            FrmInfo info = new FrmInfo();
            info.Show();
        }
        #endregion

        private void picBxMenuInfo_Click(object sender, EventArgs e)
        {
            FrmInfo info = new FrmInfo();
            info.Show();
        }

        private void picBxAddGroup_Click(object sender, EventArgs e)
        {
            FrmAddGroup addGroup = new FrmAddGroup();
            addGroup.Show();
        }

        private void picBxSecurity_Click(object sender, EventArgs e)
        {
            treeViewFolder.Visible = false;
            listViewEntrys.Visible = false;

            FrmAnmeldung anmeldung = new FrmAnmeldung();
            anmeldung.ShowDialog();

            treeViewFolder.Visible = true;
            listViewEntrys.Visible = true;
        }

        private void MenuItemLockWorkspace_Click(object sender, EventArgs e)
        {
            treeViewFolder.Visible = false;
            listViewEntrys.Visible = false;

            FrmAnmeldung anmeldung = new FrmAnmeldung();
            anmeldung.ShowDialog();

            treeViewFolder.Visible = true;
            listViewEntrys.Visible = true;
        }

        private void MenuItemEditGroup_Click(object sender, EventArgs e)
        {
            if (treeViewFolder.SelectedNode == null)
            {
                MessageBox.Show("Select a group from the list!");
            } else
            {
                FrmEditGroup editGroup = new FrmEditGroup(treeViewFolder.SelectedNode.Text);
                editGroup.Show();
            }
        }

        private void picBxNewEntry_Click(object sender, EventArgs e)
        {
            FrmAddEntry addEntry = new FrmAddEntry();
            addEntry.Show();
        }

        private void MenuItemChanceKey_Click(object sender, EventArgs e)
        {
            FrmCreatePassword creatPass = new FrmCreatePassword();
            creatPass.Show();
        }

        #region button1_click
        //private void button1_Click(object sender, EventArgs e) // Group g als Parameter, ImageIndex als Parameter
        //{
        //    TreeNode node = new TreeNode();
        //    node.Text = "Test"; // node.Test = g.Name;
        //    node.Name = "Test"; // node.Name = g.Name;
        //    int i = 0;
        //    node.ImageIndex = imgOrdner.Images.IndexOfKey(i.ToString()); // ImageIndex.ToString()
        //    treeViewFolder.Nodes.Add(node);
        //}
        #endregion

        #region AddGroup_Close
        public void AddGroup_Close(object sender, EventArgs e)
        {
            //Group g;
            //if (sender = FrmAddGroup)
            //{
            // if(sender.DialogResult == DialogResult.OK)
            //{
                // this.g = sender.g;
                // Methodenaufruf an Methode, die Gruppe in Treeview einfügt (Bsp. button1_Click)
            //}
            //}
        }
        #endregion

        private void MenuItemEditEntry_Click(object sender, EventArgs e)
        {
            //new FrmEditEntry(listViewEntrys.SelectedItems.ToString()).Show();

            ListViewItem item;

            if (listViewEntrys.SelectedItems.Count == 0)
            {
                if (listViewEntrys.Items.Count == 0)
                {
                    MessageBox.Show("No entries!");

                    return;
                }
                else
                {
                    item = listViewEntrys.Items[0];
                }
            }
            else
            {
                item = listViewEntrys.SelectedItems[0];
            }

            //MessageBox.Show(item.Text + item.SubItems[1].Text + item.SubItems[2].Text + item.SubItems[3].Text +  item.SubItems[4].Text + treeViewFolder.SelectedNode.Text);

            Entry entry = null;

            foreach (Entry entryList in handler.EntryList)
            {
                if (entryList.Title.Equals(item.Text))
                {
                    entry = entryList;
                }
            }
            new FrmEditEntry(entry).Show();

            //new FrmEditEntry(listViewEntrys.SelectedItems.ToString()).Show();

            //editEntry.LadeDaten(listViewEntrys.SelectedItems.ToString());
            //editEntry.ShowDialog();

            //editEntry.Close();

        }

        private void treeViewFolder_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            listViewEntrys.Items.Clear();

            if (e.Button == MouseButtons.Left)
            {
                for (int i = 0; i < handler.EntryList.Count; i++)
                {
                    if (handler.EntryList[i].Group_name.Equals(e.Node.Text))
                    {

                        ListViewItem item = new ListViewItem(handler.EntryList[i].Title);
                        item.SubItems.Add(handler.EntryList[i].Username);
                        item.SubItems.Add(handler.EntryList[i].Password);
                        item.SubItems.Add(handler.EntryList[i].Url);
                        item.SubItems.Add(handler.EntryList[i].Notes);
                        item.ImageIndex = 0;

                        listViewEntrys.Items.Add(item);
                        //treeViewFolder.Nodes.Find(groupName, true)[0].ContextMenu = menu;
                    }
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                treeViewFolder.SelectedNode = e.Node;
            }
        }

        #region Text1
        public string content = "Your data will be stored in an Account Manager database file, which is a regular file. After clicking "
            + "[OK], you will be prompted to specify the location where Account Manager should save this file.\n\n"
            + "It is important that you remember where the database file is stored.\n\n"
            + "You should regularly create a backup of the database file (onto an independent data storage device).";
        #endregion

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listViewEntrys.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void addEntryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmAddEntry addEntry = new FrmAddEntry(treeViewFolder.SelectedNode.Text);

            if (addEntry.ShowDialog() == DialogResult.OK)
            {
                addEntry.Close();
            }
        }

        private void editEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item;

            if (listViewEntrys.SelectedItems.Count == 0)
            {
                if (listViewEntrys.Items.Count == 0)
                {
                    MessageBox.Show("No entries!");

                    return;
                } else
                {
                    item = listViewEntrys.Items[0];
                }
            } else
            {
                item = listViewEntrys.SelectedItems[0];
            }

            //MessageBox.Show(item.Text + item.SubItems[1].Text + item.SubItems[2].Text + item.SubItems[3].Text +  item.SubItems[4].Text + treeViewFolder.SelectedNode.Text);

            Entry entry = null;

            foreach (Entry entryList in handler.EntryList)
            {
                if (entryList.Title.Equals(item.Text))
                {
                    entry = entryList;
                }
            }

            new FrmEditEntry(entry).Show();
            //new FrmEditEntry(listViewEntrys.SelectedItems.ToString()).Show();

            //editEntry.LadeDaten(listViewEntrys.SelectedItems.ToString());
            //editEntry.ShowDialog();

            //editEntry.Close();
        }
    }
}
