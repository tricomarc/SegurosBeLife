using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;

namespace AppWebSegurosBeLife
{
	public partial class ListaContrato : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

			if (Session["ContratoCollection"] != null)
			{
				gvContratos.DataSource = (ContratoCollection)Session["ContratoCollection"];
				gvContratos.DataBind();
			}



		}


	}
}