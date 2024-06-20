using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    public class MyClass<T> : IEnumerable<T>
    {
        private List<T> list;
        private int max=0;

        public MyClass()
        {
           
            list = new List<T>();
        }

       

        public void AddList(T item)
        {
            list.Add(item);
        }

        public void RemoveList(T item)
        {
            list.Remove(item);
        }

        public void ClearList()
        {
            list.Clear();
        }

        public bool ContainsList(T item)
        {
            return list.Contains(item);
        }

        public int CountList()
        {
            return list.Count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in list)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
