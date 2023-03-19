using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareObject
{
    public class Students : IEquatable<Students>
    {
        public int studentid;
        public string name;

        public bool Equals(Students? other)
        {
            if (ReferenceEquals(other,null))
            {
                return false;
            }
            if (ReferenceEquals(other,this)) { return true; }

            return studentid.Equals(other.studentid) && name.Equals(other.name);
        }
    }
}
