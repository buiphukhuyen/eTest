using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Test_Exam.BLT;
using Test_Exam.GUI;


namespace Test_Exam.GUI
{
    public partial class frm_LoginAdmin : DevExpress.XtraEditors.XtraForm
    {
        public frm_LoginAdmin()
        {
            InitializeComponent();
        }

        public static string ID, PassWord;

        private bool Check()
        {
            if (txtUsername.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn hãy nhập Tên tài khoản!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.SelectAll();
                txtUsername.Focus();
                return false;
            }
            if (txtPassword.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn hãy nhập Mật khẩu!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.SelectAll();
                txtPassword.Focus();
                return false;
            }
            return true;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frm_ChooseOperation().Show();
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            if (!Check())
                return;
            if (!new BLT_Admin(txtUsername.Text, txtPassword.Text).TrueLogin())
            {
                MessageBox.Show("Đăng nhập không thành công!", "Đăng nhập",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.SelectAll();
                txtUsername.Focus();
                return;
            }
            MessageBox.Show("Chúc mừng bạn đã đăng nhập thành công!", "Đăng nhập",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            ID = txtUsername.Text;
            PassWord = txtPassword.Text;
            this.Hide();
            

            new frm_Manager().ShowDialog();

            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if((Keys)e.KeyCode==Keys.Enter)
            {
                btnLoginAdmin.PerformClick();
            }
        }
    }
}