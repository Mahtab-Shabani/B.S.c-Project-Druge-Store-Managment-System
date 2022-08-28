using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//**********************
using System.Data;

namespace project
{
    class LoginClss
    {

        darookhaneDataSetUserTableAdapters.tbl_accessTableAdapter dt = new project.darookhaneDataSetUserTableAdapters.tbl_accessTableAdapter();

        public DataTable LoginData(string user, string pass)
        {
            return dt.GetLogin(user, pass);
        }

        public DataTable GetUserLevel(string username, string pass)
        {
            return dt.GetUserLevel(username, pass);
        }

    }
}
