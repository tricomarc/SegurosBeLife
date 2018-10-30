using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWebSegurosBeLife
{
	public partial class Contratos : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

			img_ContratoAdd.Attributes.Add("onmouseover", "this.src = '/Agregar_Cli2.png'");
			img_ContratoAdd.Attributes.Add("onmouseleave", "this.src = '/contrato_agregar.png'");

			img_ContratoDel.Attributes.Add("onmouseover", "this.src = '/Eliminar_Cli2.png'");
			img_ContratoDel.Attributes.Add("onmouseleave", "this.src = '/Eliminar_Cli.png'");

			img_ContratoAct.Attributes.Add("onmouseover", "this.src = '/Actualizar_Cli2.png'");
			img_ContratoAct.Attributes.Add("onmouseleave", "this.src = '/contrato_update.png'");

			img_ContratoBus.Attributes.Add("onmouseover", "this.src = '/Buscar_Cli2.png'");
			img_ContratoBus.Attributes.Add("onmouseleave", "this.src = '/contrato_buscar.png'");

			img_volver.Attributes.Add("onmouseover", "this.src = '/Volver.png'");
			img_volver.Attributes.Add("onmouseleave", "this.src = '/Volver2.png'");





		}
	}
}