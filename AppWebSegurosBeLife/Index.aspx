<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AppWebSegurosBeLife.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="shortcut icon" type="image/ico" href="~/be.ico" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>BeLife - Sistema Usuarios</title>
</head>
<body>
	<form> 

		<div style="align-content:center; text-align: center; position:center"   >

			<asp:Image ID="img_logo" runat="server" Height="80px" Width="317px" ImageUrl="~/Logo BeLife.png" />
			<h4>Sistema de gestion de Clientes y Contratos</h4>
		</div>

	</form>


    <form id="Ingreso" runat="server">
    <div>
		       

		<div style="align-content:center; text-align: center; position:center"   >
			
			<br />
			<br />
			<br />
			<br />
			<a href="Clientes.aspx">
			<asp:Image ID="img_Clientes" runat="server" Height="150px"  Width="150px" ImageUrl="~/Clientes.png"  />
			</a>
			<td>&nbsp;</td>
			<td>&nbsp;</td>
			<td>&nbsp;</td>
			<td>&nbsp;</td>
			<td>&nbsp;</td>
			<td>&nbsp;</td>
			<a href="Contratos.aspx">
			<asp:Image ID="img_Contratos" runat="server" Height="150px"  Width="150px" ImageUrl="~/Contratos.png" />
			</a>
				



		</div>

		</div>
		<br />
		<br />
		<br />
		<br />
		<br />








    
		<p style="text-align:center">BeLife 2018</p>
    </form>
</body>
</html>
