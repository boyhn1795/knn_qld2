using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class inHSLB : Form
    {
        public inHSLB()
        {
            InitializeComponent();
        }

        private void inHSLB_Load(object sender, EventArgs e)
        {

        }

        private void bt_in_Click(object sender, EventArgs e)
        {
            CrystalReport2 rp = new CrystalReport2();
            rp.SetParameterValue("malop", txt_lop.Text);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
