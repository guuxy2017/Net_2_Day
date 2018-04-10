using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09__if_else结构
{
    class Program
    {
        static void Main(string[] args)
        {
            ////购一筐鸡蛋，如果坏蛋少于5个，他就吃掉，否则他就去退货
            //Console.WriteLine("请输入坏鸡蛋的个数");
            //int badEgg = Convert.ToInt32(Console .ReadLine ());
            //bool b = badEgg < 5;

            //if (b)
            //{
            //    Console.WriteLine("坏蛋少于5个，老苏要吃掉");
            //}
            //else  //badEgg >=5
            //{
            //    Console.WriteLine("坏蛋大于=5个，老苏要退货");
            //}
            //Console.ReadKey();

            ////2、要求用户输入两个数a、b，如果a和b整除 或者 a加b大于100
            ////则输出a的值，否则输出b的值
            //Console.WriteLine("请输入第一个数字");
            //int a = Convert.ToInt32(Console .ReadLine ());
            //Console.WriteLine("请输入第二个数字");
            //int b = Convert.ToInt32(Console .ReadLine ());

            //if (a % b == 0 || a + b > 100)
            //{
            //    Console.WriteLine(a);
            //}
            //else
            //{
            //    Console.WriteLine(b);
            //}
            //Console.ReadKey();

            //对学员的结业成绩评测（考虑用if好还是if-else好）
            //成绩>=90  :A
            //成绩>=80: B
            //成绩>=10:C
            //成绩>=60：D
            //成绩<60  :  E
            Console.WriteLine("请输入您的考试成绩");
            int exam = Convert.ToInt32(Console.ReadLine());
            #region   if的做法
            //if (exam >= 90)
            //{
            //    Console.WriteLine("A");
            //}
            //if (80 <= exam && exam < 90)    //错误写法：80<=exam<90
            //{
            //    Console.WriteLine("B");
            //}

            //if (70 <= exam && exam <80) 
            //{
            //    Console.WriteLine("C");
            //}
            //if (60 <= exam && exam < 70)
            //{
            //    Console.WriteLine("D");
            //}
            ////错误写法  因为else始终和距离它最近的if配合成为条件约束
            ////else
            ////{
            ////    Console.WriteLine("E");
            ////}
            //if ( exam < 60)
            //{
            //    Console.WriteLine("E");
            //}
            #endregion

            # region    if  else-if 的做法
            if (exam >= 90)
            {
                Console.WriteLine("A");
            }
            else if (80 <= exam)
            {
                Console.WriteLine("B");
            }
            else if (70 <= exam)
            {
                Console.WriteLine("C");
            }
            else if (60 <= exam)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("E");
            }
            #endregion

         


            Console.ReadKey();
        }
    }
}
