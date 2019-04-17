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
using DevExpress.XtraBars;

namespace Test_Exam.GUI.Form_Manager
{
    public partial class frm_Toolkit : DevExpress.XtraEditors.XtraForm
    {
        public virtual void DataBind() { }
        public virtual void ClearDataBind() { }
        public virtual void UserAccessFunction() { }

        public virtual void Expand(bool flag) { }

        //Hàm chỉ cho phép đọc (gắn cờ trả về kiểu bool - true/false)
        public virtual void ReadOnly(bool flag) { }

        //Hàm Reset Input (Khôi phục lại khi Nhập) - sẽ Override lại ở thằng con.
        public virtual void ResetInput() { }

        //Hàm Kiểm tra Ràng buộc TextBox
        public virtual bool ValueInput() { return true; }

        //Hàm Khởi tạo - được gọi lại trong Event Load_Form
        public virtual void Init()
        {
            Click_Perform(true);
            UserAccessFunction();
            Expand(false);
        }

        //Hàm cho phép ẩn/hiện các Button Items trên Bar bằng cách đánh dấu cờ gọp cho các nút 
        //Thêm, Xóa, Sửa, Cập nhật, In và tìm kiếm cùng 1 Nhóm; Và Lưu, Hủy bỏ cùng một nhóm!
        public virtual void Click_Perform(bool flag)
        {
            //Nếu Hàm Click truyền vào là true -> Các Button Thêm, Xóa, Sửa, In và Tìm kiếm sẽ hiện.
            cmd_Add.Enabled = cmd_Delete.Enabled = cmd_Edit.Enabled = cmd_Refresh.Enabled = cmd_Print.Enabled = cmd_Search.Enabled = flag;
            //Button Lưu và Hủy bỏ sẽ ẩn. Và ngược lại
            cmd_Save.Enabled = cmd_Cancel.Enabled = !flag;
        }

        /// <summary>
        /// Trước khi thêm phải clear Databind
        /// </summary>
        public virtual void Add()
        {
            //Khôi phục DataBinding
            ClearDataBind();
            //Reset Input
            ResetInput();
            //Ẩn các Button Thêm, Xóa, Sửa, Cập nhật,... Chỉ hiện mỗi Lưu và Hủy bỏ thôi!
            Click_Perform(false);
            //Cho phép trai triển
            Expand(true);
        }

        public virtual void Edit()
        {
            Click_Perform(false);
            Expand(true);
            ReadOnly(true);
            Expand(true);
        }

        public virtual void Delete() { }
        public virtual void Save()
        {
            Expand(false);
            Click_Perform(true);
            Expand(false);
        }
        public virtual void Cancel()
        {
            ReFresh();
            Click_Perform(true);
            DataBind();
        }
        public virtual void Search() { }
        public virtual void Print() { }
        public virtual void ReFresh() { }

        public frm_Toolkit()
        {
            InitializeComponent();
        }

        private bool allowAdd;
        /// <summary>
        /// Hiển thị nút add hay không
        /// </summary>
        [DefaultValue(false)]
        public bool AllowAdd
        {
            get { return allowAdd; }
            set
            {
                allowAdd = value;
                if (!allowAdd)
                    cmd_Add.Visibility = BarItemVisibility.Never;
                else cmd_Add.Visibility = BarItemVisibility.Always;
            }
        }
        private bool allowDelete;
        /// <summary>
        /// CÓ HIỂN THỊ NÚT DELETE HAY KHÔNG
        /// </summary>
        [DefaultValue(false)]
        public bool AllowDelete
        {
            get { return allowDelete; }
            set
            {
                allowDelete = value;
                if (!allowDelete)
                    cmd_Delete.Visibility = BarItemVisibility.Never;
                else cmd_Delete.Visibility = BarItemVisibility.Always;
            }
        }

        private bool allowEdit;
        /// <summary>
        /// CÓ HIỂN THỊ NÚT sửa HAY KHÔNG
        /// </summary>
        [DefaultValue(false)]
        public bool AllowEdit
        {
            get { return allowEdit; }
            set
            {
                allowEdit = value;
                if (!allowEdit)
                    cmd_Edit.Visibility = BarItemVisibility.Never;
                else cmd_Edit.Visibility = BarItemVisibility.Always;
            }
        }
        private bool allowSave;
        /// <summary>
        /// CÓ HIỂN THỊ NÚT DELETE HAY KHÔNG
        /// </summary>
        [DefaultValue(false)]
        public bool AllowSave
        {
            get { return allowSave; }
            set
            {
                allowSave = value;
                if (!allowSave)
                    cmd_Save.Visibility = BarItemVisibility.Never;
                else cmd_Save.Visibility = BarItemVisibility.Always;
            }
        }
        private bool allowCancel;
        /// <summary>
        /// CÓ HIỂN THỊ NÚT hủy HAY KHÔNG
        /// </summary>
        [DefaultValue(false)]
        public bool AllowCancel
        {
            get { return allowCancel; }
            set
            {
                allowCancel = value;
                if (!allowCancel)
                    cmd_Cancel.Visibility = BarItemVisibility.Never;
                else cmd_Cancel.Visibility = BarItemVisibility.Always;
            }
        }
        private bool allowSearch;
        /// <summary>
        /// CÓ HIỂN THỊ NÚT SEARCH HAY KHÔNG
        /// </summary>
        [DefaultValue(false)]
        public bool AllowSearch
        {
            get { return allowSearch; }
            set
            {
                allowSearch = value;
                if (!allowSearch)
                    cmd_Search.Visibility = BarItemVisibility.Never;
                else cmd_Search.Visibility = BarItemVisibility.Always;
            }
        }
        private bool allowPrint;
        /// <summary>
        /// CÓ HIỂN THỊ NÚT DELETE HAY KHÔNG
        /// </summary>
        [DefaultValue(false)]
        public bool AllowPrint
        {
            get { return allowPrint; }
            set
            {
                allowPrint = value;
                if (!allowPrint)
                    cmd_Print.Visibility = BarItemVisibility.Never;
                else cmd_Print.Visibility = BarItemVisibility.Always;
            }
        }
        
        private void cmd_Add_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add();
        }

        private void cmd_Delete_ItemClick(object sender, ItemClickEventArgs e)
        {
            Delete();
        }

        private void cmd_Edit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Edit();
        }

        private void cmd_Search_ItemClick(object sender, ItemClickEventArgs e)
        {
            Search();
        }

        private void cmd_Save_ItemClick(object sender, ItemClickEventArgs e)
        {
            Save();
        }

        private void cmd_Cancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cancel();
        }

        private void cmd_Print_ItemClick(object sender, ItemClickEventArgs e)
        {
            Print();
        }

        private void cmd_Refresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            ReFresh();
        }
    }
}