using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Exam;
using System.Data;
using System.Data.SqlClient;

namespace Test_Exam.DAT
{
    public class DAT_Class : ConnectSQL
    {
        private string Name_Class, Name_Major;
        private DataTable dt;

        public DAT_Class() { }
        public DAT_Class(string Name_Class)
        {
            this.Name_Class = Name_Class;
        }

        public DAT_Class(string Name_Class, string Name_Major)
        {
            this.Name_Class = Name_Class;
            this.Name_Major = Name_Major;
        }

        public DAT_Class(DataTable dt)
        {
            this.dt = dt;
        }

        public DataTable GetAllClass()
        {
            return GetTable(new SqlCommand("SELECT Name_Class AS [TÊN LỚP], Name_Major AS [TÊN KHOA] FROM CLASS",Connect));
        }


        public bool Insert_Class()
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Class(Name_Class, Name_Major) VALUES (@Name_Class, @Name_Major)", Connect);
            cmd.Parameters.AddWithValue("@Name_Class", Name_Class);
            cmd.Parameters.AddWithValue("@Name_Major", Name_Major);
            return GetTable(cmd).Rows.Count == 0;
        }

        public bool Update_Class()
        {
            SqlCommand cmd = new SqlCommand("UPDATE Class SET Name_Major = @Name_Major WHERE Name_Class = @Name_Class",Connect);
            cmd.Parameters.AddWithValue("@Name_Class", Name_Class);
            cmd.Parameters.AddWithValue("@Name_Major", Name_Major);
            return GetTable(cmd).Rows.Count == 0;
        }

        public bool Delete_Class()
        {
                SqlCommand cmd = new SqlCommand("DELETE Class WHERE Name_Class = @Name_Class", Connect);
                cmd.Parameters.AddWithValue("@Name_Class", Name_Class);
                return GetTable(cmd).Rows.Count == 0;
        }
    }
}
