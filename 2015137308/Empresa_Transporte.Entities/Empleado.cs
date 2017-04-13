using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_Transporte.Entities
{
    class Empleado
    {
        public string dni { get; set; }
        public int empleadoID { get; set; }
        public string tipoEmp { get;set }
        public Empleado() { }
        public Empleado(string dni,int empleadoID,string tipoEmp)
        {
            dni = this.dni;
            empleadoID = this.empleadoID;
            tipoEmp = this.tipoEmp;
        }
    }
}
