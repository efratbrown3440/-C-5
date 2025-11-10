using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lesson5
{
    public class Group<T> : IList<T>
    {
        public List<T> Members { get; set; } = new List<T>();
        public string HeadGroup { get; set; }
        public int CountFrendMax { get; init; }
        public int CountFrendMin { get; init; }
        public DateTime StartGroup { get; set; } = DateTime.Now;

        public Group() { }

        public Group(T leader, int min, int max)
        {
            HeadGroup = leader.ToString();
            CountFrendMin = min;
            CountFrendMax = max;
        }

        public void Add(T item)
        {
            if (Members.Count < CountFrendMax)
                Members.Add(item);
            else
                throw new Exception("אין מקום בקבוצה");
        }
        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public object Name { get; private set; }
        public object Age { get; private set; }
        public object Id { get; private set; }

        public T this[int index] { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); }

        

       

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
          Members.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

       

        public void Clear()
        {
            Members.Clear();
        }

        public bool Contains(T item)
        {
            return Members.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
           return Members.Remove(item);
         }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        internal void PrintMembers()
        {
            foreach (var member in Members)
                Console.WriteLine(member);
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}";
        }
    }
}
