using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibM29.BL
{
    internal class CLS_CAT
    {

        CLS_DAL DAL = new CLS_DAL();

    
        public DataTable Load ()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
           dt= DAL.read("PR_LOADCAT", pr);
            return dt;


        }
    }
}
