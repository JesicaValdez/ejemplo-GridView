<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ejemplo_web.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
        .oculto{
            display: none;
        }
    </style>

        <div class="row">
            <div class="col">
                <asp:GridView runat="server" ID="dgvAutos" DataKeyNames="Id" OnSelectedIndexChanged="dgvAutos_SelectedIndexChanged" CssClass="table table-dark table-bordered" AutoGenerateColumns="false">
                    <columns>
                        <asp:BoundField DataField="id" HeaderText="ID" HeaderStyle-CssClass="oculto" ItemStyle-CssClass="oculto"/>
                        <asp:BoundField DataField="Marca" HeaderText="Marca" />
                        <asp:BoundField DataField="Modelo" HeaderText="Modelo" />
                        <asp:CheckBoxField DataField="Importado" HeaderText="Importado" />
                        <asp:CheckBoxField DataField="usado" HeaderText="Usado" />
                        <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText="Acción" />
                    </columns>
                </asp:GridView>
                    <a href="AutoForm.aspx">Agregar</a>
            </div>
        </div>
        

</asp:Content>
