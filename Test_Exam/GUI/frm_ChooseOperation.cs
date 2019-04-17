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

namespace Test_Exam.GUI
{
    public partial class frm_ChooseOperation : DevExpress.XtraEditors.XtraForm
    {
        public frm_ChooseOperation()
        {
            InitializeComponent();
        }
        private void picbAdmin_Click(object sender, EventArgs e)
        {
            frm_LoginAdmin f = new frm_LoginAdmin();
            this.Hide();
            f.ShowDialog();
        }

        private void picbStudents_Click(object sender, EventArgs e)
        {
            frm_LoginStudents f = new frm_LoginStudents();
            this.Hide();
            f.ShowDialog();
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}