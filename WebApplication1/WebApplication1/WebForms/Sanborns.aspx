<%@ Page Title="" Language="C#" MasterPageFile="~/WebForms/Site1.Master" AutoEventWireup="true" CodeBehind="Sanborns.aspx.cs" Inherits="WebApplication1.WebForms.Sanborns" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style24 {
        font-size: medium;
        font-family: Arial, Helvetica, sans-serif;
        font-weight: normal;
    }
    .auto-style25 {
        width:421px;
        border-style: solid;
        border-width: 1px;
        position:relative;
            left: 447px;
            top: -1px;
        }

    .auto-style26 {
        width: 300px;
    }

    .auto-style27 {
        height: 12px;
        text-align: center;
        font-family: Arial, Helvetica, sans-serif;
        font-size: small;
        color: #FFFFFF;
        background-color: #003366;
            width: 419px;
        }
    .auto-style28 {
        text-align: left;
            width: 419px;
        }
    .auto-style29 {
        text-align: right;
            width: 419px;
        }
        .auto-style30 {
            text-align: center;
            width: 419px;
        }
        .auto-style31 {
            width: 419px;
        }
        .auto-style32 {
            font-size: large;
            font-family: Arial, Helvetica, sans-serif;
            font-weight: normal;
            width: 100%;
        text-align: center;
    }
    .auto-style33 {
        text-align: center;
    }
    .auto-style34 {
        font-family: Arial, Helvetica, sans-serif;
    }
    .auto-style35 {
        background-color: #FFFFFF;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="auto-style32" ><sup>En esta página podra enviar los archivos XML correspondientes a las facturas a pagar por parte de SANBORNS. Para subir un archivo XML, dé click en Seleccionar Archivo, después, elija el archivo XML a subir de su computadora y finalmente dé click en Enviar XML.</sup></h1>
<p class="auto-style24">&nbsp;</p>
<asp:Panel ID="Panel1" runat="server" HorizontalAlign="Center" Cssclass="auto-style25">
    <table class="auto-style26">
        <tr>
            <td class="auto-style27">ENVÍO DE XML</td>
        </tr>
        <tr>
            <td class="auto-style31">
                <asp:FileUpload ID="FileUpload1" runat="server" Width="410px" Height="32px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style28">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">
                <asp:Button ID="Button1" runat="server" Text="Enviar XML" OnClick="Button1_Click" CssClass="auto-style35" Height="19px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style30">
                <asp:Label ID="validationFileLabel" runat="server" CssClass="auto-style34"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style30">
                <asp:Label ID="sanbornsResponseMessageLabel" runat="server" CssClass="auto-style34"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Panel>
<div class="auto-style33">
</div>
<p class="auto-style24">&nbsp;</p>
<p class="auto-style24">&nbsp;</p>
<a href="Sanborns.aspx?print=true" id="hrefPrint" class="auto-style24">Print</a>
</asp:Content>

