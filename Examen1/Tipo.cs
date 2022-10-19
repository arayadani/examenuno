using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Tipo
    {



            public Tipo()

            {

            }

            List<String> tipos = new List<string>() { "Motocicleta", "Automovil", "Dron" };
            int x = 0;

        public void Listado()
        {

            for (int i = 0; i < tipos.Count; i++)
            {

                Console.WriteLine(tipos[i]);
                
            }
            Console.ReadLine();

        }

        public Boolean IndicarTipo(string valor)
        {

            Boolean existe = tipos.Contains(valor);//aqui el valor "tipos" me estaba dando error, no me queria reconocer la lista de ninguna manera

            return existe;





        }
    }
}





