using System;

namespace CustomClassListProject
{
    public class CustomClassList<T>
    {
        CustomClassList<T> customClassList = new CustomClassList<T>();
        private int count;
        public int Count
        {
            get { return count; }
        }
        private int capacity;
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

        public void Add(T item)
        {

        }
    }
}