namespace Test_Exam.GUI
{
    partial class frm_ChooseOperation
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
            this.picbStudents = new System.Windows.Forms.PictureBox();
            this.picbAdmin = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bntExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picbStudents
            // 
            this.picbStudents.BackgroundImage = global::Test_Exam.Properties.Resources.Picture1;
            this.picbStudents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbStudents.Location = new System.Drawing.Point(782, 339);
            this.picbStudents.Name = "picbStudents";
            this.picbStudents.Size = new System.Drawing.Size(343, 374);
            this.picbStudents.TabIndex = 3;
            this.picbStudents.TabStop = false;
            this.picbStudents.Click += new System.EventHandler(this.picbStudents_Click);
            // 
            // picbAdmin
            // 
            this.picbAdmin.BackgroundImage = global::Test_Exam.Properties.Resources.Picture2;
            this.picbAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbAdmin.Location = new System.Drawing.Point(195, 339);
            this.picbAdmin.Name = "picbAdmin";
            this.picbAdmin.Size = new System.Drawing.Size(354, 374);
            this.picbAdmin.TabIndex = 2;
            this.picbAdmin.TabStop = false;
            this.picbAdmin.Click += new System.EventHandler(this.picbAdmin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Test_Exam.Properties.Resources.Form_ChooseOperation;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1315, 921);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bntExit
            // 
            this.bntExit.BackColor = System.Drawing.Color.Black;
            this.bntExit.FlatAppearance.BorderSize = 0;
            this.bntExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExit.ForeColor = System.Drawing.Color.White;
            this.bntExit.Location = new System.Drawing.Point(500, 865);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(316, 55);
            this.bntExit.TabIndex = 4;
            this.bntExit.Text = "THOÁT";
            this.bntExit.UseVisualStyleBackColor = false;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // frm_ChooseOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 918);
            this.ControlBox = false;
            this.Controls.Add(this.bntExit);
            this.Controls.Add(this.picbStudents);
            this.Controls.Add(this.picbAdmin);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ChooseOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.picbStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picbAdmin;
        private System.Windows.Forms.PictureBox picbStudents;
        private System.Windows.Forms.Button bntExit;
    }
}