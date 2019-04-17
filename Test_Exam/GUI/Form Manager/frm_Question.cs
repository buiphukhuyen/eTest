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
    public partial class frm_Question : DevExpress.XtraEditors.XtraForm
    {
        private BLT_Subject Obj_BLTSubject;
        private BLT_Question Obj_BLTQuestion;
        private bool LoadListBox_Subject;

        public frm_Question()
        {
            InitializeComponent();
        }

        private void frm_Question_Load(object sender, EventArgs e)
        {
            Load_ListSubject();
        }


        public void Load_ListSubject()
        {
            Obj_BLTSubject = new BLT_Subject();
            DataTable dt = Obj_BLTSubject.GetAllSubject();
            lsb_ListSubject.DataSource = dt;
            lsb_ListSubject.DisplayMember = "TÊN HỌC PHẦN";
            lsb_ListSubject.ValueMember = "MÃ HỌC PHẦN";
            LoadListBox_Subject = true;
            lsb_ListSubject_Click(null, null);
        }

        private void Load_DataGirdView(DataTable dt)
        {
            grvListQuestion.DataSource = dt;
            grvListQuestion.Columns[0].Width = 80;
            grvListQuestion.Columns[1].Width = 500;
            grvListQuestion.Columns[2].Width = 70;
            grvListQuestion.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grvListQuestion.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            grvListQuestion.DefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Regular);
            grvListQuestion.DefaultCellStyle.Padding = new Padding(0, 1, 0, 7);

            cmsItem_ShowEditQuestion.Enabled = dt.Rows.Count > 0;
            cmsItem_DeleteQuestion.Enabled = dt.Rows.Count > 0;
        }

        private void lsb_ListSubject_Click(object sender, EventArgs e)
        {
            if (lsb_ListSubject.SelectedIndices.Count == 0)
            {
                grvListQuestion.DataSource = new DataTable();

                cmsItem_ShowEditQuestion.Enabled = false;
                cmsItem_DeleteQuestion.Enabled = false;
                return;
            }
            if (!LoadListBox_Subject)
                return;

            Obj_BLTQuestion = new BLT_Question(lsb_ListSubject.SelectedValue.ToString(), null);

            Load_DataGirdView(Obj_BLTQuestion.GetQuestion_Subject());

            grcQuestion.Text = "Ngân hàng Câu hỏi: " + lsb_ListSubject.Text;

        }

        private void cmsItem_ShowEditQuestion_Click(object sender, EventArgs e)
        {
            if (new frm_EditQuestion(grvListQuestion.CurrentRow.Cells[0].Value.ToString()).ShowDialog() == DialogResult.OK)
            {

                Load_DataGirdView(new BLT_Question(lsb_ListSubject.SelectedValue.ToString(),null).GetQuestion_Subject());
            }


        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Obj_BLTQuestion = new BLT_Question(lsb_ListSubject.SelectedValue.ToString(), null);
            Load_DataGirdView(Obj_BLTQuestion.GetQuestion_Subject());
        }

        private void cmsItem_DeleteQuestion_Click(object sender, EventArgs e)
        {
            DialogResult res = XtraMessageBox.Show("Bạn có muốn Xóa Câu hỏi này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                try
                {
                    if (new BLT_Question(null, grvListQuestion.CurrentRow.Cells[0].Value.ToString()).Delete_Question())
                    {
                        XtraMessageBox.Show("Xóa Câu hỏi thành công", "Thành công", MessageBoxButtons.OK);
                    }
                    else
                    {
                        XtraMessageBox.Show("Xóa Câu hỏi thất bại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    refreshToolStripMenuItem.PerformClick();
                }
                catch
                {
                    XtraMessageBox.Show("Không thể Truy vấn Dữ liệu", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                


        }
        private void cmsItem_PrintQuestion_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Tính năng đang phát triển", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}