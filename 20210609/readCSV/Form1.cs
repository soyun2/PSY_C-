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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            new Form2().Show();
        }

        private void button_readcsv_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("test.csv", Encoding.GetEncoding("UTF-8"));

            label_contents.Text = reader.ReadLine() + Environment.NewLine;
            //label_contents.Text += reader.ReadLine();

            List<Student> students = new List<Student>();
            List<Student_Gridview> students_gridview = new List<Student_Gridview>();
            while (!reader.EndOfStream) //아무것도 없을 때까지 읽음
            {
                string[] temp = reader.ReadLine().Split(',');
                string name = temp[0];
                int age = int.Parse(temp[1]);
                string hakbeon = temp[2];
                string hakgwa = temp[3];
                Student stu = new Student(name, age, hakbeon, hakgwa);
                students.Add(stu);
                students_gridview.Add(new Student_Gridview(name, age, hakbeon, hakgwa));
            }
            reader.Dispose();
            dataGridView1.DataSource = students_gridview;

            for (int i = 0; i < students.Count; i++)
            {
                label_contents.Text += students[i].name + " " + students[i].age + Environment.NewLine;

            }
        }

        private void button_writeCSV_Click(object sender, EventArgs e)
        {
            string name = tB_name.Text;
            int age = int.Parse(tB_age.Text);
            string hakbeon = tB_hakbeon.Text;
            string hakgwa = tB_hakgwa.Text;

            using (StreamWriter writer = new StreamWriter("test.csv", true))
            {
                writer.WriteLine();
                writer.Write(name + "," + age + "," + hakbeon + "," + hakgwa);
            }
        }
    }
}
