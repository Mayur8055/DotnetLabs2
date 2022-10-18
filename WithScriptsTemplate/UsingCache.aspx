<%@ Page MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="UsingCache.aspx.cs" Inherits="WithScriptsTemplate.UsingCache" %>
<%@ OutputCache Duration="15" VaryByControl="none" %>
<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <h1>Check the time for changes</h1><br />
     <h4><%=DateTime.Now.ToLongTimeString() %>
    <hr />
    <h1> Check the Listbox for changes</h1>
   
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Width="188px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" /><br />
    </h4>
    <br />
    <p>
        <asp:ListBox ID="ListBox1" runat="server" Height="103px" Width="194px"></asp:ListBox>
    </p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>

</asp:Content>
