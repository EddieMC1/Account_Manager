using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager
{
    public class Entry
    {
        private string title;
        private string username;
        private string password;
        private string url;
        private string notes;
        private string group_name;

        public Entry(string title, string username, string password, string url, string notes, string group_name)
        {
            this.title = title;
            this.username = username;
            this.password = password;
            this.url = url;
            this.notes = notes;
            this.group_name = group_name;
        }

        public string Title { get => title; set => title = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Url { get => url; set => url = value; }
        public string Notes { get => notes; set => notes = value; }
        public string Group_name { get => group_name; set => group_name = value; }
    }
}
