<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AccountDetails.aspx.cs" Inherits="E_commerce.AccountDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 623px;
        }
        .auto-style2 {
            width: 414px;
        }
        .auto-style3 {
            height: 32px;
        }
        .auto-style4 {
            width: 414px;
            height: 32px;
        }
        .auto-style5 {
            width: 623px;
            height: 32px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style1">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style2">
            <asp:Label ID="Label1" runat="server" ForeColor="Maroon" Text="Account Number"></asp:Label>
        </td>
        <td class="auto-style1">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter Account number" ForeColor="#CC0000" Visible="False"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style2">
            <asp:Label ID="Label2" runat="server" ForeColor="Maroon" Text="Account Type"></asp:Label>
        </td>
        <td class="auto-style1">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style2">
            <asp:Label ID="Label3" runat="server" ForeColor="Maroon" Text="Balance Amount"></asp:Label>
        </td>
        <td class="auto-style1">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3"></td>
        <td class="auto-style4"></td>
        <td class="auto-style5"></td>
        <td class="auto-style3"></td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style1">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style1">
            <asp:Label ID="Label4" runat="server" ForeColor="#CC0000" Text="Label" Visible="False"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style1">
            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" PostBackUrl="~/User_home.aspx">Userhome page</asp:LinkButton>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style1">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style1">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
