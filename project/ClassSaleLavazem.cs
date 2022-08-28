using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//************************
using System.Data;

namespace project
{
    public class ClassSaleLavazem
    {

        //***********متد سازنده*****************
        public ClassSaleLavazem()
        {
        
        }

        darookhaneDataSet4TableAdapters.tbl_lavazemTableAdapter l = new project.darookhaneDataSet4TableAdapters.tbl_lavazemTableAdapter();
        darookhaneDataSet4TableAdapters.tbl_saleLavazemTableAdapter dt=new project.darookhaneDataSet4TableAdapters.tbl_saleLavazemTableAdapter();
        darookhaneDataSet4TableAdapters.tbl_selTableAdapter s = new project.darookhaneDataSet4TableAdapters.tbl_selTableAdapter();
        darookhaneDataSet4TableAdapters.tbl_sel1TableAdapter s1 = new project.darookhaneDataSet4TableAdapters.tbl_sel1TableAdapter();

        //********نمایش داده ها******************
        public DataTable show()
        {
            return s1.GetData();
        
        }

        //********وارد کردن داده ها*************
        public void insert(string lname,int number,string name,string cost ,string sDateSell)
        {
            s.InsertQuery(lname, number, cost, name, sDateSell);
        }
       
        //********حذف داده ها******************
        public void delete(int id)
        {
            s.DeleteQuery(id);
        }

        //********ویرایش داده ها****************
        public void update(string lname, int number, string name, string cost, string sDateSell, int id)
        {
            s1.UpdateQuery(lname, number, cost, name, sDateSell, id);

        }

        //********جستجوی داده******************
        public DataTable srch(string name)
        {
            return s.searchQuery(name);
        }

        public DataTable ckeck()
        {
            return s.checkQuery();
        }

        public void updateMojoodi(int lNumber, int id)
        {
            l.UpdateMojudi(lNumber, id);
        }

    }
}
