﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.IO;
using System.Diagnostics;


namespace LibM29.BL
{
    internal class CLS_BOOKS
    {

        CLS_DAL DAL = new CLS_DAL();

        //LOAD DATA
        public DataTable Load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADBOOKS", pr);
            return dt;


        }
        // COMBOOKS
        public DataTable LOADCAT()
        {
            SqlParameter[] pr = null;

            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADCATTOCOMBOX", pr);
            return dt;


        }
        //INSERT DATA
        public void insert(string TITLE, string AUTHER, string CAT, string PRICE, string BDATE, int RATE, MemoryStream COVER)
        {
            SqlParameter[] pr = new SqlParameter[7];
            pr[0] = new SqlParameter("TITLE", TITLE);
            pr[1] = new SqlParameter("AUTHER", AUTHER);
            pr[2] = new SqlParameter("CAT", CAT);
            pr[3] = new SqlParameter("PRICE", PRICE);
            pr[4] = new SqlParameter("BDATE", BDATE);
            pr[5] = new SqlParameter("RATE", RATE);
            pr[6] = new SqlParameter("COVER", COVER.ToArray());

            DAL.open();
            DAL.Excute("PR_INSERTBOOKS", pr);
            DAL.close();


        }//LOAD DATA for edit
        public DataTable LOADEDIT(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_SELECTEDIT", pr);
            return dt;


        }
        //UPDATE DATA
        public void update(string TITLE, string AUTHER, string CAT, string PRICE, string BDATE, int RATE, MemoryStream COVER,int ID)
        {
            
            SqlParameter[] pr = new SqlParameter[8];
            pr[0] = new SqlParameter("TITLE", TITLE);
            pr[1] = new SqlParameter("AUTHER", AUTHER);
            pr[2] = new SqlParameter("CAT", CAT);
            pr[3] = new SqlParameter("PRICE", PRICE);
            pr[4] = new SqlParameter("BDATE", BDATE);
            pr[5] = new SqlParameter("RATE", RATE);
            pr[6] = new SqlParameter("COVER", COVER.ToArray());
            pr[7] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.Excute("PR_EDITBOKKS", pr);
            DAL.close();
        }
        //Delete DATA
        public void Delete(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];

            pr[0] = new SqlParameter("ID", ID);

            DAL.open();
            DAL.Excute("P_DELLETEBOOKS", pr);
            DAL.close();
        }
        // SEARCH
        public DataTable serach(string search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("SEARCH", search);
            DataTable dt = new DataTable();
            dt = DAL.read("P_BOOKSSEARCH", pr);
            return dt;


        }
    }
}


