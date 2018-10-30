using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cliente
    {

        public string Rut { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime Edad { get; set; }
        public enumSexo Sexo { get; set; }

        public enumEstadoCivil EstadoCivil{ get; set; }
        private void Init()
        {
            Rut = string.Empty;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            Edad = DateTime.Now;
            Sexo = 0;
            EstadoCivil = 0;
        }
        public Cliente()
        {
            Init();
        }
    }

    public enum enumSexo
    {
        Seleccione, Masculino, Femenino 
    }

    public enum enumEstadoCivil
    {
        Selecciones, Soltero, Casado, Otros

    }
}
