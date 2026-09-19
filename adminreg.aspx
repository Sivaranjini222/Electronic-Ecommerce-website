<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminreg.aspx.cs" Inherits="webappmasterpage.adminreg" %>
                 
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="container my-4">
         <table class="w-100">
             <tr>
                 <td class="auto-style1">&nbsp;</td>
                 <td class="auto-style2">&nbsp;</td>
                 <td class="auto-style7">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style1">&nbsp;</td>
                 <td class="auto-style2">&nbsp;</td>
                 <td class="auto-style7">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style1">&nbsp;</td>
                 <td class="auto-style2">
                     <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Text="Name"></asp:Label>
                 </td>
                 <td class="auto-style7">
                     <asp:TextBox ID="TextBox1" runat="server" Height="42px" Width="301px"></asp:TextBox>
                 </td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style1">&nbsp;</td>
                 <td class="auto-style2">&nbsp;</td>
                 <td class="auto-style7">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style1">&nbsp;</td>
                 <td class="auto-style2">
                     <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="True" Text="Email"></asp:Label>
                 </td>
                 <td class="auto-style7">
                     <asp:TextBox ID="TextBox2" runat="server" Height="49px" Width="304px"></asp:TextBox>
                 </td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style1">&nbsp;</td>
                 <td class="auto-style2">&nbsp;</td>
                 <td class="auto-style7">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style1">&nbsp;</td>
                 <td class="auto-style2">
                     <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Italic="True" Text="Phone Number"></asp:Label>
                 </td>
                 <td class="auto-style7">
                     <asp:TextBox ID="TextBox3" runat="server" Height="42px" Width="308px"></asp:TextBox>
                 </td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style1">&nbsp;</td>
                 <td class="auto-style2">&nbsp;</td>
                 <td class="auto-style7">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style1">&nbsp;</td>
                 <td class="auto-style2">
                     <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Italic="True" Text="Username"></asp:Label>
                 </td>
                 <td class="auto-style7">
                     <asp:TextBox ID="TextBox4" runat="server" Height="41px" Width="306px"></asp:TextBox>
                 </td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style1">&nbsp;</td>
                 <td class="auto-style2">&nbsp;</td>
                 <td class="auto-style7">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style4"></td>
                 <td class="auto-style5">
                     <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Italic="True" Text="Password"></asp:Label>
                 </td>
                 <td class="auto-style8">
                     <asp:TextBox ID="TextBox5" runat="server" Height="47px" Width="314px"></asp:TextBox>
                 </td>
                 <td class="auto-style6"></td>
                 <td class="auto-style6"></td>
             </tr>
             <tr>
                 <td class="auto-style1">&nbsp;</td>
                 <td class="auto-style2">&nbsp;</td>
                 <td class="auto-style7">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style1">&nbsp;</td>
                 <td class="auto-style2">&nbsp;</td>
                 <td class="auto-style7">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style1">&nbsp;</td>
                 <td class="auto-style2">&nbsp;</td>
                 <td class="auto-style7">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style1">&nbsp;</td>
                 <td class="auto-style2">&nbsp;</td>
                 <td class="auto-style7">
                     <asp:Button ID="Button1" runat="server" CssClass="auto-style3" Font-Bold="True" Font-Italic="True" ForeColor="#FF9900" OnClick="Button1_Click" Text="Register" Width="214px" />
                 </td>
                 <td>
                     <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                 </td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style1">&nbsp;</td>
                 <td class="auto-style2">&nbsp;</td>
                 <td class="auto-style7">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
         </table>
    </div>
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            width: 389px;
        }
        .auto-style2 {
            width: 196px;
        }
        .auto-style3 {
            margin-left: 25;
        }
        .auto-style4 {
            width: 389px;
            height: 35px;
        }
        .auto-style5 {
            width: 196px;
            height: 35px;
        }
        .auto-style6 {
            height: 35px;
        }
        .auto-style7 {
            width: 343px;
        }
        .auto-style8 {
            height: 35px;
            width: 343px;
        }
    </style>
</asp:Content>

