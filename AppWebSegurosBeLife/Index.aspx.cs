using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;

namespace AppWebSegurosBeLife
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                Session["Usuario"] = new Usuario();
            }


			img_Clientes.Attributes.Add("onmouseover", "this.src = '/cli.png'");
			img_Clientes.Attributes.Add("onmouseleave", "this.src = '/Clientes.png'");
			

			img_Contratos.Attributes.Add("onmouseover", "this.src = '/cont.png'");
			img_Contratos.Attributes.Add("onmouseleave", "this.src = '/Contratos.png'");






		}

		/*
        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.Nickname = txtNickName.Text;
            u.Nombre = txtUsuario.Text;
            u.Password = txtPassword.Text;
            txtSaludo.Value = u.ObtenerNombre();
            Session["Usuario"] = u;
            Response.Redirect("ListaClientes.aspx");
            //string parametros = string.Format("ListaClientes.aspx?nombre={0}&nickname={1}", u.Nombre, u.Nickname);
            //Response.Redirect(parametros);
            //Server.Transfer("ListaClientes.aspx");
        }
		*/
	}
}
 