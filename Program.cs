using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REpositorio_Robert
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Personaje> personajes = new List<Personaje>()
            {

                new Princesa("Lauren"),
                new Minero ("Taysir"),
                new Caballero("Elian"),
               

            };

            


            

            BolaHielo b1 = new BolaHielo();
            FuriaInfernal ff = new FuriaInfernal();

           
           foreach (var item in personajes)
            {
                if (item is ICongelable congelable)
                {
                    b1.Congelar(congelable);
                }

                if (item is IQuemable quemables)
                {
                    ff.Quemar(quemables);
                }

            }




            
        }
    }
}
