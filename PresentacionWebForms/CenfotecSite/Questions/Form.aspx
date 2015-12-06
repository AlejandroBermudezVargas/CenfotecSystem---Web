<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="PresentacionWebForms.CenfotecSite.Questions.Form" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section class="content-header">
        <h1>Preguntas
              <small>Crear</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-dashboard"></i>Inicio</a></li>
            <li class="active">Preguntas</li>
        </ol>
    </section>
    <br />
    <section class="content">
        <asp:Panel id="panelConfirmacion" runat="server" CssClass="alert alert-info">
            <a href="#" class="close" data-dismiss="alert" aria-label="close" style="text-decoration:none">&times;</a>
            <strong>Éxito!</strong> La pregunta ha sido almacenada.
        </asp:Panel>
        <div class="form-group">
            <label for="txtPregunta">Pregunta:</label>
            <asp:TextBox ID="txtPregunta" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server"
              ControlToValidate="txtPregunta"
              ErrorMessage="Campo requerido."
              ForeColor="Red">
            </asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <label for="sltPeso">Peso:</label>
            <asp:DropDownList ID="sltPeso" runat="server" CssClass="form-control">
                <asp:ListItem>--Seleccione--</asp:ListItem>
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator runat="server" 
                ControlToValidate="sltPeso"
                ErrorMessage="Campo requerido." InitialValue="--Seleccione--"
                ForeColor="Red">
            </asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <div class="text-center">
                <asp:Button id="btnSaveQuestion" Text="Continuar" runat="server" CssClass="btn btn-success" OnClick="btnSaveQuestion_Click"/>
                <a href ="../../CenfotecSite/Questions/List.aspx" class="btn btn-primary">Cancelar</a>
            </div>
        </div>
    </section>
</asp:Content>
