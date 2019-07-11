using System;
using System.Collections.Generic;

namespace CustomClassListProject
{
    public class CustomClassList<T>
    {
        T[] customList;
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
                return customList[index];
            }
            set
            {
                customList[index] = value;
            }
        }

        // constructor
        public CustomClassList()
        {
            capacity = 4;
            customList = new T[capacity];
            count = 0;
        }

        // member variables
        public void Add(T item)
        {
            if(capacity == count){
                capacity = capacity * 2;
                customList = new T[capacity];
            }

            customList[count] = item;
            count++;
        }
    }
}