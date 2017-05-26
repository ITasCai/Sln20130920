using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03显示实现接口.NewFolder1
{
    public interface IFace1
    {
        void M1();
    }
    public interface IFace2
    {
        void M2();
    }
    public interface IFace3
    {
        void M3();
    }
    public interface IFace4
    {
        void M4();
        void M4(string msg);

        void M4(int n);
    }

    public interface IFace5 : IFace1, IFace2, IFace3, IFace4
    {
    }

    //class MyClass : IFace5
    //{

    //    #region IFace1 成员

    //    public void M1()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    #endregion

    //    #region IFace2 成员

    //    public void M2()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    #endregion

    //    #region IFace3 成员

    //    public void M3()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    #endregion

    //    #region IFace4 成员

    //    public void M4()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    #endregion
    //}
}
