using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02接口案例2.LianXi
{
    public class Duck
    {
        public void Swim()
        {
            Console.WriteLine("鸭子水上漂....");
        }
    }


    public class RealDuck : Duck, IBarkable
    {

        #region IBarkable 成员

        public void Bark()
        {
            Console.WriteLine("嘎嘎叫！！！！");
        }

        #endregion
    }

    public class WoodDuck : Duck
    {

    }

    public class RubberDuck : Duck, IBarkable
    {

        #region IBarkable 成员

        public void Bark()
        {
            Console.WriteLine("唧唧叫！！！！！");
        }

        #endregion
    }


    /// <summary>
    /// “叫”的接口
    /// </summary>
    public interface IBarkable
    {
        void Bark();
    }
}
