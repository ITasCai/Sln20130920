using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06异常_观察代码
{
    class Program
    {
        static void Main(string[] args)
        {
            //T1();


            //int n = GetNumber();
            //Console.WriteLine("返回值：{0}", n);

            //当没有异常发生的时候，返回结果是101,并且finally中的代码执行了.
            //当发生异常的时候，返回结果是102,finally中的代码同样也执行了。
            //int r = M1();
            //Console.WriteLine(r);
            //Console.ReadKey();




            Person p1 = GetPerson();
            Console.WriteLine(p1.Age);//?????
            Console.ReadKey();
        }
        static Person GetPerson()
        {
            Person p = new Person();
            p.Age = 100;
            try
            {
                p.Age = p.Age + 1;
                //======引发异常的代码==========
                int x = 10, y = 0;
                Console.WriteLine(x / y);
                //======引发异常的代码==========
                return p;
            }
            catch (Exception)
            {
                p.Age = p.Age + 1;
                return p;
            }
            finally
            {
                p.Age = p.Age + 1;
            }
        }








        static int M1()
        {
            int result = 100;
            try
            {
                result = result + 1;
                //======引发异常的代码==========
                int x = 10, y = 0;
                Console.WriteLine(x / y);
                //======引发异常的代码==========
                return result;
            }
            catch
            {
                result = result + 1;
                return result;
            }
            finally
            {
                result = result + 1;
            }
        }








        static int GetNumber()
        {
            try
            {
                int n1 = 10;
                int n2 = 0;
                //======引发异常的代码==========
                int n3 = n1 / n2;
                //======引发异常的代码==========
                return 100;
            }
            catch (Exception ex)
            {
                Console.WriteLine("*******异常了*********");
                return 1000;
            }
            finally
            {
                Console.WriteLine("finally中的代码!!!!");
            }
        }



        static void T1()
        {
            try
            {
                Console.WriteLine("11111111111111111111");
                //====引发异常代码=====
                int n = 10, m = 0;
                Console.WriteLine(n / m);
                //====引发异常代码=====
                Console.WriteLine("★★★★★★★★★★★★★★");
                return;
                Console.WriteLine("22222222222222222222");
            }
            catch (Exception)
            {
                Console.WriteLine("33333333333333333333");
            }
            finally
            {
                //虽然try块中有return语句，但是finally中的代码依然会执行，并且是在return 语句之前执行的。
                Console.WriteLine("4444444444444444444444");
            }
        }

    }

    class Person
    {
        public int Age
        {
            get;
            set;
        }
    }
}
