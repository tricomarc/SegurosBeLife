using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
	public class Contrato
	{
		public string Numero { get; set; }
		public DateTime FechaCreacion { get; set; }
		public DateTime FechaTermino { get; set; }
		public string RutCliente { get; set; }
		public enumCodPlan CodigoPlan { get; set; }
		public DateTime FechaInicioVigencia { get; set; }
		public DateTime FechaFinVigencia { get; set; }
		public enumVigencia Vigente { get; set; }
		public enumSalud DeclaracionSalud { get; set; }
		public double PrimaAnual { get; set; }
		public double PrimaMensual { get; set; }
		public string Observaciones { get; set; }


		private void Init() {

			Numero = string.Format("{0 : G}",DateTime.Now);
			FechaCreacion = DateTime.Now;
			FechaTermino = DateTime.Now;
			RutCliente = string.Empty;
			CodigoPlan = 0;
			FechaInicioVigencia = DateTime.Now;
			FechaFinVigencia = DateTime.Now;
			Vigente = 0;
			DeclaracionSalud = 0;
			PrimaAnual = 0.0;
			PrimaMensual = 0.0;
			Observaciones = string.Empty;

		}

		public Contrato() {

			Init();

		}

        public enum enumVigencia
        {
            Seleccione, Vigente, NoVigente
        }

        public enum enumCodPlan
        {
            Seleccione, Basico, Regular, Premium
        }

        public enum enumSalud
        {
            Seleccione, Fonasa, Isapre, Particular
        }


        



    }
}
