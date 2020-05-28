using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace AccountManager
{
    public class HandlerDB
    {
        public static string connectString = "datasource = 127.0.0.1; port = 3307; username = admin123; password = admin123; database = entry_db";
        private List<Entry> entryList;
        private List<Group> groupList;
        private string EncKey_DB = "1234";
        private MySqlConnection connection;
        Encryption enc = new Encryption();

        public HandlerDB()
        {
            this.entryList = new List<Entry>();
            this.groupList = new List<Group>();
            connection = new MySqlConnection(connectString);
        }

        internal List<Entry> EntryList { get => entryList; set => entryList = value; }
        internal List<Group> GroupList { get => groupList; set => groupList = value; }


        // ------------------- Groups -----------------------------

        // wird in Form_Load aufgerufen
        public List<Group> GetGroups()
        {
            GroupList.Clear();

            MySqlConnection dbConnect;
            try
            {
                dbConnect = new MySqlConnection(connectString);

                dbConnect.Open();

                if (dbConnect.State == System.Data.ConnectionState.Open)
                {
                    string sql = "SELECT group_name FROM groups";

                    using (MySqlCommand command = new MySqlCommand(sql, dbConnect))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string empty = "";

                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    empty += reader.GetString(i);
                                }
                               
                                GroupList.Add(new Group(empty));
                            }
                        }
                    }
                }
                dbConnect.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return GroupList;
        }

        public void SetGroups(string group_name, string notes)
        {
            try
            {
                connection.Open();

                if (connection.State == System.Data.ConnectionState.Open)
                {
                    string insertSql = "INSERT INTO `groups` (`group_name`, `notes`) VALUES ('" + group_name + "', '" + notes + "')";

                    MySqlCommand command = new MySqlCommand(insertSql, connection);

                    command.ExecuteNonQuery();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                connection.Close();
            }
        }

        public void DeleteGroups(string group_name)
        {
            try
            {
                connection.Open();

                if (connection.State == System.Data.ConnectionState.Open)
                {
                    string insertSql = "DELETE FROM groups WHERE group_name = '" + group_name + "';";


                    MySqlCommand command = new MySqlCommand(insertSql, connection);

                    command.ExecuteNonQuery();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                connection.Close();
            }
        }

        public void DeleteGroupPermanent(string group_name)
        {
            connection.Open();

            string recycleBinSql = "DELETE FROM recycle_bin WHERE group_name = '" + group_name + "'";
            string entriesSql = "DELETE FROM entries WHERE group_name='" + group_name + "'";

            MySqlCommand command = new MySqlCommand(recycleBinSql, connection);

            command.ExecuteNonQuery();
            command.CommandText = entriesSql;
            command.ExecuteNonQuery();

            connection.Close();
        }

        public string GetGroupNotes(string group_name)
        {
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT notes FROM groups WHERE group_name = '" + group_name + "'", connection);

            try
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader.GetString(0);
                    }
                }

                return "";
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdateGroup(string old_group_name, string new_group_name, string notes)
        {
            connection.Open();

            string groupSql = "UPDATE groups SET group_name='" + new_group_name + "', notes='" + notes + "' WHERE group_name='" + old_group_name + "'";
            string entriesSql = "UPDATE entries SET group_name='" + new_group_name + "' WHERE group_name='" + old_group_name + "'";

            MySqlCommand command = new MySqlCommand(groupSql, connection);

            command.ExecuteNonQuery();
            command.CommandText = entriesSql;
            command.ExecuteNonQuery();

            connection.Close();

        }

        public void MoveToTrash(string group_name)
        {
            connection.Open();

            string deleteSql = "DELETE FROM groups WHERE group_name = '" + group_name + "'";
            string addSql = "INSERT INTO recycle_bin (group_name) VALUES ('" + group_name + "')";

            MySqlCommand command = new MySqlCommand(deleteSql, connection);

            command.ExecuteNonQuery();
            command.CommandText = addSql;
            command.ExecuteNonQuery();

            connection.Close();

        }

        public void MoveToGroups(string group_name)
        {
            connection.Open();

            string deleteSql = "DELETE FROM recycle_bin WHERE group_name='" + group_name + "'";
            string addSql = "INSERT INTO groups (group_name) VALUES ('" + group_name + "')";

            MySqlCommand command = new MySqlCommand(deleteSql, connection);

            command.ExecuteNonQuery();
            command.CommandText = addSql;
            command.ExecuteNonQuery();

            connection.Close();
        }

        public void ClearRecycleBin()
        {
            connection.Open();

            MySqlCommand deleteCommand = new MySqlCommand("TRUNCATE TABLE recycle_bin", connection);

            deleteCommand.ExecuteNonQuery();

            connection.Close();
        }

        public List<Group> GetRecycleBin()
        {
            List<Group> recycleList = new List<Group>();

            try
            {
                connection.Open();

                if (connection.State == System.Data.ConnectionState.Open)
                {
                    string sql = "SELECT * FROM recycle_bin";

                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string empty = "";

                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    empty += reader.GetString(i);
                                }
                                recycleList.Add(new Group(empty));
                            }
                        }
                    }
                }
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return recycleList;
        }


        // ------------------- Entries -----------------------------

        public void UpdateEntry(Entry entry, Entry beforeEntry)
        {

            string entrySql = "UPDATE entries SET `title`='" + entry.Title + "', username='" + entry.Username + "', password='" + entry.Password + "', url='"
                            + entry.Url + "', notes ='" + entry.Notes + "', group_name='" + entry.Group_name + "'WHERE title='" + beforeEntry.Title + "'";
            Console.WriteLine(entrySql);

            entryList.Clear();
            MySqlConnection dbConnect;
            try
            {
                dbConnect = new MySqlConnection(connectString);

                dbConnect.Open();

                MySqlCommand command = new MySqlCommand(entrySql, dbConnect);

                command.ExecuteNonQuery();

                GetEntryDB();

                dbConnect.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void GetEntryDB()
        {
            entryList.Clear();
            MySqlConnection dbConnect;
            try
            {
                dbConnect = new MySqlConnection(connectString);

                dbConnect.Open();

                if (dbConnect.State == System.Data.ConnectionState.Open)
                {
                    string sql = "SELECT * FROM entries";

                    using (MySqlCommand command = new MySqlCommand(sql, dbConnect))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string empty = "";

                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    empty += reader.GetString(i) + ";";
                                }
                                entryList.Add(new Entry(empty.Split(';')[1], empty.Split(';')[2], empty.Split(';')[3], empty.Split(';')[4], empty.Split(';')[5], empty.Split(';')[6]));
                            }
                        }
                    }
                }
                dbConnect.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void SetEntryDB(Entry entry)
        {
            MySqlConnection dbConnect;

            dbConnect = new MySqlConnection(connectString);
            try
            {
                dbConnect.Open();

                if (dbConnect.State == System.Data.ConnectionState.Open)
                {
                    string insertSql = "INSERT INTO entries (title, username, password, url, notes, group_name) VALUES (" + "'" + entry.Title + "'"
                        + ", " + "'" + entry.Username + "'" + ", " + "'" + entry.Password + "'" + ", " + "'" + entry.Url + "'" + ", " + "'" 
                        + entry.Notes + "'" + ", " + "'" + entry.Group_name + "'" + ")";

                    MySqlCommand command = new MySqlCommand(insertSql, dbConnect);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                dbConnect.Close();
            }
        }

        public void DeleteEntryDB(string title)
        {
            MySqlConnection dbConnect;

            dbConnect = new MySqlConnection(connectString);
            try
            {
                dbConnect.Open();

                if (dbConnect.State == System.Data.ConnectionState.Open)
                {
                                        //DELETE FROM `entries` WHERE `title` = "GoogleMail"
                    string insertSql = "DELETE FROM entries WHERE title ='" + title + "'";

                    MySqlCommand command = new MySqlCommand(insertSql, dbConnect);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                dbConnect.Close();
            }
        }


        #region GetEntryID
        public int GetEntryID()
        {
            string empty = "";

            MySqlConnection dbConnect;
            try
            {
                dbConnect = new MySqlConnection(connectString);

                dbConnect.Open();

                if (dbConnect.State == System.Data.ConnectionState.Open)
                {
                    string sql = "SELECT MAX(id) FROM entry_table";

                    using (MySqlCommand command = new MySqlCommand(sql, dbConnect))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    empty += reader.GetString(i) + ";";
                                }
                            }
                        }
                    }
                }
                dbConnect.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            return Convert.ToInt32(empty);
        }
        #endregion

        public string GetMasterKey()
        {
            string empty = "";

            MySqlConnection dbConnect;
            try
            {
                dbConnect = new MySqlConnection(connectString);

                dbConnect.Open();

                if (dbConnect.State == System.Data.ConnectionState.Open)
                {
                    int countMasterPW = 0;
                    string sqltest = "SELECT Count(master_pass) FROM master_password";

                    using (MySqlCommand command = new MySqlCommand(sqltest, dbConnect))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                countMasterPW = reader.GetInt32(0);
                            }
                        }
                    }

                    if (countMasterPW == 1)
                    {
                        string sql = "SELECT DES_DECRYPT(master_pass,'" + EncKey_DB + "') FROM master_password";

                        using (MySqlCommand command = new MySqlCommand(sql, dbConnect))
                        {
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {
                                        empty += reader.GetString(i);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        return "nochkeinPWgesetzt";
                    }
                }
                dbConnect.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return empty;
        }

        public void SetMasterKey(string new_Master_Pass)
        {

            MySqlConnection dbConnect;
            dbConnect = new MySqlConnection(connectString);
            try
            {
                dbConnect.Open();

                if (dbConnect.State == System.Data.ConnectionState.Open)
                {
                    int countMasterPW = 0;
                    string sqltest = "SELECT Count(master_pass) FROM master_password";

                    using (MySqlCommand command = new MySqlCommand(sqltest, dbConnect))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                countMasterPW = reader.GetInt32(0);
                            }
                        }
                    }

                    if (countMasterPW == 1)
                    {
                        string insertSql = "UPDATE `master_password` SET `master_pass` = (DES_ENCRYPT('" + new_Master_Pass + "', '" + EncKey_DB + "'))";

                        MySqlCommand command = new MySqlCommand(insertSql, dbConnect);
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        string insertSql = "INSERT INTO `master_password` (`master_pass`) VALUES (DES_ENCRYPT('" + new_Master_Pass + "', '" + EncKey_DB + "'))";

                        MySqlCommand command = new MySqlCommand(insertSql, dbConnect);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                dbConnect.Close();
            }
        }
    }
}
