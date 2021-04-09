using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0409.Util
{    
    class RandData
    {
        Random r = new Random();

        static string[] name = { "홍길동", "김길동", "정길동", "박길동", "이길동" };
        static int[] age = { 10, 15, 20, 25, 30 };
        static string[] tel = { "010-111-1111", "010-222-2222", "010-333-3333", "010-444-4444", "010-555-5555" };
        static char[] gender = { '남', '여' };
        static string[] address = { "대구시", "서울시", "광주시", "대전시", "제주시" };

        static string[] empid = { "A01", "B01", "C01", "D01", "E01" };
        static string[] dep = { "영업1팀", "영업2팀", "영업3팀", "영업4팀", "영업5팀" };

        static string[] model = { "모닝", "아반떼", "소나타", "그랜저", "제네시스" };
        static string[] color = { "흰색", "검정색", "실버", "골드", "레드" };
        static string[] company = { "현대", "기아" };
        static string[] price = { "1천만원대", "2천만원대", "3천만원대", "4천만원대", "5천만원대" };

        public string getName()
        {
            return name[r.Next(5)];
        }
        public int getAge()
        {
            return age[r.Next(5)];
        }
        public string getTel()
        {
            return tel[r.Next(5)];
        }
        public char getGender()
        {
            return gender[r.Next(2)];
        }
        public string getAddress()
        {
            return address[r.Next(5)];
        }
        public string getEmpid()
        {
            return empid[r.Next(5)];
        }
        public string getDep()
        {
            return dep[r.Next(5)];
        }
        public string getModel()
        {
            return model[r.Next(5)];
        }
        public string getColor()
        {
            return color[r.Next(5)];
        }
        public string getCompany()
        {
            return company[r.Next(2)];
        }
        public string getPrice()
        {
            return price[r.Next(5)];
        }
    }
    
}
