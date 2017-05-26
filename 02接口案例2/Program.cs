using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _02接口案例2.LianXi;

namespace _02接口案例2
{
    class Program
    {
        static void Main(string[] args)
        {

            //House house = new House();


            //DengJi(house);
            //DengJi(new Chinese());


            IBarkable bark = new RubberDuck(); //new RealDuck();
            bark.Bark();

            Console.ReadKey();
        }



        static void DengJi(IIntroduce djObj)
        {
            djObj.Introduce();
        }



        //static void DengJi(Person person)
        //{
        //    person.Introduce();
        //}


        //static void DengJi(Chinese cn)
        //{

        //}
        //static void DengJi(American us)
        //{

        //}
        //static void DengJi(British uk)
        //{

        //}
    }

    class House : IIntroduce
    {

        #region IIntroduce 成员

        public void Introduce()
        {
            Console.WriteLine("房子的详细信息");
        }

        #endregion
    }

    //// Person类实现了IIntroduce接口，并且把接口中的Introduce()方法实现成虚方法，所以继承Person类的子类就可以重写该方法了。
    //class Person : IIntroduce
    //{
    //    public virtual void Introduce()
    //    {

    //    }
    //}

    // 
    class Person : IIntroduce
    {
        public virtual void Introduce()
        {

        }
    }

    class Chinese : Person, IIntroduce
    {
        public override void Introduce()
        {
            Console.WriteLine("我的户口，身份证号码");
        }
    }

    class American : Person, IIntroduce
    {
        public override void Introduce()
        {
            Console.WriteLine("社会保险号：00000");
        }
    }

    class British : Person, IIntroduce
    {
        public override void Introduce()
        {
            Console.WriteLine(".......;");
        }
    }

    public interface IIntroduce
    {
        /// <summary>
        /// 介绍说明自己的情况
        /// </summary>
        void Introduce();
    }
}
