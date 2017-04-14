using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransportes
{
    class Bus
    {
        private List<Tripulacion> _Tripulacion;
        private int n_asientos { get; set; }
        private string tipoBus { get; set; }
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
        public Bus(int n_asientos,string tipoBus)
        {
            n_asientos = this.n_asientos;
            tipoBus = this.tipoBus;
        }
        public Bus() { }
    }
}
