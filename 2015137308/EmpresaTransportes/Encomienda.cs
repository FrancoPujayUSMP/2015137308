﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransportes
{
    class Encomienda:Servicio
    {
       private string encomiendaID { get; set; }
        public Bus bus { get; set; }
        public enum Encomiendas { Arroz,Papa,Camote,Piña,Cebolla,Limon}
        Random r = new Random();
        float peso;
        public Encomienda(string descripcionServicio) : base(descripcionServicio) { }
        public Encomienda(Bus bus)
        {
            bus = this.bus;
        }
        public Encomienda(string encomiendaID,float peso)
        {
            encomiendaID = this.encomiendaID;
            peso = this.peso;
        }
        public override void servicio()
        {
            Console.WriteLine("Encomiendas");
            Console.WriteLine("------------------------------------------------------------------------------");
            for (int i = 0; i < 2; i++)
            {
                int x;
                switch (i) { case 0: x = r.Next(3); break; default: x = r.Next(2, 6); break; }
                var encomiendas = (Encomiendas)x;
                string encomienda = encomiendas.ToString();
                if (encomienda.Equals("Arroz")) peso = 30;
                else if (encomienda.Equals("Papa")) peso = 40;
                else if (encomienda.Equals("Camote")) peso = 25;
                else if (encomienda.Equals("Piña")) peso = 45;
                else if (encomienda.Equals("Cebolla")) peso = 35;
                else peso = 15;
                Console.WriteLine("Encomienda : {0}      Peso: {1}KG", encomienda, peso);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.ReadLine();
        }
        public Encomienda() { }
    }
}
