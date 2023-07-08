//Завдання 2

//Створіть клас, який підтримує серіалізацію.
//Виконайте серіалізацію цього об'єкта у форматі XML.
//Спочатку використовуйте формат за промовчанням,
//а потім змініть його таким чином, щоб значення полів збереглися як атрибути елементів XML.
using System.Xml.Serialization;

namespace ProfessionalLesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExampleClass exampleClass = new ExampleClass();
            FileStream fileStream;
            XmlSerializer serializer = new XmlSerializer(typeof(ExampleClass));

            //fileStream = new FileStream("Serialize.xml", FileMode.Create);
            //serializer.Serialize(fileStream, exampleClass);

            fileStream = new FileStream("SerializeWithAttribute.xml", FileMode.Create);
            serializer.Serialize(fileStream, exampleClass);
            fileStream.Close();

        }
    }
}