using System;

namespace CustomClassListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomClassList<bool> customClassList = new CustomClassList<bool>();
            customClassList.Add(true);
            customClassList.Add(false);
            customClassList.Add(true);
            // s

            Console.WriteLine(customClassList.ToString());
        }
    }
}
