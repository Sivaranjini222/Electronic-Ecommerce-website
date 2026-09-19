<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master"
    AutoEventWireup="true"
    CodeBehind="viewcart.aspx.cs"
    Inherits="webappmasterpage.viewcart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style>

        .cart-container {
            width: 90%;
            margin: auto;
            padding: 20px;
        }

        .cart-title {
            text-align: center;
            font-size: 32px;
            font-weight: bold;
            color: #333;
            margin-bottom: 25px;
        }

        .cart-table {
            width: 100%;
            border-collapse: collapse;
            background-color: white;
            box-shadow: 0px 0px 10px #cccccc;
        }

        .cart-table th {
            background-color: #007bff;
            color: white;
            padding: 15px;
            text-align: center;
            font-size: 16px;
        }

        .cart-table td {
            padding: 15px;
            text-align: center;
            border-bottom: 1px solid #dddddd;
        }

        .cart-table tr:hover {
            background-color: #f5f5f5;
        }

        .product-img {
            border-radius: 10px;
        }

        .qty-box {
            width: 60px;
            padding: 5px;
            text-align: center;
        }

        .btn-update {
            background-color: #28a745;
            color: white;
            border: none;
            padding: 8px 15px;
            border-radius: 5px;
            cursor: pointer;
        }

        .btn-update:hover {
            background-color: #218838;
        }

        .btn-main {
            background-color: #007bff;
            color: white;
            border: none;
            padding: 10px 20px;
            margin: 10px;
            border-radius: 5px;
            font-size: 16px;
            cursor: pointer;
        }

        .btn-main:hover {
            background-color: #0056b3;
        }

        .total-label {
            font-size: 22px;
            font-weight: bold;
            color: #d9534f;
        }

    </style>

</asp:Content>

<asp:Content ID="Content2"
    ContentPlaceHolderID="ContentPlaceHolder1"
    runat="server">

    <div class="cart-container">

        <div class="cart-title">
            Shopping Cart
        </div>

        <asp:GridView ID="GridView1"
            runat="server"
            AutoGenerateColumns="False"
            CssClass="cart-table"
            GridLines="None">

            <Columns>

                <asp:BoundField
                    DataField="proname"
                    HeaderText="Product Name" />

                <asp:TemplateField HeaderText="Image">

                    <ItemTemplate>

                        <asp:Image ID="Image1"
                            runat="server"
                            CssClass="product-img"
                            ImageUrl='<%# Eval("proimage") %>'
                            Height="100px"
                            Width="100px" />

                    </ItemTemplate>

                </asp:TemplateField>

                <asp:BoundField
                    DataField="proprice"
                    HeaderText="Price" />

                <asp:TemplateField HeaderText="Quantity">

                    <ItemTemplate>

                        <asp:TextBox ID="TextBox1"
                            runat="server"
                            CssClass="qty-box"
                            Text='<%# Eval("quantity") %>'>
                        </asp:TextBox>

                    </ItemTemplate>

                </asp:TemplateField>

                <asp:BoundField
                    DataField="subtotal"
                    HeaderText="Subtotal" />

                <asp:TemplateField HeaderText="Update">

                    <ItemTemplate>

                        <asp:Button ID="Button1"
                            runat="server"
                            Text="Update"
                            CssClass="btn-update"
                            CommandArgument='<%# Eval("cartid") %>'
                            OnCommand="Button1_Command" />

                    </ItemTemplate>

                </asp:TemplateField>

            </Columns>

        </asp:GridView>

        <br />

        <center>

            <asp:Button ID="Button2"
    runat="server"
    Text="Confirm Order"
    CssClass="btn-main"
    OnClick="Button2_Click" />

<asp:Button ID="Button3"
    runat="server"
    Text="View Bill"
    CssClass="btn-main"
    OnClick="Button3_Click" />

            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="payment" />

            <br /><br />

            <asp:Label ID="Label1"
                runat="server"
                CssClass="total-label">
            </asp:Label>

        </center>

    </div>

</asp:Content>