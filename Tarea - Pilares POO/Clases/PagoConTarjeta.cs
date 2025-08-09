using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea___Pilares_POO.Clases
{
    public class PagoConTarjeta : IPago
    {
        public string numeroTarjeta { get; set; }
        public double saldoDisponible { get; set; }

        public PagoConTarjeta(string numero, double saldo)
        {
            this.numeroTarjeta = numero;
            this.saldoDisponible = saldo;
        }

        public bool ProcesarPago(double monto)
        {
            if (this.saldoDisponible >= monto)
            {
                this.saldoDisponible -= monto;
                Console.WriteLine("Pago realizado");
                return true;
            }
            else
            {
                Console.WriteLine("Transaccion fallida, revise sus fondos");
                return false;
            }
        }
    }
}
