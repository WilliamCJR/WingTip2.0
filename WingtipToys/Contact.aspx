<%@ Page Title="Contacto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WingtipToys.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        Bogota. <br />
        Calle 85 #45-67.<br />
        <abbr title="Phone">Tel : 321-234-3456</abbr>

    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">soportewing@gmail.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketingwing@gmail.com</a>
    </address>
</asp:Content>
