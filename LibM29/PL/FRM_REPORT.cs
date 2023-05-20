using Microsoft.VisualBasic.ApplicationServices;
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
using LibM29.BL;

namespace LibM29.PL
{
    public partial class FRM_REPORT : Form
    {
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
        public FRM_REPORT()
        {
            InitializeComponent();
        }

        private void FRM_REPORT_Load(object sender, EventArgs e)
        {
            PL.FRM_MIAN HOME = new FRM_MIAN();
            lb_name.Text = HOME.lb_name.Text;
            lb_perm.Text = HOME.lb_prem.Text;
            lb_date.Text = DateTime.Now.ToString();
            //
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


        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            printDocument1.Print();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap img = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(img, new Rectangle(Point.Empty, panel1.Size));
            e.Graphics.DrawImage(img, 0, 0);
        }
    }
}
