﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readCSV
{
    class Student_Gridview
    {
        public Student_Gridview(string name, int age, string hakbeon, string hakgwa)
        {
            this.name = name;
            this.age = age;
            this.hakbeon = hakbeon;
            this.hakgwa = hakgwa;
        }
        public string name { get; set; }
        public int age { get; set; }
        public string hakbeon { get; set; }
        public string hakgwa { get; set; }
    }
}