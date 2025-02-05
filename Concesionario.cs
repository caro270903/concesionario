using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas_Arquitectura.Clases
{
    internal class Concesionario
    {
        //Atributos de datos --> constructor
        private string nombre;
        private string direccion;

        //Atributos de estado
        //internal List<>

        //Atributos de negocio
        internal readonly static float descto_menor = 0.01f, descto_mayor = 0.025f;
        internal readonly static float comision_menor = 0.015f, comision_mayor = 0.02f;
        internal readonly static byte long_placa_nombemp_tax = 6;
        internal readonly static byte long_marca_min = 2, long_mod_min = 2, gap_ano_nuevo = 2;
        internal readonly static short cil_min = 1000, cil_max = 6000;
        internal readonly static byte nro_pues_min = 2, nro_pues_max = 7;
        internal readonly static byte nro_puer_2 = 2, nro_puer_3 = 3, nro_puer_5 = 5;
        internal readonly static byte long_min_nom_id = 5, long_min_dir = 10, long_id_top = 10;
        internal readonly ulong cons_fraccion = 1000000;

        public string Nombre { get => nombre; set => nombre = validarNombre(value) ? value: throw new Exception("Nombre no valido"); }

        private Func<string, bool> validarNombre = (value) => !(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < long_min_nom) ? true: false;

        public string Direccion { get => direccion; set => direccion = validarDir(value) ? value : throw new Exception("Direccion no valida"); }

        private Func<string, bool> validarDir = (value) => !(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < long_min_dir) ? true: false;

        public Concesionario(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
        }
    }
}
