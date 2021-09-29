using System.Xml.Serialization;

namespace Task2
{
    public static class XmlSerializer<T>
    {
        public static readonly XmlSerializer Instance = new XmlSerializer(typeof(T));
    }
}