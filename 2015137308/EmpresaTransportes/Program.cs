using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransportes
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
        var Transporte = new Transporte();
            Transporte.servicio();
            var Encomienda = new Encomienda();
            Encomienda.servicio();
            Console.ReadLine();



        }
        
    }
}
