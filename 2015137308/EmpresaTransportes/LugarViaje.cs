using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransportes
{
    class LugarViaje
    {
      
        public string lugar_viaje { get;set; }
        public LugarViaje(string tipoViaje)
        {
            TipoViaje _TipoViaje = new TipoViaje();
            tipoViaje = _TipoViaje.tipoviaje;
        }
        public LugarViaje() { }
    }
}
