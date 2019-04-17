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

namespace Test_Exam.GUI.Form_Manager
{
    public partial class frm_ChangePassword : DevExpress.XtraEditors.XtraForm
    {
        //Khởi tạo biến ObjBLT_Admin kiểu BLT_Admin 
        public frm_ChangePassword()
        {
            InitializeComponent();
        }
       
        //Hàm Kiểm tra Dữ liệu Mật khẩu nhập trên Form
        private bool CheckValueInput()
        {
            //Trường hợp Bỏ trống Textbox Mật khẩu Cũ
            if(txtOldPassword.Text.Trim()=="")
            {
                MessageBox.Show("Bạn chưa nhập Mật khẩu cũ!");
                return false;
            }
            //Trường hợp Bỏ trống Textbox Mật khẩu Mới
            if (txtNewPassword.Text.Trim()=="")
            {
                MessageBox.Show("Bạn chưa nhập Mật khẩu mới!");
                return false;
            }

            //Trường hợp Bỏ trống Textbox Xác thực Mật khẩu
            if (txtPasswordAgain.Text.Trim()=="")
            {
                MessageBox.Show("Bạn chưa xác thực mật khẩu!");
                return false;
            }
            //Trường hợp Mật khẩu Mới khác Xác thực
            if (txtNewPassword.Text != txtPasswordAgain.Text)
            {
                MessageBox.Show("Xác thực phải trùng với Mật khẩu mới!");
                return false;
            }
            //Trường hợp Mật khẩu cũ không trùng với Mật khẩu trên hệ thống
            if (txtOldPassword.Text.ToLower() != GUI.frm_LoginAdmin.PassWord.ToLower())
            {
                MessageBox.Show("Mật khẩu cũ không trùng khớp!");
                return false;
            }
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if(!CheckValueInput())
            {
                return;
            }

            BLT_Admin res = new BLT_Admin(txtNewPassword.Text);
            if(res.ChangePassword())
            {
                MessageBox.Show("Cập nhật mật khẩu thành công!", "Cập nhật mật khẩu",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_LoginAdmin.PassWord = txtNewPassword.Text;
            }
            else
            {
                MessageBox.Show("Cập nhật mật khẩu thất bại!", "Cập nhật mật khẩu",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
   
        private void txtPasswordAgain_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnUpdatePassword.PerformClick();
            }
        }
    }
}