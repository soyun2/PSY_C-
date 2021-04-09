using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0408
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAIN_MENU_INSERT = 1;
            const int MAIN_MENU_VIEW = 2;
            const int MAIN_MENU_EXIT = 3;

            Random r = new Random();
            string[] name = {"홍길동", "김길동",
            "박길동", "최길동", "이길동"};
            int[] age = { 30, 40, 50, 60, 100 };
            char[] gender = { '남', '여' };
            string[] tel = {"010-1111-1111",
            "010-2222-2222", "010-2222-2233",
            "010-2222-2444","010-2222-2255"};
            string[] addr = {"서울 동구 신천2동",
            "대구 동구 신천2동", "부산 동구 신천2동",
            "대전 동구 신천2동","인천 동구 신천2동"};

            Student[] st = new Student[10];
            //List<Student> list = new List<Student>();            

            while (true)
            {
                switch (menuMain())
                {
                    case MAIN_MENU_INSERT:
                        createRandData(st, name, age,
                            gender, tel, addr, r);
                        break;
                    case MAIN_MENU_VIEW:
                        if (st != null)
                        {
                            dataView2(st);
                        }
                        break;
                    case MAIN_MENU_EXIT:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        public static int menuMain()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("학생 관리 프로그램 v1.0");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1. 학생정보 생성");
            Console.WriteLine("2. 학생정보 출력");
            Console.WriteLine("3. 종료");
            Console.WriteLine("-----------------------");
            Console.Write("메뉴 선택: ");
            int menu = Convert.ToInt32(Console.ReadLine());
            return menu;
        }

        public static void createRandData(Student[] st,
            string[] name, int[] age, char[] gender,
            string[] tel, string[] addr, Random r)
        {
            for (int i = 0; i < st.Length; i++)
            {
                st[i] = new Student(name[r.Next(5)],
                    age[r.Next(5)],
                    gender[r.Next(2)],
                    tel[r.Next(5)],
                    addr[r.Next(5)]);
            }
            Console.WriteLine("정상적으로 데이터가 생성되었습니다.");
        }
        public static void dataView(Student[] s)
        {
            try
            {
                for (int i = 0; i < s.Length; i++)
                {
                    s[i].studentInfo();
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("생성된 데이터가 없습니다.");
                Console.WriteLine(e.Message);
            }
        }

        public static void dataView2(Student[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                s[i].studentInfo();
            }
        }
    }
}