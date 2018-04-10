using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_计算3个整数之间的最大值
{
    class Program
    {
        static void Main(string[] args)
        {
            //计算2个数字之间的最大值
            //计算三个数字之间的最大值，不考虑相等
            Console.WriteLine("请输入第一个数字");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第 2 个数字");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第 3 个数字");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("最大值是{0}", a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("最大值是{0}", b);
            }
            else
            {
                Console.WriteLine("最大值是{0}", c);
            }

            //if (a > b)
            //{
            //    if (a > c)
            //    {
            //        Console.WriteLine("最大值是{0}", a);
            //    }
            //}
            //else
            //{
            //    if (b > c)
            //    {
            //        Console.WriteLine("最大值是{0}", b);
            //    }
            //    else
            //    {
            //        Console.WriteLine("最大值是{0}", c);
            //    }
            //}
            Console.ReadKey();
        }
    }
}
