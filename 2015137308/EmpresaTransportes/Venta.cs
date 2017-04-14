using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransportes
{
    class Venta
    {
        public Administrativo _Administrativo;
        public Cliente _Cliente;
        public Servicio _Servicio;
        public TipoPago _TipoPago;
        public TipoComprobante _TipoComprobante;
        public Venta(Administrativo _Administrativo)
        {
            _Administrativo = this._Administrativo;
        }
        public Venta(Cliente _Cliente)
        {
            _Cliente = this._Cliente;
        }
        public Venta(Servicio _Servicio)
        {
            _Servicio = this._Servicio;
        }
        public Venta(TipoPago _TipoPago)
        {
            _TipoPago = this._TipoPago;
        }
        public Venta(TipoComprobante _TipoComprobante)
        {
            _TipoComprobante = this._TipoComprobante;
        }
    }
}
