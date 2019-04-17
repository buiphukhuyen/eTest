using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Exam.DAT
{
    public class DAT_Subject : ConnectSQL
    {
        private DataTable dt; 
        private string ID_Subject, Name_Subject, Group_Subject;
        public DAT_Subject() { }

        public DAT_Subject(DataTable dt)
        {
            this.dt = dt;
        }

        public DAT_Subject(string ID_Subject)
        {
            this.ID_Subject = ID_Subject;
        }

        public DAT_Subject(string ID_Subject, string Name_Subject, string Group_Subject)
        {
            this.ID_Subject = ID_Subject;
            this.Name_Subject = Name_Subject;
            this.Group_Subject = Group_Subject;
        }

        public DataTable GetAllSubject()
        {
            return GetTable(new SqlCommand("SELECT ID_Subject AS [MÃ HỌC PHẦN], Name_Subject AS [TÊN HỌC PHẦN], Group_Subject AS [TÊN NHÓM] FROM SUBJECT", Connect));
        }

        public DataTable GetSubject_Group()
        {
            SqlCommand cmd = new SqlCommand("SELECT ID_Subject AS[MÃ HỌC PHẦN], Name_Subject AS[TÊN HỌC PHẦN], Group_Subject AS[TÊN NHÓM] FROM SUBJECT WHERE Group_Subject = @Group_Subject", Connect);
            cmd.Parameters.AddWithValue("@Group_Subject", Group_Subject);
            return GetTable(cmd);
        }

        public bool Insert_Subject()
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Subject(ID_Subject,Name_Subject, Group_Subject) VALUES (@ID_Subject, @Name_Subject, @Group_Subject)", Connect);
            cmd.Parameters.AddWithValue("@ID_Subject", ID_Subject);
            cmd.Parameters.AddWithValue("@Name_Subject", Name_Subject);
            cmd.Parameters.AddWithValue("@Group_Subject", Group_Subject);

            return GetTable(cmd).Rows.Count == 0;
        }

        public bool Edit_Subject()
        {
            SqlCommand cmd = new SqlCommand("UPDATE Subject SET Name_Subject = @Name_Subject, Group_Subject = @Group_Subject WHERE ID_Subject = @ID_Subject", Connect);
            cmd.Parameters.AddWithValue("@ID_Subject", ID_Subject);
            cmd.Parameters.AddWithValue("@Name_Subject", Name_Subject);
            cmd.Parameters.AddWithValue("@Group_Subject", Group_Subject);

            return GetTable(cmd).Rows.Count == 0;
        }

        public bool Delete_Subject()
        {
            SqlCommand cmd = new SqlCommand("DELETE Subject WHERE ID_Subject = @ID_Subject", Connect);
            cmd.Parameters.AddWithValue("@ID_Subject", ID_Subject);

            return GetTable(cmd).Rows.Count == 0;
        }

        
    }
}
