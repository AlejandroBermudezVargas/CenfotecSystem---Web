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
            <asp:GridView ID="GridQuestionsData" CssClass="table table-striped table-hover" runat="server" AllowCustomPaging="True" AutoGenerateColumns="False" GridLines="None" >
                <Columns>
                    <asp:BoundField DataField="id_pregunta" HeaderText="Id"/>
                    <asp:BoundField DataField="pregunta1" HeaderText="Preguntas" />
                    <asp:CommandField ShowEditButton="True" ShowSelectButton="True"  HeaderText="Acciones"/>
                </Columns>
            </asp:GridView>
        </div>
        <div class="text-right">
            <a href="../../CenfotecSite/Questions/Form.aspx" class="btn btn-info">Nueva pregunta</a>
        </div>
    </section>
</asp:Content>
