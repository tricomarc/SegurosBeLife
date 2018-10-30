
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }

        private void Init()
        {
            Nombre = string.Empty;
            Nickname = string.Empty;
            Password = string.Empty;
        }
        public Usuario()
        {
            Init();
        }

		//Para Login.
        /*public string ObtenerNombre()
        {
            return string.Format("{0} ({1})", Nombre, Nickname);
        }
		*/

    }
}
