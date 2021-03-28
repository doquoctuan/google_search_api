<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GoogleSearch.aspx.cs" Inherits="GoogleSearchCustom.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
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
            font-size:17px;
            text-indent:35px;
            font-family: arial,sans-serif;
            margin-left:30%;
        }
        .text:hover{
            box-shadow:1px 2px 20px #808080;
        }
        .btn{
            padding:10px;
            font-size:15px;
            width:150px;
            background-color:#f8f9fa;
            border-style:none;
            margin-left:15px;
            border-radius:10px; 
            outline:none;
        }
        .btn:hover{
            border: 1px solid #d6cfcf;
            background-color:#d3cdcd;
        }
        .img{
            margin-top:3%;
            margin-left:39%;
        }
        #fas{
            position:absolute;
            color:#d7d7c5;
            margin-left:460px;
            margin-top:13px
        }
        #fas1{
            position:absolute;
            color:#d7d7c5;
            margin-left:890px;
            margin-top:13px;
            cursor:pointer;
            color:#1c1717;
        }
        #fas2{
            position:absolute;
            color:#d7d7c5;
            margin-left:930px;
            margin-top:13px;
            color:#e76641;
            cursor:pointer;
        }

        #up{
            position:fixed;
            bottom:25px;
            right:25px;
            color:#808080;
            border : 1px solid black;
            border-radius:50%;
            padding:13px;
        }
        #daylabangne{
            margin-left:20%;
            max-width:900px;
        }
        .tddisplaylink{
            color:#1c8b56;
            font-size:19px;
        }
        .tdlink{
            color:blue;
            font-size:23px;
            margin-top:20px;
            margin-bottom:20px;
        }
        .tdsnippet{
            font-size:20px;
            color:#808080;
        }
        .count{
            margin-left:20%;
            font-family:Google Sans,arial,sans-serif;
            margin-top:-20px;
            color:#808080;
        }
        #btnPrePage,#btnNextPage{
            padding:10px;
            font-size:15px;
            width:120px;
            background-color:#f8f9fa;
            border-style:none;
            border-radius:10px; 
            outline:none;
            border:1px solid #808080;
        }
        #btnPrePage:hover,#btnNextPage:hover{
            background-color:#808080;
        }
        .button1{
            display:inline-block;
            flex-direction:row;
            margin-left:42%;
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
            <i id="fas" class="fas fa-search" style="font-size:20px;"></i>
            <i id="fas1" class="fas fa-keyboard" style="font-size:20px;"></i>
            <i id="fas2" class="fas fa-microphone-alt" style="font-size:20px;"></i>
            <asp:TextBox ID="txtKeyWord" runat="server" Height="27px" class="text"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" class="btn" Text="Tìm kiếm" />
        </p>
        
    <p id ="result">
        
            <asp:Label ID="lbResult" runat="server" Width="916px" Font-Size="Larger"></asp:Label>
    </p>
        <div class="button1">
            <asp:Button ID="btnPrePage" runat="server" Text="Previous" OnClick="btnPrePage_Click" />
            <asp:Button ID="btnNextPage" runat="server" Text="Next" OnClick="Button1_Click" />  
        </div>  
    </form>
    <a href="#"><i id="up"class="fa fa-arrow-up" style="font-size:17px;"></i></a>
    
</body>
</html>