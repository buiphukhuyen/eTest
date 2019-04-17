namespace Test_Exam.GUI.Form_Manager
{
    partial class frm_Question
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lsb_ListSubject = new DevExpress.XtraEditors.ListBoxControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.grvListQuestion = new System.Windows.Forms.DataGridView();
            this.cmsQuestion = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsItem_ShowEditQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItem_DeleteQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItem_PrintQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grcQuestion = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.lsb_ListSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvListQuestion)).BeginInit();
            this.cmsQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcQuestion)).BeginInit();
            this.grcQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsb_ListSubject
            // 
            this.lsb_ListSubject.Appearance.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsb_ListSubject.Appearance.Options.UseFont = true;
            this.lsb_ListSubject.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsb_ListSubject.AppearanceDisabled.Options.UseFont = true;
            this.lsb_ListSubject.ColumnWidth = 1;
            this.lsb_ListSubject.Location = new System.Drawing.Point(22, 54);
            this.lsb_ListSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsb_ListSubject.Name = "lsb_ListSubject";
            this.lsb_ListSubject.Padding = new System.Windows.Forms.Padding(0, 1, 0, 7);
            this.lsb_ListSubject.Size = new System.Drawing.Size(724, 874);
            this.lsb_ListSubject.TabIndex = 0;
            this.lsb_ListSubject.Click += new System.EventHandler(this.lsb_ListSubject_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.lsb_ListSubject);
            this.groupControl1.Location = new System.Drawing.Point(50, 36);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(768, 954);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Danh sách Học phần";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(70, 54);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(184, 62);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Thêm câu hỏi";
            // 
            // grvListQuestion
            // 
            this.grvListQuestion.AllowUserToAddRows = false;
            this.grvListQuestion.AllowUserToResizeRows = false;
            this.grvListQuestion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvListQuestion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grvListQuestion.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvListQuestion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvListQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvListQuestion.ContextMenuStrip = this.cmsQuestion;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 1, 0, 7);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvListQuestion.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvListQuestion.EnableHeadersVisualStyles = false;
            this.grvListQuestion.Location = new System.Drawing.Point(26, 45);
            this.grvListQuestion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grvListQuestion.Name = "grvListQuestion";
            this.grvListQuestion.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvListQuestion.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grvListQuestion.RowTemplate.Height = 33;
            this.grvListQuestion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvListQuestion.Size = new System.Drawing.Size(1302, 721);
            this.grvListQuestion.TabIndex = 3;
            // 
            // cmsQuestion
            // 
            this.cmsQuestion.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsQuestion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsItem_ShowEditQuestion,
            this.cmsItem_DeleteQuestion,
            this.refreshToolStripMenuItem,
            this.cmsItem_PrintQuestion});
            this.cmsQuestion.Name = "conMnuCauHoi";
            this.cmsQuestion.Size = new System.Drawing.Size(337, 148);
            // 
            // cmsItem_ShowEditQuestion
            // 
            this.cmsItem_ShowEditQuestion.Name = "cmsItem_ShowEditQuestion";
            this.cmsItem_ShowEditQuestion.Size = new System.Drawing.Size(336, 36);
            this.cmsItem_ShowEditQuestion.Text = "Xem / Sửa Câu hỏi";
            this.cmsItem_ShowEditQuestion.Click += new System.EventHandler(this.cmsItem_ShowEditQuestion_Click);
            // 
            // cmsItem_DeleteQuestion
            // 
            this.cmsItem_DeleteQuestion.Name = "cmsItem_DeleteQuestion";
            this.cmsItem_DeleteQuestion.Size = new System.Drawing.Size(336, 36);
            this.cmsItem_DeleteQuestion.Text = "Xóa câu hỏi đang chọn";
            this.cmsItem_DeleteQuestion.Click += new System.EventHandler(this.cmsItem_DeleteQuestion_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(336, 36);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // cmsItem_PrintQuestion
            // 
            this.cmsItem_PrintQuestion.Name = "cmsItem_PrintQuestion";
            this.cmsItem_PrintQuestion.Size = new System.Drawing.Size(336, 36);
            this.cmsItem_PrintQuestion.Text = "In thông tin câu hỏi";
            this.cmsItem_PrintQuestion.Click += new System.EventHandler(this.cmsItem_PrintQuestion_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Location = new System.Drawing.Point(856, 36);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1355, 141);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Chức năng";
            // 
            // grcQuestion
            // 
            this.grcQuestion.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grcQuestion.AppearanceCaption.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.grcQuestion.AppearanceCaption.Options.UseFont = true;
            this.grcQuestion.AppearanceCaption.Options.UseForeColor = true;
            this.grcQuestion.Controls.Add(this.grvListQuestion);
            this.grcQuestion.Location = new System.Drawing.Point(856, 199);
            this.grcQuestion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grcQuestion.Name = "grcQuestion";
            this.grcQuestion.Size = new System.Drawing.Size(1355, 793);
            this.grcQuestion.TabIndex = 5;
            this.grcQuestion.Text = "Danh sách Câu hỏi";
            // 
            // frm_Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2222, 1018);
            this.Controls.Add(this.grcQuestion);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Question";
            this.Text = "Quản Lý Câu hỏi";
            this.Load += new System.EventHandler(this.frm_Question_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lsb_ListSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvListQuestion)).EndInit();
            this.cmsQuestion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcQuestion)).EndInit();
            this.grcQuestion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl lsb_ListSubject;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridView grvListQuestion;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl grcQuestion;
        private System.Windows.Forms.ContextMenuStrip cmsQuestion;
        private System.Windows.Forms.ToolStripMenuItem cmsItem_ShowEditQuestion;
        private System.Windows.Forms.ToolStripMenuItem cmsItem_DeleteQuestion;
        private System.Windows.Forms.ToolStripMenuItem cmsItem_PrintQuestion;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}