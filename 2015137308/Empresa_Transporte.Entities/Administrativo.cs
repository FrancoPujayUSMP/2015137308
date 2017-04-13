using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_Transporte.Entities
{
    class Administrativo:Empleado
    {
        public Administrativo(string dni, int empleadoID, string tipoEmp) : base(dni, empleadoID, "Administrativo") { }
    }
}
