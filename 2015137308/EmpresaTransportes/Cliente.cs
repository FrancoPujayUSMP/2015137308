using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransportes
{
    class Cliente
    {
        public string nombreCli { get; set; }
        public string dniCli { get; set; }
        public Cliente(string nombreCli)
        {
            nombreCli = this.nombreCli;
        }
        public Cliente() { }

    }
}
