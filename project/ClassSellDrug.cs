using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//************************
using System.Data;

namespace project
{
    public class ClassSellDrug
    {
        
        //***********متد سازنده*****************
        public ClassSellDrug()
        {
        
        }

        darookhaneDataSet5TableAdapters.tbl_selDrugTableAdapter dt = new project.darookhaneDataSet5TableAdapters.tbl_selDrugTableAdapter();

        //********نمایش داده ها******************
        public DataTable show()
        {
            return dt.GetData();

        }

        public void insert(string Dr, string sName, string dName, string status, string type, string SellDate, string cost)
        {
            dt.InsertQuery(Dr, sName, dName, status, type, SellDate, cost);
        }

        public void delete(int id)
        {
            dt.DeleteQuery(id);
        }

        public void update(string Dr, string sName, string dName, string status, string type, string SellDate, string cost, int id)
        {
            dt.UpdateQuery(Dr, sName, dName, status, type, SellDate, cost, id);
        }

        public DataTable search(string dname)
        {
            return dt.searchQuery(dname);
        }
    }
}
