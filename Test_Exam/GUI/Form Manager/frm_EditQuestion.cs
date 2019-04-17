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
    public partial class frm_EditQuestion : DevExpress.XtraEditors.XtraForm
    {
        private BLT_Question Obj_BLTQuestion;
        private BLT_Subject Obj_BLTSubject;
        private string ID_Question;
        private string Key_Questions;
        public frm_EditQuestion()
        {
            InitializeComponent();
        }

        public frm_EditQuestion(string ID_Question)
        {
            InitializeComponent();
           // MessageBoxEx.EnableGlass = false;
           // cboDapAn.SelectedIndex = 0;
            this.ID_Question= ID_Question;
        }

        private bool Check_ValueInput()
        {
            if (txtIDQuestion.Text.Trim() == "")
            {
                XtraMessageBox.Show("Bạn phải nhập vào Mã câu hỏi");
                return false;
            }
            if (rtxtQuestion.Text.Trim() == "")
            {
                XtraMessageBox.Show("Bạn phải nhập vào Câu hỏi");
                return false;
            }
            if (rtxtQuestionA.Text.Trim() == "")
            {
                XtraMessageBox.Show("Bạn phải nhập vào Câu trả lời A");
                return false;
            }
            if (rtxtQuestionB.Text.Trim() == "")
            {
                XtraMessageBox.Show("Bạn phải nhập vào Câu trả lời B");
                return false;
            }
            if (rtxtQuestionC.Text.Trim() == "")
            {
                XtraMessageBox.Show("Bạn phải nhập vào Câu trả lời C");
                return false;
            }
            if (rtxtQuestionD.Text.Trim() == "")
            {
                XtraMessageBox.Show("Bạn phải nhập vào Câu trả lời D");
                return false;
            }
            if (checkA.Checked == false && checkB.Checked == false && checkC.Checked == false && checkD.Checked == false)
            {
                XtraMessageBox.Show("Bạn phải Chọn Đáp án!");
                return false;
            }

            return true;
        }

        private void frm_EditDeleteQuestion_Load(object sender, EventArgs e)
        {
            Obj_BLTQuestion = new BLT_Question(null, ID_Question);

            DataRow r = Obj_BLTQuestion.GetQuestion_IDQuestion().Rows[0];

            txtIDQuestion.Text = ID_Question;
            rtxtQuestion.Text = r["CÂU HỎI"].ToString();
            rtxtQuestionA.Text = r["A"].ToString();
            rtxtQuestionB.Text = r["B"].ToString();
            rtxtQuestionC.Text = r["C"].ToString();
            rtxtQuestionD.Text = r["D"].ToString();

            Obj_BLTSubject = new BLT_Subject();
            cmbSubject.DataSource = Obj_BLTSubject.GetAllSubject();
            cmbSubject.ValueMember = "MÃ HỌC PHẦN";
            cmbSubject.DisplayMember = "TÊN HỌC PHẦN";
            txtIDSubject.Text = r["MÃ HỌC PHẦN"].ToString();

            if (r["ĐÁP ÁN"].ToString() == "A")
            {
                checkA.Checked = true;
            }
            if(r["ĐÁP ÁN"].ToString() == "B")
            {
                checkB.Checked = true;
            }
            if(r["ĐÁP ÁN"].ToString() == "C")
            {
                checkC.Checked = true;
            }
            if(r["ĐÁP ÁN"].ToString() == "D")
            {
                checkD.Checked = true;
            }

        }
        private void Key_Question()
        {
            if (checkA.Checked == true)
            {
                Key_Questions = "A";
            }
            if (checkB.Checked == true)
            {
                Key_Questions = "B";
            }
            if (checkC.Checked == true)
            {
                Key_Questions = "C";
            }
            if (checkD.Checked == true)
            {
                Key_Questions = "D";
            }
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Check_ValueInput())
                {
                    Key_Question();
                    if (new BLT_Question(txtIDQuestion.Text, rtxtQuestion.Text, rtxtQuestionA.Text, rtxtQuestionB.Text, rtxtQuestionC.Text, rtxtQuestionD.Text, Key_Questions, txtIDSubject.Text).Update_Question())
                    {
                        XtraMessageBox.Show("Chỉnh sửa Câu hỏi thành công", "Thành công", MessageBoxButtons.OK);
                    }
                    else
                    {
                        XtraMessageBox.Show("Chỉnh sửa Câu hỏi thất bại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    Key_Questions = "";
                }
            }
            catch
            {
                XtraMessageBox.Show("Không thể Truy vấn Dữ liệu", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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