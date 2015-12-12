<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="create.aspx.cs" Inherits="PresentacionWebForms.CenfotecSite.Evaluations.create1" %>
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
            <div class="form-group">
                <label>Profesor:</label>
                <asp:DropDownList ID="stlProfesores" runat="server" CssClass="form-control" OnSelectedIndexChanged="stlProfesores_SelectedIndexChanged" OnTextChanged="stlProfesores_TextChanged">

                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="txtPorcentaje">Porcentaje de desactivación</label>
                <asp:TextBox ID="txtPorcentaje" runat="server" CssClass="form-control" OnTextChanged="txtPorcentaje_TextChanged"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="sltCurso">Curso:</label>
                <asp:DropDownList ID="sltCurso" runat="server" CssClass="form-control">
                    
                </asp:DropDownList>
            </div>
            <input type="button" class="btn btn-primary" value="Continuar">
        </div>
    </section>
</asp:Content>
