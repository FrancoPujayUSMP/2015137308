using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransportes
{
    class TipoViaje
    {
        private string tipoviaje;
        public string Tipoviaje
        {
            get
            {
                return tipoviaje;
            }
            set
            {
                if(value.Equals("VIP")||value.Equals("Normal"))
                {
                    tipoviaje = value;
                }
            }
        }
        public TipoViaje(string tipoviaje)
        {
            tipoviaje = this.tipoviaje;
        }
    }
}
