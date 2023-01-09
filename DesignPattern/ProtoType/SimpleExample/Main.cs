using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ProtoType.SimpleExample
{
    public class Main
    {
        public static void DisplayValues(Person person)
        {
            Console.WriteLine(person.GetHashCode());
            Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}",person.Name, person.Age, person.BirthDate);
            Console.WriteLine("      ID#: {0:d}", person.IdInfo.IdNumber);
        }

        public static void Example()
        {
            Person p1 = new Person();
            p1.Age = 42;
            p1.BirthDate = Convert.ToDateTime("1977-01-01");
            p1.Name = "Jack Daniels";
            p1.IdInfo = new IdInfo(666);

            // Perform a shallow copy of p1 and assign it to p2.
            Person p2 = p1.ShallowCopy();
            p2.Name = "TEST";
            // Make a deep copy of p1 and assign it to p3.
            Person p3 = p1.DeepCopy();
            p3.Name = "Deep";

            // Display values of p1, p2 and p3.
            Console.WriteLine("Original values of p1, p2, p3:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(p2);
            Console.WriteLine("   p3 instance values:");
            DisplayValues(p3);
        }
    }
}
