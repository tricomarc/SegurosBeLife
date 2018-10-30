using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;

namespace AppWebSegurosBeLife
{
    public partial class ModificarClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlSexo.DataSource = Enum.GetValues(typeof(enumSexo));
                ddlSexo.DataBind();
            }

            pnlModificarCliente.Visible = false;
        }

        protected void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente p = ((ClienteCollection)Session["ClienteCollection"]).BuscarCliente(txtBuscarRut.Text);

                if (p!=null)
                {
                    txtRut.Text = p.Rut;
                    txtNombres.Text = p.Nombres;
                    txtApellidos.Text = p.Apellidos;
                    txtEdad.Text = p.Edad.ToString();
                    ddlSexo.SelectedValue = p.Sexo.ToString();
                    pnlModificarCliente.Visible = true;
                }
                else
                {
                    lblMensaje.Text = "Cliente no existe";
                }
            }
            catch (Exception error)
            {
                lblMensaje.Text = error.Message;
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente p = new Cliente();
                p.Rut = txtRut.Text;
                p.Nombres = txtNombres.Text;
                p.Apellidos = txtApellidos.Text;
                p.Edad = DateTime.Parse(txtEdad.Text);
                p.Sexo = (enumSexo)ddlSexo.SelectedIndex;
                ((ClienteCollection)Session["ClienteCollection"]).ModificarCliente(p);
                lblMensaje.Text = "Cliente modificado exitosamente";
            }
            catch (Exception error)
            {
                lblMensaje.Text = error.Message;
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente p = ((ClienteCollection)Session["ClienteCollection"]).BuscarCliente(txtRut.Text);

                if (p != null)
                {
                    ((ClienteCollection)Session["ClienteCollection"]).Remove(p);
                }
                else
                {
                    lblMensaje.Text = "Cliente no existe";
                }
            }
            catch (Exception error)
            {

                lblMensaje.Text = error.Message;
            }
        }
    }
}