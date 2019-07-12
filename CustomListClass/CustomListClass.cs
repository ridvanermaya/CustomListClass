using System;

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
                if (index >= count || index < 0) {
                    throw new ArgumentOutOfRangeException("Nope");
                }
                else {
                    return customList[index];
                }
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
            T[] temporaryList;
            if(capacity == count){
                capacity *= 2;
                temporaryList = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    temporaryList[i] = customList[i];
                }
                customList = new T[capacity];
                customList = temporaryList;
            }
            customList[count] = item;
            count++;
        }

        public bool Remove(T item)
        {
            bool isFound = false;
            for (int i = 0; i < count; i++)
            {
                dynamic x = customList[i];
                dynamic y = item;
                if (x == y) {
                    isFound = true;
                    count--;
                    for (int j = i; j < count; j++)
                    {
                        customList[j] = customList[j + 1];
                    }
                    customList[count] = default;
                    break;
                }
            }
            return isFound;
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += customList[i].ToString();
            }
            return result;
        }

        public static CustomClassList<T> operator + (CustomClassList<T> item1, CustomClassList<T> item2)
        {
            CustomClassList<T> resultList = new CustomClassList<T>();
            for (int i = 0; i < item1.count; i++)
            {
                resultList.Add(item1[i]);
            }
            for (int i = 0; i < item2.count; i++)
            {
                resultList.Add(item2[i]);
            }
            return resultList;
        }
    }
}