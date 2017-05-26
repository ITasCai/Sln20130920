using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _05异常
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 错误
            ////错误！
            ////1.语法错误。
            ////2.逻辑错误。
            ////int n = 100;
            ////int m = 100 - 50;
            ////Console.WriteLine(m);
            ////Console.ReadKey();



            ////3.运行时错误。
            //int apples = 100;
            //int m = 10;
            //m = m - 9 - 1;

            ////除数不能为0，如果为0，则报异常！！！
            //int r = apples / m;
            //Console.WriteLine(r);
            //Console.ReadKey();
            #endregion

            #region 异常处理


            //int apples = 100;
            //int m = 10;
            //m = m - 9 - 1;



            ////================== 写多个catch块==============================

            //try
            //{
            //    object o = null;
            //    Console.WriteLine(o.ToString());

            //    //除数不能为0，如果为0，则报异常！！！
            //    int r = apples / m;
            //    Console.WriteLine(r);
            //}
            //    //一个try块可以跟多个catch块，这样就可以对不同的异常进行不同的处理。最后可以再加一个catch,参数是Exception ，这样就可以把所有的异常都捕获到了。
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (FileNotFoundException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    //执行最终的善后处理，比如资源释放，因为无论程序执行是否发生异常都需要释放资源。
            //    Console.WriteLine("这里是finally中的代码1！！！");
            //}

            ////=============================================================








            //==========================================

            //try
            //{
            //    object o = null;
            //    Console.WriteLine(o.ToString());

            //    //除数不能为0，如果为0，则报异常！！！
            //    int r = apples / m;
            //    Console.WriteLine(r);
            //}
            //catch (Exception ex)
            //{
            //    //Exception是所有异常的祖宗类，当在catch中使用Exception的时候，无论什么类型的异常都可以捕获到。
            //    //对特定的异常进行的处理程序
            //    Console.WriteLine("异常了。。。" + ex.Message);
            //}
            //finally
            //{
            //    //执行最终的善后处理，比如资源释放，因为无论程序执行是否发生异常都需要释放资源。
            //    Console.WriteLine("这里是finally中的代码1！！！");
            //}

            //==========================================





            //=======================================
            //try
            //{
            //    //除数不能为0，如果为0，则报异常！！！
            //    int r = apples / m;
            //    Console.WriteLine(r);
            //}
            //catch
            //{
            //    //对特定的异常进行的处理程序
            //    Console.WriteLine("异常了。。。");
            //}
            //finally
            //{
            //    //执行最终的善后处理，比如资源释放，因为无论程序执行是否发生异常都需要释放资源。
            //    Console.WriteLine("这里是finally中的代码1！！！");
            //}
            //===========================================
            //Console.ReadKey();


            #endregion

            #region try-catch-finally使用结构
            //try
            //{
            //    //可能出现异常的代码！！
            //    //在try块中的代码，如果一旦某句代码发生了异常，这从该条语句直接跳转到catch 块中，在try 块中该条语句后续的代码不会继续执行了。
            //}
            //catch
            //{
            //    //当try块中的代码发生异常后，执行这里的代码
            //    //如果try块中的代码没有发生异常，这不会执行catch 块中的代码
            //}
            //finally
            //{
            //      //无论try块中的代码是否发生异常，都会执行这里的代码 
            //}

            #endregion


            ////M2();
            //while (true)
            //{
            //    Console.WriteLine("请输入一个姓名：");
            //    string name = Console.ReadLine();
            //    //一般最好使用if-else等这些逻辑判断，避免使用异常。使用异常效率不高。
            //    if (name.StartsWith("张"))
            //    {
            //        //手动抛出一个异常。 
            //        throw new Exception("不能是姓张的。");
            //    }
            //    else
            //    {
            //        Console.WriteLine("姓名是：" + name);
            //    }
            //}
            //Console.WriteLine("ok");
            //Console.ReadKey();


            int n = 10, m = 0;
            try
            {
                int r = n / m;
                Console.WriteLine(r);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                //Console.WriteLine("finally中的代码。。。。。。。。");
            }


            Console.WriteLine("finally中的代码。。。。。。。。");
            Console.ReadKey();

        }

        static void M2()
        {
            Console.WriteLine("==============");
            try
            {

                M1();
            }
            catch
            {
                Console.WriteLine("M2方法中的catch块。。。。");
                //throw;
            }
            Console.WriteLine("==============");
        }


        static void M1()
        {
            int n = 100, m = 0;
            try
            {
                int r = n / m;
                Console.WriteLine(r);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //这种用写法表示把当前异常样继续向上抛。
                //  throw;  这种写法只能在catch块中才能这么写。
                throw;
            }
            finally
            {
                //这里的代码能不能不写在finally中？ 
                //Console.WriteLine("M1方法的finally中的代码。。。");
            }

            //如果在catch块中使用了throw，则后面的代码如果不放在finally中，就不会执行。
            //Console.WriteLine("M1方法的finally中的代码。。。");
            //手动抛出一个异常。
            //throw new Exception();
        }
    }
}
