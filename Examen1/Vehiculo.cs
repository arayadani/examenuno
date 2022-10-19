using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Examen1
{
    internal class Vehiculo : Tipo


    {

        protected static int cont = 1;
        protected static int[] codigos = new int[5];
        protected static String[] marca = new string[5];
        protected static int[] costo = new int[5];
        protected static String[] modelo = new string[5];


        Tipo t=new Vehiculo();

        public Vehiculo()
        {

        }

        public Vehiculo(string codigo, string marca, string costo, string modelo)
        {


        }
        public static void AgregarVehiculo(string v)

        {

            Console.WriteLine("Ingrese un codigo"); codigos[cont] = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la marca del carro"); marca[cont] = Console.ReadLine();
            Console.WriteLine("Ingrese el modelo del carro"); modelo[cont] = Console.ReadLine();
            Console.WriteLine("Ingrese el costo del carro"); costo[cont] = int.Parse(Console.ReadLine());
            cont++;
        }

        public static void Enseñar()
        {

            int numero;
            Boolean Existe = false;
            //Console.WriteLine("Ingrese el codigo del vehiculo a buscar"); numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                
                
                    Console.WriteLine($"Marca:{marca[i]}");
                    Console.WriteLine($"Modelo:{modelo[i]}");
                    Console.WriteLine($"costo:{costo[i]}");
                    Existe = true;
                
            }
           
        }

        public static void Modificar(string v)
        {

            int numero;
            Boolean Existe = false;
            Console.WriteLine("Ingrese el codigo del vehiculo a modificar"); numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                if (numero == codigos[i])
                {

                    Console.WriteLine("Ingrese la marca del carro"); marca[cont] = Console.ReadLine();
                    Console.WriteLine("Ingrese el modelo del carro"); modelo[cont] = Console.ReadLine();
                    Console.WriteLine("Ingrese el costo del carro"); costo[cont] = int.Parse(Console.ReadLine());
                    Existe = true;
                }
            }
            if (!Existe) Console.WriteLine("El vehiculo ingresado no existe");

        }

        public static void ConsultarArticulos(string v)
        {

            int numero;
            Boolean Existe = false;
            Console.WriteLine("Ingrese el codigo del vehiculo a buscar"); numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                if (numero == codigos[i])
                {
                    Console.WriteLine($"Marca:{marca[i]}");
                    Console.WriteLine($"Modelo:{modelo[i]}");
                    Console.WriteLine($"costo:{costo[i]}");
                    Existe = true;
                }
            }
            if (!Existe) Console.WriteLine("El vehiculo ingresado no existe");
        }

        public static void Ventas(string v)
        {

            int numero;
            Boolean Existe = false;
            Console.WriteLine("Ingrese el codigo del vehiculo a buscar"); numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                if (numero == codigos[i])
                {
                    Console.WriteLine($"Marca:{marca[i]}");
                    Console.WriteLine($"Modelo:{modelo[i]}");
                    Console.WriteLine($"costo:{costo[i]}");
                    Existe = true;
                }
            }
            if (!Existe) Console.WriteLine("El vehiculo ingresado no existe");
            {

            }

           

            
        }

       
    }
}


