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
using System.Data.SqlClient;


namespace LibM29.PL
{
    public partial class FRM_ADDCAT : Form
    {
        public int ID;
        public FRM_ADDCAT()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txt_catname.Text == "")
            {
                PL.FRM_ERROR FError = new FRM_ERROR();
                FError.Show();
            }
            else
            {

                if (ID==0)
                {
                    //ADD 
                    BL.CLS_CAT BLCAT = new BL.CLS_CAT();
                    BLCAT.insert(txt_catname.Text);
                    PL.FRM_DADD Fadd = new FRM_DADD();
                    Fadd.Show();
                    this.Close();
                }
                else
                {
                    //edit
                    BL.CLS_CAT BLCAT = new BL.CLS_CAT();
                    BLCAT.update(txt_catname.Text,ID);
                    PL.FRM_DEDT fEdIT = new FRM_DEDT();
                    fEdIT.Show();
                    this.Close();
                }
               
            }
        }

        private void FRM_ADDCAT_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
