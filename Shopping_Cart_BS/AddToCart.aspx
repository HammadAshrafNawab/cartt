<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddToCart.aspx.cs" Inherits="Shopping_Cart_BS.AddToCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1 style="color:indianred">Shopping Cart</h1>
        <p class="lead">This website is about Computer Products.</p>
    </div>

    <div class="row">
        <asp:DataList ID="DataList1" runat="server" RepeatLayout="Flow" RepeatDirection="Horizontal">
            <ItemTemplate>
                <div class="col-xs-6 col-md-3">
                    <div class="thumbnail">
                        <div class="card">
                            <img
                                class="card-img-top"
                                
                                src="./Images/<%# Eval("Imagess") %>"
                                alt="Card image"
                                style="width:100%; height:250px;" />
                            <div class="card-body" style="padding:10px;">
                                <h4 class="card-title">Product: <%# Eval("Name") %></h4>
                                <p class="card-text">Price Rs. <%# Eval("Price") %></p>
                                <asp:Button ID="btnAddtoCart" runat="server" Text="Add To Cart"
                                    CssClass="btn btn-danger" OnCommand="btnAddtoCart_Command"
                                    CommandName="viewdetails"
                                    CommandArgument='<%# Eval("ID") %>' />
                            </div>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:DataList>
    </div>
</asp:Content>
