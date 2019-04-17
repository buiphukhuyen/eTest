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
using Test_Exam.GUI.Form_Students;
using Test_Exam.GUI;


namespace Test_Exam
{
   
    public partial class frm_LoginStudents : DevExpress.XtraEditors.XtraForm
    {
        private BLT_Students objBL_SinhVien;
        public frm_LoginStudents()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            new frm_ChooseOperation().Show();
        }


        private void frm_LoginStudents_Load(object sender, EventArgs e)
        {
            DataTable dt = new BLT_Students().GetAllStudents();
        }

        private bool Check()
        {
            if (txtIDStudent.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn hãy nhập MSSV!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDStudent.SelectAll();
                txtIDStudent.Focus();
                return false;
            }
            if (txtClass.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn hãy nhập Lớp!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtClass.SelectAll();
                txtClass.Focus();
                return false;
            }
            return true;
        }

        private void btnLoginStudents_Click(object sender, EventArgs e)
        {
            if (!Check())
                return;
            objBL_SinhVien = new BLT_Students(txtIDStudent.Text, txtClass.Text);

            if (!objBL_SinhVien.TrueLogin())
            {
                MessageBox.Show("Bạn đã nhập sai thông tin sinh viên,\nVui lòng kiểm tra lại!", "Sai thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDStudent.SelectAll();
                txtIDStudent.Focus();
                return;
            }
            else
            {
                StaticCustom.Login_ID_Student = txtIDStudent.Text;

                this.Hide();
               
                new frm_LoadSubject().ShowDialog();
                //MessageBox.Show("Đăng nhập thành công!","Đăng nhập");
            }
            //pnChonChuong.Visible = true;
            //hienThi_thongTin(txtMSSV.Text);
        }

        private void txtClass_KeyDown(object sender, KeyEventArgs e)
        {
            if((Keys)e.KeyCode == Keys.Enter)
            {
                btnLoginStudents.PerformClick();
            }
        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thông Tin Đăng nhập được cấp bởi Người Phát triển", "Liên hệ Người Phát triển", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}