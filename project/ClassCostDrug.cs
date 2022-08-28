using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//***************
using System.Data;


namespace project
{
    public class ClassCostDrug
    {
          //***********متد سازنده*****************
        public ClassCostDrug()
        {
        
        }

        darookhaneDataSetCostTableAdapters.tbl_costDrugTableAdapter dt = new project.darookhaneDataSetCostTableAdapters.tbl_costDrugTableAdapter();

        //********نمایش داده ها******************
        public DataTable show()
        {
            return dt.GetData();
        }

        //********وارد کردن داده ها*************
        public void insert(string name,string type, string composer, string cost)
        {
            dt.InsertQuery(name, type, composer, cost);
        }

        //********حذف داده ها******************
        public void delete(int id)
        {
            dt.DeleteQuery(id);
        }

        //********ویرایش داده ها****************
        public void update(string name,string type, string composer, string cost, int id)
        {
            dt.UpdateQuery(name,type, composer, cost, id);

        }

        //********جستجوی داده******************
        public DataTable search(string name)
        {
            return dt.searchQuery(name);
        }

    }
}
