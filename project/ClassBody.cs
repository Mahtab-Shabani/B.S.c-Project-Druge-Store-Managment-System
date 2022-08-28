using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//*********************************
using System.Data;

namespace project
{
    public class ClassBody
    {

        //***********متد سازنده*****************
        public ClassBody()
        {
        
        }

        darookhaneDataSet3TableAdapters.tbl_bodyTableAdapter dt=new project.darookhaneDataSet3TableAdapters.tbl_bodyTableAdapter();

        //********نمایش داده ها******************
        public DataTable show()
        {
            return dt.GetData();

        }

        //********وارد کردن داده ها**************
        public void insert(string name, int age, string gender)
        {
            dt.InsertQuery(name, age, gender);
        }

        //********حذف داده ها******************
        public void delete(int id)
        {
            dt.DeleteQuery(id);        
        }

        //********ویرایش داده ها****************
        public void update(string name, int age, string gender, int id)
        {
            dt.UpdateQuery(name, age, gender, id);
        
        }

        //********جستجوی داده******************
        public DataTable search(string name)
        {
            return dt.SearchQuery(name);
        }

    }
}
