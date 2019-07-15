using System;

namespace CustomClassListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomClassList<int> test1 = new CustomClassList<int>();
            CustomClassList<int> test2 = new CustomClassList<int>();
            CustomClassList<int> test3 = new CustomClassList<int>();
            test1.Add(0);
            test1.Add(2);
            test2.Add(1);
            test2.Add(3);
            test1.Add(4);
            test3 = test1.Zip(test2);
        }
    }
}
