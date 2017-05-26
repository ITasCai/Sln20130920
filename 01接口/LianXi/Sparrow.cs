using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01接口.LianXi
{
    /// <summary>
    /// 麻雀类
    /// </summary>
    class Sparrow : Bird, IFlyable
    {
        #region IFlyable 成员

        public void Fly()
        {
            Console.WriteLine("麻雀飞上青天！");
        }

        #endregion
    }
}
