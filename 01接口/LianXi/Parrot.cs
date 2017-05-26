using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01接口.LianXi
{
    public class Parrot : Bird, IFlyable
    {
        #region IFlyable 成员

        public void Fly()
        {
            Console.WriteLine("鹦鹉飞。。");
        }

        #endregion
    }
}
