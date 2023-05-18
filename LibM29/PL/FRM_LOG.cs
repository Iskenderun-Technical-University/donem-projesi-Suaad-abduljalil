using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace LibM29.PL
{
    public partial class FRM_LOG : Form
    {
        public FRM_LOG()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                BL.CLS_USER CLSUSER = new BL.CLS_USER();
                DataTable dt = new DataTable();
                dt = CLSUSER.Login(txt_user.Text, txt_password.Text);
                if (dt.Rows.Count > 0)
                {
                    CLSUSER.upadteLOGIN(txt_user.Text, txt_password.Text);
                    PL.FRM_MIAN frmmain = new FRM_MIAN();
                    object lbname = dt.Rows[0]["CNAME"];
                    object lbprem = dt.Rows[0]["CPREM"];
                    frmmain.lb_name.Text = lbname.ToString();
                    frmmain.lb_prem.Text = lbprem.ToString();


                    frmmain.Show();
                    this.Close();
                }


            }catch(Exception ex)
            {
                MessageBox.Show("giriş bilgilerinde hata");
                MessageBox.Show(ex.Message);

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
