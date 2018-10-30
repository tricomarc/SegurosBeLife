<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="ListaClientes.aspx.cs" Inherits="AppWebSegurosBeLife.ListaClientes" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <h2>Lista de Clientes</h2>
    <asp:Panel ID="pnlListaClientes" runat="server">
       
     
        <asp:GridView ID="gvClientes" runat="server"
            AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="Rut"
                    HeaderText="Rut"
                    ReadOnly="true" />
                <asp:BoundField DataField="Nombres"
                    HeaderText="Nombres"
                    ReadOnly="false" />
  
                  <asp:BoundField DataField="Apellidos"
                    HeaderText="Apellidos"
                    ReadOnly="false" />

                <asp:BoundField DataField="Edad"
                    HeaderText="Edad"
                    ReadOnly="false" />

                <asp:BoundField DataField="Sexo"
                    HeaderText="Sexo"
                    ReadOnly="false" />

                <asp:BoundField DataField="EstadoCivil"
                    HeaderText="Estado Civíl"
                    ReadOnly="false" />
                
            </Columns>
        </asp:GridView>



    </asp:Panel>

    <asp:Panel ID="pnlMensajes" runat="server">
        <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
    </asp:Panel>

</asp:Content>
