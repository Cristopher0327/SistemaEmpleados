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

        // tiempo en la empresa (calculado)
        public string TiempoEnEmpresa
        {
            get
            {
                TimeSpan tiempo = DateTime.Now - FechaInicio;
                int años = (int)(tiempo.Days / 365.25);
                int meses = (int)((tiempo.Days % 365.25) / 30.44);
                return $"{años} años y {meses} meses";
            }
        }

        // AFP
        public decimal AFP
        {
            get { return Salario * 0.0287M; }
        }

        // ARS
        public decimal ARS
        {
            get { return Salario * 0.0304M; }
        }

        // ISR
        public decimal ISR
        {
            get
            {
                decimal salarioAnual = Salario * 12;

                if (salarioAnual <= 416220)
                    return 0;
                else if (salarioAnual <= 624329)
                    return Salario * 0.15M;
                else if (salarioAnual <= 867123)
                    return Salario * 0.20M;
                else
                    return Salario * 0.25M;
            }
        }

        public object Apellido { get; internal set; }
        public object Sueldo { get; internal set; }
        public object FechaNacimiento { get; internal set; }

       
    }
}

