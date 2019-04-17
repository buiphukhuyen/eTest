namespace Test_Exam.GUI
{
    partial class frm_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Manager));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnChangeInfo = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.skinPaletteRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btnSubject = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.btnClassMajor = new DevExpress.XtraBars.BarButtonItem();
            this.btnStudents = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuestion = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddQuestion = new DevExpress.XtraBars.BarButtonItem();
            this.ribQuestion = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribStudents = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribManager = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribOther = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnChangeInfo,
            this.btnChangePassword,
            this.barButtonItem2,
            this.btnLogOut,
            this.skinPaletteRibbonGalleryBarItem1,
            this.skinDropDownButtonItem1,
            this.skinRibbonGalleryBarItem1,
            this.btnSubject,
            this.barButtonItem5,
            this.btnClassMajor,
            this.btnStudents,
            this.btnQuestion,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barButtonItem12,
            this.barButtonItem13,
            this.barButtonItem14,
            this.btnAddQuestion});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbon.MaxItemId = 21;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribQuestion,
            this.ribStudents,
            this.ribManager,
            this.ribOther});
            this.ribbon.Size = new System.Drawing.Size(2241, 297);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnChangeInfo
            // 
            this.btnChangeInfo.Caption = "Đổi thông tin";
            this.btnChangeInfo.CloseRadialMenuOnItemClick = true;
            this.btnChangeInfo.Id = 1;
            this.btnChangeInfo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeInfo.ImageOptions.Image")));
            this.btnChangeInfo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChangeInfo.ImageOptions.LargeImage")));
            this.btnChangeInfo.Name = "btnChangeInfo";
            this.btnChangeInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangeInfo_ItemClick);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Caption = "Đổi mật khẩu";
            this.btnChangePassword.Id = 2;
            this.btnChangePassword.ImageOptions.LargeImage = global::Test_Exam.Properties.Resources.icon_ChangePass;
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangePassword_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Thoát";
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Caption = "Đăng xuất";
            this.btnLogOut.Id = 5;
            this.btnLogOut.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.ImageOptions.Image")));
            this.btnLogOut.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.ImageOptions.LargeImage")));
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLogOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogOut_ItemClick);
            // 
            // skinPaletteRibbonGalleryBarItem1
            // 
            this.skinPaletteRibbonGalleryBarItem1.Caption = "skinPaletteRibbonGalleryBarItem1";
            this.skinPaletteRibbonGalleryBarItem1.Id = 6;
            this.skinPaletteRibbonGalleryBarItem1.Name = "skinPaletteRibbonGalleryBarItem1";
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 7;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 8;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // btnSubject
            // 
            this.btnSubject.Caption = "Quản lý Môn học";
            this.btnSubject.Id = 9;
            this.btnSubject.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSubject.ImageOptions.Image")));
            this.btnSubject.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSubject.ImageOptions.LargeImage")));
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSubject_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Danh mục Khoa";
            this.barButtonItem5.Id = 10;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // btnClassMajor
            // 
            this.btnClassMajor.Caption = "Danh sách Khoa - Lớp";
            this.btnClassMajor.Id = 11;
            this.btnClassMajor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClassMajor.ImageOptions.Image")));
            this.btnClassMajor.ImageOptions.LargeImage = global::Test_Exam.Properties.Resources.icon_ListClass;
            this.btnClassMajor.Name = "btnClassMajor";
            this.btnClassMajor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClassMajor_ItemClick);
            // 
            // btnStudents
            // 
            this.btnStudents.Caption = "Danh sách Sinh viên";
            this.btnStudents.Id = 12;
            this.btnStudents.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStudents.ImageOptions.Image")));
            this.btnStudents.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnStudents.ImageOptions.LargeImage")));
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStudents_ItemClick);
            // 
            // btnQuestion
            // 
            this.btnQuestion.Caption = "Ngân hàng câu hỏi";
            this.btnQuestion.Id = 13;
            this.btnQuestion.ImageOptions.LargeImage = global::Test_Exam.Properties.Resources.icon_ListQuestion;
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuestion_ItemClick);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Phiên bản";
            this.barButtonItem9.Id = 14;
            this.barButtonItem9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.Image")));
            this.barButtonItem9.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.LargeImage")));
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Trợ giúp";
            this.barButtonItem10.Id = 15;
            this.barButtonItem10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.ImageOptions.Image")));
            this.barButtonItem10.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.ImageOptions.LargeImage")));
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Sao lưu";
            this.barButtonItem11.Id = 16;
            this.barButtonItem11.ImageOptions.LargeImage = global::Test_Exam.Properties.Resources.icon_Backup;
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Phục hồi";
            this.barButtonItem12.Id = 17;
            this.barButtonItem12.ImageOptions.LargeImage = global::Test_Exam.Properties.Resources.icon_Restore;
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Đề thi";
            this.barButtonItem13.Id = 18;
            this.barButtonItem13.ImageOptions.LargeImage = global::Test_Exam.Properties.Resources.icon_Test;
            this.barButtonItem13.Name = "barButtonItem13";
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.Caption = "Tạo đề thi";
            this.barButtonItem14.Id = 19;
            this.barButtonItem14.ImageOptions.LargeImage = global::Test_Exam.Properties.Resources.icon_AddTest;
            this.barButtonItem14.Name = "barButtonItem14";
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Caption = "Thêm Câu hỏi";
            this.btnAddQuestion.Id = 20;
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddQuestion_ItemClick);
            // 
            // ribQuestion
            // 
            this.ribQuestion.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribQuestion.Name = "ribQuestion";
            this.ribQuestion.Text = "TRANG CHỦ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.skinDropDownButtonItem1, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Giao diện";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnChangeInfo);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnChangePassword);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Tài khoản";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnLogOut);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Hệ thống";
            // 
            // ribStudents
            // 
            this.ribStudents.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup6});
            this.ribStudents.Name = "ribStudents";
            this.ribStudents.Text = "QUẢN LÝ ĐÀO TẠO";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSubject);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Quản lý môn học";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnClassMajor);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnStudents);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Quản lý sinh viên";
            // 
            // ribManager
            // 
            this.ribManager.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup7});
            this.ribManager.Name = "ribManager";
            this.ribManager.Text = "QUẢN LÝ CÂU HỎI - ĐỀ THI";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnQuestion);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnAddQuestion);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Quản lý câu hỏi";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonItem13);
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonItem14);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Quản lý đề thi";
            // 
            // ribOther
            // 
            this.ribOther.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup9,
            this.ribbonPageGroup8});
            this.ribOther.Name = "ribOther";
            this.ribOther.Text = "NÂNG CAO";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.barButtonItem11);
            this.ribbonPageGroup9.ItemLinks.Add(this.barButtonItem12);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "Dữ liệu";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.barButtonItem10);
            this.ribbonPageGroup8.ItemLinks.Add(this.barButtonItem9);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "Thông tin thêm";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 1389);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(2241, 42);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frm_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2241, 1431);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Manager";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "QUẢN LÝ PHẦN MỀM TRẮC NGHIỆM";
            this.Load += new System.EventHandler(this.frm_Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribQuestion;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribStudents;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribManager;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnChangeInfo;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnChangePassword;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnLogOut;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem btnSubject;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem btnClassMajor;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnStudents;
        private DevExpress.XtraBars.BarButtonItem btnQuestion;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribOther;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnAddQuestion;
    }
}