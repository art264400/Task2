using System.IO;

namespace Task2
{
    public static class XsltExtender
    {
   
        public static string ToXml<T>(this T source)
        {
            using (var writer =  new StringWriter())
            {
                XmlSerializer<T>.Instance.Serialize(writer, source);
                return writer.ToString();
            }
        }
    }
}
