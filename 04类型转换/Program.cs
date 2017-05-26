using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04类型转换
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 类型转换

            ////string msg = "123";
            ////int n = (int)msg;
            ////Console.WriteLine(n);
            ////Console.ReadKey();

            ////string msg = "123";
            ////int n = Convert.ToInt32(msg);
            ////Console.WriteLine(n);
            ////Console.ReadKey();


            ////double d = 10;
            ////Console.WriteLine(d.ToString());


            ////
            ////把任意的字符串转换为数字类型
            //string msg = "12345";
            ////int n = int.Parse(msg);
            //int n;
            //bool b = int.TryParse(msg, out n);
            //if (b)
            //{
            //    Console.WriteLine(n);
            //}
            //else
            //{
            //    Console.WriteLine("转换失败！");
            //}
            ////n++;
            ////Console.WriteLine(n);


            ////Convert.FromBase64CharArray 

            //Console.ReadKey();





            //Console.WriteLine(sizeof(bool));
            //Console.WriteLine(sizeof(byte));
            //Console.WriteLine(sizeof(short));
            //Console.WriteLine(sizeof(int));
            //Console.WriteLine(sizeof(long));
            //Console.WriteLine(sizeof(char));
            //Console.WriteLine(sizeof(float));
            //Console.WriteLine(sizeof(double));
            //Console.WriteLine(sizeof(decimal));
            //Console.ReadKey();

            //int n = 100;
            //char ch = (char)n;
            //Console.WriteLine(ch);
            //Console.ReadKey();

            //char ch='赵';
            //int n = ch;
            //Console.WriteLine(n);
            //Console.ReadKey();



            //int n = 10;
            //double d = n;

            //Console.WriteLine(d);


            //int m = (int)d;
            //Console.WriteLine(m);
            //Console.ReadKey();
            #endregion


            #region MyRegion

            ////Person p = new DingZhouRen();
            ////Console.ReadKey();

            //DingZhouRen dzr = new DingZhouRen();
            //Console.WriteLine(dzr.GetType().ToString());
            //Console.WriteLine(dzr.GetType().BaseType.ToString());
            //Console.WriteLine(dzr.GetType().BaseType.BaseType.ToString());
            //Console.WriteLine(dzr.GetType().BaseType.BaseType.BaseType.ToString());
            //Console.WriteLine(dzr.GetType().BaseType.BaseType.BaseType.BaseType.ToString());
            //Console.WriteLine(dzr.GetType().BaseType.BaseType.BaseType.BaseType.BaseType.ToString());
            //Console.WriteLine(dzr.GetType().BaseType.BaseType.BaseType.BaseType.BaseType.BaseType.ToString());
            //Console.ReadKey();

            Person p = new DingZhouRen();

            DingZhouRen dzr = p as DingZhouRen;
            if (dzr != null)
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("类型转换失败！");
            }



            //======================================================
            //if (p is DingZhouRen)
            //{
            //    DingZhouRen dzr = (DingZhouRen)p;
            //    Console.WriteLine("类型转换成功！");
            //}
            //else
            //{
            //    Console.WriteLine("无法进行类型转换！");
            //}
            //======================================================
            Console.ReadKey();

            #endregion

        }
    }

    class Person
    {

    }
    class Chinese : Person
    {

    }
    class HeBeiRen : Chinese
    {

    }

    class BaoDingRen : HeBeiRen
    {

    }
    class DingZhouRen : BaoDingRen
    {

    }


}
