using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteXML
{
    class Student
    {
        public Student(string name, int age, string hakbeon, string hakgwa, string gender)
        {
            this.name = name;
            this.age = age;
            this.hakbeon = hakbeon;
            this.hakgwa = hakgwa;
            this.gender = gender;
        } //생성자

        //이름, 나이, 학번, 학과
        public string name { get; set; }
        public int age { get; set; }
        public string hakbeon { get; set; }
        //c# 스타일 - getter, setter 설정
        public string hakgwa { get; set; }
        public string gender { get; set; }
    }
}
