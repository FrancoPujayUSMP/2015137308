using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransportes
{
    class Administrativo:Empleado
    {
        public Administrativo(string dni, int empleadoID, string tipoEmp) : base(dni, empleadoID, "Administrativo") { }
        public Administrativo() { }
        public void identificarse()
        {
            if (dni != null && empleadoID != null)
                Console.WriteLine("Soy un empleado administrativo, mi dni es " + dni + " y mi codigo de empleado es " + empleadoID+".");
            else
                Console.WriteLine("Aún no se registraron empleados del área administrativa.");
        }
    }
}
