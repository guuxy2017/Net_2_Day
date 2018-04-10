using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11_try_catch异常捕获
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;   //预设值
            bool b = true;

            Console.WriteLine("请输入一个数字");

            //错误写法
            //try
            //{
            //    int number = Convert.ToInt32(Console.ReadLine());  //变量作用域不对
            //}
            //catch
            //{

            //    Console.WriteLine("您输入的字符串不能转化成数字，程序退出");
            //}

            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("你看我执行不执行！");
            }
            catch
            {
                Console.WriteLine("您输入的字符串不能转化成数字，程序退出");
                b = false;
            }

            if (b)
            {
                Console.WriteLine("您输入的数字是{0}", number);
            }

            Console.ReadKey();

        }
    }
}
