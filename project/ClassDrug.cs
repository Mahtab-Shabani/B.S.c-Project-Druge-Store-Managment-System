using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//*****************

using System.Data;


namespace project
{
    public class ClassDrug
    {
        //***********متد سازنده*****************
        public ClassDrug()
        {
        
        }

        darookhaneDataSet2TableAdapters.tbl_drugTableAdapter dt = new project.darookhaneDataSet2TableAdapters.tbl_drugTableAdapter();

        //********نمایش داده ها******************
        public DataTable show()
        {
            return dt.GetData();
        }

        //********وارد کردن داده ها**************
        public void insert(string name, string type, DateTime tolid, DateTime engheza, string weight, int number, string composer, string cost)
        {
            dt.InsertQuery(name, type, tolid, engheza, weight, number, composer, cost);
        }

        //********حذف داده ها******************
        public void delete(int id)
        {
            dt.DeleteQuery(id);
        }

        //********ویرایش داده ها****************
        public void update(string name, string type, DateTime tolid, DateTime engheza, string weight, int number, string composer, string cost, int id)
        {
            dt.UpdateQuery(name, type, tolid, engheza, weight, number, composer, cost, id);
        }

        //********جستجوی داده******************
        public DataTable search(string name)
        {
            return dt.searchQuery(name);
        }
    }
}
