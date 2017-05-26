using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01接口.LianXi
{
    public interface ITest
    {

        void M1();

        int M2();

        string M3(string msg);


        //看起来就是一个“自动属性”，但是该属性出现在了接口中
        //所以编译器不会把该属性自动实现，所以必须交给实现该接口的类来实现该属性。
        string Name
        {
            get;
            set;
        }

        string this[int index]
        {
            get;
            set;
        }
    }

    public class TestClass : ITest
    {

        #region ITest 成员

        public void M1()
        {
            throw new NotImplementedException();
        }

        public int M2()
        {
            throw new NotImplementedException();
        }

        public string M3(string msg)
        {
            throw new NotImplementedException();
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion
    }



    //当一个抽象类实现某个接口的时候，如果实现的时候把接口中的成员标记为了abstract ,同时该类也是一个抽象类，此时可以不对接口中的成员进行实现。
    public abstract class TestAbstractClass : ITest
    {

        #region ITest 成员

        public abstract void M1();


        public abstract int M2();


        public abstract string M3(string msg);


        public abstract string Name
        {
            get;
            set;
        }

        public abstract string this[int index]
        {
            get;
            set;
        }

        #endregion
    }


}
