<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="PresentacionWebForms.CenfotecSite.Questions.List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section class="content-header">
        <h1>Preguntas
              <small>Listar</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-dashboard"></i>Inicio</a></li>
            <li class="active">Preguntas</li>
        </ol>
    </section>
    <br />
    <section class="content">
        <div class="table-responsive">
            <h3 id="msjListaVacia" class="text-danger" runat="server">No hay preguntas para mostrar</h3>
            <asp:GridView ID="GridQuestionsData" CssClass="table table-striped table-hover" runat="server" AllowCustomPaging="True" AutoGenerateColumns="False" GridLines="None" OnRowEditing="GridQuestionsData_RowEditing">
                <Columns>
                    <asp:BoundField DataField="id_pregunta" HeaderText="Id" />
                    <asp:BoundField DataField="pregunta1" HeaderText="Pregunta" />
                    <asp:BoundField DataField="peso" HeaderText="Peso" />
                    <asp:CommandField ShowEditButton="True" HeaderText="Acciones" ShowDeleteButton="True" EditText="Editar" DeleteText="Eliminar"/>
                </Columns>
            </asp:GridView>
        </div>
        <br />
        <div class="pull-right">
            <a href="../../CenfotecSite/Questions/Form.aspx" class="btn btn-primary">Nueva pregunta</a>
        </div>
    </section>
</asp:Content>
