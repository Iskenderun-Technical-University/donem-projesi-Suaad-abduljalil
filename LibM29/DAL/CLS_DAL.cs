using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


    internal class CLS_DAL
{
    SqlConnection con = new SqlConnection();
    public CLS_DAL()
    {
        con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suaad abduljalıl\OneDrive\Masaüstü\donem-projesi-Suaad-abduljalil\LibM29\DBLIBM.mdf;Integrated Security=True");
    }
    //method to open sqlcon
    public void open()
    {
        if (con.State == ConnectionState.Closed)
        {
            con.Open();

        }
    }
    //method to close sqlcon
    public void close()
    {
        
        if (con.State == ConnectionState.Open)
        {
            
            con.Close();
            

        }
        

    }
    //fun to read data
    public DataTable read(string store, SqlParameter[] pr)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = store;
        if (pr != null)
        {
            cmd.Parameters.AddRange(pr);

        }
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        return dt;
    }
    //excute to ınsert,edit delet
    public void Excute(string store, SqlParameter[] pr)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = store;
        if (pr != null)
        {
            cmd.Parameters.AddRange(pr);

        }
        cmd.ExecuteNonQuery();
    }
    }
