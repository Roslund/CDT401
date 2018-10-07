<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ComponentRepository.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="/Content/bootstrap.css" />
    <link rel="stylesheet" href="/Content/bootstrap.min.css" />
    <link rel="stylesheet" href="/Content/Site.css" />

</head>
<body>
    <form name="headerForm" runat="server">

     <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container" style="min-height: 50px; align-items: center;justify-content: center">
            
                            <asp:LinkButton ID="LinkButton1" runat="server">Component Repository</asp:LinkButton>
                            <asp:LinkButton ID="LinkButton2" runat="server">Admin Login</asp:LinkButton>
        </div>
    </div>
    <div class="container body-content">
    <div>
            <h1 class="test">Component repository</h1>
    </div>
        <hr />
        <footer>
            <p>&copy; Component Repository Group 2</p>
        </footer>
    </div>
       </form>

</body>
</html>
