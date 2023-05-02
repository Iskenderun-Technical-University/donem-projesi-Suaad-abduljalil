using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;


namespace LibM29.PL
{
    public partial class FRM_ADDSTUDNET : Form
    {
        public int ID;
        public FRM_ADDSTUDNET()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            var result = OFD.ShowDialog();
            if (result == DialogResult.OK)
            {
                cover.Image = Image.FromFile(OFD.FileName);
            }
        }

        private void FRM_ADDBOKKS_Load(object sender, EventArgs e)
        {
           

        
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PL.FRM_ADDCAT FCAT = new FRM_ADDCAT();
            FCAT.btnadd.ButtonText = "eklemek";
            FCAT.ID = 0;
            FCAT.Show();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txt_name.Text==""|| txt_lo.Text==""||txt_email.Text== "" )


                {
                PL.FRM_ERROR FError = new FRM_ERROR();
                FError.Show();
            }
            else
            {

                if (ID == 0)
                {
                    MemoryStream ma = new MemoryStream();
                    cover.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);

                    //ADD 
                    BL.CLS_ST BLCAT = new BL.CLS_ST();
                    BLCAT.insert(txt_name.Text,txt_lo.Text,txt_phone.Text,txt_email.Text,txt_scool.Text,txt_dept.Text,ma);
                    PL.FRM_DADD Fadd = new FRM_DADD();
                    Fadd.Show();
                    this.Close();
                }
                else
                {

                    MemoryStream ma = new MemoryStream();
                    cover.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //edit
                    BL.CLS_ST BLCAT = new BL.CLS_ST();
                    BLCAT.update(txt_name.Text, txt_lo.Text, txt_phone.Text, txt_email.Text, txt_scool.Text, txt_dept.Text, ma, ID);
                    PL.FRM_DEDT fEdIT = new FRM_DEDT();
                    fEdIT.Show();
                    this.Close();
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_date_onValueChanged(object sender, EventArgs e)
        {

        }

        private void Lb_Ttle_Click(object sender, EventArgs e)
        {



















        }
    }
}
