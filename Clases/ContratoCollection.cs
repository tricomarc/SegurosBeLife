using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
	public class ContratoCollection : List<Contrato>
	{


		public Contrato BuscarContrato(string rut)
		{
			try
			{
				return this.Where(r => r.RutCliente == rut).FirstOrDefault();
			}
			catch (Exception)
			{

				return null;
			}

		}

		public bool ModificarContrato(Contrato contratoModificado)
		{
			bool resultado = false;
			Contrato contratoParaModificado = BuscarContrato(contratoModificado.RutCliente);

			if (contratoParaModificado != null)
			{

				contratoParaModificado.CodigoPlan = contratoModificado.CodigoPlan;
				contratoParaModificado.DeclaracionSalud = contratoModificado.DeclaracionSalud;
				contratoParaModificado.FechaCreacion = contratoModificado.FechaCreacion;
				contratoParaModificado.FechaFinVigencia = contratoModificado.FechaFinVigencia;
				contratoParaModificado.FechaInicioVigencia = contratoModificado.FechaInicioVigencia;
				contratoParaModificado.FechaTermino = contratoModificado.FechaTermino;
				contratoParaModificado.Numero = contratoModificado.Numero;
				contratoParaModificado.Observaciones = contratoModificado.Observaciones;
				contratoParaModificado.PrimaAnual = contratoModificado.PrimaAnual;
				contratoParaModificado.PrimaMensual = contratoModificado.PrimaMensual;
				contratoParaModificado.RutCliente = contratoModificado.RutCliente;
				contratoParaModificado.Vigente = contratoModificado.Vigente;
				resultado = true;
			}

			return resultado;
		}





	}
}
