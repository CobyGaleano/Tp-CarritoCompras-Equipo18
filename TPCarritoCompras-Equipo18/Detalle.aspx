<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="TPCarritoCompras_Equipo18.Detalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #container-carousel {
            width: 350px;
            height: 350px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%-- Falta validar si no tiene imagen o si la imagen esta rota  --%>
    <%-- Falta meterle cariño al front --%>
    <div class="container bg-light p-3">
        <div class="row">
            <%-- Dibujo los label --%>
            <div class="col-sm-4">
                <%-- Carrusel para las imagenes --%>
                <div class="container" id="container-carousel">

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
                            <%--Boton de siguiente--%>
                            <button class="carousel-control-next" type="button" data-bs-target="#carouselExample" data-bs-slide="next">
                                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                                <span class="visually-hidden">Next</span>
                            </button>

                        </div>
                    </div>
                </div>
            </div>

            <div class="col-sm-8">
                <div class="row">
                    <div class="col-8 col-sm-12">
                        <asp:Label ID="lblNombre" runat="server" Text="Nombre" CssClass="form-control"></asp:Label>
                    </div>
                    <div class="col-8 col-sm-12">
                        <asp:Label ID="lblCodigo" runat="server" Text="Codigo" CssClass="form-control"></asp:Label>
                    </div>
                    <div class="col-8 col-sm-12">
                        <asp:Label ID="lblDescripcion" runat="server" Text="Descripcion" CssClass="form-control"></asp:Label>
                    </div>
                    <div class="col-8 col-sm-12">
                        <asp:Label ID="lblMarca" runat="server" Text="Marca" CssClass="form-control"></asp:Label>
                    </div>
                    <div class="col-8 col-sm-12">
                        <asp:Label ID="lblCategoria" runat="server" Text="Categoria" CssClass="form-control"></asp:Label>
                    </div>
                    <div class="col-8 col-sm-12">
                        <asp:Label ID="lblPrecio" runat="server" Text="Precio" CssClass="form-control"></asp:Label>
                    </div>
                    <div class="col-8 col-sm-12 p-3">
                        <%--<a href="Detalle.aspx?id=<%:Id%>" class="btn btn-secondary p-2">Añadir al carrito</a>--%>
                        <asp:Button ID="btn_Añadir" runat="server" Text="Añadir al carrito" OnClick="btn_Añadir_Click" CssClass="btn btn-secondary p-2"/>
                    </div>
                    <asp:Label Text="" ID="lblAñadir" runat="server" />
                </div>
            </div>
        </div>
    </div>


</asp:Content>
