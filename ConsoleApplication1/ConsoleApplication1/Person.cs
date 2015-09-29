using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Person
    {
        public String Name
        {
            get;
            set;
        }
        
        private int age;
        public int Age
        {
            get { return age; }
            set { age = (value > 0) ? value : 1; }
        }


        public Person (String name, int age)
        {
            // Toujours utiliser la propriété
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return Name + " âgé(e) de " + Age + " ans";
        }
    }
}
