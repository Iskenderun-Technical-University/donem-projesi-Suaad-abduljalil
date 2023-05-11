using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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
    }
}
