using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_Transporte.Entities
{
    class TipoTripulacion
    {
        private string tipo_tripulacion;
        public string Tipo_tripulacion
        {
            get
            {
                return tipo_tripulacion;
            }
            set
            {
                if(value.Equals("Cabina")||value.Equals("Pulser")||value.Equals("Terramoza"))
                {
                    tipo_tripulacion = value;
                }
            }
        }
        public TipoTripulacion(string tipo_tripulacion)
        {
            tipo_tripulacion = this.tipo_tripulacion;
        }
    }
}
