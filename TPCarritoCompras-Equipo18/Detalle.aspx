<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="TPCarritoCompras_Equipo18.Detalle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
    <%-- Falta validar si no tiene imagen o si la imagen esta rota  --%>
    <%-- Falta meterle cariño al front --%>
    <div class="container">
        <div class="row">
            <%-- Dibujo los label --%>
            <div class="col-12">

                <asp:Label ID="lblNombre" runat="server" Text="Nombre" CssClass="form-control"></asp:Label>
            </div>
            <div class="col-12">
                <asp:Label ID="lblCodigo" runat="server" Text="Codigo" CssClass="form-control"></asp:Label>

            </div>
            <div class="col-12">
                <asp:Label ID="lblDescripcion" runat="server" Text="Descripcion" CssClass="form-control"></asp:Label>
            </div>
            <div class="col-12">

                <asp:Label ID="lblMarca" runat="server" Text="Marca" CssClass="form-control"></asp:Label>
            </div>
            <div class="col-12">

                <asp:Label ID="lblCategoria" runat="server" Text="Categoria" CssClass="form-control"></asp:Label>
            </div>
            <div class="col-12">
                <asp:Label ID="lblPrecio" runat="server" Text="Precio" CssClass="form-control"></asp:Label>
            </div>

        </div>
    </div>
    <%-- Carrusel para las imagenes --%>
    <div id="carouselExample" class="carousel carousel-dark slide">
        <div class="carousel-inner">

            <%
                bool primera = true;
                foreach (Dominio.Imagen img in listaImagenes)
                {
                    if (primera)
                    {
                        primera = false; %>
            <%-- La primer imagen de la lista va a ser con la que arranque el carrusel  --%>
            <div class="carousel-item active">
                <img src="<%:img.ImagenUrl %>" class="d-block w-100" alt="">
            </div>
            <%}
                else
                {%>

            <div class="carousel-item ">
                <img src="<%:img.ImagenUrl %>" class="d-block w-100" alt="">
            </div>
            <% }

                } %>

            <%-- Boton de anterior --%>
            <button class="carousel-control-prev" type="button" data-bs-target="#carouselExample" data-bs-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Previous</span>
            </button>
            <%--Boton del que sigue--%>
            <button class="carousel-control-next" type="button" data-bs-target="#carouselExample" data-bs-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Next</span>
            </button>

        </div>
    </div>

</asp:Content>
