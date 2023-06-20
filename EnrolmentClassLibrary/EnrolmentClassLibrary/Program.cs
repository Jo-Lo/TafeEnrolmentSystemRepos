using EnrolmentClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentClassLibrary
{
    public class Program : Utility
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
            Course c1 = new Course(666, "Defence Against the Dark Arts", 150.53);
            Console.WriteLine(c1);

            Console.WriteLine("Testing Course obejcts are equal");
            Course c2 = new Course(4328, "Herbology", 127.45);
            Course c3 = new Course(666, "Defence Against the Dark Arts", 150.53);

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

            Console.WriteLine("\nTesting bubble sort ascending");
            List<Course> cList = new List<Course>();

            cList.Add(c1);
            cList.Add(c2);
            //cList.Add(c3);
            Course c4 = new Course(9075, "Potions", 154.32);
            cList.Add(c4);

            Course c5 = new Course(7249, "Transfiguration", 233.45);
            cList.Add(c5);
            
            cList.Add(new Course (0097, "Muggle Studies", 100.23));

            Console.WriteLine("\nCourse list");
            print(cList);

            Console.WriteLine("\nbubble sort ascending");
            bubble_sort_asc(cList);
            print(cList);



            Console.WriteLine("\nTesting compareTo of Course");
            // comparing courseCode type of INT
            
            // comparing course 1 to 2 >> returns -1
            Console.WriteLine(c1.CompareTo(c2));
            // comparing course 1 to 3 >> returns 0
            Console.WriteLine(c1.CompareTo(c3));

            // comparing course 1 is greater than course 2 >> returns false
            Console.WriteLine("c1 > c2");
            Console.WriteLine(c1 > c2);

            // comparing course 1 is equal to course 3 >> returns true
            Console.WriteLine("c1 == c3");
            Console.WriteLine(c1 == c3);


            Console.WriteLine("\nTesting compareTo of Student");
            // comparing studentId type of INT

            // comparing student 1 to student 2 >> returns -1
            Student s2 = new Student("Hermione", "hgranger@email.com", "123456781", 1235, "Dip C#", "01/01/23");
            Console.WriteLine(s1.CompareTo(s2));

            // comparing student 1 is greater than student 2 >> returns false
            Console.WriteLine(s1 > s2);

            Console.WriteLine("\nSorted");
            print(cList);
            Console.WriteLine(MyBinarySearch(cList, c5));

            Console.WriteLine(MySequentialSearch(cList, c4));

            Console.ReadLine();
        }
    }
}
