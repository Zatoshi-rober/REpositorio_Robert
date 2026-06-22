using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REpositorio_Robert
{
    internal class Caballero:Personaje,ICongelable,IQuemable
    {
        public Caballero(string nombre) : base(nombre)
        {

        }
        public void Congelar()
        {
            Console.WriteLine(Nombre + " El Caballero se ha Congelado");
        }

        public void Quemar()
        {
            Console.WriteLine(Nombre + " El Caballero se ha Quemado");
        }
    }
}
