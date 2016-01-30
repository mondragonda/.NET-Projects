using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    /// <summary>
    /// Esta clase es un uploader del contenido de archivos xml al servicio web de sanborns
    /// </summary>
    public class XmlContentUploader
    {
        private SanbornsService.wCargaXmlSoapClient sanbornsServiceClient;
        private string xmlContent;

        public XmlContentUploader(string xmlContent)
        {
            this.xmlContent = xmlContent;
        }

        /// <summary>
        /// Enviar el contenido del xml al servicio  web de sanborns
        /// </summary>
        /// <returns>La respuesta del servicio web</returns>
        public string sendXmlContentToSanbornsService()
        {
            sanbornsServiceClient = new SanbornsService.wCargaXmlSoapClient();

            var response = sanbornsServiceClient.CargarFacDigXml(xmlContent, SanbornsProviderAccount.GetProviderNumber(), SanbornsProviderAccount.GetProviderRfc());

            return response;
        }

       
    }
}
