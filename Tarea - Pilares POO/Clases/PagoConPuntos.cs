using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea___Pilares_POO.Clases
{
    public class PagoConPuntos : IPago
    {
        public double puntosDisponibles { get; set; }

        public PagoConPuntos(int puntos)
        {
            this.puntosDisponibles = puntos;
        }

        public bool ProcesarPago(double monto)
        {
            double puntosNecesarios = monto * 5;
            if (puntosDisponibles >= puntosNecesarios)
            {
                this.puntosDisponibles -= puntosNecesarios;
                Console.WriteLine("Pago exitoso");
                return true;
            }
            else
            {
                Console.WriteLine("Puntos insuficientes.");
                return false;
            }
        }
    }
}
