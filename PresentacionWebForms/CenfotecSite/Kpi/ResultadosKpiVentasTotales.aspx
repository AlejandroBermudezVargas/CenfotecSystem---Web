<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ResultadosKpiVentasTotales.aspx.cs" Inherits="PresentacionWebForms.CenfotecSite.Kpi.ResultadosKpiVentasTotales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section class="content-header">
        <h1>Kpi
            <small>Ventas</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-dashboard"></i>Inicio</a></li>
            <li class="active">Kpi</li>
        </ol>
    </section>
    <br />
    <section class="content">
        <div class="table-responsive">        
            <table style="width:100%;" class="table borderless">
                <tr>
                    <td colspan="2"><h1>Resultados</h1></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 161px">Total de Ventas:</td>
                    <td style="width: 237px">                    
                        <asp:PlaceHolder ID="results_meta" runat="server"></asp:PlaceHolder>

                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 161px">Descripcion:</td>
                    <td style="width: 237px">                    
                        <asp:PlaceHolder ID="results_descripcion" runat="server"></asp:PlaceHolder>

                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 161px">Indicadores Alcanzados:</td>
                    <td style="width: 237px">
                        <asp:PlaceHolder ID="results_venta" runat="server"></asp:PlaceHolder>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 161px">Estado</td>
                    <td style="width: 237px">
                        <asp:PlaceHolder ID="results_estado" runat="server"></asp:PlaceHolder>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                </table>
           
        </div>
        </section>
</asp:Content>
