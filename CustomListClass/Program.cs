using System;

namespace CustomClassListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomClassList<int> customClassList1 = new CustomClassList<int>();
            CustomClassList<int> customClassList2 = new CustomClassList<int>();
            CustomClassList<int> resultList = new CustomClassList<int>();
            customClassList1.Add(0);
            customClassList1.Add(1);
            customClassList1.Add(2);
            customClassList1.Add(3);
            customClassList1.Add(4);
            customClassList1.Add(5);
            customClassList2.Add(1);
            customClassList2.Add(3);
            customClassList2.Add(5);
            resultList = customClassList1 - customClassList2;
        }
    }
}
