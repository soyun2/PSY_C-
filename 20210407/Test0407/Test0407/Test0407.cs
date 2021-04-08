using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0407
{
    class Test0407
    {
        static void Main(string[] args)
        {
            //10진수를 입력받아 2진수로 출력하는 프로그램
            //1.입력받는 값의 범위는 1~65535까지
            //2.int 배열크기를 16으로 사용하여 한개의 공간에 이진수 0,1 저장
            //3.10진수값을 이진수로 변경할때 비트 범위에 맞게 출력-->8을 입력하면 00001000, 255를 입력하면 11111111
            //--> 256입력하면 0000000100000000
           
            Console.Write("숫자 입력 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int x = n;

            int[] ns = new int[16];
            
            for (int i=0;i<16;i++)
            {
                ns[i] = n % 2;
                n /= 2;
            }
            

            if (x < 256)
            {
                for (int j = 7; j>-1; j--)
                {
                    Console.Write(ns[j]);
                }
            }
            else {
                for(int j= 15; j>-1;j--)
                {
                    Console.Write(ns[j]);
                }
            }
            
        }

            
        
    }
}
