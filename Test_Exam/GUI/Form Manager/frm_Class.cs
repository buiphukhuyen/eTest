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
    public partial class frm_Class : frm_Toolkit
    {
        private BLT_Class Obj_BLTClass;
        string Status = "";
        public frm_Class()
        {
            InitializeComponent();
           
        }

        private void frm_Class_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
            Load_ComboBox();
            lblSearch.Hide();
            txtSearch.Hide();
            Click_Perform(true);

        }

        private void Load_DataGridView()
        {
            Obj_BLTClass = new BLT_Class();
            DataTable dt = Obj_BLTClass.GettAllClass();
            grdListClassMajor.DataSource = dt;

            //Custom Khoảng cách giữa các Row trên DataGridView cho phù hợp
            Padding newPadding = new Padding(0, 1, 0, 7);
            grdListClassMajor.RowTemplate.DefaultCellStyle.Padding = newPadding;

            //Custom khoảng cách giữa các Column trên DataGridView cho phù hợp
            grdListClassMajor.Columns[0].Width = 400;
            grdListClassMajor.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Tiến hành DataBidings dữ liệu từ DataGridView lên Textbox
            txtNameClass.DataBindings.Add("Text", dt, "TÊN LỚP");
            cmbNameMajor.DataBindings.Add("Text", dt, "TÊN KHOA");
        }

        private void Load_ComboBox()
        {
            //Thêm Items Khoa vào ComboBox
            cmbNameMajor.Items.Add("Công nghệ thông tin");
            cmbNameMajor.Items.Add("KT Điều khiển & Tự động hóa");
            cmbNameMajor.Items.Add("Tài chính ngân hàng");
        }

        //Hàm Xử lý sự kiện ComboBox khi chọn Items bất kỳ và lọc ra đúng tên Khoa.
        //private void cmbNameMajor_SelectionChangeCommitted(object sender, EventArgs e)
        //{
        //    (grdListClassMajor.DataSource as DataTable).DefaultView.RowFilter = string.Format("[TÊN KHOA] = '{0}'", cmbNameMajor.SelectedItem.ToString());
        //}

        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                (grdListClassMajor.DataSource as DataTable).DefaultView.RowFilter = string.Format("[TÊN LỚP] LIKE '%{0}%'", txtSearch.Text);
            }
            catch
            {
                XtraMessageBox.Show("Dữ liệu tìm kiếm không hợp lệ!", "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        #region Các hàm Override từ Form Toolkit
        //Cho phép quét sạch DataBindings từ các Control
        public override void ClearDataBind()
        {
            base.ClearDataBind();
            txtNameClass.DataBindings.Clear();
            cmbNameMajor.DataBindings.Clear();
        }

        //Hàm Override ResetInput cho phép xóa dữ liệu Control về ban đầu.
        public override void ResetInput()
        {
            base.ResetInput();
            txtNameClass.Text = cmbNameMajor.Text = "";
        }

        //Hàm Override Click_Perform (gọi lại trong sự kiện Load Form) cho phép enable control (textbox - combobox)
        public override void Click_Perform(bool flag)
        {
            base.Click_Perform(flag);
            txtNameClass.Enabled = !flag;
        }

        //Hàm Override kiểm tra Nhập liệu (Thêm - Sửa)
        public override bool ValueInput()
        {
            if(txtNameClass.Text.Trim() == "")
            {
                XtraMessageBox.Show("Bạn phải Nhập vào tên Lớp!");
                return false;
            }
            if(cmbNameMajor.Text.Trim() == "")
            {
                XtraMessageBox.Show("Bạn phải Chọn tên Khoa!");
                return false;
            }
            if(Status =="Add")
            {
                Obj_BLTClass = new BLT_Class();
                DataTable dt = Obj_BLTClass.GettAllClass();
                for(int i = 0 ; i < dt.Rows.Count ; i++)
                {
                    if(dt.Rows[i]["TÊN LỚP"].ToString().ToLower() == txtNameClass.Text.ToLower())
                    {
                        XtraMessageBox.Show("Tên Lớp đã có trên hệ thống! Vui lòng nhập Tên lớp khác");
                        return false;
                    }
                }
            }
            return base.ValueInput();
        }

        public override void Add()
        {
            base.Add();
            txtNameClass.Focus();
            Status = "Add";
            cmbNameMajor.Enabled = true;
        }

        public override void Edit()
        {
            base.Edit();
            txtNameClass.Focus();
            Status = "Edit";
            txtNameClass.Enabled = false;
        }

        public override void Search()
        {
            base.Search();
            txtNameClass.Text = cmbNameMajor.Text = "";
            txtNameClass.Enabled = cmbNameMajor.Enabled = false;
            txtSearch.Show();
            lblSearch.Show();
            txtSearch.Focus();
        }
        public override void Save()
        {
            base.Save();
            switch (Status)
            {
                case "Add":
                    if(ValueInput())
                    {
                        try
                        {
                            if (new BLT_Class(txtNameClass.Text, cmbNameMajor.SelectedItem.ToString()).Insert_Class())
                            {
                                XtraMessageBox.Show("Thêm Lớp mới thành công", "Thành công", MessageBoxButtons.OK);
                            }
                            else
                            {
                                XtraMessageBox.Show("Thêm Lớp mới thất bại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                            if (new BLT_Class(txtNameClass.Text, cmbNameMajor.SelectedItem.ToString()).Update_Class())
                            {
                                XtraMessageBox.Show("Chỉnh sửa Lớp thành công", "Thành công", MessageBoxButtons.OK);

                            }
                            else
                            {
                                XtraMessageBox.Show("Chỉnh sửa Lớp thất bại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
            DialogResult res = XtraMessageBox.Show("Bạn có muốn Xóa Lớp này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                try
                {
                    if (new BLT_Class(txtNameClass.Text).Delete_Class())
                    {
                        XtraMessageBox.Show("Xóa Lớp thành công", "Thành công", MessageBoxButtons.OK);
                    }
                    else
                    {
                        XtraMessageBox.Show("Xóa Lớp thất bại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    ReFresh();
                }
                catch
                {
                    XtraMessageBox.Show("Không thể Truy vấn Dữ liệu", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
    #endregion
    }
}