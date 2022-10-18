<%@ Page MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="UsingValidators.aspx.cs" Inherits="WithScriptsTemplate.UsingValidators" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <h1>Using all Validators</h1>
    <p>&nbsp;</p>
    <p>UsingRequired :
        <asp:TextBox ID="txtRequired" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtRequired" ErrorMessage="This field is mandatory" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    </p>
    <p>UsingCompare :<asp:TextBox ID="txtCompare1" runat="server"></asp:TextBox>
&nbsp; vs
        <asp:TextBox ID="txtCompare2" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtCompare2" ControlToValidate="txtCompare1" ErrorMessage="Values doesn't match" ForeColor="#CC0000"></asp:CompareValidator>
    </p>
    <p>UsingRange :&nbsp;&nbsp;
        <asp:TextBox ID="txtRange" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtRange" ErrorMessage="Invalid Range" ForeColor="#CC0000" MaximumValue="99" MinimumValue="18"></asp:RangeValidator>
    </p>
    <p>UsingRegularExpression :&nbsp;
        <asp:TextBox ID="txtRegular" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtRegular" ErrorMessage="Invalid Email address" ForeColor="#CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </p>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    <hr />

</asp:Content>
