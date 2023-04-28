using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Cryptography;


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
        //INSERT DATA
        public void insert(string NAME, string TLOACTION, string PHONE,string EMAIL, string SCHOOL, string DEP, MemoryStream COVER)
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
        }
    }
