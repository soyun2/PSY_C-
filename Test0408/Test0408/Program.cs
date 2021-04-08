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
            /*Car car = new Car("K8","은색","KIA","5천만원");
            car.Model = "그랜저2020";
            Console.WriteLine("모델 = " + car.Model);
            car.printInfoCar();

            Car car2 = new Car();
            car2.Model = "그랜저2021";
            car2.printInfoCar();

            Console.WriteLine(new Car("G80", "black", "hyundai", "7천").ToString());*/

            menuMain();
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 3)
            {
                Environment.Exit(0);
            }
            else if(n==2)
            {
                Console.WriteLine("출력 메뉴입니다.");
                Console.WriteLine("출력하고 싶은 학생의 이름을 입력하세요 : ");
                string stu = Console.ReadLine();

            }

            Random r = new Random();
            string[] name = { "홍길동", "김길동", "박길동", "최길동", "이길동" };
            int[] age = { 30, 40, 50, 60, 70 };
            char[] gender = { '남','여' };
            string[] tel = { "010-1111-1111", "010-2222-2222", "010-3333-3333", "010-3333-3334", "010-3333-3335" };
            string[] addr = { "대구시", "부산시", "서울시", "경산시", "대전시" };

            Student[] st = new Student[10];
            for(int i =0; i<10;i++)
            {
                st[i]=new Student(name[r.Next(5)], age[r.Next(5)], gender[r.Next(2)],tel[r.Next(5)],addr[r.Next(5)]);
                Console.Write((i+1)+"번째 학생 = 이름 : " + st[i].Name + " 나이 : " + st[i].Age + " 성별 : " + st[i].Gender + " 전화번호 : " + st[i].Tel + " 주소 : " + st[i].Addr);
                Console.WriteLine();
            }
        }
        public static void printInfo()
        {
            Console.Write("이름 : " + st[0] + " 나이 : " + st[1] + " 성별 : " + st[2] + " 전화번호 : " + st[3] + " 주소 : " + st[i].Addr);
            Console.WriteLine();
        }
        public static void menuMain()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("학생관리프로그램 v1.0");
            Console.WriteLine("---------------------");
            Console.WriteLine("1.학생정보 생성");
            Console.WriteLine("2.학생정보 출력");
            Console.WriteLine("3.종료");
            Console.WriteLine("---------------------");
        }
    }
}
