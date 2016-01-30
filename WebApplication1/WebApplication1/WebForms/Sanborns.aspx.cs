using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;

namespace WebApplication1.WebForms
{
    public partial class Sanborns : System.Web.UI.Page
    {
        protected override void OnPreInit(EventArgs e)
        {
            if (Request.QueryString["print"] != null)
            {
                Page.MasterPageFile = @"~\Print.Master";
            }
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SendXml();
        }

        private bool IsFileLoaded()
        {
            if (FileUpload1.HasFile)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsXmlFile()
        {
            var fileName = FileUpload1.FileName;

            var fileNameMatchesXmlExtension = Regex.IsMatch(fileName, "[A-Za-z0-9].xml");

            if (fileNameMatchesXmlExtension)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SendXml()
        {
            if (IsFileLoaded())
            {
                if (IsXmlFile())
                {
                    SendXmlToSanbornsService();
                }
                else
                {
                    DisplayInvalidLoadedFileWarning();
                }
            }
            else
            {
                DisplayNoFileLoaded();
            }
        }

        private void SendXmlToSanbornsService()
        {
            var pathOfSavedFile = SaveXmlFileInLocalStorage();

            var content = GetXmlContentFromSavedFile(pathOfSavedFile);

            var serviceResponse = UploadXmlContentToSanbornsService(content);

            DisplaySanbornsServiceResponse(serviceResponse);
        }

        private string SaveXmlFileInLocalStorage()
        {
            string savePath = CreateSavePath();

            FileUpload1.SaveAs(savePath);

            return savePath;
        }

        private string CreateSavePath()
        {
            var path = @"C:\Users\Compu\Documents\Visual Studio 2015\Projects\WebApplication1\WebApplication1\FileContainer";
            var fileName = FileUpload1.FileName;
            var savePath = path + fileName;

            return savePath;
        }


        private string GetXmlContentFromSavedFile(string pathOfSavedFile)
        {
            var loader = new XmlContentLoader(pathOfSavedFile);

            var xmlContent = loader.GetXmlContent();

            return xmlContent;
        }

        private string UploadXmlContentToSanbornsService(string xmlContent)
        {
            var uploader = new XmlContentUploader(xmlContent);
            var response = uploader.sendXmlContentToSanbornsService();

            return response;
        }

        private void DisplaySanbornsServiceResponse(string response)
        {
            sanbornsResponseMessageLabel.Text = response;
        }

        private void DisplayInvalidLoadedFileWarning()
        {
            validationFileLabel.Text = "Has cargado un archivo inválido";
        }

        private void DisplayNoFileLoaded()
        {
            validationFileLabel.Text = "No has cargado ningún archivo";
        }
     
    }
}