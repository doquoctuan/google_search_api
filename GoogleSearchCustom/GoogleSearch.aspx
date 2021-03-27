<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GoogleSearch.aspx.cs" Inherits="GoogleSearchCustom.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #form1{
            margin-left: 30%;
        }
        #result{
            margin-left: 20%;
        }
        .text{
            border-radius:20px;
            border:1px solid black;
            border-style:none;
            box-shadow:1px 1px 3px #808080;
            outline:none;
            width:500px;
            padding:10px;
            font-size:20px;
        }
        .btn{
            padding:10px;
            font-size:15px;
            width:150px;
            background-color:#f8f9fa;
            border-style:none;
            margin-left:15px;
            border-radius:10px; 
        }
        .img{
            margin-top:3%;
            margin-left:39%;
        }
    </style>
    
    <script src='https://kit.fontawesome.com/a076d05399.js' crossorigin='anonymous'></script>
</head>
<body>
    <div>
        <asp:Image ID="Image1" runat="server" Height="81px" ImageUrl="~/resource/logo.png" Width="273px" class="img" />
    </div>
    <form id="form1" runat="server">
        <p>
            <asp:TextBox ID="txtKeyWord" runat="server" Height="27px" class="text"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" class="btn" Text="Tìm kiếm" />
        </p>
        
    </form>
    <p id ="result">
        <asp:Label ID="lbResult" runat="server" Width="916px" Font-Size="Larger"></asp:Label>
    </p>
</body>
</html>
