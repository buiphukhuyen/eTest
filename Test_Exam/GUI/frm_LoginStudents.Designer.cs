namespace Test_Exam
{
    partial class frm_LoginStudents
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtIDStudent = new System.Windows.Forms.TextBox();
            this.btnSupport = new System.Windows.Forms.Button();
            this.btnLoginStudents = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Test_Exam.Properties.Resources.Form_Login1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1461, 966);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(127)))), ((int)(((byte)(240)))));
            this.btnExit.BackgroundImage = global::Test_Exam.Properties.Resources.Button_Exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1293, 42);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 82);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtClass
            // 
            this.txtClass.Font = new System.Drawing.Font("Arial", 13.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.Location = new System.Drawing.Point(304, 554);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(379, 48);
            this.txtClass.TabIndex = 2;
            this.txtClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClass_KeyDown);
            // 
            // txtIDStudent
            // 
            this.txtIDStudent.Font = new System.Drawing.Font("Arial", 13.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDStudent.Location = new System.Drawing.Point(304, 461);
            this.txtIDStudent.Name = "txtIDStudent";
            this.txtIDStudent.Size = new System.Drawing.Size(379, 48);
            this.txtIDStudent.TabIndex = 1;
            this.txtIDStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSupport
            // 
            this.btnSupport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(127)))), ((int)(((byte)(240)))));
            this.btnSupport.FlatAppearance.BorderSize = 0;
            this.btnSupport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupport.Image = global::Test_Exam.Properties.Resources.Button_Support;
            this.btnSupport.Location = new System.Drawing.Point(716, 482);
            this.btnSupport.Name = "btnSupport";
            this.btnSupport.Size = new System.Drawing.Size(90, 92);
            this.btnSupport.TabIndex = 3;
            this.btnSupport.UseVisualStyleBackColor = false;
            this.btnSupport.Click += new System.EventHandler(this.btnSupport_Click);
            // 
            // btnLoginStudents
            // 
            this.btnLoginStudents.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnLoginStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(127)))), ((int)(((byte)(240)))));
            this.btnLoginStudents.FlatAppearance.BorderSize = 0;
            this.btnLoginStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginStudents.Location = new System.Drawing.Point(128, 731);
            this.btnLoginStudents.Name = "btnLoginStudents";
            this.btnLoginStudents.Size = new System.Drawing.Size(362, 211);
            this.btnLoginStudents.TabIndex = 4;
            this.btnLoginStudents.UseVisualStyleBackColor = false;
            this.btnLoginStudents.Click += new System.EventHandler(this.btnLoginStudents_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(127)))), ((int)(((byte)(240)))));
            this.btnLogin.BackgroundImage = global::Test_Exam.Properties.Resources.Button_Login;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(141, 722);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(362, 196);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLoginStudents_Click);
            // 
            // frm_LoginStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 965);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnLoginStudents);
            this.Controls.Add(this.btnSupport);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtIDStudent);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_LoginStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_LoginStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtIDStudent;
        private System.Windows.Forms.Button btnSupport;
        private System.Windows.Forms.Button btnLoginStudents;
        private System.Windows.Forms.Button btnLogin;
    }
}