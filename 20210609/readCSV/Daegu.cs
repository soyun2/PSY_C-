using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readCSV
{
    class Daegu
    {
        public Daegu(string name, string upjong, string sido, string jibun)
        {
            this.name = name;
            this.upjong = upjong;
            this.sido = sido;
            this.jibun = jibun;
        }
        public string name { get; set; }
        public string upjong { get; set; }
        public string sido { get; set; }
        public string jibun { get; set; }
    }
}
