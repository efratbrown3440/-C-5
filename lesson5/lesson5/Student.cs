using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    public class Student : ICloneable, IComparable<Student>
    {
        private string age;
        private int name;

        public int Id { get; set; }
        private string Name { get; set; }
        public int Age { get; set; } = 0;



        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
            
        }

      public Student() { }
        

        public int CompareTo(Student? other)
        {
            if (other==null)
            {
                throw new Exception("אא להשוות ");

            }
            if (this.Id.CompareTo(other.Id)==0)
            
                return 0;
            if(this.Id.CompareTo(other.Id)>1)
                return -1;

            return 1;

        }
        public object Clone()
        {
            return new Student(this.Id, this.Name, this.Age);
        }

    }
}
