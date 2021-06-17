using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace readCSV
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("daegu.csv", Encoding.GetEncoding("UTF-8"));

            List<Daegu> daegu = new List<Daegu>();
            reader.ReadLine();
            while (!reader.EndOfStream) //아무것도 없을 때까지 읽음
            {
                string[] temp = reader.ReadLine().Split('|');
                string name = temp[1];
                string upjong = temp[4];
                string sido = temp[12];
                string jibun = temp[24];
                daegu.Add(new Daegu(name, upjong, sido, jibun));
            }
            reader.Dispose();
            dataGridView1.DataSource = daegu;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
