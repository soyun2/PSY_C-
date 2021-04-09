using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0409.Model
{
    class Seller
    {
        private string name;
        private string empid;
        private string tel;
        private string dep;

        public Seller(string name, string empid, string tel, string dep)
        {
            this.name = name;
            this.empid = empid;
            this.tel = tel;
            this.dep = dep;
        }

        public string Name { get => name; set => name = value; }
        public string Empid { get => empid; set => empid = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Dep { get => dep; set => dep = value; }

        public void SellerInfor()
        {
            Console.WriteLine("이름 = " + name);
            Console.WriteLine("사번 = " + empid);
            Console.WriteLine("전화번호 = " + tel);
            Console.WriteLine("소속 = " + dep);
            Console.WriteLine();
        }
        public override string ToString()
        {
            string data = "이름 : " + name + "\n";
            data += "사번 : " + empid + "\n";
            data += "전화번호 : " + tel + "\n";
            data += "소속 : " + dep + "\n";
            return data;
        }
    }
}
