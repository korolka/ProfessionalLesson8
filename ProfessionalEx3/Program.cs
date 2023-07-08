//Завдання 3

//Створіть нову програму, в якій виконайте десеріалізацію об'єкта з попереднього прикладу. Відобразіть стан об'єкта на екрані.
using ProfessionalLesson8;
using System.IO;
using System.Xml.Serialization;

namespace ProfessionalEx3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ProfessionalLesson8.ExampleClass));
            FileStream fileStream;
            ProfessionalLesson8.ExampleClass exampleClass;
            //before add xmlAttribute
            fileStream = new FileStream("Serialize.xml", FileMode.Open);
            exampleClass = xmlSerializer.Deserialize(fileStream) as ExampleClass;

            //after add xmlAttribute
            fileStream = new FileStream("SerializeWithAttribute.xml", FileMode.Open);
            exampleClass = xmlSerializer.Deserialize(fileStream) as ExampleClass;

            Console.WriteLine($"Name : {exampleClass.Name}\n Age : {exampleClass.Age}\n ID : {exampleClass.Id}");
        }
    }
}