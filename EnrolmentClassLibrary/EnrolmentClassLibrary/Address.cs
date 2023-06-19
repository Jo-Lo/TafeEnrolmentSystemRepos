using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentClassLibrary
{
    public class Address
    {
        public string Num { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }

        public Address(string _num, string _street, string _suburb, string _postcode, string _state)
        {
            Num = _num;
            Street = _street;
            Suburb = _suburb;
            Postcode = _postcode;
            State = _state;
        }


        public static bool operator ==(Address x, Address y)
        {
            return object.Equals(x, y);
        }

        public static bool operator !=(Address x, Address y)
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
            Address otherAddress = obj as Address;
            return this.Num == otherAddress.Num &&
                this.Street == otherAddress.Street &&
                this.Suburb == otherAddress.Suburb &&
                this.Postcode == otherAddress.Postcode &&
                this.State == otherAddress.State;
        }

        public override int GetHashCode()
        {
            return this.Num.GetHashCode() ^ this.Street.GetHashCode() ^ this.Suburb.GetHashCode() ^ this.Postcode.GetHashCode() ^ this.State.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("{");
            sb.AppendLine("Street Number: " + Num);
            sb.AppendLine("Street Name: " + Street);
            sb.AppendLine("Suburb: " + Suburb);
            sb.AppendLine("Postcode: " + Postcode);
            sb.AppendLine("State: " + State);
            sb.AppendLine("}");

            return sb.ToString();
        }
    }
}
