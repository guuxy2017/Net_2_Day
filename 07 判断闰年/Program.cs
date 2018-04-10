using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_判断闰年
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个年份");
            int year = Convert.ToInt32(Console.ReadLine());

            bool b = (year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0));  // 年份能被400整除 ||  年份能被4整除 && 年份不能被100整除
            Console.WriteLine(b);
            Console.ReadKey();

        }
    }
}
