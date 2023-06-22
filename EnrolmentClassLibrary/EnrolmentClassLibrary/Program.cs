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

            Console.WriteLine("\nBinary Search");
            Console.WriteLine(myBinarySearch(cList, c2));

            Console.WriteLine("\nSequential search");
            Console.WriteLine(mySequentialSearch(cList, c4));

            Console.WriteLine("\nTesting otherBinarySearch");

            Course[] cList2;

            Course cc1 = new Course(666, "Defence Against the Dark Arts", 150.53);
            Course cc2 = new Course(4328, "Herbology", 127.45);
            Course cc3 = new Course(0097, "Muggle Studies", 100.23);
            Course cc4 = new Course(9075, "Potions", 154.32);
            Course cc5 = new Course(7249, "Transfiguration", 233.45);

            cList2 = new Course[5] { cc1, cc2, cc3, cc4, cc5 };

            Console.WriteLine(cList2.Length);

            Array.Sort(cList2);
            foreach (Course c in cList2)
            {
                Console.WriteLine(c.ToString());
            }

            Console.WriteLine("\nTesting AnotherBinarySearch");
            Console.WriteLine(myBinarySearch(cList, cc4));


            List<Student> listOfStudents = new List<Student>();

            Student ss1 = new Student("Ron", "rweasley@email.com", "123456780", 1234, "Dip C#", "01/01/23");
            Student ss2 = new Student("Hermione", "hgranger@email.com", "123456781", 4895, "Dip C#", "01/01/23");
            Student ss3 = new Student("Luna", "llovegood@email.com", "123456782", 5385, "Dip C#", "01/01/23");
            Student ss4 = new Student("Draco", "dmalfoy@email.com", "123456783", 8253, "Dip C#", "01/01/23");
            Student ss5 = new Student("Harry", "hpotter@email.com", "123456786", 6427, "Dip C#", "01/01/23");
            Student ss6 = new Student("Neville", "nlongbottom@email.com", "123456734", 6237, "Dip C#", "01/01/23");
            Student ss7 = new Student("Ginny", "gweasley@email.com", "123458936", 0934, "Dip C#", "01/01/23");
            Student ss8 = new Student("Cho", "cchang@email.com", "123459851", 2138, "Dip C#", "01/01/23");
            Student ss9 = new Student("Cedric", "cdiggory@email.com", "123456767", 9845, "Dip C#", "01/01/23");
            Student ss10 = new Student("Colin", "ccreevey@email.com", "123452342", 4562, "Dip C#", "01/01/23");

            listOfStudents.Add(ss1);
            listOfStudents.Add(ss2);
            listOfStudents.Add(ss3);
            listOfStudents.Add(ss4);
            listOfStudents.Add(ss5);
            listOfStudents.Add(ss6);
            listOfStudents.Add(ss7);
            listOfStudents.Add(ss8);
            listOfStudents.Add(ss9);
            listOfStudents.Add(ss10);

            Console.WriteLine("\nTesting bubble_sort_asc() of students");
            bubble_sort_asc(listOfStudents);
            print(listOfStudents);

            Console.WriteLine("\nTesting myBinarySearch of students");
            Console.WriteLine(myBinarySearch(listOfStudents, ss3));

            Console.WriteLine("\nTesting myLinearSearch of students");
            Console.WriteLine(myLinearSearch(listOfStudents, ss2));

            listOfStudents.Sort((x, y) => x.Name.CompareTo(y.Name));
            print(listOfStudents);


           
            Console.WriteLine("\nTesting addLast");
            EnrolmentClassLibrary.LinkedList<Student> targetLinkedList = new EnrolmentClassLibrary.LinkedList<Student>();

            Student tlls1 = new Student("Ron", "rweasley@email.com", "123456780", 1234, "Dip C#", "01/01/23");
            Student tlls2 = new Student("Hermione", "hgranger@email.com", "123456781", 4895, "Dip C#", "01/01/23");
            Student tlls3 = new Student("Luna", "llovegood@email.com", "123456782", 5385, "Dip C#", "01/01/23");
            Student tlls4 = new Student("Draco", "dmalfoy@email.com", "123456783", 8253, "Dip C#", "01/01/23");
            Student tlls5 = new Student("Harry", "hpotter@email.com", "123456786", 6427, "Dip C#", "01/01/23");
            Student tlls6 = new Student("Neville", "nlongbottom@email.com", "123456734", 6237, "Dip C#", "01/01/23");
            Student tlls7 = new Student("Ginny", "gweasley@email.com", "123458936", 0934, "Dip C#", "01/01/23");
            Student tlls8 = new Student("Cho", "cchang@email.com", "123459851", 2138, "Dip C#", "01/01/23");
            Student tlls9 = new Student("Cedric", "cdiggory@email.com", "123456767", 9845, "Dip C#", "01/01/23");
            Student tlls10 = new Student("Colin", "ccreevey@email.com", "123452342", 4562, "Dip C#", "01/01/23");

            Student tlls11 = new Student("Tom", "triddle@email.com", "123459560", 3456, "Dip C#", "01/01/23");
            

            targetLinkedList.AddLast(tlls1);
            targetLinkedList.AddLast(tlls2);
            targetLinkedList.AddLast(tlls3);
            targetLinkedList.AddLast(tlls4);
            targetLinkedList.AddLast(tlls5);
            targetLinkedList.AddLast(tlls6);
            targetLinkedList.AddLast(tlls7);
            targetLinkedList.AddLast(tlls8);
            targetLinkedList.AddLast(tlls9);
            targetLinkedList.AddLast(tlls10);

            targetLinkedList.AddLast(tlls11);

            foreach (Student s in targetLinkedList)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}
