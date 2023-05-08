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
    public partial class FRM_MAKESELL : Form
    {
        public int ID;
        public FRM_MAKESELL()
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
            DataTable dt2 = new DataTable();
            dt2 = BLSELL.LoadBOOKS();
            dataGridView1.DataSource = dt2;

            DataTable dt1 = new DataTable();
            dt1 = BLSELL.LoadST();
            dataGridView2.DataSource = dt1;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
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
                    BL.CLS_SELL BLSELL = new BL.CLS_SELL();
                    BLSELL.insert(Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value), Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value), Convert.ToString(txt_title.Text), Convert.ToString(txt_date.Value));
                    PL.FRM_DADD Fadd = new FRM_DADD();
                    Fadd.Show();
                    this.Close();
                }
                else
                {
                    BL.CLS_SELL BLSELL = new BL.CLS_SELL();
                    BLSELL.upadte(Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value), Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value), Convert.ToInt32(txt_title.Text), Convert.ToString(txt_date.Value), ID);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            if (ID == 0)
            {

                //ADD 
                BL.CLS_SELL BLSELL = new BL.CLS_SELL();
                BLSELL.insert(Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value), Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value),Convert.ToString(txt_title.Text),Convert.ToString(txt_date.Value));
                PL.FRM_DADD Fadd = new FRM_DADD();
                Fadd.Show();
                this.Close();
            }

            else
            {
                BL.CLS_SELL BLSELL = new BL.CLS_SELL();
                BLSELL.upadte(Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value), Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value), Convert.ToInt32(txt_title.Text), Convert.ToString(txt_date.Value), ID);
                PL.FRM_DEDT fEdIT = new FRM_DEDT();
                fEdIT.Show();
                this.Close();
            }




        }
    }
}
