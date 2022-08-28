using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//*********************************
using System.Data;

namespace project
{
    public class ClassPersonal
    {

        //***********متد سازنده*****************
        public ClassPersonal()
        {

        }

        darookhaneDataSet6TableAdapters.tbl_personalTableAdapter dt = new project.darookhaneDataSet6TableAdapters.tbl_personalTableAdapter();

        //********نمایش داده ها******************
        public DataTable show()
        {
            return dt.GetData();

        }

        //********حذف داده ها******************
        public void delete(int id)
        {
            dt.DeleteQuery(id);
        }

        //********جستجوی داده******************
        public DataTable search(string pname, string pfamily)
        {
            return dt.searchQuery(pname, pfamily);
        }

        //********وارد کردن داده ها**************
        public void insert(string pName, string pFamily, string pFatherName, int pNumber, int pIdmeli, string pBirthday, string pTel, string pTitle, string pDegree, string pPropensity, string pAddress, string pPic)
        {
            dt.InsertQuery(pName, pFamily, pFatherName, pNumber, pIdmeli, pBirthday, pTel, pTitle, pDegree, pPropensity, pAddress, pPic);
        }

        //********ویرایش داده ها****************
        public void update(string pName, string pFamily, string pFatherName, int pNumber, int pIdmeli, string pBirthday, string pTel, string pTitle, string pDegree, string pPropensity, string pAddress, string pPic, int id)
        {
            dt.UpdateQuery(pName, pFamily, pFatherName, pNumber, pIdmeli, pBirthday, pTel, pTitle, pDegree, pPropensity, pAddress, pPic, id);
        }

        public DataTable searchById(int pId)
        {
            return dt.searchById(pId);
        }
    }
}
