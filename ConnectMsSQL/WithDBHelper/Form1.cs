using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WithDBHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            DBSelect();
        }

        private void DBSelect()
        {
            DBHelper.Query_Select();
            dataGridView1.DataSource = DBHelper.ds;
            dataGridView1.DataMember = "TB_CUST";
        }

        private void button_insert_Click(object sender, EventArgs e)
        {

        }

        private void button_update_Click(object sender, EventArgs e)
        {

        }

        private void button_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
