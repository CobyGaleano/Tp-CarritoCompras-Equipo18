<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="TPCarritoCompras_Equipo18.Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container bg-white p-3 position-relative" id="container-cart">
        <h1>Carrito de compras</h1>
        
        <%if (precioTotal != 0){ %>
        <div id="Container-items">
        <asp:GridView ID="dgvCarrito" runat="server" CssClass="table table-dark table-striped"
            AutoGenerateColumns="false" OnRowCommand="dgvCarrito_RowCommand">
            <Columns>
                <asp:BoundField HeaderText="Codigo" DataField="Codigo" />
                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                <asp:BoundField HeaderText="Precio" DataField="Precio" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lbtn_Eliminar" Text="Eliminar" runat="server" CommandName="Eliminar" CommandArgument="<%# ((GridViewRow)Container).RowIndex %>" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        </div>
        <hr>
        <div id="footer-cart">
            <div class="col-12">
                <asp:Label Text="" ID="lblTotal" runat="server" />
            </div>
        </div>
        <%}else { %>
        <h3>¡El carrito está vacío!</h3>
        <a href="Default.aspx">Volver al listado</a>
        <%} %>
    </div>


</asp:Content>
