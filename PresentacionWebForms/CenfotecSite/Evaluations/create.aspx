<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="create.aspx.cs" Inherits="PresentacionWebForms.CenfotecSite.Evaluations.create" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section class="content-header">
        <h1>Evaluaciones
              <small>Crear</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-dashboard"></i>Inicio</a></li>
            <li class="active">Evaluaciones</li>
        </ol>
    </section>
    <br />
    <section class="content">
        <asp:Panel id="panelConfirmacion" runat="server" CssClass="alert alert-info">
            <a href="#" class="close" data-dismiss="alert" aria-label="close" style="text-decoration:none">&times;</a>
            <strong>Éxito!</strong> La pregunta ha sido almacenada.
        </asp:Panel>
        <asp:Panel id="panelError" runat="server" CssClass="alert alert-danger">
            <a href="#" class="close" data-dismiss="alert" aria-label="close" style="text-decoration:none">&times;</a>
            <strong>Error!</strong> No se han podido cargar los datos.
        </asp:Panel>
        <div class="form">
            <asp:HiddenField ID="HiddenFieldPreguntas" runat="server" value=""/><!-- Aqui estaran los ids de las preguntas -->
            <div class="form-group">
                <label>Nombre:</label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtPorcentaje">Descripción</label>
                <textarea id="txtDescripcion" cols="20" rows="2" class="form-control" runat="server"></textarea>
            </div>
            <div class="form-group">
                <label for="sltCursos">Preguntas:</label>
                <ol id="olQuestions" class="selectable list-group" runat="server"></ol>
            </div>
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-success" OnClick="btnGuardar_Click"/>
            <a href ="List.aspx" class="btn btn-primary">Cancelar</a>
        </div>
        <script src="../../Scripts/createEvaluation.js"></script>
    </section>
</asp:Content>
