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
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-primary" />
        </div>
        <script src="../../Scripts/createEvaluation.js"></script>
    </section>
</asp:Content>
