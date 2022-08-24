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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        QLD17Entities db = new QLD17Entities();
        private void cậpNhậtHồSơHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmHocSinh a = new fmHocSinh();
            a.Show();
        }

        private void cậpNhậtLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmLop a = new fmLop();
            a.Show();
        }

        private void inĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inLop a = new inLop();
            a.Show();
        }

        private void thốngKêHọcSinhLưuBanTheoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inHSLB a = new inHSLB();
            a.Show();
        }
    }
}
