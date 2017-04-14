using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_Transporte.Entities
{
    class TipoComprobante
    {
        string tipocomprobante
        {
            get
            {
                return tipocomprobante;
            }
            set
            {
                if (value.Equals("Boleta") || value.Equals("Factura"))
                    tipocomprobante = value;
                else
                    Console.WriteLine("Error : " + value + " no se reconoce como un tipo de comprobante.");
            }
        }
        public TipoComprobante(string tipocomprobante)
        {
            tipocomprobante = this.tipocomprobante;
        }
    }
}
