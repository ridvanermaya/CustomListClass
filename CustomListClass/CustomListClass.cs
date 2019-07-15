using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomClassListProject
{
    public class CustomClassList<T> : IEnumerable
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

        public static CustomClassList<T> operator - (CustomClassList<T> item1, CustomClassList<T> item2)
        {
            CustomClassList<T> resultList = new CustomClassList<T>();
            for (int i = 0; i < item1.count; i++)
            {
                for (int j = 0; j < item2.count; j++)
                {
                    dynamic x = item1[i];
                    dynamic y = item2[j];
                    if (x == y) {
                        // do nothing
                        break;
                    }
                    else if (j < item2.count - 1){
                        // do nothing
                        continue;
                    }
                    else {
                        resultList.Add(item1[i]);
                        break;
                    }
                }
            }
            return resultList;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return customList[i];
            }
        }

        public CustomClassList<T> Zip(CustomClassList<T> item)
        {
            CustomClassList<T> resultList = new CustomClassList<T>();
            int numberToLoop;
            bool areListsEqual;
            int i;
            if (count > item.count) {
                numberToLoop = item.count;
                areListsEqual = false;
            }
            else if (count < item.count) {
                numberToLoop = count;
                areListsEqual = false;
            }
            else {
                numberToLoop = count;
                areListsEqual = true;
            }

            for (i = 0; i < numberToLoop; i++)
            {
                resultList.Add(customList[i]);
                resultList.Add(item[i]);
            }
            if (!areListsEqual) {
                if (count > item.count) {
                    for (int j = i; j < count; j++)
                    {
                        resultList.Add(customList[j]);
                    }
                }
                else {
                    for (int j = i; j < item.count; j++)
                    {
                        resultList.Add(item[j]);
                    }
                }
            }
            return resultList;
        }

        public void SwapFunction(ref T item1, ref T item2)
        {
            T temp;
            temp = item1;
            item1 = item2;
            item2 = temp;
        }
    }
}