using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentClassLibrary
{
    public class Course
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public double Cost { get; set; }

        public Course(string _coursecode, string _coursename, double _cost)
        {
            CourseCode = _coursecode;
            CourseName = _coursename;
            Cost = _cost;
        }


        public static bool operator == (Course x, Course y)
        {
            return object.Equals(x, y);
        }

        public static bool operator != (Course x, Course y)
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
            Course otherCourse = obj as Course;
            return this.CourseCode == otherCourse.CourseCode && this.CourseName == otherCourse.CourseName && this.Cost == otherCourse.Cost; 
        }

        
        public override int GetHashCode()
        {
            return this.CourseCode.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("Course Code: " + CourseCode);
            sb.AppendLine("Course Name: " + CourseName);
            sb.AppendLine("Cost: " + Cost.ToString());
            
            return sb.ToString();
        }
    }
}
