using LibM29.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibM29.PL
{
    public partial class FRM_MIAN : Form
    {
        string State;
        int ID;
        //var for CAT
        BL.CLS_CAT BLCAT = new CLS_CAT();
        public FRM_MIAN()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
              {
                this.WindowState = FormWindowState.Maximized;

            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            if (P_MB.Size.Width==175)
            {
                P_MB.Width = 50;
                button1.RightToLeft = RightToLeft.Yes;
                button2.RightToLeft = RightToLeft.Yes;
                button3.RightToLeft = RightToLeft.Yes;
                button4.RightToLeft = RightToLeft.Yes;
               
            }
            else
            {
                P_MB.Width = 175;
                
               
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MINE.Visible = true;
            State = "CAT";
            Lb_Ttle.Text = "    TÜRLER  ";


            // load data
            try
            {
                DataTable dt = new DataTable();
                dt = BLCAT.Load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "sıralama";
                dataGridView1.Columns[1].HeaderText = "ürün adı";

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void FRM_MIAN_Load(object sender, EventArgs e)
        {
            P_HOME.Visible = true;
            P_MINE.Visible = false;
            Lb_Ttle.Text = "  ANA SAYFA";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //ADD CATEGORE
            if (State == "CAT")
            {
                PL.FRM_ADDCAT FCAT = new FRM_ADDCAT();
                FCAT.btnadd.ButtonText = "eklemek";
                FCAT.ID = 0;
                bunifuTransition1.ShowSync(FCAT);
                
            }
        }

        private void FRM_MIAN_Activated(object sender, EventArgs e)
        {
            if (State=="CAT")
            {
                // load data cat
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLCAT.Load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "sıralama";
                    dataGridView1.Columns[1].HeaderText = "ürün adı";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            //EDIT CATEGORE
            if (State == "CAT")
            {
                PL.FRM_ADDCAT FCAT = new FRM_ADDCAT();
                FCAT.btnadd.ButtonText = "değişiklik";
                FCAT.txt_catname.Text= Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                FCAT.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);

                bunifuTransition1.ShowSync(FCAT);

            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            //delete CATEGORE
            if (State == "CAT")
            {
                BLCAT.Delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_DDELETE fdelete = new FRM_DDELETE();
                fdelete.Show();

            }
        }
    }
    }

