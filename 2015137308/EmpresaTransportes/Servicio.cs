using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransportes
{ 
    public abstract class Servicio
    {
        public string descripcionServicio { get; set; }
        public Servicio(string descripcionServicio)
        {
            descripcionServicio = this.descripcionServicio;
        }
        public Servicio() { }
        public abstract void servicio();
    }
}
