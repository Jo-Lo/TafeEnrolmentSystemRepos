using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentClassLibrary
{
    public class Student: Person, IComparable<Student>, IComparable
    {
        public int Student_Id { get; set; }
        public string Program { get; set; }
        public string Date_Registered { get; set; }
        public Enrolment _Enrolment { get; set; }

        public Student(string _name, string _email, string _telnum, int _student_id, string _program, string _date_registered)
            :base(_name, _email, _telnum)
        {
            Student_Id = _student_id;
            Program = _program;
            Date_Registered = _date_registered;
        }

        public void setEnrolment(int _student_id, string _date_enroled, string _grade, string _semester)
        {
            _Enrolment = new Enrolment(_student_id, _date_enroled, _grade, _semester);
        }

        public static bool operator ==(Student x, Student y)
        {
            return object.Equals(x, y);
        }

        public static bool operator !=(Student x, Student y)
        {
            return !object.Equals(x, y);
        }

        public bool Equals(Student otherStudent)
        {
            return this.Student_Id == otherStudent.Student_Id && this.Name == otherStudent.Name;
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            Student otherStudent = obj as Student;
            return this.Student_Id == otherStudent.Student_Id && this.Name == otherStudent.Name;
        }

        // I have selected to hash Student ID and Name
        // because student id is unique and a student must require a name in the system
        // I assume a student may not supply an email or Telephone number
        public override int GetHashCode()
        {
            return this.Student_Id.GetHashCode() ^ this.Name.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException("obj");
            if (!(obj is Student))
                throw new ArgumentException("Expected student instance", "obj");
            return CompareTo((Student)obj);
        }

        public int CompareTo(Student otherStudent)
        {
            return this.Student_Id.CompareTo(otherStudent.Student_Id);
        }


        public static bool operator <(Student x, Student y)
        {
            return x.Student_Id < y.Student_Id;
        }

        public static bool operator <=(Student x, Student y)
        {
            return x.Student_Id <= y.Student_Id;
        }

        public static bool operator >(Student x, Student y)
        {
            return x.Student_Id > y.Student_Id;
        }

        public static bool operator >=(Student x, Student y)
        {
            return x.Student_Id >= y.Student_Id;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("Student ID: " + Student_Id);
            sb.AppendLine("Program: " + Program);
            sb.AppendLine("Date Registered: " + Date_Registered);
            sb.AppendLine("Enrolment: " + _Enrolment);

            return sb.ToString();

        }
    }
}
