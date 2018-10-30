using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWebSegurosBeLife
{
	public partial class Clientes : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

			img_clienteAdd.Attributes.Add("onmouseover", "this.src = '/Agregar_Cli2.png'");
			img_clienteAdd.Attributes.Add("onmouseleave", "this.src = '/Agregar_Cli.png'");

			img_ClienteDel.Attributes.Add("onmouseover", "this.src = '/Eliminar_Cli2.png'");
			img_ClienteDel.Attributes.Add("onmouseleave", "this.src = '/Eliminar_Cli.png'");

			img_ClienteMod.Attributes.Add("onmouseover", "this.src = '/Actualizar_Cli2.png'");
			img_ClienteMod.Attributes.Add("onmouseleave", "this.src = '/Actualizar_Cli.png'");

			img_ClienteBus.Attributes.Add("onmouseover", "this.src = '/Buscar_Cli2.png'");
			img_ClienteBus.Attributes.Add("onmouseleave", "this.src = '/Buscar_Cli.png'");

			img_volver.Attributes.Add("onmouseover", "this.src = '/Volver.png'");
			img_volver.Attributes.Add("onmouseleave", "this.src = '/Volver2.png'");



		}
	}
}