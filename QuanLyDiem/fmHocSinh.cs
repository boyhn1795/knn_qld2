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
    public partial class fmHocSinh : Form
    {
        public fmHocSinh()
        {
            InitializeComponent();
        }
        QLD17Entities db = new QLD17Entities();
        void load_diem()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = db.Hocsinhs.ToList();
        }
        private void fmHocSinh_Load(object sender, EventArgs e)
        {
            load_diem();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát hay không", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                Hocsinh hs = new Hocsinh();
                var a = from q in db.Hocsinhs
                        where q.HocsinhID == txt_hsid.Text
                        select q;
                hs = a.FirstOrDefault();
                db.Hocsinhs.Remove(hs);
                db.SaveChanges();
                load_diem();
                MessageBox.Show("Xoá Thành Công");
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            try
            {
                Hocsinh hs = new Hocsinh();
                var a = from q in db.Hocsinhs
                        where q.HocsinhID == txt_hsid.Text
                        select q;
                hs = a.FirstOrDefault();
                hs.HocsinhID = txt_hsid.Text;
                hs.LopID = txt_lopid.Text;
                hs.Hoten = txt_hoten.Text;
                hs.Ngaysinh = DateTime.Parse(date_ngaysinh.Text);
                hs.Gioitinh = txt_gt.Text;
                hs.Diachi = txt_dc.Text;
                hs.Loptruong = txt_lt.Text;
                hs.Bithuchidoan = txt_btcd.Text;
                db.SaveChanges();
                load_diem();
                MessageBox.Show("Sửa Thành Công");
                txt_hsid.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }

        }
        Boolean ktdl()
        {
            if (txt_hsid.Text == "" || txt_lopid.Text == "" || txt_hoten.Text == "" || date_ngaysinh.Text == "" || txt_gt.Text == "" || txt_dc.Text == "" || txt_lt.Text == "" || txt_btcd.Text == "" || txt_gc.Text == "")
                return false;
            else return true;
        }
        void xoatext()
        {
            txt_hsid.Text = ""; txt_lopid.Text = ""; txt_hoten.Text = ""; date_ngaysinh.Text = ""; txt_gt.Text = ""; txt_dc.Text = ""; txt_lt.Text = ""; txt_btcd.Text = ""; txt_gc.Text = "";
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (ktdl() == false)
            {
                MessageBox.Show("Bạn Chưa Nhập Đủ Dữ Liệu", "Thông Báo");
            }
            else
            {
                Hocsinh hs = db.Hocsinhs.Find(txt_hsid.Text);
                if (hs != null)
                {
                    MessageBox.Show("Trùng Mã Phòng", "Thông Báo");
                    txt_hsid.Focus();
                }
                else
                {
                    Hocsinh hs1 = new Hocsinh();
                    hs1.HocsinhID = txt_hsid.Text;
                    hs1.LopID = txt_lopid.Text;
                    hs1.Hoten = txt_hoten.Text;
                    hs1.Ngaysinh = DateTime.Parse(date_ngaysinh.Text);
                    hs1.Gioitinh = txt_gt.Text;
                    hs1.Diachi = txt_dc.Text;
                    hs1.Loptruong = txt_lt.Text;
                    hs1.Bithuchidoan = txt_btcd.Text;
                    hs1.Ghichu = txt_gc.Text;
                    db.Hocsinhs.Add(hs1);
                    db.SaveChanges();
                    load_diem();
                    xoatext();
                    MessageBox.Show("Thêm Thành Công", "Thông Báo");
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txt_hsid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_lopid.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_hoten.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            date_ngaysinh.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_gt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_dc.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_lt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_btcd.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            //txt_gc.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txt_hsid.Enabled = false;
        }

        private void bt_in_Click(object sender, EventArgs e)
        {
            load_diem();
        }
    }
}
