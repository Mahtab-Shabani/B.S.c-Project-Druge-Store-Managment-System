using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//**********************
using System.Data;


namespace project
{
    public class ClassAccessLevel
    {

        public ClassAccessLevel()
        {

        }

        darookhaneDataSetUserTableAdapters.tbl_accessTableAdapter dt = new project.darookhaneDataSetUserTableAdapters.tbl_accessTableAdapter();

        public DataTable show()
        {
            return dt.GetData();        
        }

        public void insert(string username, string pass, int userLevel, int userCode)
        {
            dt.InsertQuery(username, pass, userLevel, userCode);
        }

        public void delete(int userId)
        {
            dt.DeleteQuery(userId);
        }

        public void update(string username, string pass, int userLevel, int userCode)
        {
            dt.UpdateQuery(username, pass, userLevel, userCode);
        }

        public DataTable search(string userName, string pass)
        {
            return dt.searchQuery(userName, pass);
        }

        public DataTable searchByUseCode(int userCode)
        {
            return dt.searchByuserCode(userCode);
        }

        public void update1(string userName, string oldPass, string newPass)
        {
            dt.UpdateQuery1(newPass, userName, oldPass);
        }

        public void del(int id)
        {
            dt.DeleteQuery(id);
        }
    }
}
