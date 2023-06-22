using System;
using System.Collections.Generic;
using EnrolmentClassLibrary;
using NUnit.Framework;

namespace EnrolmentSystemTest
{
    [TestFixture]
    public class EnrolmentSystemTest : Utility
    {
        //student list
        Student s1;
        Student s2;
        Student s3;
        Student s4;
        Student s5;
        Student s6;
        Student s7;
        Student s8;
        Student s9;
        Student s10;

        //student list v2
        Student ss1;
        Student ss2;
        Student ss3;
        Student ss4;
        Student ss5;
        Student ss6;
        Student ss7;
        Student ss8;
        Student ss9;
        Student ss10;

        //linkedList students
        Student lls1;
        Student lls2;
        Student lls3;
        Student lls4;
        Student lls5;
        Student lls6;
        Student lls7;
        Student lls8;
        Student lls9;
        Student lls10;

        //targetLinkedList students
        Student tlls1;
        Student tlls2;
        Student tlls3;
        Student tlls4;
        Student tlls5;
        Student tlls6;
        Student tlls7;
        Student tlls8;
        Student tlls9;
        Student tlls10;

        // DoublyLinkedList students
        Student dlls1;
        Student dlls2;
        Student dlls3;
        Student dlls4;
        Student dlls5;
        Student dlls6;
        Student dlls7;
        Student dlls8;
        Student dlls9;
        Student dlls10;

        // targetDoublyLinkedList students
        Student tdlls1;
        Student tdlls2;
        Student tdlls3;
        Student tdlls4;
        Student tdlls5;
        Student tdlls6;
        Student tdlls7;
        Student tdlls8;
        Student tdlls9;
        Student tdlls10;

        List<Student> listOfStudents;

        EnrolmentClassLibrary.LinkedList<Student> linkedListOfStudents;
        DoublyLinkedList<Student> doublyLinkedListOfStudents;


