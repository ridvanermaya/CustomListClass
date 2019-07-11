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
            customClassList.Add(5);
            customClassList.Remove(0);
            Console.WriteLine(customClassList[0]);
            Console.WriteLine(customClassList[1]);
            Console.WriteLine(customClassList[2]);
            Console.WriteLine(customClassList[3]);
            Console.WriteLine(customClassList[4]);
            Console.WriteLine(customClassList[5]);
            Console.WriteLine(customClassList[6]);
        }
    }
}
