using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Test_Exam.DAT
{
    public class DAT_Question : ConnectSQL
    {
        private string ID_Question, Question, A, B, C, D, Key_Question, Subject;
        private DataTable dt;

        public DAT_Question() { }
        public DAT_Question(string Subject, string ID_Question)
        {
            this.ID_Question = ID_Question;
            this.Subject = Subject;
        }

        public DAT_Question(string ID_Question, string Question, string A, string B, string C, string D, string Key_Question, string Subject)
        {
            this.ID_Question = ID_Question;
            this.Question = Question;
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.Key_Question = Key_Question;
            this.Subject = Subject;
        }

        public DAT_Question(DataTable dt)
        {
            this.dt = dt;
        }

        public DataTable GetQuestion_Subject()
        {
            SqlCommand cmd = new SqlCommand("SELECT ID_Question [MÃ CÂU HỎI], Question [CÂU HỎI], Key_Question [ĐÁP ÁN] FROM Question WHERE Subject = @Subject", Connect);
            cmd.Parameters.AddWithValue("@Subject", Subject);
            return GetTable(cmd);
        }

        public DataTable GetQuestion_IDQuestion()
        {
            SqlCommand cmd = new SqlCommand("SELECT ID_Question [MÃ CÂU HỎI], Question [CÂU HỎI], A, B, C, D, Key_Question [ĐÁP ÁN], Subject [MÃ HỌC PHẦN]  FROM Question WHERE ID_Question = @ID_Question", Connect);
            cmd.Parameters.AddWithValue("@ID_Question", ID_Question);
            return GetTable(cmd);
        }

        public bool Insert_Question()
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Question(ID_Question, Question, A, B, C, D, Key_Question, Subject) VALUES(@ID_Question, @Question, @A, @B, @C, @D, @Key_Question, @Subject)", Connect);
            cmd.Parameters.AddWithValue("@ID_Question", ID_Question);
            cmd.Parameters.AddWithValue("@Question", Question);
            cmd.Parameters.AddWithValue("@A", A);
            cmd.Parameters.AddWithValue("@B", B);
            cmd.Parameters.AddWithValue("@C", C);
            cmd.Parameters.AddWithValue("@D", D);
            cmd.Parameters.AddWithValue("@Key_Question", Key_Question);
            cmd.Parameters.AddWithValue("@Subject", Subject);

            return GetTable(cmd).Rows.Count == 0;
        }

        public bool Update_Question()
        {
            SqlCommand cmd = new SqlCommand("UPDATE Question SET Question = @Question, A = @A, B = @B, C = @C, D = @D, Key_Question = @Key_Question, Subject = @Subject WHERE ID_Question = @ID_Question", Connect);
            cmd.Parameters.AddWithValue("@ID_Question", ID_Question);
            cmd.Parameters.AddWithValue("@Question", Question);
            cmd.Parameters.AddWithValue("@A", A);
            cmd.Parameters.AddWithValue("@B", B);
            cmd.Parameters.AddWithValue("@C", C);
            cmd.Parameters.AddWithValue("@D", D);
            cmd.Parameters.AddWithValue("@Key_Question", Key_Question);
            cmd.Parameters.AddWithValue("@Subject", Subject);

            return GetTable(cmd).Rows.Count == 0;
        }

        public bool Delete_Question()
        {
            SqlCommand cmd = new SqlCommand("DELETE Question WHERE ID_Question = @ID_Question", Connect);
            cmd.Parameters.AddWithValue("@ID_Question", ID_Question);
            return GetTable(cmd).Rows.Count == 0;
        }
    }
}
