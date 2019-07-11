using System;

namespace CustomClassListProject
{
    public class CustomClassList<T>
    {
        CustomClassList<T> customClassList = new CustomClassList<T>();
        private int count = 0;
        public int Count
        {
            get { return count; }
        }
        private int capacity = 4;
        public int Capacity
        {
            get { return capacity; }
        }
        
        public T this[int index]
        {
            get
            {
                return customClassList[index];
            }
            set
            {
                customClassList[index] = value;
            }
        }

        // Constructor
        public CustomClassList()
        {
            CustomClassList<T> customClassList = new CustomClassList<T>();
        }

        public void Add(T item)
        {
            customClassList[0] = item;
        }
    }
}