<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="E_commerce.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 312px;
    }
    .auto-style2 {
        width: 312px;
        height: 32px;
    }
    .auto-style3 {
        height: 32px;
    }
    .auto-style4 {
        width: 278px;
    }
    .auto-style5 {
        height: 32px;
        width: 278px;
    }
    .auto-style6 {
        width: 312px;
        height: 29px;
    }
    .auto-style7 {
        height: 29px;
        width: 278px;
    }
    .auto-style8 {
        height: 29px;
    }
    .auto-style9 {
        width: 368px;
    }
    .auto-style10 {
        height: 32px;
        width: 368px;
    }
    .auto-style11 {
        height: 29px;
        width: 368px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">
            &nbsp;</td>
        <td class="auto-style4">
            &nbsp;</td>
        <td class="auto-style9">
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#663300" Text="Login"></asp:Label>
        </td>
        <td>
            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" OnCommand="LinkButton1_Command">User Register</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            &nbsp;</td>
        <td class="auto-style4">
            &nbsp;</td>
        <td class="auto-style9">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2"></td>
        <td class="auto-style5">
            <asp:Label ID="Label1" runat="server" ForeColor="#993300" Text="Username"></asp:Label>
        </td>
        <td class="auto-style10">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style3">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter username" ForeColor="Red" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td class="auto-style4">
            <asp:Label ID="Label2" runat="server" ForeColor="#993300" Text="Password"></asp:Label>
        </td>
        <td class="auto-style9">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style6"></td>
        <td class="auto-style7"></td>
        <td class="auto-style11"></td>
        <td class="auto-style8">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style9">
            <asp:Button ID="Button1" runat="server" BorderColor="#FFFFCC" ForeColor="Maroon" Text="Login" OnClick="Button1_Click" />
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style9">
            <asp:Label ID="Label3" runat="server" ForeColor="#990000" Text="Label"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
