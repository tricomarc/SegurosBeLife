<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="ModificarContrato.aspx.cs" Inherits="AppWebSegurosBeLife.ModificarContrato" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">

    <h2>Modificar Contratos</h2>
    <asp:Panel ID="pnlBuscardor" runat="server">
        <fieldset>
            <legend>Buscar Contrato</legend>
            <label class="col-50">
                Rut Cliente:
                 </label>
                <asp:TextBox ID="txtBuscarRut" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="valRut" runat="server" ErrorMessage="Rut es requerido" ControlToValidate="txtBuscarRut"></asp:RequiredFieldValidator>
           
            <asp:Button ID="btnBuscarRutC" runat="server" Text="Buscar" OnClick="btnBuscarRutC_Click"  />
        </fieldset>
    </asp:Panel>

    <asp:Panel ID="pnlModificarContrato" runat="server">
        <fieldset>
            <legend>Modificar información</legend>
            


            <label class="col-50">
        Rut Cliente: 
            </label>
        <asp:TextBox ID="txt_rutCliente" ReadOnly="true" BackColor="#f4f2f5" runat="server"></asp:TextBox>
       



		<div  >	
        <label class="col-50" >
        Numero: 
        </label>
        <asp:TextBox ID="txt_numero" runat="server" ReadOnly="true"  BackColor="#f4f2f5"></asp:TextBox>
        
        
		</div>
		
		<div>
		<label class="col-50" >
		Fecha Creacion
            </label>
		<asp:TextBox ID="dat_fechaCreacion" runat="server" ReadOnly="true" BackColor="#f4f2f5"  />


		</div>
		<br />
		
		<div>

		<label class="col-50">
		Fecha Termino
            </label>
		<asp:TextBox ID="dat_fechaTermino" runat="server" TextMode="Date"  required=""/>
		
		
		</div>
		

		
		<br />

		<div>	
        <label class="col-50"> Codigo Plan:  </label>
        <asp:DropDownList ID="ddlCodPlan" runat="server"></asp:DropDownList>
        <asp:Label ID="txt_error_CodPlan" runat="server"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Debe seleccionar un codigo de plan" ControlToValidate="ddlCodPlan"></asp:RequiredFieldValidator>
       



		</div>
		

		<div>
		<label class="col-50">
		Fecha Inicio Vigencia
            </label>
		<asp:TextBox ID="dat_fechaInicioVigencia" runat="server" TextMode="Date" required="" />
	
		
		</div>
		<br />

		<div>
		<label class="col-50">
		Fecha Fin Vigencia
            </label>
		<asp:TextBox ID="dat_fechaFinVigencia" runat="server" TextMode="Date" required="" />
		
		</div>

		<div>	
        <label class="col-50">
        Vigente: 
        </label>
        <asp:DropDownList ID="ddlVigente" runat="server"></asp:DropDownList>
        <asp:Label ID="txt_error_vigencia" runat="server"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Debe seleccionar una vigencia" ControlToValidate="ddlVigente"></asp:RequiredFieldValidator>
        


		</div>
	

		<div>	
        <label class="col-50">
        Declaracion Salud: 
             </label>
        
        <asp:DropDownList ID="ddlDeclSalud" runat="server"></asp:DropDownList>
        <asp:Label ID="txt_error_decSalud" runat="server" ></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" class="col-men"  runat="server" ErrorMessage="Debe seleccionar una Declaración de salud" ControlToValidate="ddlDeclSalud"></asp:RequiredFieldValidator>
       	</div>
	

 
            <div>	
            <label class="col-50">
            Prima Anual: 
                </label>


            <asp:TextBox ID="txt_primaAnual" runat="server" ReadOnly="true" BackColor="#f4f2f5"></asp:TextBox>
       
		    </div>

		    <div>	
            <label class="col-50">
            Prima Mensual: 
                  </label>
            <asp:TextBox ID="txt_primaMensual" runat="server" ReadOnly="true" BackColor="#f4f2f5"></asp:TextBox>
      
		    </div>


            <div>	
        <label class="col-50">
        Observaciones: 
             </label>
        <asp:TextBox ID="txt_observacion" runat="server" required=""></asp:TextBox>
      
		</div>
		<br />






            <asp:Button ID="btnModificar" runat="server" OnClick="btnModificar_Click" Text="Modificar"  />
            <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar"/>
        </fieldset>

         </asp:Panel>

        <asp:Panel ID="pnlMensajes" runat="server">
        <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
        </asp:Panel>

</asp:Content>
