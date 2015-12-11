<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarKpiVentas.aspx.cs" Inherits="PresentacionWebForms.CenfotecSite.Kpi.ListarKpiVentas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section class="content-header">
        <h1>Kpi Ventas
              <small>Listar</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-dashboard"></i>Inicio</a></li>
            <li class="active">Kpi Ventas</li>
        </ol>
    </section>
    <br />
    <section class="content">
        <asp:Label id="msjListaVacia" runat="server">No hay Kpis creados</asp:Label>
        <asp:GridView ID="GridKpisData" CssClass="table table-striped table-hover" runat="server" DataKeyNames="id_kpi" OnRowCommand="FireRowCommand"   AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="id_kpi" HeaderText="Id"/>
                <asp:BoundField DataField="indicador" HeaderText="Indicador" />
                <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
                <asp:TemplateField HeaderText="Ver Resultados">
                    <ItemTemplate>
                        <asp:LinkButton ID="btnVerResultados" runat="server" CommandArgument='<%# Eval("id_kpi") %>'
                         CommandName="VerResultados" Text="Ver" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </section>
</asp:Content>
