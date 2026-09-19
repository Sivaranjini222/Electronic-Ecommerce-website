<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="accountdetails.aspx.cs" Inherits="webappmasterpage.accountdetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 337px;
        }
        .auto-style2 {
            height: 29px;
        }
        .auto-style3 {
            width: 337px;
            height: 29px;
        }
        .auto-style4 {
            width: 331px;
        }
        .auto-style5 {
            height: 29px;
            width: 331px;
        }
    .auto-style6 {
        width: 106px;
    }
    .auto-style7 {
        width: 329px;
    }
    .auto-style8 {
        height: 210px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
    <asp:Panel ID="Panel1" runat="server">
        <table class="w-100">
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style3" style="color: #66CCFF">Account number</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style1">Account Name</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style1">Account Amount</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" />
                </td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
            </td>
        </tr>
        <tr>
            <td>
                <table class="w-100">
                    <tr>
                        <td class="auto-style8">
                            <asp:Panel ID="Panel3" runat="server" Height="143px" Width="1482px">
                                <table class="w-100">
                                    <tr>
                                        <td class="auto-style6">&nbsp;</td>
                                        <td class="auto-style7">&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                                        <td class="auto-style7">Grang Total</td>
                                        <td>
                                            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style6">&nbsp;</td>
                                        <td class="auto-style7">Balance Amount</td>
                                        <td>
                                            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                                            <br />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style6">&nbsp;</td>
                                        <td class="auto-style7">
                                            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style6">&nbsp;</td>
                                        <td class="auto-style7">&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style6">&nbsp;</td>
                                        <td class="auto-style7">&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style6">&nbsp;</td>
                                        <td class="auto-style7">&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style6">&nbsp;</td>
                                        <td class="auto-style7">&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style6">&nbsp;</td>
                                        <td class="auto-style7">&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </td>
                        <td class="auto-style8"></td>
                        <td class="auto-style8"></td>
                        <td class="auto-style8"></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Panel ID="Panel4" runat="server">
                                <table class="w-100">
                                    <tr>
                                        <td>
                                            <asp:Button ID="Button2" runat="server" Text="Feedback" Width="308px" OnClick="Button2_Click1" />
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
