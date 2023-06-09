﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;


namespace LibM29.BL
{
    internal class CLS_ST
    {
        CLS_DAL DAL = new CLS_DAL();

        //LOAD DATA
        public DataTable Load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADST", pr);
            return dt;


        }
       
       

        public void Insert(string NAME, string TLOACTION, string PHONE, string EMAIL, string SCHOOL, string DEP, MemoryStream COVER)
        {

            SqlParameter[] pr = new SqlParameter[7];
            pr[0] = new SqlParameter("NAME", NAME);
            pr[1] = new SqlParameter("TLOACTION", TLOACTION);
            pr[2] = new SqlParameter("PHONE", PHONE);
            pr[3] = new SqlParameter("EMAIL", EMAIL);
            pr[4] = new SqlParameter("SCHOOL", SCHOOL);
            pr[5] = new SqlParameter("DEP", DEP);
            pr[6] = new SqlParameter("COVER", COVER.ToArray());

            DAL.open();
            DAL.Excute("PR_INSERTST", pr);
            DAL.close();
        }
        public DataTable LOADEDIT(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_SELECTEDITST", pr);
            return dt;


        }
        public void update(string NAME, string TLOACTION, string PHONE, string EMAIL, string SCHOOL, string DEP, MemoryStream COVER, int ID)
        {
            SqlParameter[] pr = new SqlParameter[8];
            pr[0] = new SqlParameter("NAME", NAME);
            pr[1] = new SqlParameter("TLOACTION", TLOACTION);
            pr[2] = new SqlParameter("PHONE", PHONE);
            pr[3] = new SqlParameter("EMAIL", EMAIL);
            pr[4] = new SqlParameter("SCHOOL", SCHOOL);
            pr[5] = new SqlParameter("DEP", DEP);
            pr[6] = new SqlParameter("COVER", COVER.ToArray());
            pr[7] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.Excute("PR_EDITST", pr);
            DAL.close();

        }
        //Delete DATA
        public void Delete(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];

            pr[0] = new SqlParameter("ID", ID);

            DAL.open();
            DAL.Excute("P_DELLETEST", pr);
            DAL.close();
        }
        // SEARCH
        public DataTable serach(string search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("SERACH", search);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_SERACHST", pr);
            return dt;


        }
    }
}
