<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="AutoForm.aspx.cs" Inherits="ejemplo_web.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <label for="txtId" class="form-label">ID</label>
                <asp:TextBox runat="server" ID="txtId" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtMarca" class="form-label">Marca</label>
                <asp:TextBox runat="server" ID="txtMarca" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtModelo" class="form-label">Modelo</label>
                <asp:TextBox runat="server" ID="txtModelo" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtDescripcion" class="form-label">Descripción</label>
                <asp:TextBox runat="server" TextMode="MultiLine" ID="txtDescripcion" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="ddlColores" class="form-label">Color</label>
                <asp:DropDownList ID="ddlColores" runat="server" CssClass="form-select"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <label for="txtFecha" class="form-label">Fecha</label>
                <asp:TextBox runat="server" TextMode="Date" ID="txtFecha" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:RadioButton ID="rdbImportado" Text="Importado" runat="server" GroupName="Importado" />
                <asp:RadioButton ID="rdbNacional" Text="Nacional" Checked="true" runat="server" GroupName="Importado" />
            </div>
            <div class="mb-3">
                <asp:CheckBox ID="chkUsado" Text="Usado" runat="server" />
                <asp:CheckBox ID="chkNuevo" Text="Nuevo" runat="server" />
            </div>
            <!-- Button Aceptar -->
            <div class="mb-3">
                <asp:Button Text="Aceptar" ID="btnAceptar" CssClass="btn btn-primary" OnClick="btnAceptar_Click" runat="server" />
                <a href="Default.aspx">Regresar</a>
            </div>
            <!-- Label error...-->
            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>


        </div>
    </div>
</asp:Content>
