using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08__if结构
{
    class Program
    {
        static void Main(string[] args)
        {
            //让用户输入年龄，如果输入的年龄大于23（含）岁，则给用户显示您到了结婚的年龄了，
            //Console.WriteLine("请输入您的年龄");
            //int age = Convert.ToInt32(Console .ReadLine ());
            //bool  b = age >=23;

            //if (b)
            //{
            //    Console.WriteLine("您到了结婚的年龄");
            //}
            //Console.ReadKey();

            //Console.WriteLine("请输入语文成绩");
            //int chinese = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入您的音乐成绩");
            //int music = Convert.ToInt32(Console.ReadLine());

            //bool b = (chinese > 90 && music > 80) || (chinese == 100 && music > 70);

            //if (b)
            //{
            //    Console.WriteLine("奖励100元");
            //}
            //Console.ReadKey();

            //Console.WriteLine("请输入用户名");
            //string name = Console.ReadLine();
            //Console.WriteLine("请输入密码");
            //string passWord = Console.ReadLine();

            //bool b = (name == "admin") && (passWord == "mypass");
            //if (b)
            //{
            //    Console.WriteLine("登陆成功");
            //}
            //else
            //{
            //    Console.WriteLine("登录不成功");
            //}
            //Console.ReadKey();

            //编程实现：如果跪键盘时间大于60负分钟，那么媳妇奖励我玩法不用做了
            //if (Convert.ToInt32(Console.ReadLine()) > 60)
            //{
            //    Console.WriteLine("媳妇做晚饭！");
            //}
            //Console.ReadKey();

            Console.WriteLine("请输入您跪键盘的时间");
            int t = Convert.ToInt32(Console.ReadLine());
            bool b = t > 60;

            if (b) //  b == true  也可以写成b
            {
                Console.WriteLine("您跪键盘的时间超过{0},媳妇奖励你不用做饭了", t);
            }
            Console.ReadKey();

        }
    }
}
