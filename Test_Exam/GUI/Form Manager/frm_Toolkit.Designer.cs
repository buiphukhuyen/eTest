namespace Test_Exam.GUI.Form_Manager
{
    partial class frm_Toolkit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Toolkit));
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.cmd_Add = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmd_Delete = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmd_Edit = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmd_Search = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmd_Save = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmd_Cancel = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmd_Print = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmd_Refresh = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.cmd_In = new DevExpress.XtraBars.BarLargeButtonItem();
            this.Cmd_LayDuLieu = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmd_InDuLieu = new DevExpress.XtraBars.BarLargeButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1983, 118);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(7);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 73);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.cmd_Add,
            this.cmd_Delete,
            this.cmd_Edit,
            this.cmd_Save,
            this.cmd_Cancel,
            this.cmd_Print,
            this.cmd_In,
            this.cmd_Search,
            this.cmd_Refresh,
            this.Cmd_LayDuLieu,
            this.cmd_InDuLieu});
            this.barManager1.MaxItemId = 14;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cmd_Add, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmd_Delete),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmd_Edit),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmd_Search),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmd_Save, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmd_Cancel),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmd_Print),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmd_Refresh, true)});
            this.bar1.Offset = 789;
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.RotateWhenVertical = false;
            this.bar1.Text = "Tools";
            // 
            // cmd_Add
            // 
            this.cmd_Add.Caption = "Thêm";
            this.cmd_Add.Id = 0;
            this.cmd_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmd_Add.ImageOptions.Image")));
            this.cmd_Add.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("cmd_Add.ImageOptions.LargeImage")));
            this.cmd_Add.Name = "cmd_Add";
            this.cmd_Add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cmd_Add_ItemClick);
            // 
            // cmd_Delete
            // 
            this.cmd_Delete.Caption = "Xóa";
            this.cmd_Delete.Id = 1;
            this.cmd_Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmd_Delete.ImageOptions.Image")));
            this.cmd_Delete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("cmd_Delete.ImageOptions.LargeImage")));
            this.cmd_Delete.Name = "cmd_Delete";
            this.cmd_Delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cmd_Delete_ItemClick);
            // 
            // cmd_Edit
            // 
            this.cmd_Edit.Caption = "Sửa";
            this.cmd_Edit.Id = 2;
            this.cmd_Edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmd_Edit.ImageOptions.Image")));
            this.cmd_Edit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("cmd_Edit.ImageOptions.LargeImage")));
            this.cmd_Edit.Name = "cmd_Edit";
            this.cmd_Edit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cmd_Edit_ItemClick);
            // 
            // cmd_Search
            // 
            this.cmd_Search.Caption = "Tìm Kiếm";
            this.cmd_Search.Id = 7;
            this.cmd_Search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmd_Search.ImageOptions.Image")));
            this.cmd_Search.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("cmd_Search.ImageOptions.LargeImage")));
            this.cmd_Search.Name = "cmd_Search";
            this.cmd_Search.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cmd_Search_ItemClick);
            // 
            // cmd_Save
            // 
            this.cmd_Save.Caption = "Lưu";
            this.cmd_Save.Id = 3;
            this.cmd_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmd_Save.ImageOptions.Image")));
            this.cmd_Save.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("cmd_Save.ImageOptions.LargeImage")));
            this.cmd_Save.Name = "cmd_Save";
            this.cmd_Save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cmd_Save_ItemClick);
            // 
            // cmd_Cancel
            // 
            this.cmd_Cancel.Caption = "Hủy";
            this.cmd_Cancel.Id = 4;
            this.cmd_Cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmd_Cancel.ImageOptions.Image")));
            this.cmd_Cancel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("cmd_Cancel.ImageOptions.LargeImage")));
            this.cmd_Cancel.Name = "cmd_Cancel";
            this.cmd_Cancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cmd_Cancel_ItemClick);
            // 
            // cmd_Print
            // 
            this.cmd_Print.Caption = "In Ấn";
            this.cmd_Print.Id = 5;
            this.cmd_Print.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmd_Print.ImageOptions.Image")));
            this.cmd_Print.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("cmd_Print.ImageOptions.LargeImage")));
            this.cmd_Print.Name = "cmd_Print";
            this.cmd_Print.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cmd_Print_ItemClick);
            // 
            // cmd_Refresh
            // 
            this.cmd_Refresh.Caption = "Cập Nhật";
            this.cmd_Refresh.Id = 8;
            this.cmd_Refresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmd_Refresh.ImageOptions.Image")));
            this.cmd_Refresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("cmd_Refresh.ImageOptions.LargeImage")));
            this.cmd_Refresh.Name = "cmd_Refresh";
            this.cmd_Refresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cmd_Refresh_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.barDockControlTop.Appearance.Options.UseFont = true;
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(7);
            this.barDockControlTop.Size = new System.Drawing.Size(1983, 118);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 191);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(7);
            this.barDockControlBottom.Size = new System.Drawing.Size(1983, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 118);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(7);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 73);
            // 
            // cmd_In
            // 
            this.cmd_In.Caption = "Thoát";
            this.cmd_In.Id = 6;
            this.cmd_In.Name = "cmd_In";
            // 
            // Cmd_LayDuLieu
            // 
            this.Cmd_LayDuLieu.Caption = "Lấy Dữ Liệu";
            this.Cmd_LayDuLieu.Id = 12;
            this.Cmd_LayDuLieu.Name = "Cmd_LayDuLieu";
            this.Cmd_LayDuLieu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // cmd_InDuLieu
            // 
            this.cmd_InDuLieu.Caption = "In Dữ Liệu";
            this.cmd_InDuLieu.Id = 13;
            this.cmd_InDuLieu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("cmd_InDuLieu.ImageOptions.LargeImage")));
            this.cmd_InDuLieu.Name = "cmd_InDuLieu";
            this.cmd_InDuLieu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // frm_Toolkit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1983, 191);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frm_Toolkit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Toolkit";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarLargeButtonItem cmd_Add;
        private DevExpress.XtraBars.BarLargeButtonItem cmd_Delete;
        private DevExpress.XtraBars.BarLargeButtonItem cmd_Edit;
        private DevExpress.XtraBars.BarLargeButtonItem cmd_Search;
        private DevExpress.XtraBars.BarLargeButtonItem cmd_Save;
        private DevExpress.XtraBars.BarLargeButtonItem cmd_Cancel;
        private DevExpress.XtraBars.BarLargeButtonItem cmd_Print;
        private DevExpress.XtraBars.BarLargeButtonItem cmd_Refresh;
        private DevExpress.XtraBars.BarLargeButtonItem cmd_In;
        private DevExpress.XtraBars.BarLargeButtonItem Cmd_LayDuLieu;
        private DevExpress.XtraBars.BarLargeButtonItem cmd_InDuLieu;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
    }
}