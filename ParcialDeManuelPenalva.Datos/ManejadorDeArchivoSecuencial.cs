using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParcialDeManuelPenalva.Entidades;

namespace ParcialDeManuelPenalva.Datos
{
    public static class ManejadorDeArchivoSecuencial
    {
        private static string archivo = "Esfera.txt";
        public static void GuardarEnArchivoSecuencia(List<Esfera> lista)
        {
            using (var escritor = new StreamWriter(archivo))
            {

                foreach (var esfera in lista)
                {
                    string linea = ConstruirLinea(esfera);
                    escritor.WriteLine(linea);
                }
            }
        }
        public static List<Esfera> LeerArchivoSecuencial()
        {
            List<Esfera> lista = new List<Esfera>();
            using (var lector = new StreamReader(archivo))
            {
                while (!lector.EndOfStream)

                {
                    string linea = lector.ReadLine();
                    Esfera esf = ConstruirEsfera(linea);
                    lista.Add(esf);
                }
            }
            return lista;

        }

        private static Esfera ConstruirEsfera(string linea)
        {
            return new Esfera() { Radio = int.Parse(linea) };
        }

       
        private static string ConstruirLinea(Esfera esfera)
        {
            return $"{esfera.Radio}";
        }
    }
}
            
   

