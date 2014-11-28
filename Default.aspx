<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Garoe._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Presione el botón Iniciar para apagar todos los Equipos
    </h2>
<p>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Iniciar" />
    </p>
    <p>
        Desarrrollado por [AisaSoft] <a href="http://www.aisasoft.net" title="AisaSoft Website"> www.aisasoft.net</a> 
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
