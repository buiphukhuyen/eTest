using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Test_Exam.BLT;
using Test_Exam.GUI.Form_Manager;

using System.Configuration;

namespace Test_Exam.GUI
{
    public partial class frm_Manager : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_Manager()
        {
            InitializeComponent();
        }
        
        private void frm_Manager_Load(object sender, EventArgs e)
        {
            Load_ListChapter_ListBox();
        }

        public void Load_ListChapter_ListBox()
        {
          /*  objChapter = new BLT_Subject();
            DataTable DTChapter = objChapter.GetAllSubject();
            lstChapter.DisplayMember = "Name_Subject";
            lstChapter.ValueMember = "ID_Subject";
            lstChapter.DataSource = DTChapter; */

        }
        private Form CheckForm(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void btnChangeInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckForm(typeof(frm_ChangeInfoAdmin));
            if (frm == null)
            {
                frm_ChangeInfoAdmin forms = new frm_ChangeInfoAdmin();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
       }

        private void btnLogOut_ItemClick(object sender, ItemClickEventArgs e)
        {
           DialogResult res = MessageBox.Show("Bạn có muốn Đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnChangePassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_ChangePassword fmr = new frm_ChangePassword();
            fmr.ShowDialog();
        }

        private void btnSubject_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckForm(typeof(frm_Subject));
            if (frm == null)
            {
                frm_Subject forms = new frm_Subject();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnClassMajor_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckForm(typeof(frm_Class));
            if (frm == null)
            {
                frm_Class forms = new frm_Class();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnStudents_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckForm(typeof(frm_Students));
            if (frm == null)
            {
                frm_Students forms = new frm_Students();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnQuestion_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckForm(typeof(frm_Question));
            if (frm == null)
            {
                frm_Question forms = new frm_Question();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnAddQuestion_ItemClick(object sender, ItemClickEventArgs e)
        {
                frm_AddQuestion forms = new frm_AddQuestion();
                forms.Show();
        }
    }
}