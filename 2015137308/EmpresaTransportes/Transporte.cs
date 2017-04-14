using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransportes
{
    class Transporte:Servicio
    {

        

        public override void servicio()
        {

            Cliente _Cliente = new Cliente();
            TipoViaje _TipoViaje = new TipoViaje();
            LugarViaje _LugarViaje = new LugarViaje();
            Console.WriteLine("Transporte");
            Console.WriteLine("------------------------------------------------------------------------------");

            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        _TipoViaje.tipoviaje = ("VIP   ");
                        _Cliente.nombreCli = "Hernan Torres";
                        _Cliente.dniCli = "48128374";
                        _LugarViaje.lugar_viaje = "Ica"; break;
                    case 1:
                        _TipoViaje.tipoviaje = "Normal";
                        _Cliente.nombreCli = "Felipe Dueñas";
                        _Cliente.dniCli = "20387312";
                        _LugarViaje.lugar_viaje = "Trujillo"; break;
                    default:
                        _TipoViaje.tipoviaje = "VIP   ";
                        _Cliente.nombreCli = "Isaac Morales";
                        _Cliente.dniCli = "08745621";
                        _LugarViaje.lugar_viaje = "Puno"; break;
                }

                Console.WriteLine("" + _Cliente.nombreCli + " " + _Cliente.dniCli + "  Tipo de Viaje: " + _TipoViaje.tipoviaje + "   Destino:" + _LugarViaje.lugar_viaje);
            }

            Console.WriteLine("------------------------------------------------------------------------------");
        }
        public Transporte() { }
    }
}
