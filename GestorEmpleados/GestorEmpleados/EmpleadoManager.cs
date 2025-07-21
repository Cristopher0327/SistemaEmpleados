using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEmpleados
{

    public static class EmpleadoManager
    {
            public static List<Empleado> ListaEmpleados = new List<Empleado>();

            public static int GenerarNuevoID()
            {
                if (ListaEmpleados.Count == 0)
                    return 1;
                else
                    return ListaEmpleados.Max(e => e.ID) + 1;
            }

            public static void AgregarEmpleado(Empleado emp)
            {
                ListaEmpleados.Add(emp);
            }
      
    }

}
