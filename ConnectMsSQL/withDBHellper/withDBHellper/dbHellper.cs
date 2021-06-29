using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace withDBHellper
{
    public class dbHellper
    {
        public static SqlDataAdapter da;
        public static SqlConnection conn;
        public static DataSet ds;
        public static DataTable dt;

        public int ex1;
        public int ex2;
        public void example()
        {
            System.Windows.Forms.MessageBox.Show("Test");
        }
        public dbHellper instance;

        public dbHellper getInstance()
        {
            if (instance == null)
                instance = new dbHellper();

            return instance;
        }
        public static void conDB()
        {

            string connect = string.Format("Data Source=({0});" +
                "Initial Catalog = {1};" +
                "Integrated Security = {2};" +
                "Timeout = 3",
                "local", "MYDB1", "SSPI");
            conn = new SqlConnection(connect);
            conn.Open();
        }
        public static void Query_Select()
        {
            conDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;// DB 접속 정보 추가
            cmd.CommandText = "select * from TB_CUST"; //DB에 날릴 쿼리문

            da = new SqlDataAdapter(cmd); //DB에 쿼리날려서 받은 테이블 관련 정보
            ds = new DataSet();
            da.Fill(ds, "TB_CUST");
            //dataGridView1.DataSource = ds;
            //dataGridView1.DataMember = "TB_CUST";

            conn.Close();
        }
        public static void Query_Add(string id, string dt)
        {
            conDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;// DB 접속 정보 추가
            cmd.CommandText = "insert into TB_CUST(CUST_ID,BIRTH_DT) values (@p1, @p2)"; //DB에 날릴 쿼리문
            cmd.Parameters.AddWithValue("@p1", id);
            cmd.Parameters.AddWithValue("@p2", dt);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public static void Qurey_Update(string id, string dt)
        {
            conDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;// DB 접속 정보 추가
            cmd.CommandText = "UPDATE TB_CUST SET CUST_ID = @p1,BIRTH_DT = @p2 WHERE CUST_ID = @p3"; //DB에 날릴 쿼리문
            cmd.Parameters.AddWithValue("@p1", id);
            cmd.Parameters.AddWithValue("@p2", dt);
            cmd.Parameters.AddWithValue("@p3", id);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public static void Qurey_Delete(string id)
        {
            conDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;// DB 접속 정보 추가
            cmd.CommandText = "DELETE TB_CUST WHERE CUST_ID = @p1"; //DB에 날릴 쿼리문
            cmd.Parameters.AddWithValue("@p1", id);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
