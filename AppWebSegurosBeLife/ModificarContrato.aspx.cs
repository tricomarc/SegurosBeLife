using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Clases.Contrato;

namespace AppWebSegurosBeLife
{
    public partial class ModificarContrato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                ddlCodPlan.DataSource = Enum.GetValues(typeof(enumCodPlan));
                ddlCodPlan.DataBind();
                ddlDeclSalud.DataSource = Enum.GetValues(typeof(enumSalud));
                ddlDeclSalud.DataBind();
                ddlVigente.DataSource = Enum.GetValues(typeof(enumVigencia));
                ddlVigente.DataBind();
            }

            pnlModificarContrato.Visible = false;
        }


        protected void btnBuscarRutC_Click(object sender, EventArgs e)
        {

            try
            {
                Contrato con = ((ContratoCollection)Session["ContratoCollection"]).BuscarContrato(txtBuscarRut.Text);

                if (con != null)
                {
                    ddlCodPlan.SelectedIndex = (int)con.CodigoPlan;
                    txt_rutCliente.Text = con.RutCliente;
                    txt_numero.Text = con.Numero;
                    dat_fechaCreacion.Text = con.FechaCreacion.ToString();
                    dat_fechaTermino.Text = con.FechaTermino.ToString();
                    dat_fechaInicioVigencia.Text = con.FechaInicioVigencia.ToString();
                    dat_fechaFinVigencia.Text = con.FechaFinVigencia.ToString();
                    ddlVigente.SelectedIndex = (int)con.Vigente;
                    ddlDeclSalud.SelectedIndex = (int)con.DeclaracionSalud;
                    txt_primaAnual.Text = con.PrimaAnual.ToString();
                    txt_primaMensual.Text = con.PrimaMensual.ToString();
                    txt_observacion.Text = con.Observaciones;
                    pnlModificarContrato.Visible = true;
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

                Contrato p = new Contrato
                {
                    CodigoPlan = (enumCodPlan)ddlCodPlan.SelectedIndex,
                    DeclaracionSalud = (enumSalud)ddlDeclSalud.SelectedIndex,
                    FechaCreacion = DateTime.Parse(dat_fechaCreacion.Text),
                    FechaFinVigencia = DateTime.Parse(dat_fechaFinVigencia.Text),
                    FechaInicioVigencia = DateTime.Parse(dat_fechaFinVigencia.Text),
                    FechaTermino = DateTime.Parse(dat_fechaTermino.Text),
                    Numero = txt_numero.Text,
                    Observaciones = txt_rutCliente.Text,
                    Vigente = (enumVigencia)ddlVigente.SelectedIndex,
                    PrimaAnual = double.Parse(txt_primaAnual.Text),
                    PrimaMensual = double.Parse(txt_primaMensual.Text),
                    RutCliente = txt_rutCliente.Text
                };


                ((ContratoCollection)Session["ContratoCollection"]).Add(p);

                lblMensaje.Text = "Contrato modificado exitosamente";
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
                Contrato con = ((ContratoCollection)Session["ContratoCollection"]).BuscarContrato(txtBuscarRut.Text);

                if (con != null)
                {
                    ((ContratoCollection)Session["ContratoCollection"]).Remove(con);
                }
                else
                {
                    lblMensaje.Text = "Contrato no existe";
                }
            }
            catch (Exception error)
            {

                lblMensaje.Text = error.Message;
            }
        }
    }
}