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
        <asp:Label id="msjListaVacia" runat="server">No hay preguntas creadas</asp:Label>
        <asp:GridView ID="GridQuestionsData" CssClass="table table-striped table-hover" runat="server" AllowCustomPaging="True" AutoGenerateColumns="False" GridLines="None" OnRowEditing="GridQuestionsData_RowEditing" >
            <Columns>
                <asp:BoundField DataField="id_pregunta" HeaderText="Id"/>
                <asp:BoundField DataField="pregunta1" HeaderText="Pregunta" />
                <asp:BoundField DataField="peso" HeaderText="Peso" />
                <asp:CommandField ShowEditButton="True"  HeaderText="Acciones" ShowDeleteButton="True"/>
            </Columns>
        </asp:GridView>
        <div class="text-right">
            <a href="../../CenfotecSite/Questions/Form.aspx" class="btn btn-primary">Nueva pregunta</a>
        </div>
    </section>
</asp:Content>
