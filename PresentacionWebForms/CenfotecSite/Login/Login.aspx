<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="PresentacionWebForms.CenfotecSite.Login.login" %>

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
                <h1 class="text-center login-title"></h1>
                <div class="account-wall">
                    <asp:Image class="profile-img" runat="server" ImageUrl="/Resources/logoU.png" alt="Logo" Height="125"></asp:Image>
                    <br />
                    <br />
                    <br />
                    <form class="form-signin" runat="server">
                        <asp:TextBox runat="server" ID="userName" class="form-control" placeholder="Usuario (Email)" required="true" />
                        <asp:TextBox runat="server" ID="password" class="form-control" placeholder="Contraseña" required="true" TextMode="Password" />
                        <br />
                        <asp:Button runat="server" class="btn btn-lg btn-primary btn-block" OnClick="Login1" Text="Ingresar" />
                        <label class="checkbox pull-left">
                        </label>
                    </form>
                </div>
                <a href="#" class="text-center new-account"></a>
            </div>
        </div>
    </div>

    <asp:Panel ID="mensajeError" runat="server" CssClass="alert alert-warning">
        <a href="#" class="close" data-dismiss="alert" aria-label="close" style="text-decoration: none">&times;</a>
        <strong>Error!</strong> La combinación de Nombre de Usuario y Contraseña no es correcta.
    </asp:Panel>

    <asp:Panel ID="mensajeError2" runat="server" CssClass="alert alert-warning">
        <a href="#" class="close" data-dismiss="alert" aria-label="close" style="text-decoration: none">&times;</a>
        <strong>Error!</strong> Este usuario se encuentra inactivo.
    </asp:Panel>
</body>
</html>
