<%@ Page Title="" Language="C#" MasterPageFile="~/WebForms/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.WebForms.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style10 {
            background-color: #FFFFFF;
        }
        .auto-style20 {
            border-style: solid;
            border-width: 1px;
            padding: 1px 4px;
            position: relative;
            left: 4px;
            top: 7px;
            width: 291px;
            height: 275px;
        }
        .auto-style22 {
            text-align: center;
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #FFFFFF;
            background-color: #003366;
        }
        .auto-style25 {
            width: 129px;
        }
        .auto-style27 {
            height: 26px;
        }
        .auto-style28 {
            height: 26px;
            text-align: center;
        }
        .auto-style30 {
            width: 129px;
            height: 26px;
            text-align: right;
        }
        .auto-style31 {
            width: 129px;
            text-align: right;
        }
        .auto-style34 {
            height: 26px;
            text-align: right;
        }
        .auto-style36 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
        }
        .auto-style37 {
            position: absolute;
            top: 3px;
            left: 75px;
        }
        .auto-style38 {
            border-style: solid;
            border-width: 1px;
            padding: 1px 4px;
            position: relative;
            left: 5px;
            top: -142px;
            width: 286px;
            height: 297px;
        }
        .auto-style39 {
            text-align: center;
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #FFFFFF;
            background-color: #003366;
            height: 20px;
        }
        .auto-style41 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            margin-left: 0px;
            background-color: #FFFFFF;
        }
        .auto-style46 {
            height: 26px;
            text-align: right;
            width: 12px;
        }
        .auto-style50 {
        width: 101%;
        position: relative;
        left: 0px;
        top: 0px;
    }
        .auto-style51 {
            width: 12px;
        }
        .auto-style52 {
            height: 26px;
            width: 12px;
        }
        .auto-style53 {
            height: 26px;
            text-align: center;
            width: 12px;
        }
        .auto-style55 {
            width: 101%;
        }
        .auto-style59 {
            font-weight: normal;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" CssClass="auto-style10" Height="929px">
        &nbsp;<br />
        <asp:Panel ID="Panel3" runat="server" CssClass="auto-style20">
            <table class="auto-style50">
                <tr>
                    <td class="auto-style39" colspan="3"><strong class="auto-style37" style="z-index: 1"><span class="auto-style59">Ingreso de Usuarios</span></strong></td>
                </tr>
                <tr>
                    <td class="auto-style25">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style51">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style30">
                        <asp:Label ID="Label12" runat="server" CssClass="auto-style36" Text="Usuario"></asp:Label>
                        :</td>
                    <td class="auto-style27">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style52">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="El usuario es requerido.">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style31">
                        <asp:Label ID="Label13" runat="server" CssClass="auto-style36" Text="RFC"></asp:Label>
                        :</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style51">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="El RFC es requerido.">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style34" colspan="2">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                    </td>
                    <td class="auto-style52">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style28" colspan="2">
                        <asp:LinkButton ID="OlvidoContrasenaLabel" runat="server">¿Olvidó su contraseña?</asp:LinkButton>
                    </td>
                    <td class="auto-style53">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style28" colspan="2">
                        &nbsp;</td>
                    <td class="auto-style53">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style34" colspan="2">
                        <asp:Button ID="Button5" runat="server" CssClass="auto-style41" Height="20px" Text="Ingresar" Width="109px" />
                    </td>
                    <td class="auto-style53">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style34" colspan="2">
                        &nbsp;</td>
                    <td class="auto-style46">&nbsp;</td>
                </tr>
            </table>
        </asp:Panel>


        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        &nbsp;<asp:Panel ID="Panel4" runat="server" CssClass="auto-style38">
            <table class="auto-style55">
                <tr>
                    <td class="auto-style22" colspan="3">Registro de nuevo usuario</td>
                </tr>
                <tr>
                    <td class="auto-style25">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style30">
                        <asp:Label ID="Label15" runat="server" CssClass="auto-style36" Text="Nombre"></asp:Label>
                        :</td>
                    <td class="auto-style27">
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style27">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style31">
                        <asp:Label ID="Label16" runat="server" CssClass="auto-style36" Text="Dirección"></asp:Label>
                        :</td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style30">
                        <asp:Label ID="Label17" runat="server" CssClass="auto-style36" Text="Teléfono"></asp:Label>
                        :</td>
                    <td class="auto-style27">
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style27">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style30">
                        <asp:Label ID="Label18" runat="server" CssClass="auto-style36" Text="RFC:"></asp:Label>
                    </td>
                    <td class="auto-style27">
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style27">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style30">
                        <asp:Label ID="Label19" runat="server" CssClass="auto-style36" Text="E-mail:"></asp:Label>
                    </td>
                    <td class="auto-style27">
                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style27">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style30">
                        <asp:Label ID="Label20" runat="server" CssClass="auto-style36" Text="Contraseña:"></asp:Label>
                    </td>
                    <td class="auto-style27">
                        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style27">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style28" colspan="2">&nbsp;</td>
                    <td class="auto-style28">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style34" colspan="2">
                        <asp:Button ID="Button3" runat="server" CssClass="auto-style41" Height="20px" Text="Crear Usuario" Width="109px" OnClick="Button3_Click" />
                    </td>
                    <td class="auto-style34">&nbsp;</td>
                </tr>
            </table>
            <ajaxToolkit:ConfirmButtonExtender ID="cbe" ConfirmText="Deseas registrarte?" TargetControlID="Button3" runat="server" />
           
        </asp:Panel>
        <br />
    </asp:Panel>
    <span class="auto-style10">&nbsp;</span>
</asp:Content>
