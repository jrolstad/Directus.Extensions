using System.IO;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace Directus.Extensions.MVC
{
    /// <summary>
    /// Extensions for an MVC controller
    /// </summary>
    public static class ControllerExtensions
    {
        /// <summary>
        /// Converts a given object to an XML result
        /// </summary>
        /// <typeparam name="T">Type of object to convert</typeparam>
        /// <param name="controller">Controller this is extending</param>
        /// <param name="model">Object to convert</param>
        /// <returns></returns>
        public static ContentResult Xml<T>(this Controller controller, T model)
        {
            
            // Serialize them as XML
            var xmlSerializer = new XmlSerializer(typeof(T));
            var stringWriter = new StringWriter();
            xmlSerializer.Serialize(stringWriter, model);
            var serializedXML = stringWriter.ToString();

            // Return  the Content result
            var result = new ContentResult { Content = serializedXML, ContentType = @"text/xml" };
            return result;
        }

    }
}