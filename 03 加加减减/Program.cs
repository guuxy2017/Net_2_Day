using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_加加减减
{
    class Program
    {
        static void Main(string[] args)
        {
            // int num = 10;
            //// num++;
            ////++num;    //num = num + 1
            // //num--;
            // --num;       
            //Console.WriteLine(num);
            //Console.ReadKey();

           // 前++；后++
            //int num = 10;
            ////int result = 10 + num++;
            //int result = 10 + ++num;
            //Console.WriteLine(num);
            //Console.WriteLine(result);
            //Console.ReadKey();
            //解释
            //int num = 10;
            //int result = 10 + num;
            //num++;


            ////前--；后--
            //int num = 10;
            ////int result = 20 - num--;
            //int result = 20 - --num;
            //Console.WriteLine(num);
            //Console.WriteLine(result);
            //Console.ReadKey();

            //int var1, var2 = 5, var3 = 6;
            //var1 = var2++ * --var3;    //var1= 5 * 5

            //Console.WriteLine(var1);
            //Console.ReadKey();

            int a = 5;
            int b = a++ + (++a) * 2 + ++a;
            //            5          7     *2       8
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();


        }
    }
}
