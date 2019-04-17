using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using Test_Exam.GUI;

namespace Test_Exam
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();

       //     Application.Run(new frm_Manager());

            frm_Launching f = new frm_Launching();
            f.ShowDialog();

            if (f.DialogResult == DialogResult.OK)
            {
                Application.Run(new frm_ChooseOperation());
            }
        }
    }
}
