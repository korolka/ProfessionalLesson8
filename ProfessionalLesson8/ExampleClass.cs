using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProfessionalLesson8
{
    [Serializable]
    public class ExampleClass
    {
        private int id = 4142;
        private string name = "Vlad";
        private int age= 22;

        [XmlAttribute]
        public int Id { get { return id; } set { id = value; } }

        [XmlAttribute]
        public string Name { get { return name; }
            set
            {
                name = value;
        }   }

        [XmlAttribute]
        public int Age { get { return age;} set { age = value; } }
    }
}
