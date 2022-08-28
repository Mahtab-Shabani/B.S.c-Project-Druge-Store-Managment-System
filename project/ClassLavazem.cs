using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//*****************

using System.Data;



namespace project
{
    public class ClassLavazem
    {       
        //***********متد سازنده*****************
        public ClassLavazem()
        {
        
        }

        darookhaneDataSet1TableAdapters.tbl_lavazemTableAdapter dt = new project.darookhaneDataSet1TableAdapters.tbl_lavazemTableAdapter();

        //********نمایش داده ها******************
        public DataTable show()
        {
           return dt.GetData();
        }

        //********وارد کردن داده ها**************
        public void insert(string name, int number, DateTime engheza, string composer, string cost)
        {
            dt.InsertQuery(name, number, engheza, composer, cost);
        }

        //********حذف داده ها******************
        public void delete(int id)
        {
            dt.DeleteQuery(id);
        }

        //********ویرایش داده ها****************
        public void updatel(string name, int number, DateTime engheza, string composer, string cost, int id)
        {
            dt.UpdateQuery(name, number, engheza, composer, cost, id);
        }

        //********جستجوی داده******************
        public DataTable srch(string name)
        {
            return dt.search(name);
        }
    }
}
