using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12_三个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习1：提示用户输入密码，如果密码是“88888”则提示正确，
            //否则要求再输入一次，如果密码是“88888”则提示正确，
            //否则提示错误,程序结束

            #region 自己做的
            //string pwd = "";
            ////bool b = true;
            //Console.WriteLine("请输入密码");
            // pwd = Convert .ToString( Console.ReadLine());
            //string pwd1 = Convert.ToString(88888);

            //if (pwd == pwd1)
            //{
            //    Console.WriteLine("密码正确");
            //}
            //else
            //{
            //    Console.WriteLine("错误密码，请重新输入密码！");
            //     pwd = Convert.ToString(Console.ReadLine());
            //     if (pwd == pwd1)
            //     {
            //         Console.WriteLine("密码正确");
            //     }
            //     else
            //     {
            //         Console.WriteLine("错误密码");
            //     }
            //}
            //Console.ReadKey();
            #endregion

            #region   赵老师做的
            //Console.WriteLine("请输入密码");
            //string pwd = Console.ReadLine();

            //if (pwd == "888888")
            //{
            //    Console.WriteLine("密码正确");
            //}
            //else
            //{
            //    Console.WriteLine("密码错误，请再次输入密码");
            //    pwd = Console.ReadLine();
            //    if (pwd == "888888")
            //    {
            //        Console.WriteLine("密码正确");
            //    }
            //    else
            //    {
            //        Console.WriteLine("白痴，2次都输错密码，程序退出");
            //    }
            //}
            //Console.ReadKey();
            #endregion

            ////  提示用户输入用户名，然后再提示输入密码，
            ////如果用户名是“admin”并且密码是“88888”，则提示正确，
            ////否则，如果用户名不是admin还提示用户用户名不存在,
            ////如果用户名是admin则提示密码错误.
            //Console.WriteLine("请输入用户名");
            //string name = Console.ReadLine();
            //Console.WriteLine("请输入密码");
            //string pwd = Console.ReadLine();

            #region  自己做
            ////if (name == "admin")
            ////{
            ////    if (pwd == "8888")
            ////    {
            ////        Console.WriteLine("输入正确");
            ////    }
            ////    else
            ////    {
            ////        Console.WriteLine("密码错误");
            ////    }
            ////}
            ////else 
            ////{
            ////    Console.WriteLine("用户名不存在");
            ////}
            #endregion

            #region  老师做
            ////if (name == "admin" && pwd =="888888")
            ////{
            ////     Console.WriteLine("输入正确");
            ////}
            ////else if (name == "admin")
            ////{
            ////     Console.WriteLine("密码错误");
            ////}
            ////else if (pwd == "888888")
            ////{
            ////    Console.WriteLine("用户名错误");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("未知错误");
            ////}
            #endregion
            //Console.ReadKey();

            //练习3：提示用户输入年龄，如果大于等于18，则告知用户可以查看，
            //如果小于10岁，则告知不允许查看，如果大于等于10岁并且小于18，
            //则提示用户是否继续查看（yes、no），如果输入的是yes则提示用户请查看，
            //否则提示"退出,你放弃查看"。
            Console.WriteLine("请输入您的年龄！");
            int age = Convert.ToInt32(Console.ReadLine());

            #region  自己做的方法
            if (age < 10)
            {
                Console.WriteLine("年龄小，不能看");
            }
            else if (age >= 18)
            {
                Console.WriteLine("可以查看");
            }
            else
            {
                Console.WriteLine("是否继续查看?（yes、no）");
                string input = Console.ReadLine();
                if (input == "yes")
                {
                    Console.WriteLine("请查看");
                }
                if (input == "no")
                {
                    Console.WriteLine("退出,你放弃查看");
                }
            }
            #endregion

            Console.ReadKey();
        }
    }
}
