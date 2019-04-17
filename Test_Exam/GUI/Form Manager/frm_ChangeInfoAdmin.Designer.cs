namespace Test_Exam.GUI.Form_Manager
{
    partial class frm_ChangeInfoAdmin
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_time = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmd_changeavt = new DevExpress.XtraEditors.SimpleButton();
            this.lb_chucvu = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_time
            // 
            this.lb_time.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lb_time.Appearance.Options.UseFont = true;
            this.lb_time.Appearance.Options.UseForeColor = true;
            this.lb_time.Location = new System.Drawing.Point(54, 63);
            this.lb_time.Margin = new System.Windows.Forms.Padding(6);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(188, 51);
            this.lb_time.TabIndex = 6;
            this.lb_time.Text = "Thời gian:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.pictureBox1);
            this.groupControl1.Controls.Add(this.cmd_changeavt);
            this.groupControl1.Controls.Add(this.lb_chucvu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(6);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(366, 722);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Tài khoản cá nhân";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(48, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 340);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // cmd_changeavt
            // 
            this.cmd_changeavt.Location = new System.Drawing.Point(92, 429);
            this.cmd_changeavt.Margin = new System.Windows.Forms.Padding(6);
            this.cmd_changeavt.Name = "cmd_changeavt";
            this.cmd_changeavt.Size = new System.Drawing.Size(150, 44);
            this.cmd_changeavt.TabIndex = 2;
            this.cmd_changeavt.Text = "Đổi Ảnh";
            // 
            // lb_chucvu
            // 
            this.lb_chucvu.Location = new System.Drawing.Point(62, 390);
            this.lb_chucvu.Margin = new System.Windows.Forms.Padding(6);
            this.lb_chucvu.Name = "lb_chucvu";
            this.lb_chucvu.Size = new System.Drawing.Size(84, 25);
            this.lb_chucvu.TabIndex = 1;
            this.lb_chucvu.Text = "Chức vụ:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lb_time);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(6);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1395, 722);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Thông tin tài khoản";
            // 
            // frm_ChangeInfoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 722);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Name = "frm_ChangeInfoAdmin";
            this.Text = "Thay đổi thông tin";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.LabelControl lb_time;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton cmd_changeavt;
        private DevExpress.XtraEditors.LabelControl lb_chucvu;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}