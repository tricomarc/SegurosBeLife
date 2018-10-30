using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ClienteCollection : List<Cliente>
    {

        public Cliente BuscarCliente(string rut)
        {
            try
            {
                return this.Where(p => p.Rut == rut).FirstOrDefault();
            }
            catch (Exception)
            {

                return null;
            }

            //Cliente Cliente = null;
            //var query = from p in this
            //            where p.Rut == rut
            //            select p;
            //if (query.Count() >1)
            //{
            //    Cliente = query.First();
            //}
            //return Cliente;
        }

        public bool ModificarCliente(Cliente ClienteModificado)
        {
            bool resultado = false;
            Cliente ClienteParaModificar = BuscarCliente(ClienteModificado.Rut);

            if (ClienteParaModificar != null)
            {
                ClienteParaModificar.Nombres = ClienteModificado.Nombres;
                ClienteParaModificar.Apellidos = ClienteModificado.Apellidos;
                ClienteParaModificar.Edad = ClienteModificado.Edad;
                ClienteParaModificar.Sexo = ClienteModificado.Sexo;
				ClienteParaModificar.EstadoCivil = ClienteModificado.EstadoCivil;
                resultado = true;
            }

            return resultado;
        }

    }
}
