using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentClassLibrary
{
    public class Enrolment
    {
        public int Enrolment_Id { get; set; }
        public string Date_Enroled { get; set; }
        public string Grade { get; set; }
        public string Semester { get; set; }
        public List<Course> _Courses { get; set; }

        public Enrolment(int _enrolment_id, string _date_enroled, string _grade, string _semester)
        {
            Enrolment_Id = _enrolment_id;
            Date_Enroled = _date_enroled;
            Grade = _grade;
            Semester = _semester;
        }

        public static bool operator == (Enrolment x, Enrolment y)
        {
            return object.Equals(x, y);
        }

        public static bool operator != (Enrolment x, Enrolment y)
        {
            return !object.Equals(x, y);
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            Enrolment otherEnrolment = obj as Enrolment;
            return this.Enrolment_Id == otherEnrolment.Enrolment_Id;
        }


        public override int GetHashCode()
        {
            return this.Enrolment_Id.GetHashCode();
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("Enrolment ID: " + Enrolment_Id);
            sb.AppendLine("Date Enroled: " + Date_Enroled);
            sb.AppendLine("Grade: " + Grade);
            sb.AppendLine("Semester: " + Semester);
            sb.AppendLine("Courses: " + _Courses);

            return sb.ToString();
        }
    }
}
