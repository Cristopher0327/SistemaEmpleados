using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEmpleados
{
    public class Empleado
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Departamento { get; set; }
        public string Cargo { get; set; }
        public string Estado { get; set; }
        public DateTime FechaInicio { get; set; }
        public decimal Salario { get; set; }
    }
}
