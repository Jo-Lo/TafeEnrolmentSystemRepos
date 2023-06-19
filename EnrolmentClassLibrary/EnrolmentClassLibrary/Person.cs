using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentClassLibrary
{
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string TelNum { get; set; }
        public Address _Address { get; set; }

        public Person(string _name, string _email, string _telnum)
        {
            Name = _name;
            Email = _email;
            TelNum = _telnum;

        }
        public void setAddress(string _num, string _street, string _suburb, string _postcode, string _state)
        {
            _Address = new Address(_num, _street, _suburb, _postcode, _state);
        }


        public static bool operator ==(Person x, Person y)
        {
            return object.Equals(x, y);
        }

        public static bool operator !=(Person x, Person y)
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
            Person otherPerson = obj as Person;
            return this.Email == otherPerson.Email;
        }

        public override int GetHashCode()
        {
            return this.Email.GetHashCode();
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            //sb.Append("{ ");
            sb.AppendLine("Name: " + Name);
            sb.AppendLine("Email: " + Email);
            sb.AppendLine("Telephone Number: " + TelNum);
            //sb.Append(" }");
            sb.AppendLine("\nAddress: " + _Address);

            return sb.ToString();
        }
    }
}
