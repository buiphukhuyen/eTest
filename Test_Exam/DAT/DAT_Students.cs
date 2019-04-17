using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Exam.DAT
{
    public class DAT_Students : ConnectSQL
    {
        private string ID_Student, Name_Class, Full_Name;
        private DataTable dt;

        public DAT_Students(string ID_Student)
        {
            this.ID_Student = ID_Student;
        }

        public DAT_Students(string ID_Student, string Name_Class)
        {
            this.ID_Student = ID_Student;
            this.Name_Class = Name_Class;
        }
        public DAT_Students(string ID_Student, string Full_Name ,string Name_Class)
        {
            this.ID_Student = ID_Student;
            this.Full_Name = Full_Name;
            this.Name_Class = Name_Class;
        }
        public DAT_Students(DataTable dt)
        {
            this.dt = dt;
        }

        public DAT_Students() { }


        public bool TrueLogin()
        {
            SqlCommand cmd =
                new SqlCommand("SELECT * FROM Students Where ID_Student = @ID_Student And Name_Class = @Name_Class", Connect);
            cmd.Parameters.AddWithValue("@ID_Student", ID_Student);
            cmd.Parameters.AddWithValue("@Name_Class", Name_Class);
            return GetTable(cmd).Rows.Count == 1;
        }

        public DataTable GetAllStudents()
        {
            return GetTable(new SqlCommand("SELECT ID_Student [MSSV], Full_Name [HỌ VÀ TÊN], Name_Class [TÊN LỚP] FROM Students", Connect));
        }

        public DataTable Get_Student()
        {
            SqlCommand cmd =  new SqlCommand("SELECT ID_Student [MSSV], Full_Name [HỌ VÀ TÊN], Name_Class [TÊN LỚP] FROM Students WHERE ID_Student = @ID_Student", Connect);
            cmd.Parameters.AddWithValue("@ID_Student", ID_Student);
            return GetTable(cmd);
        }
        public bool Insert_Student()
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Students(ID_Student, Full_Name, Name_Class) VALUES (@ID_Student, @Full_Name, @Name_Class)", Connect);
            cmd.Parameters.AddWithValue("@ID_Student", ID_Student);
            cmd.Parameters.AddWithValue("@Full_Name", Full_Name);
            cmd.Parameters.AddWithValue("@Name_Class", Name_Class);

            return GetTable(cmd).Rows.Count == 0;
        }

        public bool Edit_Student()
        {
            SqlCommand cmd = new SqlCommand("UPDATE Students SET Full_Name = @Full_Name, Name_Class = @Name_Class WHERE ID_Student = @ID_Student", Connect);
            cmd.Parameters.AddWithValue("@Full_Name", Full_Name);
            cmd.Parameters.AddWithValue("@Name_Class", Name_Class);
            cmd.Parameters.AddWithValue("@ID_Student", ID_Student);
            return GetTable(cmd).Rows.Count == 0;
        }

        public bool Delete_Student()
        {
            SqlCommand cmd = new SqlCommand("DELETE Students WHERE ID_Student = @ID_Student", Connect);
            cmd.Parameters.AddWithValue("@ID_Student", ID_Student);
            return GetTable(cmd).Rows.Count == 0;
        }
    }
}
