<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="View_Cart.aspx.cs" Inherits="E_commerce.View_Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 733px;
        }
        .auto-style2 {
            width: 197px;
        }
        .auto-style3 {
            width: 197px;
            height: 32px;
        }
        .auto-style4 {
            width: 733px;
            height: 32px;
        }
        .auto-style5 {
            height: 32px;
        }
        .auto-style7 {
            width: 90px;
        }
        .auto-style8 {
            width: 202px;
        }
        .auto-style9 {
            width: 297px;
        }
        .auto-style10 {
            width: 653px;
        }
        .auto-style11 {
            height: 32px;
            width: 653px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style1">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="Product_Name" HeaderText="Product Name" />
                        <asp:ImageField DataImageUrlField="Product_Image" HeaderText="Product Image">
                            <ControlStyle Height="200px" Width="200px" />
                        </asp:ImageField>
                        <asp:BoundField DataField="Product_Description" HeaderText="Description" />
                        <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                        <asp:BoundField HeaderText="Total price" DataField="Total_Price" />
                        <asp:TemplateField HeaderText="Edit">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("Cart_Id") %>' OnCommand="LinkButton1_Command">Edit</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Delete">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("Cart_Id") %>' OnCommand="LinkButton2_Command">Delete</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
            <td class="auto-style10">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style1">
                                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Confirm" />
            </td>
            <td class="auto-style10">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style1">
                &nbsp;</td>
            <td class="auto-style10">
                <asp:Panel ID="Panel1" runat="server" Visible="False">
                    <table class="w-100">
                        <tr>
                            <td class="auto-style7">
                                <asp:Label ID="Label1" runat="server" ForeColor="#990000" Text="Quantity"></asp:Label>
                            </td>
                            <td class="auto-style8">
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style7">&nbsp;</td>
                            <td class="auto-style8">
                                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Edit" />
                            </td>
                            <td>
                                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Continue" />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style10">
                <asp:Panel ID="Panel2" runat="server" Visible="False">
                    <table class="w-100">
                        <tr>
                            <td class="auto-style9">
                                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style9">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style4">
                &nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style5"></td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style4"></td>
            <td class="auto-style11">
                &nbsp;</td>
            <td class="auto-style5"></td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
