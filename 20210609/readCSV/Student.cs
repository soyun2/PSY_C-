using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readCSV
{
    class Student
    {
        public Student(string name, int age, string hakbeon, string hakgwa)
        {
            this.name = name;
            this.age = age;
            this.hakbeon = hakbeon;
            this.hakgwa = hakgwa;
        } //생성자

        //이름, 나이, 학번, 학과
        public string name { get; set; }
        public int age;
        public string hakbeon;

        //c# 스타일 - getter, setter 설정
        private string hakgwa;
        public string _hakgwa
        {
            get { return hakgwa; }
            set { hakgwa = value; }
        }
    }
}
