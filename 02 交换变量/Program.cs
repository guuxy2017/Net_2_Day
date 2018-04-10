using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_交换变量
{
    class Program
    {
        static void Main(string[] args)
        {
            //1、交换两个类型的变量
           // int n1 = 10;  //定义int类型变量n1，并赋值10
           // int n2 = 20;  //定义int类型变量n2，并赋值20

           // int temp = n1;   //n1赋值给temp
           // n1 = n2;            //n2赋值给n1
           // n2 = temp;       //temp赋值给n2

           //// Console.WriteLine("交换后，n1的值是{0}，n2的值是{1}", n2, n1);
           // Console.WriteLine("n1={0}，n2={1}",n1,n2);
           // Console.ReadKey();

            //2、交换两个类型的变量，但是不能声明第三方变量
            int n1 = 10;  //定义int类型变量n1，并赋值10
            int n2 = 20;  //定义int类型变量n2，并赋值20
            n1 = n1 - n2;    //n1= -10  ,  n2=20
            n2 = n1 + n2;   //n1=  -10，n2=10
            n1 = n2 - n1;

            Console.WriteLine("交换后，n1={0}，n2={1}",n1,n2);
            Console.ReadKey();
        }
    }
}
