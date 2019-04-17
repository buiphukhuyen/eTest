using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Test_Exam.DAT;

namespace Test_Exam.BLT
{
    public class BLT_Students
    {
        private DAT_Students objDAT_Students;

        public BLT_Students()
        {
            objDAT_Students = new DAT_Students();
        }

        public BLT_Students(string ID_Student, string Name_Class)
        {
            objDAT_Students = new DAT_Students(ID_Student, Name_Class);
        }

        public BLT_Students(string ID_Student)
        {
            objDAT_Students = new DAT_Students(ID_Student);
        }

        public BLT_Students(string ID_Student, string Full_Name, string Name_Class)
        {
            objDAT_Students = new DAT_Students(ID_Student, Full_Name, Name_Class);
        }
        public BLT_Students(DataTable dt)
        {
            objDAT_Students = new DAT_Students(dt);
        }

        public bool TrueLogin()
        {
            return objDAT_Students.TrueLogin();
        }

        public DataTable GetAllStudents()
        {
            return objDAT_Students.GetAllStudents();
        }

        public DataTable Get_Student()
        {
            return objDAT_Students.Get_Student();
        }

        public bool Insert_Student()
        {
            return objDAT_Students.Insert_Student();
        }

        public bool Edit_Student()
        {
            return objDAT_Students.Edit_Student();
        }
        
        public bool Delete_Student()
        {
            return objDAT_Students.Delete_Student();
        }

    }
}
