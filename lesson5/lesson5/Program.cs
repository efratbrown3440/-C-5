using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    public class Program
    {
        public static void Main()
        {

            Student s1 = new Student(33333, "efrat", 19);
            Student s2 = new Student(11111, "tamar", 34);
            Student s3 = new Student(99999, "chani", 32);

            Group1<Student> group = new Group1<Student>(s1, 1, 5);

            group.Add(s1);
            group.Add(s2);
            group.Add(s3);
            Console.WriteLine("Leader:");
            Console.WriteLine(group.HeadGroup);

            Console.WriteLine("\nMembers:");
            group.PrintMembers();


            Console.WriteLine("\nToString():");
            Console.WriteLine(group);
        }
    }

}