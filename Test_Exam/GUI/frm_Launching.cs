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

namespace Test_Exam
{
    public partial class frm_Launching : DevExpress.XtraEditors.XtraForm
    {

        public frm_Launching()
        {
            InitializeComponent();
        }

        private void tmr_Launching_Tick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}