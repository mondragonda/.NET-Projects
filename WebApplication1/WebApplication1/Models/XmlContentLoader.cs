using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WebApplication1.Models
{
    /// <summary>
    /// Esta clase realiza la operacion de carga de los archivos xml desde el disco duro
    /// </summary>
    public class XmlContentLoader
    {
        private string xmlPath;
        private string xmlContent;

        public XmlContentLoader(string xmlPath)
        {
            this.xmlPath = xmlPath;
        }

        public string GetXmlContent()
        {
            xmlContent = File.ReadAllText(xmlPath);

            return xmlContent;
        }
    }
}
