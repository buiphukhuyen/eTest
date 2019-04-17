using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Exam.DAT
{
    public class DAT_Admin : ConnectSQL
    {
        private string id, password;
        private DataTable dt;

        public DAT_Admin(string id, string password)
        {
            this.id = id;
            this.password = password;
        }
        public DAT_Admin(string password)
        {
            this.password = password;
        }

        public DAT_Admin(DataTable dt)
        {
            this.dt = dt;
        }
        

        //Truy vấn kiểm tra Người dùng có tồn tại trên Database hay không?
        public bool TrueLogin()
        {
            SqlCommand cmd =
                new SqlCommand("Select * From Login Where ID = @ID And Password = @Password", Connect);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@Password", password);
            return GetTable(cmd).Rows.Count > 0;
        }

        //Truy vấn Cập nhật Mật khẩu Admin
        public bool ChangePassword()
        {
            SqlCommand cmd = new SqlCommand("UPDATE LOGIN SET Password = @Password", Connect);
            cmd.Parameters.AddWithValue("@Password", password);
            return GetTable(cmd).Rows.Count == 0;
        }

    }
}
