using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialDeManuelPenalva.Entidades
{
    public class Esfera
    {
        public double Radio { get; set; }

        public Esfera(double radio)
        {
            Radio = radio;
        }

        public Esfera()
        {
        }

        enum ColorDeRelleno
        {
            Rojo=1,
            Azul=2,
            Blanco=3,
            Negro=4,
            Naranja=5
        }
        enum TipoTrazoLinea
        {
            Continuo=1,
            Rayas=2,
            Puntos=3
        }
       
        public double GetVolumen() => 4 / 3 * Math.PI * Math.Pow(Radio, 3);
        public double GetArea() => 4 * Math.PI * Math.Pow(Radio, 2);

    }



}