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
    public partial class AgregarContrato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                dat_fechaCreacion.Text = DateTime.Now.ToString("dd-MM-yyyy");
                
                txt_numero.Text = GeneraCodigo();
                ddlCodPlan.DataSource = Enum.GetValues(typeof(enumCodPlan));
                ddlCodPlan.DataBind();
                ddlDeclSalud.DataSource = Enum.GetValues(typeof(enumSalud));
                ddlDeclSalud.DataBind();
                ddlVigente.DataSource = Enum.GetValues(typeof(enumVigencia));
                ddlVigente.DataBind();
            }
            pnlCalculoPrima.Visible = false;

        }
        

        protected void btn_enviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validaComboBox(ddlCodPlan.SelectedIndex))
                {
                    txt_error_CodPlan.Text = "Debe seleccionar plan";
                }
                else if (!validaComboBox(ddlDeclSalud.SelectedIndex))
                {
                    txt_error_decSalud.Text = "Debe seleccionar Declaración de salud";
                }
                else if (!validaComboBox(ddlVigente.SelectedIndex))
                {
                    txt_error_vigencia.Text = "Debe seleccionar Vigencia";
                }
                else
                {

                    if (BuscaCliente(txt_rutCliente.Text) == true)
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
                            lblMensaje.Text = "Contrato creado correctamente";



                        }
                        catch (Exception error)
                        {

                            lblMensaje.Text = error.Message;
                        }

                       

                    }
                    else
                    {
                        lblMensaje.Text = "Debe crear un cliente";
                    }


                    
                }

            }
            catch (Exception error)
            {
                lblMensaje.Text = error.Message;
            }
        }

        // Genera el codigo del contrato

        public string GeneraCodigo()
        {
            string fecha = "";
            DateTime tiempo = DateTime.Now;
            fecha = tiempo.ToString("yyyyMMddHmmss");
            return fecha;
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


       
        


       

        protected void btn_buscarC_Click(object sender, EventArgs e)
        {

            try
            {
                Cliente p = ((ClienteCollection)Session["ClienteCollection"]).BuscarCliente(txt_rutCliente.Text);

                if (p != null)
                {
                    pnlCalculoPrima.Visible = true;

                    DateTime tiemAhora = DateTime.Now;
                    DateTime TimeFechaNAc = p.Edad;


                    int edad = tiemAhora.Year - TimeFechaNAc.Year;
                    int sexo = (int) p.Sexo;
                    int ecivil = (int)p.EstadoCivil;

                    txt_primaAnual.Text = CalculoPrimaAnual(edad, sexo, ecivil).ToString();
                    txt_primaMensual.Text = CalculoPrimaMensual(edad, sexo, ecivil).ToString();
                }
                else
                {
                    txt_rutCliente.Text = "Cliente no existe";
                }
            }
            catch (Exception error)
            {
                lblMensaje.Text = error.Message;
            }


        }

        // Calcula la prima


        

        public int CalculoPrimaAnual(int edad, int sexo, int eCivil)
        {
            int valorPrimaAnual = 0;
            //   int valorPrimamensual = 0;
            int valorUF = 40000;
            int valorBase = 250000;
            float uf = 0f;
            float recargo;


            // Edad
            if (edad >= 18 && edad <= 25)
            {
                uf = uf + 3.6f;
            }
            else if (edad >= 26 && edad <= 45)
            {
                uf = uf + 2.4f;
            }
            else if (edad >= 46)
            {
                uf = uf + 6.0f;
            }

            // Tipo de Sexo

            if (sexo == 1)
            {
                // Sexo Hombre
                uf = uf + 2.4f;

            }
            else if (sexo == 2)
            {
                // Sexo Mujer
                uf = uf + 1.2f;
            }

            // Estado Civil

            if (eCivil == 1)
            {
                // Soltero
                uf = uf + 4.8f;
            }
            else if (eCivil == 2)
            {
                // Casado
                uf = uf + 2.4f;
            }
            else if (eCivil == 3)
            {
                // Otros
                uf = uf + 3.6f;
            }


            recargo = uf * valorUF;

            valorPrimaAnual = valorBase + (int)recargo;

            return valorPrimaAnual;

        }


        public int CalculoPrimaMensual(int edad, int sexo, int eCivil)
        {
            int valorAnual = CalculoPrimaAnual(edad, sexo, eCivil);
            int valorPrimaMensual;
            valorPrimaMensual = valorAnual / 12;
            return valorPrimaMensual;

        }

        public Boolean BuscaCliente(string rut)
        {
            bool valido = false;


            Cliente p = ((ClienteCollection)Session["ClienteCollection"]).BuscarCliente(txt_rutCliente.Text);

            if (p != null)
            {
                valido = true;
            }

            return valido;

        }

        


    }
}
