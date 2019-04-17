using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Exam.DAT
{
    public class ConnectSQL
    {
        protected SqlConnection Connect = new SqlConnection(@"Data Source = MR-KHUYEN\SQLEXPRESS; Initial Catalog = SQL_TestExam; Integrated Security = True");

        //SQLCommandBuilder -> Insert, Update, Delete => Không lấy hết data
        //SQLAdapter -> Select (Query)

        //DataSet -> Trả về Table (Row, Columm)
        //DataTable -> Con của DataSet, chứa nhiều Table (Database hoàn chỉnh)

        protected DataTable GetTable(SqlCommand cmd) //Lấy Table bằng cách truyền câu lệnh cmd
        {
            DataTable Table = new DataTable();
            new SqlDataAdapter(cmd).Fill(Table);  //Đổ DataApter xuống Table
            return Table;
        }

        protected int UpdateTable(SqlCommand cmd, DataTable table) //Cập nhật Table
        {
            SqlDataAdapter update = new SqlDataAdapter(cmd);
            new SqlCommandBuilder(update);
            return update.Update(table);
        }
    }
}
