using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibM29.BL
{
    internal class CLS_CAT
    {

        CLS_DAL DAL = new CLS_DAL();


        public DataTable Load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADCAT", pr);
            return dt;


        }
        //INSERT DATA
        public void insert  (string CAT_NAME)
            {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("CAT_NAME", CAT_NAME);
            DAL.open();
            DAL.Excute("P_ADDCAT", pr);
            DAL.close();
        }
    

//UPDATE DATA
public void update(string CAT_NAME , int ID)
{
    SqlParameter[] pr = new SqlParameter[2];
    pr[0] = new SqlParameter("CAT_NAME", CAT_NAME);
    pr[1] = new SqlParameter("ID", ID);

            DAL.open();
    DAL.Excute("P_EDITCAT", pr);
    DAL.close();
}
    


    //Delete DATA
    public void Delete (int ID)
    {
        SqlParameter[] pr = new SqlParameter[1];
       
        pr[0] = new SqlParameter("ID", ID);

        DAL.open();
        DAL.Excute("P_DELLETECAT", pr);
        DAL.close();
    }
}
}


