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
    public partial class frm_AddQuestion : DevExpress.XtraEditors.XtraForm
    {
        private BLT_Question Obj_BLTQuestion;
        private BLT_Subject Obj_BLTSubject;
        private string Key_Questions;
        public frm_AddQuestion()
        {
            InitializeComponent();
        }

        private void frm_AddQuestion_Load(object sender, EventArgs e)
        {
            Load_Subject();
        }

        public void Load_Subject()
        {
            rtxtQuestion.Focus();
            Obj_BLTSubject = new BLT_Subject();
            DataTable dt = Obj_BLTSubject.GetAllSubject();
            cmbSubject.DataSource = dt;
            cmbSubject.ValueMember = "MÃ HỌC PHẦN";
            cmbSubject.DisplayMember = "TÊN HỌC PHẦN";
            txtIDSubject.DataBindings.Add("Text", dt, "MÃ HỌC PHẦN");
            txtIDSubject.Enabled = false;
        }

        private bool Check_ValueInput()
        {
            if(txtIDQuestion.Text.Trim() == "")
            {
                XtraMessageBox.Show("Bạn phải nhập vào Mã câu hỏi");
                return false;
            }
            if(rtxtQuestion.Text.Trim() == "")
            {
                XtraMessageBox.Show("Bạn phải nhập vào Câu hỏi");
                return false;
            }
            if(rtxtQuestionA.Text.Trim() == "")
            {
                XtraMessageBox.Show("Bạn phải nhập vào Câu trả lời A");
                return false;
            }
            if(rtxtQuestionB.Text.Trim() == "")
            {
                XtraMessageBox.Show("Bạn phải nhập vào Câu trả lời B");
                return false;
            }
            if(rtxtQuestionC.Text.Trim() == "")
            {
                XtraMessageBox.Show("Bạn phải nhập vào Câu trả lời C");
                return false;
            }
            if(rtxtQuestionD.Text.Trim() == "")
            {
                XtraMessageBox.Show("Bạn phải nhập vào Câu trả lời D");
                return false;
            }
            if(checkA.Checked == false && checkB.Checked == false && checkC.Checked == false && checkD.Checked == false)
            {
                XtraMessageBox.Show("Bạn phải Chọn Đáp án!");
                return false;
            }
            Obj_BLTQuestion = new BLT_Question(txtIDSubject.Text, null);
            DataTable dt = Obj_BLTQuestion.GetQuestion_Subject();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["MÃ CÂU HỎI"].ToString().ToLower() == txtIDQuestion.Text.ToLower())
                {
                    XtraMessageBox.Show("Mã Câu hỏi đã tồn tại trong hệ thống!");
                    return false;
                }
            }
            return true;
        }

        private void Key_Question()
        {
            if(checkA.Checked == true)
            {
                Key_Questions = "A";
            }
            if(checkB.Checked == true)
            {
                Key_Questions = "B";
            }
            if(checkC.Checked == true)
            {
                Key_Questions = "C";
            }
            if(checkD.Checked == true)
            {
                Key_Questions = "D";
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Check_ValueInput())
                {
                    Key_Question();
                    if (new BLT_Question(txtIDQuestion.Text, rtxtQuestion.Text, rtxtQuestionA.Text, rtxtQuestionB.Text, rtxtQuestionC.Text, rtxtQuestionD.Text, Key_Questions, txtIDSubject.Text).Insert_Question())
                    {
                        XtraMessageBox.Show("Thêm Câu hỏi mới thành công", "Thành công", MessageBoxButtons.OK);
                    }
                    else
                    {
                        XtraMessageBox.Show("Thêm Câu hỏi mới thất bại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    Key_Questions = "";
                }
            }
            catch
            {
                XtraMessageBox.Show("Không thể Truy vấn Dữ liệu", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
        }


        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Sự kiện cho phép chỉ Tick chọn 1 tròn 4 đáp án!
        private void checkA_CheckedChanged(object sender, EventArgs e)
        {
            if (checkA.Checked == true)
                checkB.Checked = checkC.Checked = checkD.Checked = false;
        }
        private void checkB_CheckedChanged(object sender, EventArgs e)
        {
            if (checkB.Checked == true)
                checkA.Checked = checkC.Checked = checkD.Checked = false;
        }
        private void checkC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkC.Checked == true)
                checkA.Checked = checkB.Checked = checkD.Checked = false;
        }

        private void checkD_CheckedChanged(object sender, EventArgs e)
        {
            if (checkD.Checked == true)
                checkA.Checked = checkB.Checked = checkC.Checked = false;
        }

        #endregion
    }
}