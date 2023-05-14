using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibM29.PL
{
    public partial class FRM_ADDUSER : Form
    {
        public int ID;
        public FRM_ADDUSER()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_timer.Text = DateTime.Now.ToString();
        }

        private void txt_timer_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_user.Text == "" || txt_prem.Text == "")


            {
                PL.FRM_ERROR FError = new FRM_ERROR();
                FError.Show();
            }
            else
            {

                if (ID == 0)
                {

                    //ADD 
                    BL.CLS_USER BLUSER = new BL.CLS_USER();
                    BLUSER.insert(txt_name.Text, txt_user.Text, txt_password.Text, txt_prem.Text, "False");
                    PL.FRM_DADD Fadd = new FRM_DADD();
                    Fadd.Show();
                    this.Close();
                }
                else
                {


                    ////edit
                    //BL.CLS_ST BLCAT = new BL.CLS_ST();
                    //BLCAT.update(txt_name.Text, txt_lo.Text, txt_phone.Text, txt_email.Text, txt_scool.Text, txt_dept.Text, ma, ID);
                    //PL.FRM_DEDT fEdIT = new FRM_DEDT();
                    //fEdIT.Show();
                    //this.Close();
                }
            }
        }
    }
}
