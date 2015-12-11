﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="PresentacionWebForms.CenfotecSite.Login.login"  %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <link href="../../Content/Site.css" rel="stylesheet" /> 
    <link href="../../Content/bootstrap.css" rel="stylesheet" />
   
</head>
<body id="loginPage">
    <div class="container">
    <div class="row" runat="server">
        <div class="col-sm-6 col-md-4 col-md-offset-4">
            <h1 class="text-center login-title">  </h1>
            <div class="account-wall">
                <asp:Image class="profile-img" runat="server" ImageUrl= "/Resources/logoU.png" alt="Logo" > </asp:Image>
                <form class="form-signin" runat="server">
                <asp:TextBox runat="server" ID="userName" class="form-control" placeholder="Usuario (Email)" required="true"/>
                <asp:TextBox runat="server" ID="password" class="form-control" placeholder="Contraseña" required="true" TextMode="Password"/>
                <asp:button runat="server" class="btn btn-lg btn-primary btn-block" onClick="Login" Text="Ingresar" />
                <label class="checkbox pull-left">
                </label>
                <a href="#" class="pull-right need-help">Olvidó su contraseña? </a><span class="clearfix"></span>
                </form>
            </div>
            <a href="#" class="text-center new-account"> </a>
        </div>
    </div>
</div>
</body>
</html>