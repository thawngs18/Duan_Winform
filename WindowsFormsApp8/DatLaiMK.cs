﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp8.database;

namespace WindowsFormsApp8
{
    public partial class DatLaiMK : Form
    {
        string tentk = "";
        public DatLaiMK()
        {
            InitializeComponent();
        }
        public DatLaiMK(string hoten)
        {
            InitializeComponent();
            tentk = hoten;
        }

        private string GenerateRandomString(int length)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            string result = "";
            for (int i = 0; i < length; i++)
            {
                result += chars[random.Next(chars.Length)];
            }
            return result;
        }



        private void DatLaiMK_Load(object sender, EventArgs e)
        {
            txt_user.Text = tentk;
            txt_maxn.Text = GenerateRandomString(6);
            button7.Visible = false;
            button6.Visible = false;
            button10.Visible = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_maxn.Text = GenerateRandomString(6);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txt_user.Text;
            string currentPassword = txt_passcu.Text;
            string newPassword = txt_passmoi.Text;
            string confirmPassword = txt_confirmpass.Text;
            string maxn = txt_maxn.Text;
            string confirm = txt_confirmxn.Text;

            // Kiểm tra mật khẩu mới và xác nhận mật khẩu
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu mới không khớp. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var db = new Model1())
            {
                // Tìm người dùng theo tên và mật khẩu hiện tại
                var user = db.ACCOUNTs.SingleOrDefault(u =>  u.matkhau == currentPassword);
                if (user == null)
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu hiện tại không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(maxn == confirm)
                {
                    user.matkhau = newPassword;
                    db.SaveChanges();
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ma xac nhan khong trung khop", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                

                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button7.Visible = true;
            txt_passmoi.PasswordChar = '\0';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Visible = false;
            button3.Visible = true;
            txt_passmoi.PasswordChar = '*';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button6.Visible = true;
            txt_confirmpass.PasswordChar = '\0';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            button4.Visible = true;
            txt_confirmpass.PasswordChar = '*';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Visible = false;
            button10.Visible = true;
            txt_passcu.PasswordChar = '\0';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Visible = false;
            button9.Visible = true;
            txt_passcu.PasswordChar = '*';
        }
    }
}
