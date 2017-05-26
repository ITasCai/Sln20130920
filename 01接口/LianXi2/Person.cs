using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01接口.LianXi2
{
    public class Person
    {
        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

    }


    public class Student : Person, ICollectHomework
    {

        #region ICollectHomework 成员

        public void Collect()
        {
            Console.WriteLine("班长收作业！！");
        }

        #endregion
    }


    public class BestStudent : Student
    {

    }


    public class Teacher : Person, ICollectHomework
    {

        #region ICollectHomework 成员

        public void Collect()
        {
            Console.WriteLine("老师收作业！ ");
        }

        #endregion
    }

    public interface ICollectHomework
    {
        void Collect();
    }
}
