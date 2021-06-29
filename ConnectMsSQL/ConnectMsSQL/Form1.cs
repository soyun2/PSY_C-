using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectMsSQL
{
    public partial class Form1 : Form
    {
        public SqlConnection conn;
        
        private void ConnectDB()
        {
            string connect = string.Format("Data Source=({0}); " +
                "Initial Catalog = {1};" +
                "Integrated Security = {2};" +
                "Timeout = 3",
                "local", "MYDB1", "SSPI");
            conn = new SqlConnection(connect);
            conn.Open();
        }

        private void Query_Select()
        {
            ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn; //DB 접속 정보 추가
            //테이블에 날릴 쿼리 추가
            cmd.CommandText = "select * from TB_CUST";

            //DB 접속해서 쿼리 날려서 결과값으로 받은 테이블 관련 정보
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "TB_CUST"); //da를 통하여 ds에 테이블 데이터를 넣는다.

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "TB_CUST";

            conn.Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            Query_Select();
        }

        private void Query_Insert()
        {
            ConnectDB();

            string sqlcommand = "Insert Into TB_CUST(CUST_ID, BIRTH_DT) values (@p1, @p2)";
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox2.Text);
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            Query_Insert();
            Query_Select();
        }

        private void Query_Update()
        {
            ConnectDB();

            string sqlcommand = "Update TB_CUST set CUST_ID=@p1, BIRTH_DT = @p2 where CUST_ID = @p3";
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox2.Text);
            cmd.Parameters.AddWithValue("@p3", textBox1.Text);
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            Query_Update();
            Query_Select();
        }

        private void Query_Delete()
        {
            ConnectDB();

            string sqlcommand = "Delete TB_CUST where CUST_ID = @p1";
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            Query_Delete();
            Query_Select();
        }
    }
}
