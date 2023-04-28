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
using System.IO;


namespace LibM29.PL
{
    public partial class FRM_MIAN : Form
    {
        string State;
        int ID;
        //var for CAT
        BL.CLS_CAT BLCAT = new CLS_CAT();
        //INSTANCE OF BOOKS
        BL.CLS_BOOKS BLBOOKS = new BL.CLS_BOOKS();

        //INSTANCE OF STUDENT
        BL.CLS_ST BLST = new BL.CLS_ST();
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
            if (WindowState == FormWindowState.Normal)
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
            if (P_MB.Size.Width == 175)
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
            P_HOME.Visible = false;
            P_MINE.Visible = true;
            bunifuThinButton24.Visible = true;
            State = "BOOKS";
            Lb_Ttle.Text = "    KİTABLAR ";


            // load data
            try
            {
                DataTable dt = new DataTable();
                dt = BLBOOKS.Load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "sıralama";
                dataGridView1.Columns[1].HeaderText = "kitab adı";
                dataGridView1.Columns[2].HeaderText = "yazar adı";
                dataGridView1.Columns[3].HeaderText = "kategori";
                dataGridView1.Columns[4].HeaderText = "fiyat";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            catch (Exception ex)
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
            //ADD books
            if (State == "BOOKS")
            {
                PL.FRM_ADDBOKKS FBOOKS = new FRM_ADDBOKKS();
                FBOOKS.btnadd.ButtonText = "eklemek";
                FBOOKS.ID = 0;
                bunifuTransition1.ShowSync(FBOOKS);

            }
            //ADD STUDENT
            if (State == "ST")
            {
                PL.FRM_ADDSTUDNET FBOOKS = new FRM_ADDSTUDNET();
                FBOOKS.btnadd.ButtonText = "eklemek";
                FBOOKS.ID = 0;
                bunifuTransition1.ShowSync(FBOOKS);

            }
        }

        private void FRM_MIAN_Activated(object sender, EventArgs e)
        {
            if (State == "CAT")
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
            else if (State == "BOOKS")
            {
                P_HOME.Visible = false;
                P_MINE.Visible = true;
                bunifuThinButton24.Visible = true;
                State = "BOOKS";
                Lb_Ttle.Text = "    KİTABLAR ";


                // load data
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLBOOKS.Load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "sıralama";
                    dataGridView1.Columns[1].HeaderText = "kitab adı";
                    dataGridView1.Columns[2].HeaderText = "yazar adı";
                    dataGridView1.Columns[3].HeaderText = "kategori";
                    dataGridView1.Columns[4].HeaderText = "fiyat";


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (State =="ST")
            {
                P_HOME.Visible = false;
                P_MINE.Visible = true;
                bunifuThinButton24.Visible = true;
                State = "ST";
                Lb_Ttle.Text = "   ÖĞRENCİLER ";


                // load data
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLST.Load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "sıralama";
                    dataGridView1.Columns[1].HeaderText = "Öğrenci adı";
                    dataGridView1.Columns[2].HeaderText = "yaşamak";
                    dataGridView1.Columns[3].HeaderText = "telefon numarası";
                    dataGridView1.Columns[4].HeaderText = "e-posta";


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
                FCAT.txt_catname.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                FCAT.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);

                bunifuTransition1.ShowSync(FCAT);

            }
            else if (State == "BOOKS")
            {
                try
                {
                    PL.FRM_ADDBOKKS FBOOKS = new FRM_ADDBOKKS();
                    FBOOKS.btnadd.ButtonText = "değişiklik";
                    FBOOKS.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                    DataTable dt = new DataTable();
                    dt = BLBOOKS.LOADEDIT(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                    object obj1 = dt.Rows[0]["TITLE"];
                    object obj2 = dt.Rows[0]["AUTHER"];
                    object obj3 = dt.Rows[0]["CAT"];
                    object obj4 = dt.Rows[0]["PRICE"];
                    object obj5 = dt.Rows[0]["BDATE"];
                    object obj6 = dt.Rows[0]["RATE"];
                    object obj7 = dt.Rows[0]["COVER"];
                    FBOOKS.txt_title.Text = obj1.ToString();
                    FBOOKS.txt_auther.Text = obj2.ToString();
                    FBOOKS.comboBox1.Text = obj3.ToString();
                    FBOOKS.txt_price.Text = obj4.ToString();
                    FBOOKS.txt_date.Value = (DateTime)obj5;
                    FBOOKS.txt_rate.Value = (int)obj6;
                    //load ımage
                    byte[] ob = (byte[])obj7;
                    MemoryStream ma = new MemoryStream(ob);
                    FBOOKS.cover.Image = Image.FromStream(ma);

                    bunifuTransition1.ShowSync(FBOOKS);


                }
                catch
                {

                }


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

                //delete books
            }
            else if (State == "BOOKS")
            {
                BLBOOKS.Delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_DDELETE fdelete = new FRM_DDELETE();
                fdelete.Show();

            }
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            //SEARCH CATEGORE
            if (State == "CAT")
            {
                DataTable dt = new DataTable();
                dt = BLBOOKS.serach(bunifuMaterialTextbox1.Text);
                dataGridView1.DataSource = dt;


            }
            //SEARCH CATEGORE
            if (State == "BOOKS")
            {
                DataTable dt = new DataTable();
                dt = BLCAT.serach(bunifuMaterialTextbox1.Text);
                dataGridView1.DataSource = dt;


            }
        }

        private void P_MB_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            //det books
            if (State == "BOOKS")
            {
                try
                {

                    DataTable dt = new DataTable();
                    dt = BLBOOKS.LOADEDIT(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                    object obj1 = dt.Rows[0]["TITLE"];
                    object obj2 = dt.Rows[0]["AUTHER"];
                    object obj3 = dt.Rows[0]["CAT"];
                    object obj4 = dt.Rows[0]["PRICE"];
                    object obj5 = dt.Rows[0]["BDATE"];
                    object obj6 = dt.Rows[0]["RATE"];
                    object obj7 = dt.Rows[0]["COVER"];
                    PL.FRM_DETBOOKS DETBOOKS = new FRM_DETBOOKS();
                    DETBOOKS.txt_title.Text = obj1.ToString();
                    DETBOOKS.txt_auther.Text = obj2.ToString();
                    DETBOOKS.txt_cat.Text = obj3.ToString();
                    DETBOOKS.txt_price.Text = obj4.ToString();
                    DETBOOKS.txt_date.Value = (DateTime)obj5;
                    DETBOOKS.txt_rate.Value = (int)obj6;
                    //load ımage
                    byte[] ob = (byte[])obj7;
                    MemoryStream ma = new MemoryStream(ob);
                    DETBOOKS.cover.Image = Image.FromStream(ma);

                    bunifuTransition1.ShowSync(DETBOOKS);


                }
                catch
                {
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MINE.Visible = true;
            bunifuThinButton24.Visible = true;
            State = "ST";
            Lb_Ttle.Text = "   ÖĞRENCİLER ";


            // load data
            try
            {
                DataTable dt = new DataTable();
                dt = BLST.Load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "sıralama";
                dataGridView1.Columns[1].HeaderText = "Öğrenci adı";
                dataGridView1.Columns[2].HeaderText = "yaşamak";
                dataGridView1.Columns[3].HeaderText = "telefon numarası";
                dataGridView1.Columns[4].HeaderText = "e-posta";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
    

