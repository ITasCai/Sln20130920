using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08ref与out练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  案例1：两个int变量的交换,用方法做。ref

            //int n1 = 10, n2 = 20;
            //Swap(ref n1, ref n2);
            //Console.WriteLine("n1={0},n2={1}", n1, n2);
            //Console.ReadKey();

            #endregion

            #region 案例2：模拟登陆，返回登陆是否成功(bool)，如果登陆失败，提示用户是用户名错误还是密码错误”admin”,“888888”

            while (true)
            {
                Console.WriteLine("请输入用户名：");
                string loginId = Console.ReadLine();
                Console.WriteLine("请输入密码：");
                string loginPwd = Console.ReadLine();
                string message;
                bool isOk = CheckUserLogin(loginId, loginPwd, out message);
                Console.WriteLine("登录结果：{0}  提示消息：{1}", isOk, message);
            }

            #endregion

        }

        private static bool CheckUserLogin(string loginId, string loginPwd, out string message)
        {
            message = string.Empty;
            if (loginId == "admin" && loginPwd == "888888")
            {
                message = "登录成功！";
                return true;
            }
            else if (loginId == "admin")
            {
                message = "密码错误！";
                return false;
            }
            else
            {
                message = "用户名错误！";
                return false;
            }
        }

        private static void Swap(ref int n1, ref int n2)
        {
            int t = n1;
            n1 = n2;
            n2 = t;
        }
    }
}
