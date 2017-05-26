using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03显示实现接口
{
    class Program
    {
        static void Main(string[] args)
        {
            //IFace1 face1 = new Person();

            //face1.Fly();

            //IFace2 face2 = new Person();

            //face2.Fly();

            //Console.ReadKey();


            //========================

            Person p = new Person();
            p.Fly();//face1中的Fly()

            IFace1 f1 = new Person();
            f1.Fly();//face1中的Fly()

            IFace2 f2 = new Person();
            f2.Fly();//face2中的Fly()

            Console.ReadKey();



        }
    }

    public class Person : IFace1, IFace2
    {

        #region MyRegion

        //public void Fly()
        //{
        //    throw new NotImplementedException();
        //}


        ////实现接口的时候在方法名前面加    接口名.方法名()  就叫做显示实现接口。
        //void IFace1.Fly()
        //{
        //    throw new NotImplementedException();
        //}


        #endregion


        #region IFace1 成员

        public void Fly()
        {
            Console.WriteLine("实现了IFace1中的Fly方法。");
        }

        #endregion

        #region IFace2 成员

        //显示实现接口的访问修饰符默认是没有的，类中成员没有写访问修饰符这默认就是private 
        //显示实现接口是私有的所以必须通过接口名才能访问的到。
        void IFace2.Fly()
        {
            Console.WriteLine("实现了IFace2中的Fly方法。");
        }

        #endregion
    }


    public interface IFace1
    {
        void Fly();
    }


    public interface IFace2
    {
        void Fly();
    }
}
