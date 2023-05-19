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
    public partial class FRM_START : Form
    {
        public FRM_START()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BL.CLS_USER userfrm = new BL.CLS_USER();
            DataTable dt = new DataTable();
            dt = userfrm.STARTLOADDTA();
            if(dt.Rows.Count>0)
            {
                PL.FRM_MIAN frmmain = new FRM_MIAN();
                object lbname = dt.Rows[0]["CNAME"];
                object lbprem = dt.Rows[0]["CPREM"];
                frmmain.lb_name.Text = lbname.ToString();
                frmmain.lb_prem.Text = lbprem.ToString();
                frmmain.Show();
                this.Hide();
                timer1.Enabled = false;
            }
            else
            {
                PL.FRM_LOG frmlogin = new FRM_LOG();
                frmlogin.Show();
                this.Hide();
                timer1.Enabled = false;

            }
        }
        }
    }

