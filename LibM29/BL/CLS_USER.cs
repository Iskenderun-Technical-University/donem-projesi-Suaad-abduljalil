using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace LibM29.BL
{
    internal class CLS_USER
    {
        CLS_DAL DAL = new CLS_DAL();

        //LOAD DATA
        public DataTable Load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADUSER", pr);
            return dt;


        }
        //INSERT DATA
        public void insert(string CNAME, string CUSER, string CPASSWORD, string CPREM, string CSTATE)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("CNAME", CNAME);
            pr[1] = new SqlParameter("CUSER", CUSER);
            pr[2] = new SqlParameter("CPASSWORD", CPASSWORD);
            pr[3] = new SqlParameter("CPREM", CPREM);
            pr[4] = new SqlParameter("CSTATE", CSTATE);

            DAL.open();
            DAL.Excute("PR_INSERTUSER", pr);
            DAL.close();


        }
        //UPDATE DATA
        public void upadte(string CNAME, string CUSER, string CPASSWORD, string CPREM, int ID)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("CNAME", CNAME);
            pr[1] = new SqlParameter("CUSER", CUSER);
            pr[2] = new SqlParameter("CPASSWORD", CPASSWORD);
            pr[3] = new SqlParameter("CPREM", CPREM);
            pr[4] = new SqlParameter("ID", ID);

            DAL.open();
            DAL.Excute("PR_EDITUSER", pr);
            DAL.close();


        }
        //Delete DATA
        public void Delete(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];

            pr[0] = new SqlParameter("ID", ID);

            DAL.open();
            DAL.Excute("PR_DELETEUSER", pr);
            DAL.close();
        }
        //logout
        public void logout()
        {
            SqlParameter[] pr = null;

            DAL.open();
            DAL.Excute("PR_LOGOUT", pr);
            DAL.close();


        } 
        //LOAD DATA FOR LOGİN
        public DataTable Login(string CUSER , string CPASSWORD)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("CUSER", CUSER);
            pr[1] = new SqlParameter("CPASSWORD", CPASSWORD);


            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOGIN", pr);
            return dt;


        }
        //UPDATE DATA FOR LOGIN
        public void upadteLOGIN( string CUSER, string CPASSWORD)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("CUSER", CUSER);
            pr[1] = new SqlParameter("CPASSWORD", CPASSWORD);
      
            DAL.open();
            DAL.Excute("PR_updatelogin", pr);
            DAL.close();


        }
        //LOAD DATA FOR CHECK  START
        public DataTable STARTLOADDTA()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_START", pr);
            return dt;


        }
    } 
    }

