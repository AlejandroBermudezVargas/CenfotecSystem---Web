<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="KpiVentas.aspx.cs" Inherits="PresentacionWebForms.CenfotecSite.Kpi.KpiVentas" %>
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
                    <td style="width: 115px">Indicadores:</td>
                    <td style="width: 237px">                    
                       <asp:DropDownList ID="DropDownIndicadores"  CssClass="btn btn-default dropdown-toggle" runat="server" >
                       </asp:DropDownList>

                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 115px"><asp:Button ID="generateKpiVentas" runat="server" Text="Generar" CssClass="btn btn-info" OnClick="generateKpiVentas_Click"  />  </td>
                    <td style="width: 237px">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                </table>
           
        </div>
    </section>
</asp:Content>
