using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06__逻辑运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //语文和数学成绩都大于90
            Console.WriteLine("请输入语文成绩");
            int chinese = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入数学成绩");
            int math = Convert.ToInt32(Console.ReadLine());

            //bool b = chinese > 90 && math > 90;
            //Console.WriteLine(b);
            //Console.ReadKey();


            //语文和数学成绩，有一门大于90
            bool b = chinese > 90 || math > 90;
            Console.WriteLine(b);
            Console.ReadKey();



        }
    }
}
