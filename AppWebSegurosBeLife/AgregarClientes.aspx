<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="AgregarClientes.aspx.cs" Inherits="AppWebSegurosBeLife.AgregarClientes" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <h2>Agregar Clientes</h2>
    <fieldset>
        <legend>Ingresa la información del Cliente</legend>

        <label class="col-50">
            Rut: 
            </label>
            <asp:TextBox ID="txtRut" runat="server"></asp:TextBox>
            <asp:Label ID="txtErrorRut" runat="server"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Rut es requerido" ControlToValidate="txtRut"></asp:RequiredFieldValidator>
        
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
            <asp:TextBox ID="txtEdad"  runat="server" TextMode="Date"></asp:TextBox>                     
            <asp:Label ID="txt_error_edad" runat="server"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Rut es requerido" ControlToValidate="txtRut"></asp:RequiredFieldValidator>
        <label class="col-50">
            Sexo: 
             </label>
            <asp:DropDownList ID="ddlSexo" runat="server"></asp:DropDownList>
            <asp:Label ID="txt_error_sexo" runat="server"></asp:Label>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Sexo es requerido" ControlToValidate="ddlSexo"></asp:RequiredFieldValidator>
        <label class="col-50">
            Estado Civíl:
        </label>
        <asp:DropDownList ID="ddlEstadoCivil" runat="server"></asp:DropDownList>
        <asp:Label ID="txt_error_estadoCivil" runat="server"></asp:Label>
        <asp:RequiredFieldValidator ID="RequieredFieldValidator6" runat="server" ErrorMessage="Estado Civíl es requerido" ControlToValidate="ddlEstadoCivil"></asp:RequiredFieldValidator>
      <br />
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
    </fieldset>

    <asp:Panel ID="pnlMensajes" runat="server">
        <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
    </asp:Panel>
</asp:Content>