        [OneTimeSetUp]
        public void setUp()
        {
            // list of students
            listOfStudents = new List<Student>();

            s1 = new Student("Ron", "rweasley@email.com", "123456780", 1234, "Dip C#", "01/01/23");
            s2 = new Student("Hermione", "hgranger@email.com", "123456781", 4895, "Dip C#", "01/01/23");
            s3 = new Student("Luna", "llovegood@email.com", "123456782", 5385, "Dip C#", "01/01/23");
            s4 = new Student("Draco", "dmalfoy@email.com", "123456783", 8253, "Dip C#", "01/01/23");
            s5 = new Student("Harry", "hpotter@email.com", "123456786", 6427, "Dip C#", "01/01/23");
            s6 = new Student("Neville", "nlongbottom@email.com", "123456734", 6237, "Dip C#", "01/01/23");
            s7 = new Student("Ginny", "gweasley@email.com", "123458936", 0934, "Dip C#", "01/01/23");
            s8 = new Student("Cho", "cchang@email.com", "123459851", 2138, "Dip C#", "01/01/23");
            s9 = new Student("Cedric", "cdiggory@email.com", "123456767", 9845, "Dip C#", "01/01/23");
            s10 = new Student("Colin", "ccreevey@email.com", "123452342", 4562, "Dip C#", "01/01/23");
            
            listOfStudents.Add(s1);
            listOfStudents.Add(s2);
            listOfStudents.Add(s3);
            listOfStudents.Add(s4);
            listOfStudents.Add(s5);
            listOfStudents.Add(s6);
            listOfStudents.Add(s7);
            listOfStudents.Add(s8);
            listOfStudents.Add(s9);
            listOfStudents.Add(s10);


            // linkedlist of students
            linkedListOfStudents = new EnrolmentClassLibrary.LinkedList<Student>();

            lls1 = new Student("Ron", "rweasley@email.com", "123456780", 1234, "Dip C#", "01/01/23");
            lls2 = new Student("Hermione", "hgranger@email.com", "123456781", 4895, "Dip C#", "01/01/23");
            lls3 = new Student("Luna", "llovegood@email.com", "123456782", 5385, "Dip C#", "01/01/23");
            lls4 = new Student("Draco", "dmalfoy@email.com", "123456783", 8253, "Dip C#", "01/01/23");
            lls5 = new Student("Harry", "hpotter@email.com", "123456786", 6427, "Dip C#", "01/01/23");
            lls6 = new Student("Neville", "nlongbottom@email.com", "123456734", 6237, "Dip C#", "01/01/23");
            lls7 = new Student("Ginny", "gweasley@email.com", "123458936", 0934, "Dip C#", "01/01/23");
            lls8 = new Student("Cho", "cchang@email.com", "123459851", 2138, "Dip C#", "01/01/23");
            lls9 = new Student("Cedric", "cdiggory@email.com", "123456767", 9845, "Dip C#", "01/01/23");
            lls10 = new Student("Colin", "ccreevey@email.com", "123452342", 4562, "Dip C#", "01/01/23");


            linkedListOfStudents.AddLast(lls1);
            linkedListOfStudents.AddLast(lls2);
            linkedListOfStudents.AddLast(lls3);
            linkedListOfStudents.AddLast(lls4);
            linkedListOfStudents.AddLast(lls5);
            linkedListOfStudents.AddLast(lls6);
            linkedListOfStudents.AddLast(lls7);
            linkedListOfStudents.AddLast(lls8);
            linkedListOfStudents.AddLast(lls9);
            linkedListOfStudents.AddLast(lls10);


            // doublyLinkedList students
            doublyLinkedListOfStudents = new DoublyLinkedList<Student>();

            dlls1 = new Student("Ron", "rweasley@email.com", "123456780", 1234, "Dip C#", "01/01/23");
            dlls2 = new Student("Hermione", "hgranger@email.com", "123456781", 4895, "Dip C#", "01/01/23");
            dlls3 = new Student("Luna", "llovegood@email.com", "123456782", 5385, "Dip C#", "01/01/23");
            dlls4 = new Student("Draco", "dmalfoy@email.com", "123456783", 8253, "Dip C#", "01/01/23");
            dlls5 = new Student("Harry", "hpotter@email.com", "123456786", 6427, "Dip C#", "01/01/23");
            dlls6 = new Student("Neville", "nlongbottom@email.com", "123456734", 6237, "Dip C#", "01/01/23");
            dlls7 = new Student("Ginny", "gweasley@email.com", "123458936", 0934, "Dip C#", "01/01/23");
            dlls8 = new Student("Cho", "cchang@email.com", "123459851", 2138, "Dip C#", "01/01/23");
            dlls9 = new Student("Cedric", "cdiggory@email.com", "123456767", 9845, "Dip C#", "01/01/23");
            dlls10 = new Student("Colin", "ccreevey@email.com", "123452342", 4562, "Dip C#", "01/01/23");

            doublyLinkedListOfStudents.AddLast(dlls1);
            doublyLinkedListOfStudents.AddLast(dlls2);
            doublyLinkedListOfStudents.AddLast(dlls3);
            doublyLinkedListOfStudents.AddLast(dlls4);
            doublyLinkedListOfStudents.AddLast(dlls5);
            doublyLinkedListOfStudents.AddLast(dlls6);
            doublyLinkedListOfStudents.AddLast(dlls7);
            doublyLinkedListOfStudents.AddLast(dlls8);
            doublyLinkedListOfStudents.AddLast(dlls9);
            doublyLinkedListOfStudents.AddLast(dlls10);

        }


