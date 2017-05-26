using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _01接口.LianXi;

namespace _01接口
{
    class Program
    {
        static void Main(string[] args)
        {
            //IFlyable sp = new SupperMan();
            //sp.Fly();
            //sp.Jump();
            //Console.ReadKey();

            _01接口.LianXi.IFlyable fly = new Parrot();
            fly.Fly();
        }
    }


    public interface IUSB
    {
        void Read();

        void Write();
    }

    public class USBDisk : IUSB
    {

        #region IUSB 成员

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Write()
        {
            throw new NotImplementedException();
        }

        #endregion
    }



    public class Computer
    {


        public void DDDD()
        {


            //IUSB usb=....;
            //usb.Read();
        }


    }







    class Person
    {

    }

    //当一个类继承了某个父类，并且实现了多个接口的时候，被继承的父类必须写在继承列表中的第一个位置。
    class Student : Person, IFlyable, ICloneable
    {

        #region ICloneable 成员

        public object Clone()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IFlyable 成员

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Jump()
        {
            throw new NotImplementedException();
        }

        #endregion
    }



    //使用抽象类与虚方法已经完全可以实现多态了，为什么还要用接口来实现多态？
    //什么情况下需要使用接口来实现多态？
    //1>当多个类型不能抽象出合理的父类的时候，但是又要对某些方法进行多态，此时可以考虑使用接口来实现多态。即吧公共的方法抽象到一个接口中，然后让不同的子类实现该接口
    //2>因为接口可以多实现，所以解决了类的单继承问题，当一个类需要同时“继承”多个类的行为时，可以考虑使用接口来进行多实现。







    //定义一个接口
    //定义接口使用interface 关键字
    //一般接口名要以大写I开头
    //接口中只能包含方法【属性、事件、索引器最终都是方法，所以可以说接口中只能包含方法】
    //接口中的成员不能有任何访问修饰符，默认是public,如果手动写了访问修饰符这报错！！！！
    //接口中的成员不能有任何实现，就像抽象方法一样不能有实现
    public interface IFlyable
    {
        void Fly();


        void Jump();
    }




    //定义一个类来实现该接口
    //实现接口的类，必须将接口中的所有成员都实现
    //实现接口的类直接实现接口中的方法即可，无需使用override 关键字。


    public class SupperMan : IFlyable
    {

        #region IFlyable 成员

        public void Fly()
        {
            Console.WriteLine("超人在飞.....");
        }

        public void Jump()
        {
            Console.WriteLine("超人在跳。。。。");
        }

        #endregion
    }



    public class SpiderMan : IFlyable, IFormattable, IDisposable, ICloneable
    {

        #region IFlyable 成员

        public void Fly()
        {
            Console.WriteLine("蜘蛛侠在飞。。。");
        }

        public void Jump()
        {
            Console.WriteLine("蜘蛛侠在跳。。。");
        }

        #endregion

        #region IFormattable 成员

        public string ToString(string format, IFormatProvider formatProvider)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IDisposable 成员

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region ICloneable 成员

        public object Clone()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
