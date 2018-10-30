using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;

namespace AppWebSegurosBeLife
{
    public partial class Plantilla : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*Usuario usuario = (Usuario)Session["Usuario"];
            lblNombreUsuario.Text = usuario.ObtenerNombre();
			*/

            if (Session["ClienteCollection"] == null)
            {
                Session["ClienteCollection"] = new ClienteCollection();
            }

			if (Session["ContratoCollection"] == null)
			{
				Session["ContratoCollection"] = new ContratoCollection();
			}







		}
	}
}