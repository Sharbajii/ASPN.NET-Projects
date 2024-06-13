<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASP.NET_Test.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <script src="~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
 <%:MyProperty%>
 <%:MyProperty2%>
        <div class="container">
                        <label for="txtName">Name</label>
                        <input type="text" class="form-control" id="txtName" placeholder="Enter Name" />
            </div>
       

        
    </form>
</body>

    <script>

    </script>
</html>
