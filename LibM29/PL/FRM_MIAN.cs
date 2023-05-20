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
using System.Diagnostics.Eventing.Reader;

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

        //INSTANCE OF SELL
        BL.CLS_SELL BSELL = new BL.CLS_SELL();
        //INSTANCE OF BRO
        BL.CLS_BOR BRO = new BL.CLS_BOR();
        //INSTANCE OF USER
        BL.CLS_USER BLUSER = new BL.CLS_USER();

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
                button5.RightToLeft = RightToLeft.Yes;
                button6.RightToLeft = RightToLeft.Yes;
                button7.RightToLeft = RightToLeft.Yes;
                lb_name.Visible = false;
                lb_prem.Visible = false;




            }
            else
            {
                P_MB.Width = 175;
                button1.RightToLeft = RightToLeft.Yes;
                button2.RightToLeft = RightToLeft.Yes;
                button3.RightToLeft = RightToLeft.Yes;
                button4.RightToLeft = RightToLeft.Yes;
                button5.RightToLeft = RightToLeft.Yes;
                button6.RightToLeft = RightToLeft.Yes;
                button7.RightToLeft = RightToLeft.Yes;
                lb_name.Visible = true;
                lb_prem.Visible = true;



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = true;
            P_MINE.Visible = false;
           
            Lb_Ttle.Text = "  A N A ";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MINE.Visible = true;
            bunifuThinButton24.Visible = true;
            txt_serach.Visible = true;
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
            txt_serach.Visible = true;

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
            //ADD SELL
            if (State == "SELL")
            {
                PL.FRM_MAKESELL FSELL = new FRM_MAKESELL();
                FSELL.btnadd.ButtonText = "eklemek";
                FSELL.ID = 0;
                bunifuTransition1.ShowSync(FSELL);

            }
            //ADD BOR
            if (State == "BOR")
            {
                PL.FRM_BRO FSELL = new FRM_BRO();
                FSELL.btnadd.ButtonText = "eklemek";
                FSELL.ID = 0;
                bunifuTransition1.ShowSync(FSELL);

            }
            //ADD USER
            if (State == "USER")
            {
                PL.FRM_ADDUSER FUSER = new FRM_ADDUSER();
                FUSER.btnadd.ButtonText = "eklemek";
                FUSER.ID = 0;
                bunifuTransition1.ShowSync(FUSER);

            }
        }

            private void FRM_MIAN_Activated(object sender, EventArgs e)
        {
            //FOR CHECK NuMBER
            //BOOK
            try
            {
                DataTable dt = new DataTable();
                dt = BLBOOKS.Load();
                label3.Text = dt.Rows.Count.ToString();


            }
            catch { }

            //for check number students

            try
            {
                DataTable dt = new DataTable();
                dt = BSELL.Load();
                label4.Text = dt.Rows.Count.ToString();


            }
            catch 
            {
               
            }

            //for check number satış

            try
            {
                DataTable dt = new DataTable();
                dt = BLST.Load();
                label6.Text = dt.Rows.Count.ToString();
            }
            catch 
            {
               
            }
            //for check number BORÇLANMA
            try
            {
                DataTable dt = new DataTable();
                dt = BRO.Load();
                label12.Text = dt.Rows.Count.ToString();
            }
            catch 
            {
                
            }
            //for check number TÜRLER
            try
            {
                DataTable dt = new DataTable();
                dt = BLCAT.Load();
                label10.Text = dt.Rows.Count.ToString();


            }
            catch 
            {
               
            }
            //for check number KULLANICILAR

            try
            {
                DataTable dt = new DataTable();
                dt = BLUSER.Load();
                label8.Text = dt.Rows.Count.ToString();
            }
            catch
            {
                
            }
            // for prem
            if (lb_prem.Text == "MÜDÜR")
            {
                bunifuThinButton23.Enabled = true;
                button6.Enabled = true;
            }
            else
            {
                bunifuThinButton23.Enabled = false;
                button6.Enabled = false;

            }


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
            else if (State == "ST")
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
            else if (State == "SELL")
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
                    dt = BSELL.Load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "sıralama";
                    dataGridView1.Columns[1].HeaderText = "Kitap adı";
                    dataGridView1.Columns[2].HeaderText = "alıcı";
                    dataGridView1.Columns[3].HeaderText = "fiyat";
                    dataGridView1.Columns[4].HeaderText = "tarih";


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
                if (State == "BOR")
                {
                    P_HOME.Visible = false;
                    P_MINE.Visible = true;
                    bunifuThinButton24.Visible = false;
                    State = "BOR";
                    Lb_Ttle.Text = " borçlanma ";


                    // load data
                    try
                    {
                        DataTable dt = new DataTable();
                        dt = BRO.Load();
                        dataGridView1.DataSource = dt;
                        dataGridView1.Columns[0].HeaderText = "sıralama";
                        dataGridView1.Columns[1].HeaderText = "ALICI ADI";
                        dataGridView1.Columns[2].HeaderText = "KİTAP ADI";
                        dataGridView1.Columns[3].HeaderText = "BORÇLANMA BAŞLANGICI";
                        dataGridView1.Columns[4].HeaderText = "BORÇLANMA SONU";
                        dataGridView1.Columns[5].HeaderText = "FİYAT";



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                if (State == "USER")
                {

                    P_HOME.Visible = false;
                    P_MINE.Visible = true;
                    bunifuThinButton24.Visible = false;
                    State = "USER";
                    Lb_Ttle.Text = " KULLANICILAR";


                    // load data
                    try
                    {
                        DataTable dt = new DataTable();
                        dt = BLUSER.Load();
                        dataGridView1.DataSource = dt;
                        dataGridView1.Columns[0].HeaderText = "sıralama";
                        dataGridView1.Columns[1].HeaderText = "AD SOYAD";
                        dataGridView1.Columns[2].HeaderText = "KULLANICI ADI";
                        dataGridView1.Columns[3].HeaderText = "ŞİFRE";
                        dataGridView1.Columns[4].HeaderText = "GEÇERLİLİK";




                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
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
            //edit books
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
            //edit student
            else if (State == "ST")
            {
                try
                {
                    PL.FRM_DETST FST = new FRM_DETST();
                    DataTable dt = new DataTable();
                    dt = BLST.LOADEDIT(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                    object obj1 = dt.Rows[0]["NAME"];
                    object obj2 = dt.Rows[0]["TLOACTION"];
                    object obj3 = dt.Rows[0]["PHONE"];
                    object obj4 = dt.Rows[0]["EMAIL"];
                    object obj5 = dt.Rows[0]["SCHOOL"];
                    object obj6 = dt.Rows[0]["DEP"];
                    object obj7 = dt.Rows[0]["COVER"];
                    FST.txt_name.Text = obj1.ToString();
                    FST.txt_lo.Text = obj2.ToString();
                    FST.txt_phone.Text = obj3.ToString();
                    FST.txt_email.Text = obj4.ToString();
                    FST.txt_school.Text = obj5.ToString();
                    FST.txt_dept.Text = obj6.ToString();
                    //load ımage
                    byte[] ob = (byte[])obj7;
                    MemoryStream ma = new MemoryStream(ob);
                    FST.cover.Image = Image.FromStream(ma);

                    bunifuTransition1.ShowSync(FST);


                }
                catch
                {

                }

            }
            else if (State == "SELL")
            {
                try
                {
                    PL.FRM_MAKESELL FST = new FRM_MAKESELL();
                    FST.btnadd.ButtonText = "DEĞİŞİKLİK";
                    FST.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                    bunifuTransition1.ShowSync(FST);


                }
                catch
                {

                }
            }
            else if (State == "BOR")
            {
                try
                {
                    PL.FRM_BRO FST = new FRM_BRO();
                    FST.btnadd.ButtonText = "DEĞİŞİKLİK";
                    FST.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                    bunifuTransition1.ShowSync(FST);


                }
                catch
                {

                }

            }
            else if (State == "USER")
            {
                try
                {
                    PL.FRM_ADDUSER FUSER = new FRM_ADDUSER();
                    FUSER.btnadd.ButtonText = "DEĞİŞİKLİK";
                    FUSER.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                    bunifuTransition1.ShowSync(FUSER);


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
            //delete student
        
            else if (State == "ST")
            {
                BLST.Delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_DDELETE fdelete = new FRM_DDELETE();
        fdelete.Show();

            }
            //delete sell

            else if (State == "SELL")
            {
                BSELL.Delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_DDELETE fdelete = new FRM_DDELETE();
                fdelete.Show();

            } //delete bor

            else if (State == "BOR")
            {
                BRO.Delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_DDELETE fdelete = new FRM_DDELETE();
                fdelete.Show();

            }
            //delete user

            else if (State == "USER")
            {
                BLUSER.Delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
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
                dt = BLBOOKS.serach(txt_serach.Text);
                dataGridView1.DataSource = dt;


            }
            //SEARCH CATEGORE
            if (State == "BOOKS")
            {
                DataTable dt = new DataTable();
                dt = BLCAT.serach(txt_serach.Text);
                dataGridView1.DataSource = dt;


            }

            //SEARCH STUDENT
            if (State == "ST")
            {
                DataTable dt = new DataTable();
                dt = BLST.serach(txt_serach.Text);
                dataGridView1.DataSource = dt;


            }
            //SEARCH SELL
            if (State == "SELL")
            {
                DataTable dt = new DataTable();
                dt = BSELL.serach(txt_serach.Text);
                dataGridView1.DataSource = dt;


            }
            //SEARCH BOR
            if (State == "BOR")
            {
                DataTable dt = new DataTable();
                dt = BRO.serach(txt_serach.Text);
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
            else if (State == "ST")
            {
                try
                {
                    PL.FRM_DETST FST = new FRM_DETST();
                    DataTable dt = new DataTable();
                    dt = BLST.LOADEDIT(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                    object obj1 = dt.Rows[0]["NAME"];
                    object obj2 = dt.Rows[0]["TLOACTION"];
                    object obj3 = dt.Rows[0]["PHONE"];
                    object obj4 = dt.Rows[0]["EMAIL"];
                    object obj5 = dt.Rows[0]["SCHOOL"];
                    object obj6 = dt.Rows[0]["DEP"];
                    object obj7 = dt.Rows[0]["COVER"];
                    FST.txt_name.Text = obj1.ToString();
                    FST.txt_lo.Text = obj2.ToString();
                    FST.txt_phone.Text = obj3.ToString();
                    FST.txt_email.Text = obj4.ToString();
                    FST.txt_school.Text = obj5.ToString();
                    FST.txt_dept.Text = obj6.ToString();
                    //load ımage
                    byte[] ob = (byte[])obj7;
                    MemoryStream ma = new MemoryStream(ob);
                    FST.cover.Image = Image.FromStream(ma);

                    bunifuTransition1.ShowSync(FST);


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
            txt_serach.Visible = true;

            State = "ST";
            Lb_Ttle.Text = "   ÖĞRENCİLER ";


            // load data
            try
            {
                DataTable dt = new DataTable();
                dt = BSELL.Load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "sıralama";
                dataGridView1.Columns[1].HeaderText = "Kitap adı";
                dataGridView1.Columns[2].HeaderText = "alıcı";
                dataGridView1.Columns[3].HeaderText = "fiyat";
                dataGridView1.Columns[4].HeaderText = "tarih";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MINE.Visible = true;
            bunifuThinButton24.Visible = false;
            txt_serach.Visible = true;

            State = "SELL";
            Lb_Ttle.Text = "  satış ";


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

        private void button5_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MINE.Visible = true;
            bunifuThinButton24.Visible = false;
            txt_serach.Visible = true;

            State = "BOR";
            Lb_Ttle.Text = "borçlanma ";


            // load data
            try
            {
                DataTable dt = new DataTable();
                dt = BRO.Load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "sıralama";
                dataGridView1.Columns[1].HeaderText = "ALICI ADI";
                dataGridView1.Columns[2].HeaderText = "KİTAP ADI";
                dataGridView1.Columns[3].HeaderText = "BORÇLANMA BAŞLANGICI";
                dataGridView1.Columns[4].HeaderText = "BORÇLANMA SONU";
                dataGridView1.Columns[5].HeaderText = "FİYAT";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MINE.Visible = true;
            bunifuThinButton24.Visible = false;
            txt_serach.Visible = false;

            State = "USER";
            Lb_Ttle.Text = " KULLANICILAR";


            // load data
            try
            {
                DataTable dt = new DataTable();
                dt = BLUSER.Load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "sıralama";
                dataGridView1.Columns[1].HeaderText = "AD SOYAD";
                dataGridView1.Columns[2].HeaderText = "KULLANICI ADI";
                dataGridView1.Columns[3].HeaderText = "ŞİFRE";
                dataGridView1.Columns[4].HeaderText = "GEÇERLİLİK";
               



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            PL.FRM_LOG Login = new FRM_LOG();
            BLUSER.logout();
            this.Hide();
            Login.Show();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //ADD CATEGORE
                PL.FRM_ADDCAT FCAT = new FRM_ADDCAT();
                FCAT.btnadd.ButtonText = "eklemek";
                FCAT.ID = 0;
                bunifuTransition1.ShowSync(FCAT);  
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //ADD BOR
                PL.FRM_BRO FSELL = new FRM_BRO();
                FSELL.btnadd.ButtonText = "eklemek";
                FSELL.ID = 0;
                bunifuTransition1.ShowSync(FSELL);       
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //ADD SELL
            
                PL.FRM_MAKESELL FSELL = new FRM_MAKESELL();
                FSELL.btnadd.ButtonText = "eklemek";
                FSELL.ID = 0;
                bunifuTransition1.ShowSync(FSELL);

            }
            private void button9_Click(object sender, EventArgs e)
        {
            //ADD STUDENT
                PL.FRM_ADDSTUDNET FBOOKS = new FRM_ADDSTUDNET();
                FBOOKS.btnadd.ButtonText = "eklemek";
                FBOOKS.ID = 0;
                bunifuTransition1.ShowSync(FBOOKS);

            } 
        private void button8_Click(object sender, EventArgs e)
        {
            //ADD books
                PL.FRM_ADDBOKKS FBOOKS = new FRM_ADDBOKKS();
                FBOOKS.btnadd.ButtonText = "eklemek";
                FBOOKS.ID = 0;
                bunifuTransition1.ShowSync(FBOOKS);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            PL.FRM_REPORT Report = new FRM_REPORT();
            Report.Show();

        }
    }
    }
    
  

