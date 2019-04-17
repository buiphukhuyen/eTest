using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Exam.DAT;

namespace Test_Exam.BLT
{
    public class BLT_Admin
    {
            private DAT_Admin objDA_Admin;

            public BLT_Admin(string ID, string Password)
            {
                objDA_Admin = new DAT_Admin(ID, Password);
            }
            
            public BLT_Admin(string Password)
            {
                objDA_Admin = new DAT_Admin(Password);
            }
            public BLT_Admin(DataTable dt)
            {
                objDA_Admin = new DAT_Admin(dt);
            }

            public bool TrueLogin()
            {
                return objDA_Admin.TrueLogin();
            }

            public bool ChangePassword()
            {
                return objDA_Admin.ChangePassword();
            }
        }
}

