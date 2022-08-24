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
    public partial class inLop : Form
    {
        public inLop()
        {
            InitializeComponent();
        }
        QLD17Entities db = new QLD17Entities();
        private void inLop_Load(object sender, EventArgs e)
        {
            //var q = from n in db.Lops
            //        join m in db.Diems on n.LopID equals m.HocsinhID
            //        //join k in db.tblMonHocs on n.Mamon equals k.Mamon
            //        where n.LopID.Contains(txt_lop.Text)
            //        select new
            //        {
            //            LopID = n.LopID,
            //            Tenlop = n.Tenlop,
            //            Siso = n.Siso

            //        };
            //CrystalReport1 rp = new CrystalReport1();
            //rp.SetDataSource(q.ToList());
            //viewLop.ReportSource = rp;
            ////CrystalReport1 rp = new CrystalReport1();
            ////rp.SetDataSource(db.Lops.ToList());
            ////viewLop.ReportSource = rp;
            ///

        }
        private void bt_in_Click(object sender, EventArgs e)
        {
                CrystalReport1 rp = new CrystalReport1();
                rp.SetParameterValue("malop", txt_lop.Text);
                viewLop.ReportSource = rp;
            
        }
    }
}
