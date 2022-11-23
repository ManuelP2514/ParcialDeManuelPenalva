using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParcialDeManuelPenalva.Entidades;

namespace ParcialDeManuelPenalva.Datos
{
    public class RepositorioDeEsferas
    {
        private bool HayCambios = false;
        private List<Esfera> listaEsferas;
        public RepositorioDeEsferas()
        {
            listaEsferas = new List<Esfera>();
            listaEsferas = ManejadorDeArchivoSecuencial.LeerArchivoSecuencial();
        }
        public void Agregar (Esfera e1)
        {
            listaEsferas.Add(e1);
        }
        public int GetCantidad()
        {
            return listaEsferas.Count;
        }
        public List<Esfera> GetLista()
        {
            return listaEsferas;
        }
        public bool Borrar(Esfera esfera)
        {
            if (listaEsferas.Contains(esfera))
            {
                listaEsferas.Remove(esfera);
                return true;
            }
            return false;
        }

        public void Editar(Esfera esfera)
        {
            HayCambios = true;
        }
        
    }
}
