<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Shopping_Cart_BS.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <table style="height: 346px; width: 737px">
            <tr>
                <th>Id</th>
                <td>
                    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnSearch" runat="server" Text="Search"  />
                </td>
            </tr>
            <tr>
                <th>Name</th>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
                <td></td>
            </tr>
            <tr>
                <th>DESCRIPRION</th>
                <td>
                    <asp:TextBox ID="txtdescription" runat="server"></asp:TextBox>
                </td>
                <td></td>
            </tr>
           <tr>
                <th>PRICE</th>
                <td>
                    <asp:TextBox ID="txtprice" runat="server"></asp:TextBox>
                </td>
                <td></td>
            </tr>
         
              
          
          <tr>
                <th>IMAGE</th>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
                <td>

                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnAdd" runat="server" Text="ADD"  onClick="btnAdd_Click1" />
                </td>
                <td>
                    <asp:Button ID="btnUpdate" runat="server" Text="UPDATE"   />
                </td>
                <td>
                    <asp:Button ID="btnDelete" runat="server" Text="DELETE"   />
                </td>
            </tr>
    </form>
</body>
</html>
