using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_Transporte.Entities
{
    class Tripulacion : Empleado
    {
        private List<TipoTripulacion> _TipoTripulacion;
        public Tripulacion() { }
        public Tripulacion(int numTripulantes)
        {
            _TipoTripulacion = new List<TipoTripulacion>(numTripulantes);
        }
        public Tripulacion(string dni,int empleadoID,string tipoEmp) : base(dni, empleadoID, "Tripulacion") { }
    }
}
