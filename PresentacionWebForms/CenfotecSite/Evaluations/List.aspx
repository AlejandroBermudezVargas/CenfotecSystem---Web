<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="PresentacionWebForms.CenfotecSite.Evaluations.List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section class="content-header">
        <h1>Evaluaciones
              <small>Listar</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-dashboard"></i>Inicio</a></li>
            <li class="active">Evaluaciones</li>
        </ol>
    </section>
    <br />
    <section class="content">
        <div class="table-responsive">
            <asp:GridView ID="GridView1" CssClass="table table-hover" runat="server" >
                <Columns>
                    <asp:BoundField DataField="name" HeaderText="Nombre" />
                    <asp:BoundField DataField="evaluado" HeaderText="Evaluado" />
                    <asp:BoundField DataField="estado" HeaderText="Estado" />
                    <asp:BoundField DataField="contador" HeaderText="Realizadas/Faltantes" />
                    <asp:CommandField ShowEditButton="True" ShowSelectButton="True"  HeaderText="Acciones"/>
                </Columns>
            </asp:GridView>
        </div>


    </section>
</asp:Content>
