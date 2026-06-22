using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REpositorio_Robert
{
    internal class Minero:Personaje, IQuemable
    {
        public Minero (string nombre): base(nombre)
        {

        }

        public void Quemar()
        {
            Console.WriteLine(Nombre + " El Minero se ha Quemado");
        }

    }
}
