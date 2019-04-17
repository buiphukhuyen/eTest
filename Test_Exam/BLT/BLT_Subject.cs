using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Exam.DAT;
namespace Test_Exam.BLT
{
    public class BLT_Subject
    {
        private DAT_Subject objBLT_Subject;

        public BLT_Subject()
        {
            objBLT_Subject = new DAT_Subject();
        }

        public BLT_Subject(string ID_Subject)
        {
            objBLT_Subject = new DAT_Subject(ID_Subject);
        }

        public BLT_Subject(string ID_Subject, string Name_Subject, string Group_Subject)
        {
            objBLT_Subject = new DAT_Subject(ID_Subject, Name_Subject, Group_Subject);
        }

        public BLT_Subject(DataTable dt)
        {
            objBLT_Subject = new DAT_Subject(dt);
        }

        public DataTable GetAllSubject()
        {
            return objBLT_Subject.GetAllSubject();
        }

        public bool Insert_Subject()
        {
            return objBLT_Subject.Insert_Subject();
        }

        public bool Edit_Subject()
        {
            return objBLT_Subject.Edit_Subject();
        }
        public bool Delete_Subject()
        {
            return objBLT_Subject.Delete_Subject();
        }
    }
}
