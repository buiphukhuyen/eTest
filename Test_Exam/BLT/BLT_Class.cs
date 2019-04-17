using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Test_Exam.DAT;
using System.Data.SqlClient;

namespace Test_Exam.BLT
{
    public class BLT_Class
    {
        private DAT_Class objBLT_Class;

        public BLT_Class()
        {
            objBLT_Class = new DAT_Class();
        }
        public BLT_Class(string Name_Class)
        {
            objBLT_Class = new DAT_Class(Name_Class);
        }
        public BLT_Class(string Name_Class, string Name_Major)
        {
            objBLT_Class = new DAT_Class(Name_Class, Name_Major);
        }
        public BLT_Class(DataTable dt)
        {
            objBLT_Class = new DAT_Class(dt);
        }

        public DataTable GettAllClass()
        {
            return objBLT_Class.GetAllClass();
        }
        public bool Insert_Class()
        {
            return objBLT_Class.Insert_Class();
        }

        public bool Update_Class()
        {
            return objBLT_Class.Update_Class();
        }

        public bool Delete_Class()
        {
            return objBLT_Class.Delete_Class();
        }
    }
}
