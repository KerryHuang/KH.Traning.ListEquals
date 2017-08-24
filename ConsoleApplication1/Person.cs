using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApplication1
{
    public class Name
    {
        public string FristName { get; set; }
        public string LastName { get; set; }

        public Name()
        {
        }

        public Name(string frisName, string lastName)
        {
            this.FristName = frisName;
            this.LastName = lastName;
        }
    }

    [Serializable]
    public class Person
    {
        public int Age { get; set; }
        public string Address { get; set; }
        public Name Name { get; set; }
    }
}
