using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//*********************************
using System.Data;


namespace project
{
    public class ClassSick
    {

        //***********متد سازنده*****************
        public ClassSick()
        {
        
        }
        darookhaneDataSetTableAdapters.tbl_sickTableAdapter dt = new project.darookhaneDataSetTableAdapters.tbl_sickTableAdapter();
        
        //********نمایش داده ها******************
        public DataTable show()
        {
            return dt.GetData();

        }

        //********وارد کردن داده ها*************
        public void insert(string name, int age, string gender,string status)
        {
            dt.InsertQuery(name, age, gender, status);
        }

        //********حذف داده ها******************
        public void delete(int id)
        {
            dt.DeleteQuery(id);        
        }

        //********ویرایش داده ها****************
        public void update(string name, int age, string gender, string status, int id)
        {
            dt.UpdateQuery(name, age, gender, status, id);
        
        }

        //********جستجوی داده******************
        public DataTable srch(string name)
        {
            return dt.searchQuery(name);
        }

    }
}
