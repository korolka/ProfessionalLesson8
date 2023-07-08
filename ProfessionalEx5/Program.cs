using System.IO.Compression;
using System.Xml.Serialization;

namespace ProfessionalEx5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person(22, "Vlad");
            FileStream fileStream = new FileStream("Serialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            xmlSerializer.Serialize(fileStream, person);
            fileStream.Close();

            FileStream fileStream2 = new FileStream("Serialize.xml", FileMode.Open, FileAccess.Read);

            FileStream fileStreamZip = new FileStream("serializeCompressed.rar", FileMode.Create);
            GZipStream gZipStream = new GZipStream(fileStreamZip, CompressionMode.Compress);
            fileStream2.CopyTo(gZipStream);

            gZipStream.Close();
            fileStream2.Close();
        }
    }
}