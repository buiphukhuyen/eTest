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
    public partial class frm_Subject : frm_Toolkit
    {
        private BLT_Subject Obj_BLTSubject;

        private string Status = " ";
        public frm_Subject()
        {
            InitializeComponent();
        }

        //Event Load Form Môn học
        private void frm_Subject_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
            Load_ComboBox();
            Click_Perform(true);
            txtSearch.Hide();
            lblSearch.Hide();
        }

        //Hàm Load DataGridView và ComboBox (được gọi lại trong Event Load Form)
        private void Load_DataGridView()
        {
            Obj_BLTSubject = new BLT_Subject();
            DataTable dt = Obj_BLTSubject.GetAllSubject();
            grdListSubject.DataSource = dt;

            //Custom Khoảng cách giữa các Row trên DataGridView cho phù hợp
            Padding newPadding = new Padding(0, 1, 0, 7);
            grdListSubject.RowTemplate.DefaultCellStyle.Padding = newPadding;

            //Custom khoảng cách giữa các Column trên DataGridView cho phù hợp
            grdListSubject.Columns[0].Width = 200;
            grdListSubject.Columns[1].Width = 1200;
            grdListSubject.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Tiến hành DataBidings dữ liệu từ DataGridView lên Textbox
            txtIDSubject.DataBindings.Add("Text", dt, "MÃ HỌC PHẦN");
            txtNameSubjcet.DataBindings.Add("Text", dt, "TÊN HỌC PHẦN");
            cmbGroupSubject.DataBindings.Add("Text", dt, "TÊN NHÓM");

        }
        private void Load_ComboBox()
        {
            //Thêm Items cho ComboBox đại diện các Học phần
            cmbGroupSubject.Items.Add("Đại cương");
            cmbGroupSubject.Items.Add("Toán");
            cmbGroupSubject.Items.Add("Tiếng anh");
            cmbGroupSubject.Items.Add("Giáo dục Quốc phòng");
            cmbGroupSubject.Items.Add("Khác");
        }

        ////Hàm Filter (Lọc) Những Nhóm môn học cùng với nhau trên DataGridView từ ComboBox
        //private void cmbGroupSubject_SelectionChangeCommitted(object sender, EventArgs e)
        //{
        //    if (cmbGroupSubject.SelectedItem.ToString() == "Khác")
        //    {
        //        DataTable dt = Obj_BLTSubject.GetAllSubject();
        //        grdListSubject.DataSource = dt;
        //    }
        //    else
        //    {
        //        (grdListSubject.DataSource as DataTable).DefaultView.RowFilter = string.Format("[TÊN NHÓM]= '{0}'", cmbGroupSubject.SelectedItem.ToString());
        //    }
        //}
        //Hàm Tìm kiếm Tên Học phần Bằng cách nhập Vào TextBox
        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                (grdListSubject.DataSource as DataTable).DefaultView.RowFilter = string.Format("[TÊN HỌC PHẦN] LIKE '%{0}%'", txtSearch.Text);
            }
            catch
            {
                XtraMessageBox.Show("Dữ liệu tìm kiếm không hợp lệ!", "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

       #region Các hàm Override từ Form Toolkit

        //Hàm Override (Chỉnh sửa lại hàm) ClearDataBind từ Form Tool
        public override void ClearDataBind()
        {
            base.ClearDataBind();
            txtIDSubject.DataBindings.Clear();
            txtNameSubjcet.DataBindings.Clear();
            cmbGroupSubject.DataBindings.Clear();
        }
        public override void ResetInput()
        {
            base.ResetInput();
            txtIDSubject.Text = txtNameSubjcet.Text = cmbGroupSubject.Text = "";
        }
        public override void Click_Perform(bool flag)
        {
            base.Click_Perform(flag);
            txtIDSubject.Enabled = txtNameSubjcet.Enabled = !flag;
        }

        //Hàm override ValueInput kiểm tra Dữ liệu nhập vào
        public override bool ValueInput()
        {
            if (txtIDSubject.Text.Trim() == "")
            {
                XtraMessageBox.Show("Bạn phải nhập vào Mã Học phần");
                return false;
            }

            if (txtNameSubjcet.Text.Trim() == "")
            {
                XtraMessageBox.Show("Bạn phải nhập vào Tên Học phần");
                return false;
            }
            if (cmbGroupSubject.Text == "")
            {
                XtraMessageBox.Show("Bạn phải Chọn Nhóm Học phần");
                return false;
            }
            if (Status == "Add")
            {
                Obj_BLTSubject = new BLT_Subject();
                DataTable dt = Obj_BLTSubject.GetAllSubject();
                for (int i = 0; i < dt.Rows.Count; i++)
                    if (txtIDSubject.Text.ToLower() == dt.Rows[i]["MÃ HỌC PHẦN"].ToString().ToLower())
                    {
                        XtraMessageBox.Show("Mã Học phần đã có sẵn, vui lòng nhập lại!");
                        return false;
                    }
            }
            return base.ValueInput(); //true
        }

        public override void Add()
        {
            base.Add();
            txtIDSubject.Focus();
            Status = "Add";
        }

        public override void Edit()
        {
            base.Edit();
            txtIDSubject.Enabled = false;
            cmbGroupSubject.Enabled = false;
            txtNameSubjcet.Focus();
            Status = "Edit";
        }

        public override void Save()
        {
            base.Save();
            switch (Status)
            {
                case "Add":
                    try
                    {
                        if (ValueInput())
                        {
                            if (new BLT_Subject(txtIDSubject.Text, txtNameSubjcet.Text, cmbGroupSubject.SelectedItem.ToString()).Insert_Subject())
                            {
                                XtraMessageBox.Show("Thêm Học phần mới thành công", "Thành công", MessageBoxButtons.OK);
                            }
                            else
                                XtraMessageBox.Show("Thêm Học phần thất bại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        break;
                    }
                    catch
                    {
                        XtraMessageBox.Show("Không thể Truy cập Dữ liệu", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                case "Edit":
                    try
                    {
                        if (ValueInput())
                        {
                            if (new BLT_Subject(txtIDSubject.Text, txtNameSubjcet.Text, cmbGroupSubject.SelectedItem.ToString()).Edit_Subject())
                            {
                                XtraMessageBox.Show("Chỉnh sửa Học phần thành công", "Thành công", MessageBoxButtons.OK);
                            }
                            else
                                XtraMessageBox.Show("Chỉnh sửa Học phần thất bại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        break;
                    }
                    catch
                    {
                        XtraMessageBox.Show("Không thể Truy vấn Dữ liệu", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    
                default: break;

            }
        }

        public override void Delete()
        {
            base.Delete();
            try
            {
                DialogResult res = XtraMessageBox.Show("Bạn có muốn Xóa Học phần này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.OK)
                {
                    if (new BLT_Subject(txtIDSubject.Text).Delete_Subject())
                    {
                        XtraMessageBox.Show("Xóa Học phần thành công","Thành công", MessageBoxButtons.OK);
                        
                    }
                    else
                    {
                        XtraMessageBox.Show("Xóa Học phần thất bại!","Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    ReFresh();
                }
            }
            catch
            {
                XtraMessageBox.Show("Không thể Truy vấn Dữ liệu","Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public override void Search()
        {
            base.Search();
            txtIDSubject.Text = txtNameSubjcet.Text = cmbGroupSubject.Text = "";
            txtIDSubject.Enabled = txtNameSubjcet.Enabled= cmbGroupSubject.Enabled = false;
            txtSearch.Show();
            lblSearch.Show();
            txtSearch.Focus();
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
    #endregion 
}