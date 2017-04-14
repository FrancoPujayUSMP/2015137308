using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_Transporte.Entities
{
    class Transporte:Servicio
    {
        public Cliente _Cliente;
        public TipoViaje _TipoViaje;
        public LugarViaje _LugarViaje;
        public Transporte(Cliente _Cliente)
        {
            _Cliente = this._Cliente;
        }
        public Transporte(TipoViaje _TipoViaje)
        {
            _TipoViaje = this._TipoViaje;
        }
        public Transporte(LugarViaje _LugarViaje)
        {
            _LugarViaje = this._LugarViaje;
        }
        public override void servicio()
        {

            string tipoviaje;
            Console.WriteLine("Transporte");
            Console.WriteLine("------------------------------------------------------------------------------");
            
            for(int i=0;i<3;i++)
            {
                switch (i) { case 0: _TipoViaje = new TipoViaje("VIP"); break; case 1: _TipoViaje = new TipoViaje("Normal");break; default: _TipoViaje = new TipoViaje("VIP");break; }
                tipoviaje = _TipoViaje.Tipoviaje;
                Console.WriteLine("Armando Torres 01856212 Tipo de Viaje: " + tipoviaje + " Destino: Ica");
            }
            
            Console.WriteLine("------------------------------------------------------------------------------");
            
        }
    }
}
