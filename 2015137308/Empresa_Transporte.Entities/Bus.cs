using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_Transporte.Entities
{
    class Bus
    {
        private List<Tripulacion> _Tripulacion;
        public List<Tripulacion> Tripulacion
        {
            get
            {
                return _Tripulacion;
            }
            set
            {
                if (value.Count == 6)
                    _Tripulacion = value;
            }
        }
        public Bus(List<Tripulacion> Tripulacion)
        {
            Tripulacion = this.Tripulacion;
        }
    }
}
