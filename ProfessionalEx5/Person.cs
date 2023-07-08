﻿namespace ProfessionalEx5
{
    [Serializable]
    public class Person
    {
        private int age;
        private string name;
        public int Age { get { return age; } set { age = value; } }
        public string Name { get { return name; } set { name = value; } }

        public Person() { }

        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
    }
}
