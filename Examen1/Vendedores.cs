using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Vendedores


    {

        public Vendedores()
        {



        }
        public void Listado_Vendedores()
        {

            Dictionary<string, string> vende = new Dictionary<string, string>();
            vende.Add("123", "Daniela Araya");
            vende.Add("456", "Jholy Araya");

            foreach (var ven in vende)
            {
                Console.WriteLine($"Llave: {ven.Key} Nombre:{ven.Value}");
            }
            Console.Read();

        }

    }
        
}
    
	


	

    


    

