using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace withDBHellper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dbHellper dh = new dbHellper();
            dh.ex1 = 100;
            dh.ex2 = 200;
            dh.example();
        }
        private void select()
        {
            dbHellper.Query_Select();
            dataGridView1.DataSource = dbHellper.ds;
            dataGridView1.DataMember = "TB_CUST";
        }
        private void btn_select_Click(object sender, EventArgs e)
        {
            select();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            dbHellper.Query_Add(textBox1.Text,textBox2.Text);
            select();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            dbHellper.Qurey_Update(textBox1.Text,textBox2.Text);
            select();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            dbHellper.Qurey_Delete(textBox1.Text);
            select();
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
