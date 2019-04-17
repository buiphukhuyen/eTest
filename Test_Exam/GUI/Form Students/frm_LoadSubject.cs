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
using Test_Exam.GUI;

namespace Test_Exam.GUI.Form_Students
{
    public partial class frm_LoadSubject : DevExpress.XtraEditors.XtraForm
    {
        private BLT_Students Obj_BLTStudent;
        private BLT_Subject Obj_BLTSubject;
        public frm_LoadSubject()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_LoadSubject_Load(object sender, EventArgs e)
        {

            Obj_BLTStudent = new BLT_Students(StaticCustom.Login_ID_Student);
            DataTable dt = Obj_BLTStudent.Get_Student();
            txtFullName.DataBindings.Add("Text", dt, "HỌ VÀ TÊN");

            Obj_BLTSubject = new BLT_Subject();
            DataTable dt2 = Obj_BLTSubject.GetAllSubject();
            cmbListSubject.DataSource = dt2;
            cmbListSubject.ValueMember = "MÃ HỌC PHẦN";
            cmbListSubject.DisplayMember = "TÊN HỌC PHẦN";
        }
    }
}