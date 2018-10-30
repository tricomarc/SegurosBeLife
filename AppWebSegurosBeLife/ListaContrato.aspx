<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="ListaContrato.aspx.cs" Inherits="AppWebSegurosBeLife.ListaContrato" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">

    <h2>Lista de Contratos</h2>
    <asp:Panel ID="pnlListaContratos" runat="server">
     

           <asp:GridView ID="gvContratos" runat="server"
            AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="Numero"
                    HeaderText="Numero"
                    ReadOnly="true" />
                <asp:BoundField DataField="FechaCreacion"
                    HeaderText="FechaCreacion"
                    dataformatstring="{0:dd-MM-yyyy}"
                    ReadOnly="false" />

  
                  <asp:BoundField DataField="FechaTermino"
                    HeaderText="FechaTermino"
                    dataformatstring="{0:dd-MM-yyyy}"
                    ReadOnly="false" />

                <asp:BoundField DataField="RutCliente"
                    HeaderText="RutCliente"
                    ReadOnly="false" />

                       <asp:BoundField DataField="CodigoPlan"
                    HeaderText="CodigoPlan"
                    ReadOnly="false" />

                      <asp:BoundField DataField="FechaInicioVigencia"
                           dataformatstring="{0:dd-MM-yyyy}"
                    HeaderText="FechaInicioVigencia"
                    ReadOnly="false" />

                <asp:BoundField DataField="FechaFinVigencia"
                     dataformatstring="{0:dd-MM-yyyy}"
                    HeaderText="FechaFinVigencia"
                    ReadOnly="false" />

                <asp:BoundField DataField="Vigente"
                    HeaderText="Vigente"
                    ReadOnly="false" />

                <asp:BoundField DataField="DeclaracionSalud"
                    HeaderText="DeclaracionSalud"
                    ReadOnly="false" />

                <asp:BoundField DataField="PrimaAnual"
                    HeaderText="PrimaAnual"
                    ReadOnly="false" />

                <asp:BoundField DataField="PrimaMensual"
                    HeaderText="PrimaMensual"
                    ReadOnly="false" />

                <asp:BoundField DataField="Observaciones"
                    HeaderText="Observaciones"
                    ReadOnly="false" />
                
            </Columns>
        </asp:GridView>



    </asp:Panel>


    <asp:Panel ID="pnlMensajes" runat="server">
        <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
    </asp:Panel>


</asp:Content>
