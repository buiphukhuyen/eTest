using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Test_Exam.DAT;

namespace Test_Exam.BLT
{
    public class BLT_Question
    {
        private DAT_Question objBLT_Question;
        
        public BLT_Question()
        {
            objBLT_Question = new DAT_Question();
        }

        public BLT_Question(string Subject, string ID_Question)
        {
            objBLT_Question = new DAT_Question(Subject, ID_Question);
        }

        public BLT_Question(string ID_Question, string Question, string A, string B, string C, string D, string Key_Question, string Subject)
        {
            objBLT_Question = new DAT_Question(ID_Question, Question, A, B, C, D, Key_Question, Subject);
        }

        public BLT_Question(DataTable dt)
        {
            objBLT_Question = new DAT_Question(dt);
        }

        public DataTable GetQuestion_Subject()
        {
            return objBLT_Question.GetQuestion_Subject();
        }
        public DataTable GetQuestion_IDQuestion()
        {
            return objBLT_Question.GetQuestion_IDQuestion();
        }

        public bool Insert_Question()
        {
            return objBLT_Question.Insert_Question();
        }

        public bool Update_Question()
        {
            return objBLT_Question.Update_Question();
        }

        public bool Delete_Question()
        {
            return objBLT_Question.Delete_Question();
        }
    }
}
