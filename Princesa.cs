using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REpositorio_Robert
{
    internal class Princesa:Personaje, ICongelable
    {

        public Princesa(string nombre) : base(nombre)
        {

        }
        public void Congelar()
        {
            Console.WriteLine(Nombre + " La Princesa se ha Congelado");
        }
    }
}
