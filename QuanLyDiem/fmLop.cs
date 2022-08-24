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
    public partial class fmLop : Form
    {
        public fmLop()
        {
            InitializeComponent();
        }
        QLD17Entities db = new QLD17Entities();
        void load_lop()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = db.Lops.ToList();
        }
        private void fmLop_Load(object sender, EventArgs e)
        {
            load_lop();

        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thoát Hay Không", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                Lop l = new Lop();
                var q = from a in db.Lops
                        where a.LopID == txt_maidlop.Text
                        select a;
                l = q.FirstOrDefault();
                db.Lops.Remove(l);
                db.SaveChanges();
                MessageBox.Show("Xoá Thành Công");
                load_lop();
            }
            catch
            {
                MessageBox.Show("lỗi");
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            try
            {
                Lop i = new Lop();
                var a = from s in db.Lops
                        where s.LopID == txt_maidlop.Text
                        select s;
                i = a.FirstOrDefault();
                i.LopID = txt_maidlop.Text;
                i.Tenlop = txt_tenlop.Text;
                i.Siso = int.Parse(txt_siso.Text);
                db.SaveChanges();
                load_lop();
                MessageBox.Show("Sửa Thành Công");
                txt_maidlop.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        Boolean ktdl_lop()
        {
            if (txt_maidlop.Text == "" || txt_siso.Text == "" || txt_tenlop.Text == "")
                return false;
            else return true;
        }
        void xoatext()
        {
            txt_tenlop.Text = "";
            txt_siso.Text = "";
            txt_maidlop.Text = "";
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (ktdl_lop() == false)
            {
                MessageBox.Show("Vui Lòng Nhập Đủ Thông Tin", "Thông Báo");
            }
            else
            {
                Lop l = db.Lops.Find(txt_maidlop.Text);
                if (l != null)
                {
                    MessageBox.Show("Trùng Mã, Vui Lòng Nhập Lại", "Thông Báo");
                    txt_maidlop.Focus();
                    xoatext();
                }
                else
                {
                    try
                    {
                        Lop a = new Lop();
                        a.LopID = txt_maidlop.Text;
                        a.Siso = int.Parse(txt_siso.Text);
                        a.Tenlop = txt_tenlop.Text;
                        db.Lops.Add(a);
                        db.SaveChanges();
                        load_lop();
                        //xoatext();
                    }
                    catch
                    {
                        MessageBox.Show("Bạn Phải Nhập Số Nguyên", "Thông Báo");
                    }
                }
            }
        }

        private void txt_siso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txt_maidlop.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_tenlop.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_siso.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
