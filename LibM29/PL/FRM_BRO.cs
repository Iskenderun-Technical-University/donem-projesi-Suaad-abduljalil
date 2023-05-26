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
    public partial class FRM_BRO : Form
    {
        public int ID;
        public FRM_BRO()
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

        }

        private void FRM_ADDBOKKS_Load(object sender, EventArgs e)
        {
            BL.CLS_SELL BLSELL = new BL.CLS_SELL();
            //LOAD BOOKS
            DataTable dt1 = new DataTable();
            dt1 = BLSELL.LoadBOOKS();
            dataGridView2.DataSource = dt1;

            DataTable dt2 = new DataTable();
            dt2 = BLSELL.LoadST();
            dataGridView1.DataSource = dt2;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_date_onValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Lb_Ttle_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {


            if (txt_title.Text == "")
            {
                PL.FRM_ERRORINSERT FError = new FRM_ERRORINSERT();
                FError.ShowDialog();
            }
            else
            {
                if (ID == 0)
                {

                    //ADD
                    BL.CLS_BOR BLSEEL = new BL.CLS_BOR();
                    BLSEEL.insert(Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value), Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value), Convert.ToString(txt_date.Value), Convert.ToString(txt_date2.Value), Convert.ToInt32(txt_title.Text));
                    PL.FRM_DADD Fadd = new FRM_DADD();
                    Fadd.Show();
                    this.Close();
                }
                else
                {

                    BL.CLS_BOR BLSEEL = new BL.CLS_BOR();
                    BLSEEL.update(Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value), Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value), Convert.ToString(txt_date.Value), Convert.ToString(txt_date2.Value), Convert.ToInt32(txt_title.Text), ID);
                    PL.FRM_DEDT fEDIT = new FRM_DEDT();
                    fEDIT.Show();
                    this.Close();
                }


            }
        }
    }
}

