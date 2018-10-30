
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;

namespace AppWebSegurosBeLife
{
    public partial class ListaClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ClienteCollection"]!=null)
            {
                gvClientes.DataSource = (ClienteCollection)Session["ClienteCollection"];
                gvClientes.DataBind();
		
            }
        }
    }
}