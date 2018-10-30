using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;

namespace AppWebSegurosBeLife
{
    public partial class AgregarClientes : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlSexo.DataSource = Enum.GetValues(typeof(enumSexo));
                ddlSexo.DataBind();
                ddlEstadoCivil.DataSource = Enum.GetValues(typeof(enumEstadoCivil));
                ddlEstadoCivil.DataBind();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                Cliente p = new Cliente();
                p.Rut = txtRut.Text;
                p.Nombres = txtNombres.Text;
                p.Apellidos = txtApellidos.Text;
                p.Edad = DateTime.Parse(txtEdad.Text);
                p.Sexo = (enumSexo)ddlSexo.SelectedIndex;
                p.EstadoCivil = (enumEstadoCivil)ddlEstadoCivil.SelectedIndex;
                if (!ValidarRut(txtRut.Text))
                {

					txtErrorRut.Text = "RUT inválido";
   
                }
                else
                {
                    if (!validaComboBox(ddlSexo.SelectedIndex))
                    {
                        txt_error_sexo.Text = "Debe seleccionar Sexo";
                    }
                    else
                    {
                        if (!validaComboBox(ddlEstadoCivil.SelectedIndex))
                        {
                            txt_error_estadoCivil.Text = "Debe seleccionar Estado Civíl";
                        }
                        else
                        {
                            ((ClienteCollection)Session["ClienteCollection"]).Add(p);
                            lblMensaje.Text = "Cliente agregado exitosamente";
                        }
                    }

                }

            

              
            }
            catch (Exception error)
            {

                lblMensaje.Text = error.Message;
            }

        }

        //Metodo que alerta cuando el combo box es selecciones

        public bool validaComboBox(int opcion)
        {

            bool validar = false;
            if (opcion != 0)
            {
                validar = true;
            }
            else
            {
                validar = false;
            }

            return validar;
        }

        //Método que valida formato del rut

        public bool ValidarRut(string rut)
        {
            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {

            }
            return validacion;
        }

        ////Método que valida si cliente es mayor a 18 años

        //public bool CalculoEdad( DateTime fechaNacimiento)
        //{
        //    bool validar = false;
        //    int edad = DateTime.Now.Year - fechaNacimiento.Year;

        //    if (edad >= 18)
        //    {
        //        validar = true;
        //    }
        //    else
        //    {
        //        validar = false;
        //    }
        //    return validar;
        //}
    }
}