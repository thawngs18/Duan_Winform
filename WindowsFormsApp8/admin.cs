using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlTypes;
using WindowsFormsApp8.database;
using System.Windows.Documents;



namespace WindowsFormsApp8
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }


        private void admin_Load(object sender, EventArgs e)
        {

            Panel[] panels = { flp_admin, ftp_DL, panel2, pnlKH, pnlDinhDang, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlTheLoai, pnlPhongChieu,pnl_tk };
            foreach (var pan in panels)
            {
                pan.Visible = false;
            }

            flp_admin.Visible = true;
            panel1.Visible = true;
            System.Windows.Forms.Button[] buttons = { btn_acc, button16, button17, button15, button13, button14, button24, button28, button29, button30, button31, button32 };
            foreach (var button in buttons)
                button.BackColor = SystemColors.Control;
            button16.BackColor = Color.Red;




        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Text = "Nhan Vien";
            Panel[] panels = { flp_admin, ftp_DL, panel2, pnlKH, pnlDinhDang, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlTheLoai, pnlPhongChieu, pnl_tk };
            foreach (var pan in panels)
            {
                pan.Visible = false;
            }
            pnlNV.Visible = true;
            System.Windows.Forms.Button[] buttons = { btn_acc, button16, button17, button15, button13, button14, button24, button28, button29, button30, button31, button32 };
            foreach (var button in buttons)
                button.BackColor = SystemColors.Control;
            button13.BackColor = Color.Red;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Text = "Khach Hang";
            Panel[] p = { flp_admin, panel2, ftp_DL, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai, pnl_tk };
            foreach (var panel in p)
            { panel.Visible = false; }
            pnlKH.Visible = true;
            System.Windows.Forms.Button[] buttons = { btn_acc, button16, button17, button15, button13, button14, button24, button28, button29, button30, button31, button32 };
            foreach (var button in buttons)
                button.BackColor = SystemColors.Control;
            button15.BackColor = Color.Red;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "Doanh Thu";
            Panel[] p = { flp_admin, panel2, ftp_DL, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai, pnl_tk };
            foreach (var panel in p)
            { panel.Visible = false; }
            pnlDoanhThu.Visible = true;

            loadCBPhim();
            System.Windows.Forms.Button[] buttons = { btn_acc, button16, button17, button15, button13, button14, button24, button28, button29, button30, button31, button32 };
            foreach (var button in buttons)
                button.BackColor = SystemColors.Control;
            button14.BackColor = Color.Red;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Text = "Du Lieu";
            Panel[] p = { flp_admin, panel2, ftp_DL, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai, pnl_tk };
            foreach (var panel in p)
            { panel.Visible = false; }
            panel2.Visible = true;
            ftp_DL.Visible = true;
            System.Windows.Forms.Button[] buttons = { btn_acc, button16, button17, button15, button13, button14, button24, button28, button29, button30, button31, button32 };
            foreach (var button in buttons)
                button.BackColor = SystemColors.Control;

            button17.BackColor = Color.Red;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Text = "Loai Man Hinh";
            Panel[] p = { flp_admin, panel2, ftp_DL, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai, pnl_tk };
            foreach (var panel in p)
            { panel.Visible = false; }
            panel2.Visible = true;
            pnlLoaiManHinh.Visible = true;
            System.Windows.Forms.Button[] buttons = { btn_acc, button16, button17, button15, button13, button14, button24, button28, button29, button30, button31, button32 };
            foreach (var button in buttons)
                button.BackColor = SystemColors.Control;
            button24.BackColor = Color.Red;
            button17.BackColor = Color.Red;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Text = "Phong Chieu";
            Panel[] p = { flp_admin, panel2, ftp_DL, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai, pnl_tk };
            foreach (var panel in p)
            { panel.Visible = false; }
            panel2.Visible = true;
            pnlPhongChieu.Visible = true;
            System.Windows.Forms.Button[] buttons = { btn_acc, button16, button17, button15, button13, button14, button24, button28, button29, button30, button31, button32 };
            foreach (var button in buttons)
                button.BackColor = SystemColors.Control;
            button28.BackColor = Color.Red;
            button17.BackColor = Color.Red;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Text = "The Loai";
            Panel[] p = { flp_admin, panel2, ftp_DL, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai, pnl_tk };
            foreach (var panel in p)
            { panel.Visible = false; }
            panel2.Visible = true;
            pnlTheLoai.Visible = true;
            System.Windows.Forms.Button[] buttons = { btn_acc, button16, button17, button15, button13, button14, button24, button28, button29, button30, button31, button32 };
            foreach (var button in buttons)
                button.BackColor = SystemColors.Control;
            button29.BackColor = Color.Red;
            button17.BackColor = Color.Red;


        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Text = "Phim";
            Panel[] p = { flp_admin, panel2, ftp_DL, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai, pnl_tk };
            foreach (var panel in p)
            { panel.Visible = false; }
            panel2.Visible = true;
            pnlPhim.Visible = true;

            LoadTheLoaiToCheckedListBox();
            System.Windows.Forms.Button[] buttons = { btn_acc, button16, button17, button15, button13, button14, button24, button28, button29, button30, button31, button32 };
            foreach (var button in buttons)
                button.BackColor = SystemColors.Control;
            button30.BackColor = Color.Red;
            button17.BackColor = Color.Red;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Text = "Dinh Dang";
            Panel[] p = { flp_admin, panel2, ftp_DL, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai, pnl_tk };
            foreach (var panel in p)
            { panel.Visible = false; }
            panel2.Visible = true;
            pnlDinhDang.Visible = true;

            LoadComboBoxData();
            System.Windows.Forms.Button[] buttons = { btn_acc, button16, button17, button15, button13, button14, button24, button28, button29, button30, button31, button32 };
            foreach (var button in buttons)
                button.BackColor = SystemColors.Control;
            button31.BackColor = Color.Red;
            button17.BackColor = Color.Red;
        }
        private void btnacc_Click(object sender, EventArgs e)
        {
            this.Text = "Tai Khoan";
            Panel[] p = { flp_admin, panel2, ftp_DL, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai, pnl_tk };
            foreach (var panel in p)
            { panel.Visible = false; }
            pnl_tk.Visible = true;
            System.Windows.Forms.Button[] buttons = { btn_acc, button16, button17, button15, button13, button14, button24, button28, button29, button30, button31, button32 };
            foreach (var button in buttons)
                button.BackColor = SystemColors.Control;
            btn_acc.BackColor = Color.Red;
        }
        private void btn_acc_Click(object sender, EventArgs e)
        {
            this.Text = "Tai Khoan";
            Panel[] p = { flp_admin, panel2, ftp_DL, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai, pnl_tk };
            foreach (var panel in p)
            { panel.Visible = false; }
            pnl_tk.Visible = true;
            System.Windows.Forms.Button[] buttons = { btn_acc, button16, button17, button15, button13, button14, button24, button28, button29, button30, button31, button32 };
            foreach (var button in buttons)
                button.BackColor = SystemColors.Control;
            btn_acc.BackColor = Color.Red;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            btn_acc.PerformClick();
;       }



        private void button23_Click(object sender, EventArgs e)
        {
            this.Text = "Lich Chieu";
            Panel[] p = { flp_admin, panel2, ftp_DL, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai, pnl_tk };
            foreach (var panel in p)
            { panel.Visible = false; }
            panel2.Visible = true;
            pnlLichChieu.Visible = true;

            LoadData();
            LoadPhongChieuData();
            System.Windows.Forms.Button[] buttons = { btn_acc, button16, button17, button15, button13, button14, button24, button28, button29, button30, button31, button32 };
            foreach (var button in buttons)
                button.BackColor = SystemColors.Control;
            button32.BackColor = Color.Red;
            button17.BackColor = Color.Red;

        }
        //dg code
        private void button16_Click(object sender, EventArgs e)
        {
            Panel[] panels = { flp_admin, ftp_DL, panel2, pnlKH, pnlDinhDang, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlTheLoai, pnlPhongChieu, pnl_tk };
            foreach (var pan in panels)
            {
                pan.Visible = false;
            }

            flp_admin.Visible = true;
            System.Windows.Forms.Button[] buttons = { btn_acc, button16, button17, button15, button13, button14, button24, button28, button29, button30, button31, button32 };
            foreach (var button in buttons)
                button.BackColor = SystemColors.Control;
            button16.BackColor = Color.Red;


        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            button16.PerformClick();
        }
        private void button17_Click(object sender, EventArgs e)
        {
            this.Text = "Du Lieu";
            Panel[] p = { flp_admin, panel2, ftp_DL, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai, pnl_tk };
            foreach (var panel in p)
            { panel.Visible = false; }
            panel2.Visible = true;
            ftp_DL.Visible = true;
            System.Windows.Forms.Button[] buttons = { btn_acc, button16, button17, button15, button13, button14, button24, button28, button29, button30, button31, button32 };
            foreach (var button in buttons)
                button.BackColor = SystemColors.Control;
            button17.BackColor = Color.Red;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            button17.PerformClick();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            this.Text = "Khach Hang";
            Panel[] p = { flp_admin, panel2, ftp_DL, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai, pnl_tk };
            foreach (var panel in p)
            { panel.Visible = false; }
            pnlKH.Visible = true;
            System.Windows.Forms.Button[] buttons = { btn_acc, button16, button17, button15, button13, button14, button24, button28, button29, button30, button31, button32 };
            foreach (var button in buttons)
                button.BackColor = SystemColors.Control;
            button15.BackColor = Color.Red;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            button15.PerformClick();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            this.Text = "Nhan Vien";
            Panel[] panels = { flp_admin, ftp_DL, panel2, pnlKH, pnlDinhDang, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlTheLoai, pnlPhongChieu, pnl_tk };
            foreach (var pan in panels)
            {
                pan.Visible = false;
            }
            pnlNV.Visible = true;
            System.Windows.Forms.Button[] buttons = { btn_acc, button16, button17, button15, button13, button14, button24, button28, button29, button30, button31, button32 };
            foreach (var button in buttons)
                button.BackColor = SystemColors.Control;
            button13.BackColor = Color.Red;
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            button13.PerformClick();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            this.Text = "Doanh Thu";
            Panel[] p = { flp_admin, panel2, ftp_DL, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai, pnl_tk };
            foreach (var panel in p)
            { panel.Visible = false; }
            pnlDoanhThu.Visible = true;

            loadCBPhim();
            System.Windows.Forms.Button[] buttons = { btn_acc, button16, button17, button15, button13, button14, button24, button28, button29, button30, button31, button32 };
            foreach (var button in buttons)
                button.BackColor = SystemColors.Control;
            button14.BackColor = Color.Red;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            button14.PerformClick();
        }
        private void button24_Click(object sender, EventArgs e)
        {
            this.Text = "Loai Man Hinh";
            Panel[] p = { flp_admin, panel2, ftp_DL, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai, pnl_tk };
            foreach (var panel in p)
            { panel.Visible = false; }
            panel2.Visible = true;
            pnlLoaiManHinh.Visible = true;
            System.Windows.Forms.Button[] buttons = { btn_acc, button16, button17, button15, button13, button14, button24, button28, button29, button30, button31, button32 };
            foreach (var button in buttons)
                button.BackColor = SystemColors.Control;
            button24.BackColor = Color.Red;
            button17.BackColor = Color.Red;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            button24.PerformClick();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            this.Text = "Phong Chieu";
            Panel[] p = { flp_admin, panel2, ftp_DL, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai, pnl_tk };
            foreach (var panel in p)
            { panel.Visible = false; }
            panel2.Visible = true;
            pnlPhongChieu.Visible = true;
            System.Windows.Forms.Button[] buttons = { btn_acc, button16, button17, button15, button13, button14, button24, button28, button29, button30, button31, button32 };
            foreach (var button in buttons)
                button.BackColor = SystemColors.Control;
            button28.BackColor = Color.Red;
            button17.BackColor = Color.Red;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            button28.PerformClick();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            this.Text = "The Loai";
            Panel[] p = { flp_admin, panel2, ftp_DL, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai, pnl_tk };
            foreach (var panel in p)
            { panel.Visible = false; }
            panel2.Visible = true;
            pnlTheLoai.Visible = true;
            System.Windows.Forms.Button[] buttons = { btn_acc, button16, button17, button15, button13, button14, button24, button28, button29, button30, button31, button32 };
            foreach (var button in buttons)
                button.BackColor = SystemColors.Control;
            button29.BackColor = Color.Red;
            button17.BackColor = Color.Red;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            button29.PerformClick();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            this.Text = "Phim";
            Panel[] p = { flp_admin, panel2, ftp_DL, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai, pnl_tk };
            foreach (var panel in p)
            { panel.Visible = false; }
            panel2.Visible = true;
            pnlPhim.Visible = true;

            LoadTheLoaiToCheckedListBox();
            System.Windows.Forms.Button[] buttons = { btn_acc, button16, button17, button15, button13, button14, button24, button28, button29, button30, button31, button32 };
            foreach (var button in buttons)
                button.BackColor = SystemColors.Control;
            button30.BackColor = Color.Red;
            button17.BackColor = Color.Red;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            button30.PerformClick();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            this.Text = "Dinh Dang";
            Panel[] p = { flp_admin, panel2, ftp_DL, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai, pnl_tk };
            foreach (var panel in p)
            { panel.Visible = false; }
            panel2.Visible = true;
            pnlDinhDang.Visible = true;

            LoadComboBoxData();
            System.Windows.Forms.Button[] buttons = { btn_acc, button16, button17, button15, button13, button14, button24, button28, button29, button30, button31, button32 };
            foreach (var button in buttons)
                button.BackColor = SystemColors.Control;
            button31.BackColor = Color.Red;
            button17.BackColor = Color.Red;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            button31.PerformClick();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            this.Text = "Lich Chieu";
            Panel[] p = { flp_admin, panel2, ftp_DL, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai, pnl_tk };
            foreach (var panel in p)
            { panel.Visible = false; }
            panel2.Visible = true;
            pnlLichChieu.Visible = true;

            LoadData();
            LoadPhongChieuData();
            System.Windows.Forms.Button[] buttons = { btn_acc, button16, button17, button15, button13, button14, button24, button28, button29, button30, button31, button32 };
            foreach (var button in buttons)
                button.BackColor = SystemColors.Control;
            button32.BackColor = Color.Red;
            button17.BackColor = Color.Red;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            button32.PerformClick();
        }











        private void btnXemNV_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    // Tải danh sách nhân viên
                    var nhanViens = context.NhanViens
                                           .Select(nv => new
                                           {
                                               nv.id,
                                               nv.HoTen,
                                               nv.NgaySinh,
                                               nv.DiaChi,
                                               nv.SDT,
                                               nv.CMND
                                           }).ToList();

                    dgvNV.DataSource = nhanViens; // Gán dữ liệu vào DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void txtTKNV_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtTKNV.Text.Trim();

            using (var db = new Model1())
            {
                var searchResults = db.NhanViens
                                      .Where(Mk => Mk.HoTen.Contains(searchValue))
                                      .ToList();


                dgvNV.DataSource = searchResults;
            }
        }
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    // Tạo đối tượng nhân viên mới
                    var newNhanVien = new NhanVien
                    {
                        id = txtMaNV.Text,
                        HoTen = txtHoTenNV.Text,
                        NgaySinh = DateTime.Parse(txtDateNV.Text),
                        DiaChi = txtDCNV.Text,
                        SDT = txtSDTNV.Text,
                        CMND = int.Parse(txtCCCDNV.Text)
                    };

                    // Thêm nhân viên vào DbSet
                    context.NhanViens.Add(newNhanVien);
                    context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                    MessageBox.Show("Thêm nhân viên thành công!");
                    btnXemNV.PerformClick(); // Tải lại danh sách sau khi thêm
                    ClearTextBoxes(pnlNV);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }





        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (dgvNV.SelectedRows.Count > 0)
            {
                var id = dgvNV.SelectedRows[0].Cells["id"].Value.ToString();
                try
                {
                    using (var context = new Model1())
                    {
                        var nhanVien = context.NhanViens.FirstOrDefault(nv => nv.id == id);
                        if (nhanVien != null)
                        {
                            context.NhanViens.Remove(nhanVien);
                            context.SaveChanges();
                            MessageBox.Show("Xóa nhân viên thành công!");
                            btnXemNV.PerformClick(); // Tải lại danh sách sau khi xóa
                            ClearTextBoxes(pnlNV);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nhân viên để xóa.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa.");
            }
        }



        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (dgvNV.SelectedRows.Count > 0)
            {
                var id = dgvNV.SelectedRows[0].Cells["id"].Value.ToString();
                try
                {
                    using (var context = new Model1())
                    {
                        var nhanVien = context.NhanViens.FirstOrDefault(nv => nv.id == id);
                        if (nhanVien != null)
                        {
                            nhanVien.HoTen = txtHoTenNV.Text;
                            nhanVien.NgaySinh = DateTime.Parse(txtDateNV.Text);
                            nhanVien.DiaChi = txtDCNV.Text;
                            nhanVien.SDT = txtSDTNV.Text;
                            nhanVien.CMND = int.Parse(txtCCCDNV.Text);

                            context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                            MessageBox.Show("Cập nhật nhân viên thành công!");
                            btnXemNV.PerformClick(); // Tải lại danh sách sau khi sửa
                            ClearTextBoxes(pnlNV);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nhân viên để cập nhật.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa.");
            }
        }



        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem có hàng nào được chọn không
            {
                var row = dgvNV.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["id"].Value?.ToString();
                txtHoTenNV.Text = row.Cells["HoTen"].Value?.ToString();
                txtDateNV.Text = row.Cells["NgaySinh"].Value?.ToString();
                txtDCNV.Text = row.Cells["DiaChi"].Value?.ToString();
                txtSDTNV.Text = row.Cells["SDT"].Value?.ToString();
                txtCCCDNV.Text = row.Cells["CMND"].Value?.ToString();
            }
        }
        //KhachHang
        private void btnXemKh_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    // Lấy danh sách khách hàng
                    var khachHangs = context.KhachHangs
                                            .Select(kh => new
                                            {
                                                kh.id,
                                                kh.HoTen,
                                                kh.NgaySinh,
                                                kh.DiaChi,
                                                kh.SDT,
                                                kh.CMND,
                                            }).ToList();

                    // Gán dữ liệu vào DataGridView
                    dgvKH.DataSource = khachHangs;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void btnThemKh_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    // Tạo đối tượng khách hàng mới
                    var newKhachHang = new KhachHang
                    {
                        id = txtMaKh.Text,
                        HoTen = txtHoTenKH.Text,
                        NgaySinh = DateTime.Parse(txtNsKH.Text),
                        DiaChi = txtDiaChiKH.Text,
                        SDT = txtSDTKH.Text,
                        CMND = int.Parse(txtCMNDKH.Text),
                      
                    };

                    // Thêm khách hàng vào DbSet
                    context.KhachHangs.Add(newKhachHang);
                    context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

                    MessageBox.Show("Thêm khách hàng thành công!");
                    btnXemKh.PerformClick(); // Tải lại danh sách sau khi thêm
                    ClearTextBoxes(pnlKH);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void btnXoaKh_Click(object sender, EventArgs e)
        {
            if (dgvKH.SelectedRows.Count > 0)
            {
                var id = dgvKH.SelectedRows[0].Cells["id"].Value.ToString();
                try
                {
                    using (var context = new Model1())
                    {
                        var khachHang = context.KhachHangs.FirstOrDefault(kh => kh.id == id);
                        if (khachHang != null)
                        {
                            context.KhachHangs.Remove(khachHang);
                            context.SaveChanges();
                            MessageBox.Show("Xóa khách hàng thành công!");
                            btnXemKh.PerformClick(); // Tải lại danh sách sau khi xóa
                            ClearTextBoxes(pnlKH);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy khách hàng để xóa.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa.");
            }
        }


        private void btnSuaKh_Click(object sender, EventArgs e)
        {
            if (dgvKH.SelectedRows.Count > 0)
            {
                var id = dgvKH.SelectedRows[0].Cells["id"].Value.ToString();
                try
                {
                    using (var context = new Model1())
                    {
                        var khachHang = context.KhachHangs.FirstOrDefault(kh => kh.id == id);
                        if (khachHang != null)
                        {
                            khachHang.HoTen = txtHoTenKH.Text;
                            khachHang.NgaySinh = DateTime.Parse(txtNsKH.Text);
                            khachHang.DiaChi = txtDiaChiKH.Text;
                            khachHang.SDT = txtSDTKH.Text;
                            khachHang.CMND = int.Parse(txtCMNDKH.Text);


                            context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                            MessageBox.Show("Cập nhật thông tin khách hàng thành công!");
                            btnXemKh.PerformClick(); // Tải lại danh sách sau khi sửa
                            ClearTextBoxes(pnlKH);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy khách hàng để cập nhật.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để sửa.");
            }
        }
        private void txtsearchkh_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtsearchkh.Text.Trim();

            using (var db = new Model1())
            {
                var searchResults = db.KhachHangs
                                      .Where(Mk => Mk.HoTen.Contains(searchValue))
                                      .ToList();


                dgvKH.DataSource = searchResults;
            }
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem có hàng nào được chọn không
            {
                var row = dgvKH.Rows[e.RowIndex];
                txtMaKh.Text = row.Cells["id"].Value?.ToString();
                txtHoTenKH.Text = row.Cells["HoTen"].Value?.ToString();
                txtNsKH.Text = row.Cells["NgaySinh"].Value?.ToString();
                txtDiaChiKH.Text = row.Cells["DiaChi"].Value?.ToString();
                txtSDTKH.Text = row.Cells["SDT"].Value?.ToString();
                txtCMNDKH.Text = row.Cells["CMND"].Value?.ToString();


          
            }
        }




        //Loai man hinh
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    // Lấy danh sách loại màn hình
                    var loaiManHinhs = context.LoaiManHinhs
                                              .Select(lmh => new
                                              {
                                                  lmh.id,
                                                  lmh.TenMH
                                              }).ToList();

                    // Gán dữ liệu vào DataGridView
                    dgvLMH.DataSource = loaiManHinhs;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    // Tạo đối tượng loại màn hình mới
                    var newLoaiManHinh = new LoaiManHinh
                    {
                        id = textBox4.Text,
                        TenMH = textBox13.Text
                    };

                    // Thêm loại màn hình vào DbSet
                    context.LoaiManHinhs.Add(newLoaiManHinh);
                    context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

                    MessageBox.Show("Thêm loại màn hình thành công!");
                    button6.PerformClick(); // Tải lại danh sách sau khi thêm
                    ClearTextBoxes(pnlLoaiManHinh);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void dgvLMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem có hàng nào được chọn không
            {
                var row = dgvLMH.Rows[e.RowIndex];
                textBox4.Text = row.Cells["id"].Value?.ToString();
                textBox13.Text = row.Cells["TenMH"].Value?.ToString();
            }
        }


        private void button27_Click(object sender, EventArgs e)
        {
            if (dgvLMH.SelectedRows.Count > 0)
            {
                var id = dgvLMH.SelectedRows[0].Cells["id"].Value?.ToString();
                try
                {
                    using (var context = new Model1())
                    {
                        // Tìm loại màn hình cần sửa
                        var loaiManHinh = context.LoaiManHinhs.FirstOrDefault(lmh => lmh.id == id);
                        if (loaiManHinh != null)
                        {
                            loaiManHinh.TenMH = textBox13.Text;

                            context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                            MessageBox.Show("Cập nhật thông tin thành công!");
                            button6.PerformClick(); // Tải lại danh sách sau khi cập nhật
                            ClearTextBoxes(pnlLoaiManHinh);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy loại màn hình để cập nhật.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một loại màn hình để sửa.");
            }
        }


        private void button26_Click(object sender, EventArgs e)
        {
            if (dgvLMH.SelectedRows.Count > 0)
            {
                var id = dgvLMH.SelectedRows[0].Cells["id"].Value?.ToString();
                try
                {
                    using (var context = new Model1())
                    {
                        // Tìm loại màn hình cần xóa
                        var loaiManHinh = context.LoaiManHinhs.FirstOrDefault(lmh => lmh.id == id);
                        if (loaiManHinh != null)
                        {
                            context.LoaiManHinhs.Remove(loaiManHinh);
                            context.SaveChanges();
                            MessageBox.Show("Xóa loại màn hình thành công!");
                            button6.PerformClick(); // Tải lại danh sách sau khi xóa
                            ClearTextBoxes(pnlLoaiManHinh);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy loại màn hình để xóa.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một loại màn hình để xóa.");
            }
        }


        //phong chieu


        private void btnThemPC_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    // Kiểm tra idManHinh có tồn tại không
                    var manHinh = context.LoaiManHinhs.FirstOrDefault(mh => mh.id == txtMHPC.Text);
                    if (manHinh == null)
                    {
                        MessageBox.Show("Mã màn hình không tồn tại.");
                        return;
                    }

                    var phongChieu = new PhongChieu
                    {
                        id = txtMaPc.Text,
                        TenPhong = txtTenPC.Text,
                        idManHinh = txtMHPC.Text,
                        SoChoNgoi = int.Parse(txtChoNgoiPC.Text),
                        TinhTrang = int.Parse(txtTinhTrangPc.Text),
                        SoHangGhe = int.Parse(txtHangGhePC.Text),
                        SoGheMotHang = int.Parse(txtGheMoiHangPC.Text)
                    };

                    context.PhongChieux.Add(phongChieu);
                    context.SaveChanges();
                    MessageBox.Show("Thêm phòng chiếu thành công!");
                    btnXemPC.PerformClick();
                    ClearTextBoxes(pnlPhongChieu);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.InnerException?.Message ?? ex.Message);
            }
        }



        private void btnXemPC_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    var phongChieus = context.PhongChieux
                        .Select(pc => new
                        {
                            pc.id,
                            pc.TenPhong,
                            pc.idManHinh,
                            pc.SoChoNgoi,
                            pc.TinhTrang,
                            pc.SoHangGhe,
                            pc.SoGheMotHang
                        })
                        .ToList();

                    dgvPC.DataSource = phongChieus;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.InnerException?.Message ?? ex.Message);
            }
        }




        private void btnXoaPC_Click(object sender, EventArgs e)
        {
            if (dgvPC.SelectedRows.Count > 0)
            {
                var id = dgvPC.SelectedRows[0].Cells["id"].Value.ToString();

                try
                {
                    using (var context = new Model1())
                    {
                        var phongChieu = context.PhongChieux.FirstOrDefault(pc => pc.id == id);
                        if (phongChieu != null)
                        {
                            // Kiểm tra xem có lịch chiếu liên quan không
                            if (context.LichChieux.Any(lc => lc.idPhong == id))
                            {
                                MessageBox.Show("Không thể xóa phòng chiếu vì có lịch chiếu liên quan.");
                                return;
                            }

                            context.PhongChieux.Remove(phongChieu);
                            context.SaveChanges();
                            MessageBox.Show("Xóa phòng chiếu thành công!");
                            btnXemPC.PerformClick();
                            ClearTextBoxes(pnlPhongChieu);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy phòng chiếu để xóa.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.InnerException?.Message ?? ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phòng chiếu để xóa.");
            }
        }




        private void btnSuaPC_Click(object sender, EventArgs e)
        {
            if (dgvPC.SelectedRows.Count > 0)
            {
                var id = dgvPC.SelectedRows[0].Cells["id"].Value.ToString();

                try
                {
                    using (var context = new Model1())
                    {
                        var phongChieu = context.PhongChieux.FirstOrDefault(pc => pc.id == id);
                        if (phongChieu != null)
                        {
                            phongChieu.TenPhong = txtTenPC.Text;
                            phongChieu.idManHinh = txtMHPC.Text;
                            phongChieu.SoChoNgoi = int.Parse(txtChoNgoiPC.Text);
                            phongChieu.TinhTrang = int.Parse(txtTinhTrangPc.Text);
                            phongChieu.SoHangGhe = int.Parse(txtHangGhePC.Text);
                            phongChieu.SoGheMotHang = int.Parse(txtGheMoiHangPC.Text);

                            context.SaveChanges();
                            MessageBox.Show("Cập nhật thông tin thành công!");
                            btnXemPC.PerformClick();
                            ClearTextBoxes(pnlPhongChieu);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy phòng chiếu để cập nhật.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.InnerException?.Message ?? ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phòng chiếu để sửa.");
            }
        }



        private void dgvPC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvPC.Rows[e.RowIndex];
                txtMaPc.Text = row.Cells["id"].Value?.ToString();
                txtTenPC.Text = row.Cells["TenPhong"].Value?.ToString();
                txtMHPC.Text = row.Cells["idManHinh"].Value?.ToString();
                txtChoNgoiPC.Text = row.Cells["SoChoNgoi"].Value?.ToString();
                txtTinhTrangPc.Text = row.Cells["TinhTrang"].Value?.ToString();
                txtHangGhePC.Text = row.Cells["SoHangGhe"].Value?.ToString();
                txtGheMoiHangPC.Text = row.Cells["SoGheMotHang"].Value?.ToString();
            }
        }



        // Thể Loại
        private void btnXemTL_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (var context = new Model1())
                {
                    // Lấy danh sách dữ liệu và chuyển sang DTO
                    var theLoaiList = context.TheLoais
                        .Select(tl => new
                        {
                            tl.id,
                            tl.TenTheLoai,
                             tl.MoTa
                        })
                        .ToList();

                    // Gán dữ liệu vào DataGridView hoặc ListBox
                    dgvTL.DataSource = theLoaiList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnThemTL_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    var theLoai = new TheLoai
                    {
                        id = txtMaTheLoai.Text,
                        TenTheLoai = txtTenTheLoai.Text,
                        MoTa = txtMoTaTL.Text
                    };

                    context.TheLoais.Add(theLoai);
                    context.SaveChanges();

                    MessageBox.Show("Thêm thể loại thành công!");
                    btnXemTL.PerformClick(); // Tải lại danh sách
                    ClearTextBoxes(pnlTheLoai);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void btnXoaTL_Click(object sender, EventArgs e)
        {
            if (dgvTL.SelectedRows.Count > 0)
            {
                var id = dgvTL.SelectedRows[0].Cells["id"].Value.ToString();

                try
                {
                    using (var context = new Model1())
                    {
                        var theLoai = context.TheLoais.FirstOrDefault(tl => tl.id == id);
                        if (theLoai != null)
                        {
                            context.TheLoais.Remove(theLoai);
                            context.SaveChanges();

                            MessageBox.Show("Xóa thể loại thành công!");
                            btnXemTL.PerformClick(); // Tải lại danh sách
                            ClearTextBoxes(pnlTheLoai);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thể loại để xóa.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một thể loại để xóa.");
            }
        }

        private void dgvTL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTL.SelectedRows.Count > 0)
            {
                var row = dgvTL.SelectedRows[0];
                txtMaTheLoai.Text = row.Cells["id"].Value?.ToString();
                txtTenTheLoai.Text = row.Cells["TenTheLoai"].Value?.ToString();
                txtMoTaTL.Text = row.Cells["MoTa"].Value?.ToString();
            }
        }


        private void btnSuaTL_Click(object sender, EventArgs e)
        {
            if (dgvTL.SelectedRows.Count > 0)
            {
                var id = dgvTL.SelectedRows[0].Cells["id"].Value.ToString();

                try
                {
                    using (var context = new Model1())
                    {
                        var theLoai = context.TheLoais.FirstOrDefault(tl => tl.id == id);
                        if (theLoai != null)
                        {
                            theLoai.TenTheLoai = txtTenTheLoai.Text;
                            theLoai.MoTa = txtMoTaTL.Text;

                            context.SaveChanges();

                            MessageBox.Show("Cập nhật thông tin thành công!");
                            btnXemTL.PerformClick(); // Tải lại danh sách
                            ClearTextBoxes(pnlTheLoai);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thể loại để cập nhật.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một thể loại để sửa.");
            }
        }

        //Phim

        private void LoadTheLoaiToCheckedListBox()
        {
            try
            {
                using (var context = new Model1())
                {
                    var theLoais = context.TheLoais.ToList();

                    // Xóa danh sách cũ trước khi thêm mới
                    clbTheLoaiP.Items.Clear();

                    // Thêm từng tên thể loại vào CheckedListBox
                    foreach (var theLoai in theLoais)
                    {
                        clbTheLoaiP.Items.Add(new ListItem
                        {
                            Id = theLoai.id,
                            Name = theLoai.TenTheLoai
                        });
                    }

                    clbTheLoaiP.DisplayMember = "Name"; // Hiển thị tên thể loại
                    clbTheLoaiP.ValueMember = "Id";    // Lưu id ẩn trong ListItem
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }





        private void btnXemP_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    var phimList = context.Phims
                                          .Select(p => new
                                          {
                                              p.id,
                                              p.TenPhim,
                                              p.MoTa,
                                              p.ThoiLuong,
                                              p.NgayKhoiChieu,
                                              p.NgayKetThuc,
                                              p.SanXuat,
                                              p.DaoDien,
                                              p.NamSX,
                                              
                                              // Thêm các trường khác nếu cần
                                          })
                                          .ToList();
                    dgvP.DataSource = phimList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void btnSuaP_Click(object sender, EventArgs e)
        {
            if (dgvP.SelectedRows.Count > 0)
            {
                var id = dgvP.SelectedRows[0].Cells["id"].Value.ToString();

                try
                {
                    using (var context = new Model1())
                    {
                        var phim = context.Phims.FirstOrDefault(p => p.id == id);
                        if (phim != null)
                        {
                            phim.TenPhim = txtTenPhimP.Text;
                            phim.MoTa = txtMoTaP.Text;
                            phim.ThoiLuong = float.Parse(txtThoiLuongP.Text);
                            phim.NgayKhoiChieu = dtpKCP.Value.Date;
                            phim.NgayKetThuc = dtpKTP.Value.Date;
                            phim.SanXuat = txtSanXuatP.Text;
                            phim.DaoDien = txtDaoDienP.Text;
                            phim.NamSX = int.Parse(txtNamSXP.Text);

                            // Lấy danh sách thể loại được chọn
                            List<string> theLoaiIds = GetCheckedTheLoaiIds();

                            // Tìm các thể loại trong cơ sở dữ liệu
                            var theLoaiEntities = context.TheLoais
                                .Where(tl => theLoaiIds.Contains(tl.id))
                                .ToList();

                            // Cập nhật thể loại cho phim
                            phim.TheLoais.Clear();
                            foreach (var theLoai in theLoaiEntities)
                            {
                                phim.TheLoais.Add(theLoai);
                            }

                            context.SaveChanges();
                            MessageBox.Show("Cập nhật phim thành công!");
                            btnXemP.PerformClick();
                            ClearTextBoxes(pnlPhim);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy phim để cập nhật.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phim để sửa.");
            }
        }


        private void dgvP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvP.SelectedRows.Count > 0)
            {
                var row = dgvP.SelectedRows[0];
                txtMaPhimP.Text = row.Cells["id"].Value?.ToString();
                txtTenPhimP.Text = row.Cells["TenPhim"].Value?.ToString();
                txtMoTaP.Text = row.Cells["MoTa"].Value?.ToString();
                txtThoiLuongP.Text = row.Cells["ThoiLuong"].Value?.ToString();
                dtpKCP.Value = Convert.ToDateTime(row.Cells["NgayKhoiChieu"].Value);
                dtpKTP.Value = Convert.ToDateTime(row.Cells["NgayKetThuc"].Value);
                txtSanXuatP.Text = row.Cells["SanXuat"].Value?.ToString();
                txtDaoDienP.Text = row.Cells["DaoDien"].Value?.ToString();
                txtNamSXP.Text = row.Cells["NamSX"].Value?.ToString();

                // Load thể loại vào CheckedListBox
                LoadTheLoaiToCheckedListBox();
                var selectedPhimId = row.Cells["id"].Value?.ToString();
                using (var context = new Model1())
                {
                    var selectedPhim = context.Phims
                        .Include("TheLoais")
                        .FirstOrDefault(p => p.id == selectedPhimId);

                    if (selectedPhim != null)
                    {
                        // Tạo một bản sao của danh sách Items
                        var itemsCopy = clbTheLoaiP.Items.Cast<object>().ToList();

                        foreach (var item in itemsCopy)
                        {
                            if (item is ListItem listItem)
                            {
                                // Kiểm tra nếu thể loại có trong danh sách của phim đã chọn
                                bool isChecked = selectedPhim.TheLoais.Any(tl => tl.id == listItem.Id);

                                // Cập nhật trạng thái checked của item
                                int index = clbTheLoaiP.Items.IndexOf(item);
                                if (index >= 0)
                                {
                                    clbTheLoaiP.SetItemChecked(index, isChecked);
                                }
                            }
                        }
                    }
                }
            }
        }



        private List<string> GetCheckedTheLoaiIds()
        {
            List<string> checkedIds = new List<string>();

            foreach (var item in clbTheLoaiP.CheckedItems)
            {
                if (item is ListItem listItem)
                {
                    checkedIds.Add(listItem.Id); // Lấy danh sách id của thể loại
                }
            }

            return checkedIds;
        }

        private void AddPhanLoaiPhim(string maPhim, List<string> theLoaiIds)
        {
            try
            {
                using (var context = new Model1()) // Model1 là DbContext của bạn
                {
                    // Lấy đối tượng Phim dựa trên mã phim
                    var phim = context.Phims.FirstOrDefault(p => p.id == maPhim);
                    if (phim == null)
                    {
                        MessageBox.Show("Không tìm thấy phim.");
                        return;
                    }

                    // Lấy các thể loại dựa trên danh sách theLoaiIds và thêm vào Phim
                    foreach (string theLoaiId in theLoaiIds)
                    {
                        var theLoai = context.TheLoais.FirstOrDefault(t => t.id == theLoaiId);
                        if (theLoai != null && !phim.TheLoais.Contains(theLoai)) // Kiểm tra trùng lặp
                        {
                            phim.TheLoais.Add(theLoai); // Thêm thể loại vào phim
                        }
                    }

                    // Lưu thay đổi vào cơ sở dữ liệu
                    context.SaveChanges();
                    MessageBox.Show("Thêm thể loại cho phim thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void btnThemP_Click(object sender, EventArgs e)
        {
            string idP = txtMaPhimP.Text;
            string tenP = txtTenPhimP.Text;
            string MT = txtMoTaP.Text;
            float thoiluong = float.Parse(txtThoiLuongP.Text);
            DateTime ngaykc = dtpKCP.Value.Date;
            DateTime ngaykt = dtpKTP.Value.Date;
            string sannxuat = txtSanXuatP.Text;
            string daodien = txtDaoDienP.Text;
            int namsx = int.Parse(txtNamSXP.Text);

            // Lấy danh sách ID thể loại từ CheckedListBox
            List<string> theLoaiIds = GetCheckedTheLoaiIds();

            try
            {
                using (var context = new Model1())
                {
                    // Tạo đối tượng Phim
                    var phim = new Phim
                    {
                        id = idP,
                        TenPhim = tenP,
                        MoTa = MT,
                        ThoiLuong = thoiluong,
                        NgayKhoiChieu = ngaykc,
                        NgayKetThuc = ngaykt,
                        SanXuat = sannxuat,
                        DaoDien = daodien,
                        NamSX = namsx,
                        TheLoais = new List<TheLoai>() // Khởi tạo danh sách thể loại
                    };

                    // Lấy các thể loại và thêm vào phim
                    foreach (string theLoaiId in theLoaiIds)
                    {
                        var theLoai = context.TheLoais.FirstOrDefault(t => t.id == theLoaiId);
                        if (theLoai != null)
                        {
                            phim.TheLoais.Add(theLoai);
                        }
                    }

                    // Thêm phim vào DbContext
                    context.Phims.Add(phim);
                    context.SaveChanges();

                    MessageBox.Show("Thêm phim thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }



        private void btnXoaP_Click(object sender, EventArgs e)
        {
            if (dgvP.SelectedRows.Count > 0)
            {
                var id = dgvP.SelectedRows[0].Cells["id"].Value.ToString();

                try
                {
                    using (var context = new Model1())
                    {
                        var phim = context.Phims.FirstOrDefault(p => p.id == id);
                        if (phim != null)
                        {
                            context.Phims.Remove(phim);
                            context.SaveChanges();
                            MessageBox.Show("Xóa phim thành công!");
                            btnXemP.PerformClick();
                            ClearTextBoxes(pnlPhim);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy phim để xóa.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phim để xóa.");
            }
        }

        //Dinh Dang
        private void btnXemDD_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    // Lấy danh sách DinhDangPhim từ cơ sở dữ liệu
                    var dinhDangPhimList = context.DinhDangPhims
                        .Include("Phim") // Load thông tin phim
                        .Include("LoaiManHinh") // Load thông tin màn hình
                        .ToList();

                    dgvDD.DataSource = dinhDangPhimList.Select(ddp => new
                    {
                        ddp.id,
                        idPhim = ddp.Phim?.id,
                        TenPhim = ddp.Phim?.TenPhim,
                        idLoaiManHinh = ddp.LoaiManHinh?.id,
                        TenManHinh = ddp.LoaiManHinh?.TenMH
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThemDD_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    var newDinhDangPhim = new DinhDangPhim
                    {
                        id = txtMaDD.Text,
                        idPhim = ((ComboBoxItem)cmbMaPhimDD.SelectedItem).Id,
                        idLoaiManHinh = ((ComboBoxItem)cmbMaManHinhDD.SelectedItem).Id
                    };

                    context.DinhDangPhims.Add(newDinhDangPhim);
                    context.SaveChanges();
                    MessageBox.Show("Thêm định dạng phim thành công!");
                    btnXemDD.PerformClick(); // Tải lại danh sách
                    ClearTextBoxes(pnlDinhDang);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }



        private void LoadComboBoxData()
        {
            try
            {
                using (var context = new Model1())
                {
                    cmbMaPhimDD.Items.Clear();
                    cmbMaManHinhDD.Items.Clear();

                    // Load danh sách phim
                    var phimList = context.Phims.ToList();
                    foreach (var phim in phimList)
                    {
                        cmbMaPhimDD.Items.Add(new ComboBoxItem
                        {
                            Id = phim.id,
                            Name = phim.TenPhim
                        });
                    }

                    // Load danh sách màn hình
                    var manHinhList = context.LoaiManHinhs.ToList();
                    foreach (var manHinh in manHinhList)
                    {
                        cmbMaManHinhDD.Items.Add(new ComboBoxItem
                        {
                            Id = manHinh.id,
                            Name = manHinh.TenMH
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void cmbMaPhimDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaPhimDD.SelectedItem != null)
            {
                var selectedItem = (dynamic)cmbMaPhimDD.SelectedItem;
                txtTenPhimDD.Text = selectedItem.Name;
            }
        }

        private void cmbMaManHinhDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaManHinhDD.SelectedItem != null)
            {
                var selectedItem = (dynamic)cmbMaManHinhDD.SelectedItem;
                txtTenManHinhDD.Text = selectedItem.Name;
            }
        }

        private void dgvDD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDD.SelectedRows.Count > 0)
            {
                var row = dgvDD.SelectedRows[0];
                txtMaDD.Text = row.Cells["id"].Value?.ToString();

                // Gán giá trị vào ComboBox
                var phimId = row.Cells["idPhim"].Value?.ToString();
                var manHinhId = row.Cells["idLoaiManHinh"].Value?.ToString();

                foreach (ComboBoxItem item in cmbMaPhimDD.Items)
                {
                    if (item.Id == phimId)
                    {
                        cmbMaPhimDD.SelectedItem = item;
                        break;
                    }
                }

                foreach (ComboBoxItem item in cmbMaManHinhDD.Items)
                {
                    if (item.Id == manHinhId)
                    {
                        cmbMaManHinhDD.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void btnSuaDD_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    var id = txtMaDD.Text;
                    var dinhDangPhim = context.DinhDangPhims.FirstOrDefault(ddp => ddp.id == id);

                    if (dinhDangPhim != null)
                    {
                        dinhDangPhim.idPhim = ((ComboBoxItem)cmbMaPhimDD.SelectedItem).Id;
                        dinhDangPhim.idLoaiManHinh = ((ComboBoxItem)cmbMaManHinhDD.SelectedItem).Id;

                        context.SaveChanges();
                        MessageBox.Show("Cập nhật định dạng phim thành công!");
                        btnXemDD.PerformClick(); // Tải lại danh sách
                        ClearTextBoxes(pnlDinhDang);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy định dạng phim cần cập nhật.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoaDD_Click(object sender, EventArgs e)
        {
            if (dgvDD.SelectedRows.Count > 0)
            {
                var id = dgvDD.SelectedRows[0].Cells["id"].Value?.ToString();
                try
                {
                    using (var context = new Model1())
                    {
                        var dinhDangPhim = context.DinhDangPhims.FirstOrDefault(ddp => ddp.id == id);

                        if (dinhDangPhim != null)
                        {
                            context.DinhDangPhims.Remove(dinhDangPhim);
                            context.SaveChanges();
                            MessageBox.Show("Xóa định dạng phim thành công!");
                            btnXemDD.PerformClick(); // Tải lại danh sách
                            ClearTextBoxes(pnlDinhDang);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy định dạng phim để xóa.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một định dạng phim để xóa.");
            }
        }
        //Lich Chieu
        private void btnXemLC_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    // Truy vấn đầy đủ thông tin
                    var lichChieus = (from lc in context.LichChieux
                                      join phong in context.PhongChieux on lc.idPhong equals phong.id
                                      join dd in context.DinhDangPhims on lc.idDinhDang equals dd.id
                                      select new
                                      {
                                          lc.id,
                                          lc.ThoiGianChieu,
                                          idPhong = phong.id, // Bao gồm idPhong
                                          Phong = phong.TenPhong,
                                          idDinhDang = dd.id,
                                          lc.GiaVe,
                                          lc.TrangThai
                                      }).ToList();

                    dgvLC.DataSource = lichChieus;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }





        //load data dinhdangtronglichchieu
        private void LoadData()
        {
            try
            {
                using (var context = new Model1())
                {
                    // Lấy dữ liệu từ bảng DinhDangPhim
                    var dinhDangPhims = context.DinhDangPhims
                        .Include("Phim") // Hoặc .Include(dd => dd.Phim)
                        .Include("LoaiManHinh") // Hoặc .Include(dd => dd.LoaiManHinh)
                        .Select(dd => new
                        {
                            id = dd.id,
                            TenPhim = dd.Phim.TenPhim,
                            TenMH = dd.LoaiManHinh.TenMH
                        })
                        .ToList();

                    cmbMaDDLC.DataSource = dinhDangPhims;
                    cmbMaDDLC.DisplayMember = "TenPhim"; // Hiển thị tên phim
                    cmbMaDDLC.ValueMember = "id";       // Giá trị là id
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void cmbMaDDLC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaDDLC.SelectedItem != null)
            {
                dynamic selectedItem = cmbMaDDLC.SelectedItem;
                txtPhimLC.Text = selectedItem.TenPhim;
                txtManHinhLC.Text = selectedItem.TenMH;
            }
        }
        private void LoadPhongChieuData()
        {
            try
            {
                using (var context = new Model1())
                {
                    // Lấy dữ liệu từ bảng PhongChieu
                    var phongChieus = context.PhongChieux
                        .Select(pc => new
                        {
                            pc.id,
                            pc.TenPhong
                        })
                        .ToList();

                    cmbPhongChieuLC.DataSource = phongChieus;
                    cmbPhongChieuLC.DisplayMember = "TenPhong";
                    cmbPhongChieuLC.ValueMember = "id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }



        private void btnThemLC_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    var lichChieu = new LichChieu
                    {
                        id = txtMaLC.Text,
                        ThoiGianChieu = new DateTime(
                            dtpNgayLC.Value.Year,
                            dtpNgayLC.Value.Month,
                            dtpNgayLC.Value.Day,
                            dtpGioLC.Value.Hour,
                            dtpGioLC.Value.Minute,
                            0),
                        idPhong = cmbPhongChieuLC.SelectedValue.ToString(),
                        idDinhDang = cmbMaDDLC.SelectedValue.ToString(),
                        GiaVe = decimal.Parse(txtGiaVeLC.Text),
                        TrangThai = int.Parse(textTTLC.Text)
                    };

                    context.LichChieux.Add(lichChieu);
                    context.SaveChanges();

                    MessageBox.Show("Thêm lịch chiếu thành công!");
                    btnXemLC.PerformClick();
                    ClearTextBoxes(pnlLichChieu);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoaLC_Click(object sender, EventArgs e)
        {
            if (dgvLC.SelectedRows.Count > 0)
            {
                try
                {
                    using (var context = new Model1())
                    {
                        string id = dgvLC.SelectedRows[0].Cells["id"].Value.ToString();
                        var lichChieu = context.LichChieux.Find(id);
                        if (lichChieu != null)
                        {
                            context.LichChieux.Remove(lichChieu);
                            context.SaveChanges();

                            MessageBox.Show("Xóa lịch chiếu thành công!");
                            btnXemLC.PerformClick();
                            ClearTextBoxes(pnlLichChieu);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy lịch chiếu.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }


        private void btnSuaLC_Click(object sender, EventArgs e)
        {
            if (dgvLC.SelectedRows.Count > 0) // Kiểm tra nếu có hàng được chọn
            {
                try
                {
                    using (var context = new Model1())
                    {
                        string id = txtMaLC.Text.Trim(); // Đảm bảo không có khoảng trắng thừa
                        var lichChieu = context.LichChieux.FirstOrDefault(lc => lc.id == id);

                        if (lichChieu != null)
                        {
                            // Kiểm tra giá trị hợp lệ của combobox
                            if (cmbPhongChieuLC.SelectedValue == null || string.IsNullOrEmpty(cmbPhongChieuLC.SelectedValue.ToString()))
                            {
                                MessageBox.Show("Giá trị Phòng Chiếu không hợp lệ.");
                                return;
                            }

                            if (cmbMaDDLC.SelectedValue == null || string.IsNullOrEmpty(cmbMaDDLC.SelectedValue.ToString()))
                            {
                                MessageBox.Show("Giá trị Định Dạng không hợp lệ.");
                                return;
                            }

                            // Cập nhật giá trị từ form vào đối tượng
                            lichChieu.ThoiGianChieu = new DateTime(
                                dtpNgayLC.Value.Year,
                                dtpNgayLC.Value.Month,
                                dtpNgayLC.Value.Day,
                                dtpGioLC.Value.Hour,
                                dtpGioLC.Value.Minute,
                                0);

                            lichChieu.idPhong = cmbPhongChieuLC.SelectedValue.ToString();
                            lichChieu.idDinhDang = cmbMaDDLC.SelectedValue.ToString();

                            // Chuyển đổi giá trị GiaVe
                            if (decimal.TryParse(txtGiaVeLC.Text.Trim(), out decimal giaVe))
                            {
                                lichChieu.GiaVe = giaVe;
                            }
                            else
                            {
                                MessageBox.Show("Giá trị Giá Vé không hợp lệ.");
                                return;
                            }

                            // Chuyển đổi giá trị TrangThai
                            if (int.TryParse(textTTLC.Text.Trim(), out int trangThai))
                            {
                                lichChieu.TrangThai = trangThai;
                            }
                            else
                            {
                                MessageBox.Show("Giá trị Trạng Thái không hợp lệ.");
                                return;
                            }

                            // Lưu thay đổi vào cơ sở dữ liệu
                            context.SaveChanges();
                            MessageBox.Show("Cập nhật lịch chiếu thành công!");
                            btnXemLC.PerformClick();
                            ClearTextBoxes(pnlLichChieu);// Tải lại danh sách
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy lịch chiếu để cập nhật.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.InnerException?.Message ?? ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một lịch chiếu để sửa.");
            }
        }




        private void dgvLC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Chỉ xử lý khi hàng hợp lệ
            {
                var row = dgvLC.Rows[e.RowIndex];

                txtMaLC.Text = row.Cells["id"].Value?.ToString();

                if (row.Cells["ThoiGianChieu"].Value is DateTime thoiGianChieu)
                {
                    dtpNgayLC.Value = thoiGianChieu.Date;
                    dtpGioLC.Value = thoiGianChieu;
                }

                if (dgvLC.Columns.Contains("idPhong") && row.Cells["idPhong"].Value != null)
                {
                    cmbPhongChieuLC.SelectedValue = row.Cells["idPhong"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Không thể tải giá trị idPhong.");
                }

                if (dgvLC.Columns.Contains("idDinhDang") && row.Cells["idDinhDang"].Value != null)
                {
                    cmbMaDDLC.SelectedValue = row.Cells["idDinhDang"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Không thể tải giá trị idDinhDang.");
                }

                txtGiaVeLC.Text = row.Cells["GiaVe"].Value?.ToString();
                textTTLC.Text = row.Cells["TrangThai"].Value?.ToString();
            }
        }







        private void btnThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    // Lấy khoảng thời gian từ người dùng nhập
                    DateTime tuNgay = dtpNgayBD.Value;
                    DateTime denNgay = dtpNgayKT.Value;

                    // Lấy ID phim từ ComboBox (nếu chọn tất cả thì bỏ lọc theo phim)
                    string idPhim = cmbChonPhim.SelectedValue?.ToString();
                    var doanhThuQuery = context.DoanhThus.Where(dt => dt.Tien > 0 && dt.idLichChieu != null);

                    if (!string.IsNullOrEmpty(idPhim))
                    {
                        doanhThuQuery = doanhThuQuery.Where(dt => dt.idPhim == idPhim);
                    }

                    doanhThuQuery = doanhThuQuery.Where(dt =>
                        context.LichChieux.Any(lc => lc.id == dt.idLichChieu && lc.ThoiGianChieu >= tuNgay && lc.ThoiGianChieu <= denNgay));

                    // Lấy dữ liệu và chuyển thành danh sách
                    var doanhThuList = doanhThuQuery.Select(dt => new
                    {
                        TenPhim = context.Phims.Where(p => p.id == dt.idPhim).Select(p => p.TenPhim).FirstOrDefault(),
                        NgayChieu = context.LichChieux.Where(lc => lc.id == dt.idLichChieu).Select(lc => lc.ThoiGianChieu).FirstOrDefault(),
                        Tien = dt.Tien
                    }).ToList();

                    // Hiển thị dữ liệu trong DataGridView
                    dtgDoanhThu.DataSource = doanhThuList;

                    // Tính tổng doanh thu
                    double tongDoanhThu = doanhThuList.Sum(dt => dt.Tien.HasValue ? dt.Tien.Value : 0);
                    txtDoanhThu.Text = tongDoanhThu.ToString("C"); // Format thành tiền tệ
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void loadCBPhim()
        {
            try
            {
                using (var context = new Model1())
                {
                    // Lấy dữ liệu từ bảng Phim
                    var phimList = context.Phims
                        .Select(phim => new
                        {
                            phim.id,
                            phim.TenPhim
                        })
                        .ToList();

                    // Gán dữ liệu vào ComboBox
                    cmbChonPhim.DataSource = phimList;
                    cmbChonPhim.DisplayMember = "TenPhim"; // Hiển thị tên phim
                    cmbChonPhim.ValueMember = "id"; // Giá trị là id của phim
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXemTK_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    // Tải danh sách nhân viên
                    var accounts = context.ACCOUNTs
                                           .Select(acc => new
                                           {
                                               acc.id,
                                               acc.idnv,
                                               acc.taikhoan,
                                               acc.matkhau,
                                               acc.chucvu

                                           }).ToList();

                    dgv_TaiKhoan.DataSource = accounts; // Gán dữ liệu vào DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    var cv = "";
                    if (rad_bv.Checked)
                    {
                         cv = "banve";
                    }
                    else if (rad_ql.Checked)
                    {
                        cv = "quanly";
                    }
                    else
                    {
                        MessageBox.Show("vui long chon chuc vu !!!!");  
                    }

                    if (cv != "")
                    {

                        // Tạo đối tượng nhân viên mới
                        var newacc = new ACCOUNT
                        {
                            id = txt_id.Text,
                            idnv = txt_idnv.Text,
                            taikhoan = txt_user.Text,
                            matkhau = txt_pass.Text,
                            chucvu = cv,


                        };

                        // Thêm nhân viên vào DbSet
                        context.ACCOUNTs.Add(newacc);
                        context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                        MessageBox.Show("Thêm tai khoan thành công!");
                        btnXemTK.PerformClick();// Tải lại danh sách sau khi thêm
                        ClearTextBoxes(pnl_tk);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            if (dgv_TaiKhoan.SelectedRows.Count > 0)
            {
                var id = dgv_TaiKhoan.SelectedRows[0].Cells["id"].Value.ToString();
                try
                {
                    var cv = "";
                    if (rad_bv.Checked)
                    {
                        cv = "banve";
                    }
                    else if (rad_ql.Checked)
                    {
                        cv = "quanly";
                    }
                    using (var context = new Model1())
                    {
                        var acc = context.ACCOUNTs.FirstOrDefault(nv => nv.id == id);
                        if (acc != null)
                        {
                            acc.idnv = txt_idnv.Text;
                            acc.taikhoan = txt_user.Text;
                            acc.matkhau = txt_pass.Text;
                            acc.chucvu = cv;

                            context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                            MessageBox.Show("Cập nhật tai khoan thành công!");
                            btnXemTK.PerformClick(); // Tải lại danh sách sau khi sửa
                            ClearTextBoxes(pnl_tk);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nhân viên để cập nhật.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tai khoan để sửa.");
            }
        }

        private void dgv_TaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem có hàng nào được chọn không
            {
                var row = dgv_TaiKhoan.Rows[e.RowIndex];
                txt_id.Text = row.Cells["id"].Value?.ToString();
                txt_idnv.Text = row.Cells["idnv"].Value?.ToString();
                txt_user.Text = row.Cells["taikhoan"].Value?.ToString();
                txt_pass.Text = row.Cells["matkhau"].Value?.ToString();
                var cv = row.Cells["chucvu"].Value?.ToString();
                if (cv == "banve")
                {
                    rad_bv.Checked = true;
                }
                else if (cv == "quanly")
                {
                    rad_ql.Checked = true;
                }
            }
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            if (dgv_TaiKhoan.SelectedRows.Count > 0)
            {
                var id = dgv_TaiKhoan.SelectedRows[0].Cells["id"].Value.ToString();
                try
                {
                    using (var context = new Model1())
                    {
                        var acc = context.ACCOUNTs.FirstOrDefault(nv => nv.id == id);
                        if (acc != null)
                        {
                            context.ACCOUNTs.Remove(acc);
                            context.SaveChanges();
                            MessageBox.Show("Xóa tai khoan thành công!");
                            btnXemTK.PerformClick(); // Tải lại danh sách sau khi xóa
                            ClearTextBoxes(pnl_tk);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy tai khoan để xóa.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        

        private void txt_tktk_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txt_tktk.Text.Trim();

            using (var db = new Model1())
            {
                var searchResults = db.ACCOUNTs
                                      .Where(Mk => Mk.idnv.Contains(searchValue))
                                      .ToList();


                dgv_TaiKhoan.DataSource = searchResults;
            }
        }



        // Hàm để clear tất cả TextBox trong một Panel

        private void ClearTextBoxes(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is System.Windows.Forms.TextBox textBox)
                {
                    textBox.Text = string.Empty;

                }
            }
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ DataGridView (dtgDoanhThu)
                List<BaoCaoItem> danhSachBaoCao = new List<BaoCaoItem>();
                foreach (DataGridViewRow row in dtgDoanhThu.Rows)
                {
                    if (row.Cells["TenPhim"].Value != null) // Kiểm tra dòng có dữ liệu
                    {
                        var item = new BaoCaoItem
                        {
                            STT = row.Index + 1, // Số thứ tự
                            TenPhim = row.Cells["TenPhim"].Value.ToString(),
                            NgayChieu = DateTime.Parse(row.Cells["NgayChieu"].Value.ToString()),
                            TienBanVe = decimal.Parse(row.Cells["Tien"].Value.ToString()) // Sửa lỗi kiểu dữ liệu
                        };

                        danhSachBaoCao.Add(item);
                    }
                }

                // Lấy tổng doanh thu từ TextBox
                decimal tongDoanhThu = decimal.Parse(txtDoanhThu.Text, System.Globalization.NumberStyles.Currency);

                // Lấy khoảng thời gian
                DateTime tuNgay = dtpNgayBD.Value;
                DateTime denNgay = dtpNgayKT.Value;

    
      
                BaoCao bc = new BaoCao();
                bc.HienThiBaoCao(danhSachBaoCao, tongDoanhThu, tuNgay, denNgay);
                bc.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo báo cáo: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
   

