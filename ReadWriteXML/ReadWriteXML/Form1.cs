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
using System.Xml.Linq;

namespace ReadWriteXML
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_readXML_Click(object sender, EventArgs e)
        {
            try
            {
                string xmlfile = File.ReadAllText("student.xml");
                XElement student_xml = XElement.Parse(xmlfile);
                students.Clear();
                foreach (var item in student_xml.Descendants("student"))
                {
                    string name = item.Element("name").Value;
                    int age = int.Parse(item.Element("age").Value);
                    string hakbeon = item.Element("hakbeon").Value;
                    string hakgwa = item.Element("hakgwa").Value;
                    string gender = item.Element("gender").Value;

                    students.Add(new Student(name, age, hakbeon, hakgwa, gender));
                }
                dataGridView1.DataSource = students;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button_writeXML_Click(object sender, EventArgs e)
        {
            students.Add(new Student(tB_name.Text, int.Parse(tB_age.Text), tB_hakbeon.Text, tB_hakgwa.Text, cB_gender.Text));
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;

            string input = "<students>";
            foreach (var item in students)
            {
                input += "    <student>";
                input += $"     <name>{item.name}</name>{Environment.NewLine}";
                input += $"     <age>{item.age}</age>{Environment.NewLine}";
                input += $"     <hakbeon>{item.hakbeon}</hakbeon>{Environment.NewLine}";
                input += $"     <hakgwa>{item.hakgwa}</hakgwa>{Environment.NewLine}";
                input += $"     <gender>{item.gender}</gender>{Environment.NewLine}";
                input += "    </student>\n";
            }
            input += "</students>";
            File.WriteAllText("student.xml", input);
        }     

        private void button_API_Click_1(object sender, EventArgs e)
        {
            string url = $"http://apis.data.go.kr/1470000/DURIrdntInfoService/getUsjntTabooInfoList";
            string myKey = "UjDht29yDmUGSzh9R4AYLbxgTrTSx285gfzWLazEoj17hfOBaOqv162EmbZa3LrZLBNPBK31HfoHWkYMGD2xJQ%3D%3D";
            //?ServiceKey=서비스키(URL Encode)&numOfRows=3&pageNo=1
            url += "?ServiceKey=" + myKey;
            url += "&numOfRows=3";

            XElement api = XElement.Load(url);
            List<Drug> drugs = new List<Drug>();

            foreach (var item in api.Descendants("item"))
            {
                string item_name = item.Element("ITEM_NAME").Value;
                string item_seq = item.Element("ITEM_SEQ").Value;
                string entp = item.Element("ENTP_NAME").Value;

                drugs.Add(new Drug(item_name, item_seq, entp));
            }
            dataGridView2.DataSource = drugs;
        }
    }
}