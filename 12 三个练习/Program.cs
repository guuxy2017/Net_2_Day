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
            #endregion

            Console.WriteLine("请输入密码");
            string pwd = Console.ReadLine();

            if (pwd == "888888")
            {
                Console.WriteLine("密码正确");
            }
            else
            {
                Console.WriteLine("密码错误，请再次输入密码");
                pwd = Console.ReadLine();
                if (pwd == "888888")
                {
                    Console.WriteLine("密码正确");
                }
                else
                {
                    Console.WriteLine("白痴，2次都输错密码，程序退出");
                }
            }

            Console.ReadKey();

        }
    }
}
