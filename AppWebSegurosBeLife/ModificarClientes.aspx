<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="ModificarClientes.aspx.cs" Inherits="AppWebSegurosBeLife.ModificarClientes" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <h2>Modificar Clientes</h2>
    <asp:Panel ID="pnlBuscardor" runat="server">
        <fieldset>
            <legend>Buscar Cliente</legend>
            <label class="col-50">
                Rut:
                 </label>
                <asp:TextBox ID="txtBuscarRut" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="valRut" runat="server" ErrorMessage="Rut es requerido" ControlToValidate="txtBuscarRut"></asp:RequiredFieldValidator>
           
            <asp:Button ID="btnBuscarCliente" runat="server" Text="Buscar" OnClick="btnBuscarCliente_Click" />
        </fieldset>
    </asp:Panel>

    <asp:Panel ID="pnlModificarCliente" runat="server">
        <fieldset>
            <legend>Modificar información</legend>
            <label class="col-50">
                Rut: 
                </label>
            <asp:TextBox ReadOnly="true" ID="txtRut" runat="server"></asp:TextBox>
            
            <label class="col-50">
                Nombres: 
                 </label>
            <asp:TextBox ID="txtNombres" runat="server"></asp:TextBox>
 <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Nombre es requerido" ControlToValidate="txtNombres"></asp:RequiredFieldValidator>
           
            <label class="col-50">
                Apellidos: 
                 </label>
            <asp:TextBox ID="txtApellidos" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Apellidos es requerido" ControlToValidate="txtApellidos"></asp:RequiredFieldValidator>
           
            <label class="col-50">
                Fecha de Nacimiento: 
                </label>
            <asp:TextBox ID="txtEdad" runat="server" TextMode="Date"></asp:TextBox>
                 
            <label class="col-50">
                Sexo: 
                 </label>
            <asp:DropDownList ID="ddlSexo" runat="server"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Sexo es requerido" ControlToValidate="ddlSexo"></asp:RequiredFieldValidator>
           
            <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
        </fieldset>

    </asp:Panel>


        <asp:Panel ID="pnlMensajes" runat="server">
        <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
    </asp:Panel>

</asp:Content>
