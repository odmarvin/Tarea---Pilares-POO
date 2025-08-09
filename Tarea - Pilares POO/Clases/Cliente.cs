using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea___Pilares_POO.Clases
{
    public class Cliente
    {
        public string nombre { get; set; }
        public string email { get; set; }

        public Cliente(string nombre, string email)
        {
            this.nombre = nombre;
            this.email = email;
        }
    }
}
