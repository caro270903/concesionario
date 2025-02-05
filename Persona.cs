using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas_Arquitectura.Clases
{
    internal abstract class Persona
    {
        private string id;
        private string nombre;

        protected Persona(string id, string nombre)
        {6
            this.id = id;
            this.nombre = nombre;
        }

        public string Id { get => id; set => id = !(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < Concesionario.long_id_top) ?
            value: throw new Exception("ID no valido"); }

        public string Nombre { get => nombre; set => nombre = validarNombre(value) ? value: throw new Exception("Nombre no valido"); }
        private Func<string, bool> validarNombre = (value) => !(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < Concesionario.long_min_nom_id) ? true : false;
    }
}
