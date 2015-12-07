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
                    <td style="width: 115px">Periodo:</td>
                    <td style="width: 237px">Desde: <asp:TextBox ID="FromDate" runat="server"></asp:TextBox><asp:Image ID="Image1" runat="server" ImageUrl="/../Resources/calendar_icon.gif" />
                        <ajaxToolkit:CalendarExtender ID="CalendarExtender1" 
                             runat="server" TargetControlID="FromDate" 
                            PopupButtonID="Image1">
                        </ajaxToolkit:CalendarExtender>
</td>
                    <td>
                        Hasta: <asp:TextBox ID="ToDate" runat="server"></asp:TextBox><asp:Image ID="Image2" runat="server" ImageUrl="../Resources/calendar_icon.gif" />
                        <ajaxToolkit:CalendarExtender ID="CalendarExtender2" 
                             runat="server" TargetControlID="ToDate" 
                            PopupButtonID="Image2">
                        </ajaxToolkit:CalendarExtender>
                    </td>
                </tr>
                <tr>
                    <td style="width: 115px">&nbsp;</td>
                    <td style="width: 237px">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 115px">&nbsp;</td>
                    <td style="width: 237px"><asp:Button ID="generateKpiVentas" runat="server" Text="Generar" CssClass="btn btn-info" OnClick="generateKpiVentas_Click"  />  </td>
                    <td>
                        &nbsp;

                    </td>
                </tr>
            </table>
           
            <asp:PlaceHolder ID="ResultsData" runat="server"></asp:PlaceHolder>
        </div>
    </section>
</asp:Content>
