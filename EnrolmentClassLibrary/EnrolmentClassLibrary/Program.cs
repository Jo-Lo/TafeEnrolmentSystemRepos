using EnrolmentClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentClassLibrary
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Person object");
            Person p1 = new Person("Harry", "hpotter@email.com", "123456789");
            p1.setAddress("4", "Privet Drive", "Little Whinging", "3434", "SU");
            Console.WriteLine(p1);

            Console.WriteLine("Testing Student object");
            Student s1 = new Student("Ron", "rweasley@email.com", "123456780", 1234, "Dip C#", "01/01/23");
            s1.setAddress("5", "George Drive", "Murray", "2567", "MU");
            s1.setEnrolment(0111, "01/01/23", "P", "Semester 2");
            Console.WriteLine(s1);

            Console.WriteLine("Testing Course obejct");
            Course c1 = new Course("DADA", "Defence Against the Dark Arts", 150.53);
            Console.WriteLine(c1);

            Console.WriteLine("Testing Course obejcts are equal");
            Course c2 = new Course("HERB", "Herbology", 127.45);
            Course c3 = new Course("DADA", "Defence Against the Dark Arts", 150.53);

            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1.Equals(c2));
            Console.WriteLine(c1.Equals(c3));

            Console.WriteLine("\nTesting Linked List");
            LinkedList<Student> studentLL = new LinkedList<Student>();
            
            studentLL.AddLast(s1);
            studentLL.AddLast(new Student("Hermione", "hgranger@email.com", "123456781", 1235, "Dip C#", "01/01/23"));
            studentLL.AddFirst(new Student("Luna", "llovegood@email.com", "123456782", 1236, "Dip C#", "01/01/23"));
            studentLL.AddLast(new Student("Draco", "dmalfoy@email.com", "123456783", 1237, "Dip C#", "01/01/23"));
            
            foreach (Student s in studentLL)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\nTesting Doubly Linked List");
            DoublyLinkedList<Course> courseDLL = new DoublyLinkedList<Course>();

            courseDLL.AddLast(c1);
            courseDLL.AddLast(c2);
            courseDLL.AddFirst(c3);

            foreach (Course c in courseDLL)
            {
                Console.WriteLine(c);
            }

            Console.ReadLine();
        }
    }
}
