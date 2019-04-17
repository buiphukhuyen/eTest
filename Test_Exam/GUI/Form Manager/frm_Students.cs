using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_Exam.BLT;

namespace Test_Exam.GUI.Form_Manager
{
    public partial class frm_Students : frm_Toolkit
    {
        BLT_Students Obj_BLTStudents;
        string Status = "";
        public frm_Students()
        {
            InitializeComponent();
        }

        private void frm_Students_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
            txtSearch.Hide();
            lblSearch.Hide();
            Click_Perform(true);


            Obj_BLTStudents = new BLT_Students();
            DataTable dt = Obj_BLTStudents.GetAllStudents();

            txtName_Class.AutoCompleteCustomSource.Clear();
            foreach (DataRow r in dt.Rows)
            {
                //getting all rows in the specific field|Column
                var rw = r.Field<string>("TÊN LỚP");

                //Set the properties of a textbox to make it auto suggest and append.
                txtName_Class.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtName_Class.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //adding all rows into the textbox
                txtName_Class.AutoCompleteCustomSource.Add(rw);

            }
        }


        private void Load_DataGridView()
        {
            Obj_BLTStudents = new BLT_Students();
            DataTable dt = Obj_BLTStudents.GetAllStudents();
            grvListStudents.DataSource = dt;

            //Custom khoảng cách giữa các Column trên DataGridView cho phù hợp
            grvListStudents.Columns[0].Width = 500;
            grvListStudents.Columns[1].Width = 1000;
            grvListStudents.Columns[2].Width = 500;

            //DataBindings các Control TextBox
            txtID_Student.DataBindings.Add("Text", dt, "MSSV");
            txtFull_Name.DataBindings.Add("Text", dt, "HỌ VÀ TÊN");
            txtName_Class.DataBindings.Add("Text", dt, "TÊN LỚP");
        }

        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                (grvListStudents.DataSource as DataTable).DefaultView.RowFilter = string.Format("[HỌ VÀ TÊN] LIKE '%{0}%'", txtSearch.Text);
            }
            catch
            {
                XtraMessageBox.Show("Dữ liệu tìm kiếm không hợp lệ!", "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        public override void ClearDataBind()
        {
            base.ClearDataBind();
            txtFull_Name.DataBindings.Clear();
            txtID_Student.DataBindings.Clear();
            txtName_Class.DataBindings.Clear();
        }

        public override void ResetInput()
        {
            base.ResetInput();
            txtID_Student.Text = txtFull_Name.Text = txtName_Class.Text = "";
        }

        public override void Click_Perform(bool flag)
        {
            base.Click_Perform(flag);
            txtID_Student.Enabled = txtFull_Name.Enabled = txtName_Class.Enabled = !flag;
        }

        public override bool ValueInput()
        {
            if(txtID_Student.Text.Trim()=="")
            {
                XtraMessageBox.Show("Bạn phải nhập vào Mã số Sinh viên");
                return false;
            }
            if(txtFull_Name.Text.Trim() == "")
            {
                XtraMessageBox.Show("Bạn phải nhập vào Tên Sinh viên");
                return false;
            }
            if(txtName_Class.Text.Trim() == "")
            {
                XtraMessageBox.Show("Bạn phải nhập vào Tên Lớp");
                return false;
            }
            Obj_BLTStudents = new BLT_Students(txtID_Student.Text);
            DataTable dt = Obj_BLTStudents.GetAllStudents();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if(dt.Rows[i]["MSSV"].ToString().ToLower() == txtID_Student.Text.ToLower())
                {
                    XtraMessageBox.Show("Mã số Sinh viên đã tồn tại trong hệ thống!");
                    return false;
                }
            }
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["TÊN LỚP"].ToString().ToLower() != txtName_Class.Text.ToLower())
                {
                    XtraMessageBox.Show("Lớp không tồn tại trên hệ thống!");
                    return false;
                }
            }
            return base.ValueInput();
        }

        public override void Add()
        {
            base.Add();
            Status = "Add";
            txtID_Student.Focus();
        }

        public override void Edit()
        {
            base.Edit();
            Status = "Edit";
            txtID_Student.Focus();
        }

        public override void Search()
        {
            base.Search();
            txtSearch.Show();
            lblSearch.Show();
            txtSearch.Focus();
            ClearDataBind();
        }

        public override void Save()
        {
            base.Save();

            switch(Status)
            {
                case "Add":
                    if (ValueInput())
                    {
                        try
                        {
                            if (new BLT_Students(txtID_Student.Text, txtFull_Name.Text, txtName_Class.Text).Insert_Student())
                            {
                                XtraMessageBox.Show("Thêm Sinh viên mới thành công", "Thành công", MessageBoxButtons.OK);
                            }
                            else
                            {
                                XtraMessageBox.Show("Thêm Sinh viên mới thất bại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                            ReFresh();
                        }
                            catch
                            {
                                XtraMessageBox.Show("Không thể Truy vấn Dữ liệu", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                    }
                    break;
                case "Edit":
                    if(ValueInput())
                    {
                        try
                        {
                            if(new BLT_Students(txtID_Student.Text, txtName_Class.Text,txtName_Class.Text).Edit_Student())
                            {
                                XtraMessageBox.Show("Sửa Sinh viên mới thành công", "Thành công", MessageBoxButtons.OK);
                            }
                            else
                            {
                                XtraMessageBox.Show("Sửa Sinh viên mới thất bại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                            ReFresh();
                        }
                        catch
                        {
                            XtraMessageBox.Show("Không thể Truy vấn Dữ liệu", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                default: break;
            }
        }

        public override void Delete()
        {
            base.Delete();
            DialogResult res = XtraMessageBox.Show("Bạn có muốn Xóa Sinh viên này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                try
                {
                    if (new BLT_Students(txtID_Student.Text).Delete_Student())
                    {
                        XtraMessageBox.Show("Xóa Sinh viên thành công", "Thành công", MessageBoxButtons.OK);
                    }
                    else
                    {
                        XtraMessageBox.Show("Xóa Sinh viên thất bại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                catch
                {
                    XtraMessageBox.Show("Không thể Truy vấn Dữ liệu", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ReFresh();
            }

                
        }

        public override void ReFresh()
        {
            base.ReFresh();
            ClearDataBind();
            Load_DataGridView();
        }

        public override void Print()
        {
            base.Print();
            XtraMessageBox.Show("Tính năng đang phát triển", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
