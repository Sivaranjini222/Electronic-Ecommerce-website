<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="webappmasterpage.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        height: 12px;
    }
    .auto-style2 {
        width: 135px;
    }
    .auto-style3 {
        height: 12px;
        width: 135px;
    }
    .auto-style4 {
        width: 1794px;
    }
        .auto-style5 {
            width: 127px;
        }
        .auto-style6 {
            height: 12px;
            width: 127px;
        }
        .auto-style7 {
            width: 135px;
            height: 29px;
        }
        .auto-style8 {
            height: 29px;
        }
        .auto-style9 {
            width: 127px;
            height: 29px;
        }
        .auto-style10 {
            height: 29px;
            width: 306px;
        }
        .auto-style11 {
            height: 12px;
            width: 306px;
        }
        .auto-style12 {
            width: 306px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style4">
    <tr>
        <td class="auto-style7"></td>
        <td class="auto-style10"></td>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style8"></td>
        <td class="auto-style8"></td>
        <td class="auto-style8"></td>
    </tr>
    <tr>
        <td class="auto-style3">
            &nbsp;</td>
        <td class="auto-style11">
            &nbsp;</td>
        <td class="auto-style6">
            <asp:Label ID="Label1" runat="server" Text="Username" Font-Bold="True" Font-Italic="True"></asp:Label>
        </td>
        <td class="auto-style1">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style1"></td>
        <td class="auto-style1"></td>
    </tr>
    <tr>
        <td class="auto-style2">
            &nbsp;</td>
        <td class="auto-style12">
            &nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style12">&nbsp;</td>
        <td class="auto-style5">
            <asp:Label ID="Label2" runat="server" Text="Password" Font-Bold="True" Font-Italic="True"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style12">
            &nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style12">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" ForeColor="#FF9900" Text="Login" OnClick="Button1_Click" />
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style12">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
