<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="AgregarContrato.aspx.cs" Inherits="AppWebSegurosBeLife.AgregarContrato" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <h2>Agregar Contrato</h2>
    <fieldset>
        <legend>Ingresa la información del Contrato</legend>
			
               <div>	
        <label class="col-50">
        Rut Cliente: 
            </label>
        <asp:TextBox ID="txt_rutCliente" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator class="col-men" ID="RequiredFieldValidator6"  runat="server" ErrorMessage="Rut Requerido" ControlToValidate="txt_rutCliente"></asp:RequiredFieldValidator>
        
		</div>

        <div>	
        

		<asp:Button ID="btn_buscarC" runat="server" Text="Buscar" OnClick="btn_buscarC_Click"/>
            
       
		</div>



        <asp:Panel id="pnlCalculoPrima" runat="server">


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

		<div>	
        

		<asp:Button ID="btn_enviar" runat="server" Text="Agregar" OnClick="btn_enviar_Click" />
            
       
		</div>
		
        <br />


        </asp:Panel>

		
	

		


   
    </fieldset>

    <asp:Panel ID="pnlMensajes" runat="server">
        <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
    </asp:Panel>
</asp:Content>
