<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contratos.aspx.cs" Inherits="AppWebSegurosBeLife.Contratos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="shortcut icon" type="image/ico" href="~/be.ico" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form>

		<div style="align-content:center; text-align: center; position:center"   >

			<asp:Image ID="img_logo" runat="server" Height="80px" Width="317px" ImageUrl="~/Logo BeLife.png" />
			<h4>Sistema de gestion de Clientes y Contratos</h4>
		</div>

	</form>
    <form id="form2" runat="server">
        <div>

			<div style="align-content:center; text-align: center; position:center"   >
			
			<br />
			<br />
			<br />
			<br />
			<a href="AgregarContrato.aspx">
			<asp:Image ID="img_ContratoAdd" runat="server" Height="150px"  Width="150px" ImageUrl="~/contrato_agregar.png"  />
			</a>

			<a href="ModificarClientes.aspx">
			<asp:Image ID="img_ContratoAct" runat="server" Height="150px"  Width="150px" ImageUrl="~/contrato_update.png"/>
			</a>
			<td>&nbsp;</td>
			<td>&nbsp;</td>
			<td>&nbsp;</td>
			<td>&nbsp;</td>
			<td>&nbsp;</td>
			<td>&nbsp;</td>
			<a href="ListaContrato.aspx">
			<asp:Image ID="img_ContratoBus" runat="server" Height="150px"  Width="150px" ImageUrl="~/contrato_buscar.png"/>
			</a>
			<td>&nbsp;</td>
			<td>&nbsp;</td>
			<td>&nbsp;</td>
			<td>&nbsp;</td>
			<td>&nbsp;</td>
			<td>&nbsp;</td>
			<a href="ModificarClientes.aspx">
			<asp:Image ID="img_ContratoDel" runat="server" Height="150px"  Width="150px" ImageUrl="~/contrato_del.png"/>
			</a>
			<td>&nbsp;</td>
			<td>&nbsp;</td>
			<td>&nbsp;</td>
			<td>&nbsp;</td>
			<td>&nbsp;</td>
			<td>&nbsp;</td>
			<br />
			<a href="Index.aspx">
			<asp:Image ID="img_volver" runat="server" Height="80px"  Width="80px" ImageUrl="~/Volver2.png"/>
			</a>




		</div>

		</div>
		<br />
		<br />
		<br />
		<br />
		<br />

    
		<p style="text-align:center">BeLife 2018</p>


        </div>
    </form>
</body>
</html>
