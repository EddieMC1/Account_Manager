using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager
{
    public class Group
    {
        private string group_name;

        public Group(string group_name)
        {
            this.group_name = group_name;
        }

        public string Group_name { get => group_name; set => group_name = value; }
    }
}
