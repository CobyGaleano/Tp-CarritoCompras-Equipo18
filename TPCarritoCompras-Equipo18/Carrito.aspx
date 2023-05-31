<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="TPCarritoCompras_Equipo18.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Carrito de compras</h1>
       <asp:GridView ID="dgvCarrito" runat="server" CssClass="table table-dark table-striped" 
        AutoGenerateColumns="false" >
        <Columns>
            <asp:BoundField HeaderText="Codigo" DataField="Codigo" />
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Precio" DataField="Precio" />

        </Columns>

    </asp:GridView>
</asp:Content>
