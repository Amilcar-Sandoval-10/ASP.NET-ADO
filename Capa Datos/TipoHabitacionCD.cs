using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;

namespace Capa_Datos
{
    public class TipoHabitacionCD
    {

        public List<TipoHabitacionCLE> listaTipoHabitacion()
        {
            List<TipoHabitacionCLE> lista = new List<TipoHabitacionCLE>();
            lista.Add (new TipoHabitacionCLE
            {
                Id =2,
                Nombre= "Sensilla",
                Descripcion = "Solo para una persona"
            });

            return lista;
        }

    }
}
