using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PersonComparer : IEqualityComparer<Person>
    {
        public Boolean Equals(Person p1, Person p2)
        {
            if (p1 == p2 || (p1.Age == p2.Age && p1.Name == p2.Name))
                return true;
            else
                return false;
        }

        public int GetHashCode(Person p1)
        {
            return (int)(Math.Pow(p1.Name.GetHashCode(), p1.Age));
        }
    }
}
