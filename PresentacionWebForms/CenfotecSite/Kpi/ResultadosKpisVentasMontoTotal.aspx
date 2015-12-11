<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ResultadosKpisVentasMontoTotal.aspx.cs" Inherits="PresentacionWebForms.CenfotecSite.Kpi.VerKpisVentasMontoTotal" %>
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
                    <td style="width: 115px">Meta&nbsp; Monto:</td>
                    <td style="width: 237px">                    
                        <asp:PlaceHolder ID="results_meta" runat="server"></asp:PlaceHolder>

                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 115px">Descripcion:</td>
                    <td style="width: 237px">                    
                        <asp:PlaceHolder ID="results_descripcion" runat="server"></asp:PlaceHolder>

                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 115px">Monto Total:</td>
                    <td style="width: 237px">
                        <asp:PlaceHolder ID="results_monto" runat="server"></asp:PlaceHolder>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 115px">Estado</td>
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
