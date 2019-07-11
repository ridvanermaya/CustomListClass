using System;

namespace CustomClassListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomClassList<int> customClassList = new CustomClassList<int>();
            customClassList.Add(0);
            customClassList.Add(1);
            customClassList.Add(2);
            customClassList.Add(3);
            customClassList.Add(4);
        }
    }
}
