using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jsonAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            chart1.Series[0].Name = "성적";
            for (int i = 1; i <= 10; i++)
            {
                //chart1.Series[0].Points.AddXY(i, i * 10);
                chart1.Series["성적"].Points.AddXY(i, i * 10);
            }
            chart1.Series.Add("나이");
            for (int i = 1; i <= 10; i++)
            {
                chart1.Series[1].Points.AddXY(i, i * 10);
            }
        }

        private void button_write_Click(object sender, EventArgs e)
        {
            var jDoctorArray = new JArray();
            var jDoctorObject = new JObject();

            try
            {
                //방법 1. 버튼 강제 클릭
                //button_read.PerformClick();
                //방법 2. 함수 호출
                load();
            }
            catch (Exception ex)
            {
            }

            //만약에 doctors 안에 아무것도 없다면 이 작업할 필요 없음
            if(doctors.Count > 0)
            {
                foreach(var item in doctors)
                {
                    jDoctorObject = new JObject(); //값 초기화
                    jDoctorObject.Add("name", item.name);
                    jDoctorObject.Add("sabeon", item.sabeon);
                    jDoctorArray.Add(jDoctorObject);
                }
            }
            jDoctorObject = new JObject(); //값 초기화
            jDoctorObject.Add("name", textBox_name.Text);
            jDoctorObject.Add("sabeon", textBox_sabeon.Text);

            jDoctorArray.Add(jDoctorObject);

            var jDoctorArray_object = new JObject();
            jDoctorArray_object.Add("doctor", jDoctorArray);

            var jDoctors_object = new JObject();
            jDoctors_object.Add("doctors", jDoctorArray_object);

            //만약 특정 폴더에 넣고 싶은데 그게 없는 경우

            DirectoryInfo di = new DirectoryInfo("jsonEx");
            if (!di.Exists) //해당 폴더가 없는 경우
                di.Create();  //폴더를 만든다

            //파일만 생성하고 싶을 때
            StreamWriter writer = File.CreateText("Doctors.json");
            writer.Dispose(); //메모리 해제

            File.WriteAllText(@"jsonEx\Doctors.json", jDoctors_object.ToString());
        }

        List<Doctor> doctors = new List<Doctor>();
        const string FILENAME = @"jsonEx\Doctors.json";
        private void button_read_Click(object sender, EventArgs e)
        {
            doctors.Clear();

            string source = File.ReadAllText(FILENAME);
            JObject jsonObjectDoctor = JObject.Parse(source);

            foreach (var item in jsonObjectDoctor["doctors"]["doctor"])
            {
                Doctor temp = new Doctor();
                temp.name = item["name"].ToString();
                temp.sabeon = item["sabeon"].ToString();
                doctors.Add(temp);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = doctors;

            //linq 문법 쓰는 방법(반복문 없이 SQL문과 유사하게 생긴 linq 사용) - 디버깅 하기 힘듬
            doctors.Clear();
            doctors = (from item in jsonObjectDoctor["doctors"]["doctor"]
                       select new Doctor()
                       {
                           name = item["name"].ToString(),
                           sabeon = item["sabeon"].ToString()
                       }).ToList<Doctor>();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = doctors;
        }

        private void load()
        {
            doctors.Clear();

            string source = File.ReadAllText(FILENAME);
            JObject jsonObjectDoctor = JObject.Parse(source);

            foreach (var item in jsonObjectDoctor["doctors"]["doctor"])
            {
                Doctor temp = new Doctor();
                temp.name = item["name"].ToString();
                temp.sabeon = item["sabeon"].ToString();
                doctors.Add(temp);
            }
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            //openFileDialog1.InitialDirectory = @"C:\Users\KB\Desktop\PSY\PSY_C-\jsonAPI\jsonAPI\bin\Debug";
            openFileDialog1.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);

            //필터 지정 가능 => "이름 | *.확장자" 방식으로 지정하기
            openFileDialog1.Filter = "json파일|*.json";
            openFileDialog1.Filter += "|소스파일|*.cs";

            string source = File.ReadAllText(FILENAME);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                source = File.ReadAllText(openFileDialog1.FileName);
            }
            JObject jsonObjectDoctor = JObject.Parse(source);

            foreach (var item in jsonObjectDoctor["doctors"]["doctor"])
            {
                Doctor temp = new Doctor();
                temp.name = item["name"].ToString();
                temp.sabeon = item["sabeon"].ToString();
                doctors.Add(temp);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = doctors;
        }

        private void button_json_api_Click(object sendor, EventArgs e)
        {
            int count = 860;
            string url = "https://www.dhlottery.co.kr/common.do?method=getLottoNumber&drwNo="+count;

            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(url);
                var jArray = JObject.Parse(json);

                foreach(var item in jArray)
                {
                    Console.WriteLine(item.Key);
                    Console.WriteLine(item.Value);
                }
                Console.WriteLine(jArray["totSellamnt"]);
                DisplayLotto();
            }
        }

        private void DisplayLotto()
        {
            List<Lotto> lottos = new List<Lotto>();
            int count = 960;
            while(true)
            {
                using (WebClient wc = new WebClient())
                {
                    var json = wc.DownloadString("https://www.dhlottery.co.kr/common.do?method=getLottoNumber&drwNo=" + count);
                    count++;  //960회차부터 최신회차까지 정보 제공

                    var jArray = JObject.Parse(json);

                    if (jArray["returnValue"].ToString() == "fail")
                    {
                        break; //while에 대한 break문
                    }
                    lottos.Add(new Lotto(jArray["drwtNo1"].ToString(), jArray["drwtNo2"].ToString(), jArray["drwtNo3"].ToString(),
                        jArray["drwtNo4"].ToString(), jArray["drwtNo5"].ToString(), jArray["drwtNo6"].ToString(), jArray["bnusNo"].ToString(),
                        jArray["drwNo"].ToString(), jArray["drwNoDate"].ToString()));                   
                }
            }
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = lottos;
        }
    }
}
