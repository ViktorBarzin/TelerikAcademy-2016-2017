using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StudentClass
{
    public class Student : IEquatable<Student>, ICloneable, IComparable
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string MiddleName { get; private set; }

        // TODO: not sure what ssn is...
        public string SSN { get; private set; }

        public string PermanentAddress { get; private set; }

        public uint MobilePhoneNumber { get; private set; }

        public string Email { get; private set; }

        public string Course { get; private set; }

        public override string ToString()
        {
            return this.FirstName + ' ' + this.LastName;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            return this.Equals((Student)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (this.FirstName != null ? this.FirstName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (this.LastName != null ? this.LastName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (this.MiddleName != null ? this.MiddleName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (this.SSN != null ? this.SSN.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (this.PermanentAddress != null ? this.PermanentAddress.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (int)this.MobilePhoneNumber;
                hashCode = (hashCode * 397) ^ (this.Email != null ? this.Email.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (this.Course != null ? this.Course.GetHashCode() : 0);
                return hashCode;
            }
        }

        public bool Equals(Student other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return string.Equals(this.FirstName, other.FirstName)
                && string.Equals(this.LastName, other.LastName)
                && string.Equals(this.MiddleName, other.MiddleName)
                && string.Equals(this.SSN, other.SSN)
                && string.Equals(this.PermanentAddress, other.PermanentAddress)
                && this.MobilePhoneNumber == other.MobilePhoneNumber
                && string.Equals(this.Email, other.Email)
                && string.Equals(this.Course, other.Course);
        }

        public static bool operator ==(Student left, Student right) => Equals(left, right);

        public static bool operator !=(Student left, Student right) => !Equals(left, right);

        public object Clone()
        {
            // All of the properties behave as value types so copying should be simple as that.
            return
                new Student()
                {
                    Course = this.Course,
                    Email = this.Email,
                    FirstName = this.FirstName,
                    LastName = this.LastName,
                    MiddleName = this.MiddleName,
                    MobilePhoneNumber = this.MobilePhoneNumber,
                    PermanentAddress = this.PermanentAddress,
                    SSN = this.SSN
                };
        }

        public int CompareTo(object obj)
        {
            var tempStudent = obj as Student;
            if (this.FirstName.CompareTo(tempStudent.FirstName) < 0)
            {
                return -1;
            }
            if (this.FirstName.CompareTo(tempStudent.FirstName) > 0)
            {
                return 1;
            }

            if (this.SSN.CompareTo(tempStudent.SSN) < 0)
            {
                return -1;
            }
            if (this.SSN.CompareTo(tempStudent.SSN) > 0)
            {
                return 1;
            }

            return 0;
        }
    }
}
