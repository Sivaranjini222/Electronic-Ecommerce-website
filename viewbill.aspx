<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master"
AutoEventWireup="true"
CodeBehind="viewbill.aspx.cs"
Inherits="webappmasterpage.viewbill" %>

<asp:Content ID="Content1"
ContentPlaceHolderID="head"
runat="server">
</asp:Content>

<asp:Content ID="Content2"
ContentPlaceHolderID="ContentPlaceHolder1"
runat="server">

    <center>

        <h2>BILL DETAILS</h2>

        <table border="1" style="width:700px">

            <tr>
                <td>User Name</td>

                <td>
                    <asp:Label ID="Label1"
                        runat="server">
                    </asp:Label>
                </td>
            </tr>

            <tr>
                <td>Address</td>

                <td>
                    <asp:Label ID="Label2"
                        runat="server">
                    </asp:Label>
                </td>
            </tr>

            <tr>
                <td>Phone</td>

                <td>
                    <asp:Label ID="Label3"
                        runat="server">
                    </asp:Label>
                </td>
            </tr>

            <tr>
                <td>Bill Date</td>

                <td>
                    <asp:Label ID="Label4"
                        runat="server">
                    </asp:Label>
                </td>
            </tr>

        </table>

        <br />

        <asp:GridView ID="GridView1"
            runat="server"
            AutoGenerateColumns="False">

            <Columns>

                <asp:BoundField DataField="proname"
                    HeaderText="Product Name" />

                <asp:TemplateField HeaderText="Image">

                    <ItemTemplate>

                        <asp:Image ID="Image1"
                            runat="server"
                            ImageUrl='<%# Eval("proimage") %>'
                            Height="100px"
                            Width="100px" />

                    </ItemTemplate>

                </asp:TemplateField>

                <asp:BoundField DataField="proprice"
                    HeaderText="Price" />

                <asp:BoundField DataField="quantity"
                    HeaderText="Quantity" />

                <asp:BoundField DataField="subtotal"
                    HeaderText="Subtotal" />

            </Columns>

        </asp:GridView>

        <br />

        <h3>

            Grand Total :

            <asp:Label ID="Label5"
                runat="server">
            </asp:Label>

        </h3>

    </center>

</asp:Content>