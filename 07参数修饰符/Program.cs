using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07参数修饰符
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 可变参数

            //// int r = Add(1, 2, 3, 4, 5, 6, 76, 78, 8);
            //int[] arr = new int[] { 1, 3, 5, 7, 9 };
            ////int r = Add(arr);
            //int r = Add(10, 10);
            //Console.WriteLine(r);
            //Console.ReadKey();

            //Console.WriteLine("{0}  {1}  {2}  {3}", 1, 2, 3, 4);
            //string.Format(
            #endregion

            #region ref

            ////int x = 10;
            //int x=100;
            ////ref参数在传递的时候必须为变量赋值。
            //M1(ref x);
            //Console.WriteLine(x);
            //Console.ReadKey();




            //int salary = 100000;

            //JiangJin(ref salary);

            //JiXiao(ref salary);

            //QuanQinJiang(ref salary);

            //ChiDao(ref salary);

            //Console.WriteLine(salary);
            //Console.ReadKey();



            #endregion



            #region out

            int n;
            //out参数在传递之前完全没有必要赋值，即便赋值了也没有任何意义，在方法中
            //使用之前必须重新赋值，才能使用，out参数无法将变量的值，从方法外面传递进来。
            TestOut(out n);
            Console.WriteLine(n);
            Console.ReadKey();

           //M2(

            #endregion

        }

        static void M2(int n)
        {
        }

        ////static void M2(ref int n)
        ////{

        ////}
        //static void M2(out int n)
        //{

        //}


        //out参数的主要作用就是，当方法有多个返回值的时候，可以通过out参数来获取方法的多个返回值。
        static void TestOut(out int m)
        {
            //既然out参数无法把方法外的变量值传递进来，所以在方法中必须为out参数赋值后才能使用
            //m = 100;
            //m = m + 100;

            //out参数要求在方法中必须为该参数赋值！！！！！
            m = 100;
        }

        private static void ChiDao(ref int salary)
        {
            salary = salary - 5 * 200;
        }

        private static void QuanQinJiang(ref int salary)
        {
            salary = salary + 500;
        }

        private static void JiXiao(ref int salary)
        {
            salary = salary + 300;
        }

        private static void JiangJin(ref int salary)
        {
            salary = salary + 10000;
        }

        static void M1(ref int n)
        {
            //在方法中可以直接使用ref变量的值，并且在方法中不为该变量赋值也是完全可以的。
            n++;
        }




        //如果传递多个参数，这每个参数都是nums数组中的一个元素，如果一个参数都不传递，这nums并不是null,而是一个长度为0的数组。
        //使用可变参数要注意：
        //1.参数使用pramas关键字修饰
        //2.参数的类型是一个数组类型
        //3.如果该方法有多个参数，这可变参数必须写在最后一个。
        //4.可变参数也可以直接传递一个数组进来。
        static int Add(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
        static int Add(int n1, int n2)
        {
            return n1 + n2;
        }
        static int Add(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

    }
}
