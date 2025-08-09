using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea___Pilares_POO.Clases
{
    public class PagoConTransferencia : IPago
    {
        public string cuentaBancaria { get; set; }
        public bool cuentaValida { get; set; }

        public PagoConTransferencia(string cuenta, bool estado)
        {
            this.cuentaBancaria = cuenta;
            this.cuentaValida = estado;
        }

        public bool ProcesarPago(double monto)
        {
            if (cuentaValida)
            {
                Console.WriteLine($"Transferencia exitosa");
                return true;
            }
            else
            {
                Console.WriteLine("Cuenta inválida.");
                return false;
            }
        }
    }
}