        [Test]
        public void TC1_TestLinearSearch()
        {
            //listOfStudents.Sort();
            int result = myLinearSearch(listOfStudents, s2);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void TC2_TestBinarySearch()
        {
            listOfStudents.Sort((x, y) => x.Name.CompareTo(y.Name));
            int result = myBinarySearch(listOfStudents, s3);
            Assert.AreEqual(7, result);
        }

        [Test]
        public void TC3_BubbleSort()
        {
            List<Student> listOfStudents2 = new List<Student>();

            ss1 = new Student("Ron", "rweasley@email.com", "123456780", 1234, "Dip C#", "01/01/23");
            ss2 = new Student("Hermione", "hgranger@email.com", "123456781", 4895, "Dip C#", "01/01/23");
            ss3 = new Student("Luna", "llovegood@email.com", "123456782", 5385, "Dip C#", "01/01/23");
            ss4 = new Student("Draco", "dmalfoy@email.com", "123456783", 8253, "Dip C#", "01/01/23");
            ss5 = new Student("Harry", "hpotter@email.com", "123456786", 6427, "Dip C#", "01/01/23");
            ss6 = new Student("Neville", "nlongbottom@email.com", "123456734", 6237, "Dip C#", "01/01/23");
            ss7 = new Student("Ginny", "gweasley@email.com", "123458936", 0934, "Dip C#", "01/01/23");
            ss8 = new Student("Cho", "cchang@email.com", "123459851", 2138, "Dip C#", "01/01/23");
            ss9 = new Student("Cedric", "cdiggory@email.com", "123456767", 9845, "Dip C#", "01/01/23");
            ss10 = new Student("Colin", "ccreevey@email.com", "123452342", 4562, "Dip C#", "01/01/23");

            // adding listOfStudents2 in alphabetical order without sorting
            listOfStudents2.Add(ss9);
            listOfStudents2.Add(ss8);
            listOfStudents2.Add(ss10);
            listOfStudents2.Add(ss4);
            listOfStudents2.Add(ss7);
            listOfStudents2.Add(ss5);
            listOfStudents2.Add(ss2);
            listOfStudents2.Add(ss3);
            listOfStudents2.Add(ss6);
            listOfStudents2.Add(ss1);

            bubble_sort_asc(listOfStudents);

            CollectionAssert.AreEqual(listOfStudents2, listOfStudents);
        }

        [Test]
        public void TC4_LinkedList_Head()
        {
            EnrolmentClassLibrary.LinkedList<Student> targetLinkedList = new EnrolmentClassLibrary.LinkedList<Student>();

            tlls1 = new Student("Ron", "rweasley@email.com", "123456780", 1234, "Dip C#", "01/01/23");
            tlls2 = new Student("Hermione", "hgranger@email.com", "123456781", 4895, "Dip C#", "01/01/23");
            tlls3 = new Student("Luna", "llovegood@email.com", "123456782", 5385, "Dip C#", "01/01/23");
            tlls4 = new Student("Draco", "dmalfoy@email.com", "123456783", 8253, "Dip C#", "01/01/23");
            tlls5 = new Student("Harry", "hpotter@email.com", "123456786", 6427, "Dip C#", "01/01/23");
            tlls6 = new Student("Neville", "nlongbottom@email.com", "123456734", 6237, "Dip C#", "01/01/23");
            tlls7 = new Student("Ginny", "gweasley@email.com", "123458936", 0934, "Dip C#", "01/01/23");
            tlls8 = new Student("Cho", "cchang@email.com", "123459851", 2138, "Dip C#", "01/01/23");
            tlls9 = new Student("Cedric", "cdiggory@email.com", "123456767", 9845, "Dip C#", "01/01/23");
            tlls10 = new Student("Colin", "ccreevey@email.com", "123452342", 4562, "Dip C#", "01/01/23");

            Student tlls11 = new Student("Tom", "triddle@email.com", "123459560", 3456, "Dip C#", "01/01/23");
            targetLinkedList.AddLast(tlls11);

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

            //adding student to the head
            Student lls11 = new Student("Tom", "triddle@email.com", "123459560", 3456, "Dip C#", "01/01/23");
            linkedListOfStudents.AddFirst(lls11);

            CollectionAssert.AreEqual(targetLinkedList, linkedListOfStudents);
        }

        [Test]
        public void TC5_LinkedList_Tail()
        {
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

            Student tlls12 = new Student("Tomm", "triddle@email.com", "123459560", 3456, "Dip C#", "01/01/23");

            targetLinkedList.AddLast(tlls11);
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
            targetLinkedList.AddLast(tlls12);

            //adding student to the tail
            Student lls12 = new Student("Tomm", "triddle@email.com", "123459560", 3456, "Dip C#", "01/01/23");
            linkedListOfStudents.AddLast(lls12);

            CollectionAssert.AreEqual(targetLinkedList, linkedListOfStudents);
        }

        [Test]
        public void TC6_LinkedList_RemoveFirst()
        {
            EnrolmentClassLibrary.LinkedList<Student> targetLinkedList = new EnrolmentClassLibrary.LinkedList<Student>();

            tlls1 = new Student("Ron", "rweasley@email.com", "123456780", 1234, "Dip C#", "01/01/23");
            tlls2 = new Student("Hermione", "hgranger@email.com", "123456781", 4895, "Dip C#", "01/01/23");
            tlls3 = new Student("Luna", "llovegood@email.com", "123456782", 5385, "Dip C#", "01/01/23");
            tlls4 = new Student("Draco", "dmalfoy@email.com", "123456783", 8253, "Dip C#", "01/01/23");
            tlls5 = new Student("Harry", "hpotter@email.com", "123456786", 6427, "Dip C#", "01/01/23");
            tlls6 = new Student("Neville", "nlongbottom@email.com", "123456734", 6237, "Dip C#", "01/01/23");
            tlls7 = new Student("Ginny", "gweasley@email.com", "123458936", 0934, "Dip C#", "01/01/23");
            tlls8 = new Student("Cho", "cchang@email.com", "123459851", 2138, "Dip C#", "01/01/23");
            tlls9 = new Student("Cedric", "cdiggory@email.com", "123456767", 9845, "Dip C#", "01/01/23");
            tlls10 = new Student("Colin", "ccreevey@email.com", "123452342", 4562, "Dip C#", "01/01/23");

            Student tlls11 = new Student("Tom", "triddle@email.com", "123459560", 3456, "Dip C#", "01/01/23");

            Student tlls12 = new Student("Tomm", "triddle@email.com", "123459560", 3456, "Dip C#", "01/01/23");


            //targetLinkedList.AddLast(tlls11);
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
            targetLinkedList.AddLast(tlls12);

            linkedListOfStudents.Removefirst();

            CollectionAssert.AreEqual(targetLinkedList, linkedListOfStudents);
        }

        [Test]
        public void TC7_LinkedList_RemoveLast()
        {
            EnrolmentClassLibrary.LinkedList<Student> targetLinkedList = new EnrolmentClassLibrary.LinkedList<Student>();

            tlls1 = new Student("Ron", "rweasley@email.com", "123456780", 1234, "Dip C#", "01/01/23");
            tlls2 = new Student("Hermione", "hgranger@email.com", "123456781", 4895, "Dip C#", "01/01/23");
            tlls3 = new Student("Luna", "llovegood@email.com", "123456782", 5385, "Dip C#", "01/01/23");
            tlls4 = new Student("Draco", "dmalfoy@email.com", "123456783", 8253, "Dip C#", "01/01/23");
            tlls5 = new Student("Harry", "hpotter@email.com", "123456786", 6427, "Dip C#", "01/01/23");
            tlls6 = new Student("Neville", "nlongbottom@email.com", "123456734", 6237, "Dip C#", "01/01/23");
            tlls7 = new Student("Ginny", "gweasley@email.com", "123458936", 0934, "Dip C#", "01/01/23");
            tlls8 = new Student("Cho", "cchang@email.com", "123459851", 2138, "Dip C#", "01/01/23");
            tlls9 = new Student("Cedric", "cdiggory@email.com", "123456767", 9845, "Dip C#", "01/01/23");
            tlls10 = new Student("Colin", "ccreevey@email.com", "123452342", 4562, "Dip C#", "01/01/23");

            Student tlls11 = new Student("Tom", "triddle@email.com", "123459560", 3456, "Dip C#", "01/01/23");

            Student tlls12 = new Student("Tomm", "triddle@email.com", "123459560", 3456, "Dip C#", "01/01/23");

            //targetLinkedList.AddLast(tlls11);
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
            //targetLinkedList.AddLast(tlls12);

            linkedListOfStudents.RemoveLast();

            CollectionAssert.AreEqual(targetLinkedList, linkedListOfStudents);
        }

        [Test]
        public void TC8_DoublyLinkedList_Head()
        {
            DoublyLinkedList<Student> targetDoublyLinkedList = new DoublyLinkedList<Student>();
           
            tdlls1 = new Student("Ron", "rweasley@email.com", "123456780", 1234, "Dip C#", "01/01/23");
            tdlls2 = new Student("Hermione", "hgranger@email.com", "123456781", 4895, "Dip C#", "01/01/23");
            tdlls3 = new Student("Luna", "llovegood@email.com", "123456782", 5385, "Dip C#", "01/01/23");
            tdlls4 = new Student("Draco", "dmalfoy@email.com", "123456783", 8253, "Dip C#", "01/01/23");
            tdlls5 = new Student("Harry", "hpotter@email.com", "123456786", 6427, "Dip C#", "01/01/23");
            tdlls6 = new Student("Neville", "nlongbottom@email.com", "123456734", 6237, "Dip C#", "01/01/23");
            tdlls7 = new Student("Ginny", "gweasley@email.com", "123458936", 0934, "Dip C#", "01/01/23");
            tdlls8 = new Student("Cho", "cchang@email.com", "123459851", 2138, "Dip C#", "01/01/23");
            tdlls9 = new Student("Cedric", "cdiggory@email.com", "123456767", 9845, "Dip C#", "01/01/23");
            tdlls10 = new Student("Colin", "ccreevey@email.com", "123452342", 4562, "Dip C#", "01/01/23");

            Student tlls11 = new Student("Tom", "triddle@email.com", "123459560", 3456, "Dip C#", "01/01/23");
            targetDoublyLinkedList.AddLast(tlls11);

            targetDoublyLinkedList.AddLast(tdlls1);
            targetDoublyLinkedList.AddLast(tdlls2);
            targetDoublyLinkedList.AddLast(tdlls3);
            targetDoublyLinkedList.AddLast(tdlls4);
            targetDoublyLinkedList.AddLast(tdlls5);
            targetDoublyLinkedList.AddLast(tdlls6);
            targetDoublyLinkedList.AddLast(tdlls7);
            targetDoublyLinkedList.AddLast(tdlls8);
            targetDoublyLinkedList.AddLast(tdlls9);
            targetDoublyLinkedList.AddLast(tdlls10);

            //adding student to the head
            Student lls11 = new Student("Tom", "triddle@email.com", "123459560", 3456, "Dip C#", "01/01/23");
            doublyLinkedListOfStudents.AddFirst(lls11);

            CollectionAssert.AreEqual(targetDoublyLinkedList, doublyLinkedListOfStudents);
        }


        [Test]
        public void TC9_DoublyLinkedList_Tail()
        {
            DoublyLinkedList<Student> targetDoublyLinkedList = new DoublyLinkedList<Student>();

            tdlls1 = new Student("Ron", "rweasley@email.com", "123456780", 1234, "Dip C#", "01/01/23");
            tdlls2 = new Student("Hermione", "hgranger@email.com", "123456781", 4895, "Dip C#", "01/01/23");
            tdlls3 = new Student("Luna", "llovegood@email.com", "123456782", 5385, "Dip C#", "01/01/23");
            tdlls4 = new Student("Draco", "dmalfoy@email.com", "123456783", 8253, "Dip C#", "01/01/23");
            tdlls5 = new Student("Harry", "hpotter@email.com", "123456786", 6427, "Dip C#", "01/01/23");
            tdlls6 = new Student("Neville", "nlongbottom@email.com", "123456734", 6237, "Dip C#", "01/01/23");
            tdlls7 = new Student("Ginny", "gweasley@email.com", "123458936", 0934, "Dip C#", "01/01/23");
            tdlls8 = new Student("Cho", "cchang@email.com", "123459851", 2138, "Dip C#", "01/01/23");
            tdlls9 = new Student("Cedric", "cdiggory@email.com", "123456767", 9845, "Dip C#", "01/01/23");
            tdlls10 = new Student("Colin", "ccreevey@email.com", "123452342", 4562, "Dip C#", "01/01/23");

            Student tdlls11 = new Student("Tom", "triddle@email.com", "123459560", 3456, "Dip C#", "01/01/23");

            Student tdlls12 = new Student("Tomm", "triddle@email.com", "123459560", 3456, "Dip C#", "01/01/23");

            targetDoublyLinkedList.AddLast(tdlls11);
            targetDoublyLinkedList.AddLast(tdlls1);
            targetDoublyLinkedList.AddLast(tdlls2);
            targetDoublyLinkedList.AddLast(tdlls3);
            targetDoublyLinkedList.AddLast(tdlls4);
            targetDoublyLinkedList.AddLast(tdlls5);
            targetDoublyLinkedList.AddLast(tdlls6);
            targetDoublyLinkedList.AddLast(tdlls7);
            targetDoublyLinkedList.AddLast(tdlls8);
            targetDoublyLinkedList.AddLast(tdlls9);
            targetDoublyLinkedList.AddLast(tdlls10);
            targetDoublyLinkedList.AddLast(tdlls12);


            //adding student to the tail
            Student dlls12 = new Student("Tomm", "triddle@email.com", "123459560", 3456, "Dip C#", "01/01/23");
            doublyLinkedListOfStudents.AddLast(dlls12);

            CollectionAssert.AreEqual(targetDoublyLinkedList, doublyLinkedListOfStudents);
        }

        [Test]
        public void TC91_DoublyLinkedList_RemoveFirst()
        {
            DoublyLinkedList<Student> targetDoublyLinkedList = new DoublyLinkedList<Student>();

            tdlls1 = new Student("Ron", "rweasley@email.com", "123456780", 1234, "Dip C#", "01/01/23");
            tdlls2 = new Student("Hermione", "hgranger@email.com", "123456781", 4895, "Dip C#", "01/01/23");
            tdlls3 = new Student("Luna", "llovegood@email.com", "123456782", 5385, "Dip C#", "01/01/23");
            tdlls4 = new Student("Draco", "dmalfoy@email.com", "123456783", 8253, "Dip C#", "01/01/23");
            tdlls5 = new Student("Harry", "hpotter@email.com", "123456786", 6427, "Dip C#", "01/01/23");
            tdlls6 = new Student("Neville", "nlongbottom@email.com", "123456734", 6237, "Dip C#", "01/01/23");
            tdlls7 = new Student("Ginny", "gweasley@email.com", "123458936", 0934, "Dip C#", "01/01/23");
            tdlls8 = new Student("Cho", "cchang@email.com", "123459851", 2138, "Dip C#", "01/01/23");
            tdlls9 = new Student("Cedric", "cdiggory@email.com", "123456767", 9845, "Dip C#", "01/01/23");
            tdlls10 = new Student("Colin", "ccreevey@email.com", "123452342", 4562, "Dip C#", "01/01/23");

            Student tdlls11 = new Student("Tom", "triddle@email.com", "123459560", 3456, "Dip C#", "01/01/23");

            Student tdlls12 = new Student("Tomm", "triddle@email.com", "123459560", 3456, "Dip C#", "01/01/23");

            //targetDoublyLinkedList.AddLast(tdlls11);
            targetDoublyLinkedList.AddLast(tdlls1);
            targetDoublyLinkedList.AddLast(tdlls2);
            targetDoublyLinkedList.AddLast(tdlls3);
            targetDoublyLinkedList.AddLast(tdlls4);
            targetDoublyLinkedList.AddLast(tdlls5);
            targetDoublyLinkedList.AddLast(tdlls6);
            targetDoublyLinkedList.AddLast(tdlls7);
            targetDoublyLinkedList.AddLast(tdlls8);
            targetDoublyLinkedList.AddLast(tdlls9);
            targetDoublyLinkedList.AddLast(tdlls10);
            targetDoublyLinkedList.AddLast(tdlls12);

            doublyLinkedListOfStudents.RemoveFirst();

            CollectionAssert.AreEqual(targetDoublyLinkedList, doublyLinkedListOfStudents);
        }

        [Test]
        public void TC92_DoublyLinkedList_RemoveLast()
        {
            DoublyLinkedList<Student> targetDoublyLinkedList = new DoublyLinkedList<Student>();

            tdlls1 = new Student("Ron", "rweasley@email.com", "123456780", 1234, "Dip C#", "01/01/23");
            tdlls2 = new Student("Hermione", "hgranger@email.com", "123456781", 4895, "Dip C#", "01/01/23");
            tdlls3 = new Student("Luna", "llovegood@email.com", "123456782", 5385, "Dip C#", "01/01/23");
            tdlls4 = new Student("Draco", "dmalfoy@email.com", "123456783", 8253, "Dip C#", "01/01/23");
            tdlls5 = new Student("Harry", "hpotter@email.com", "123456786", 6427, "Dip C#", "01/01/23");
            tdlls6 = new Student("Neville", "nlongbottom@email.com", "123456734", 6237, "Dip C#", "01/01/23");
            tdlls7 = new Student("Ginny", "gweasley@email.com", "123458936", 0934, "Dip C#", "01/01/23");
            tdlls8 = new Student("Cho", "cchang@email.com", "123459851", 2138, "Dip C#", "01/01/23");
            tdlls9 = new Student("Cedric", "cdiggory@email.com", "123456767", 9845, "Dip C#", "01/01/23");
            tdlls10 = new Student("Colin", "ccreevey@email.com", "123452342", 4562, "Dip C#", "01/01/23");

            Student tdlls11 = new Student("Tom", "triddle@email.com", "123459560", 3456, "Dip C#", "01/01/23");

            Student tdlls12 = new Student("Tomm", "triddle@email.com", "123459560", 3456, "Dip C#", "01/01/23");

            //targetDoublyLinkedList.AddLast(tdlls11);
            targetDoublyLinkedList.AddLast(tdlls1);
            targetDoublyLinkedList.AddLast(tdlls2);
            targetDoublyLinkedList.AddLast(tdlls3);
            targetDoublyLinkedList.AddLast(tdlls4);
            targetDoublyLinkedList.AddLast(tdlls5);
            targetDoublyLinkedList.AddLast(tdlls6);
            targetDoublyLinkedList.AddLast(tdlls7);
            targetDoublyLinkedList.AddLast(tdlls8);
            targetDoublyLinkedList.AddLast(tdlls9);
            targetDoublyLinkedList.AddLast(tdlls10);
            //targetDoublyLinkedList.AddLast(tdlls12);

            doublyLinkedListOfStudents.revmoveLast();

            CollectionAssert.AreEqual(targetDoublyLinkedList, doublyLinkedListOfStudents);
        }

    }
}
