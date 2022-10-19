using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Menu
    {

        static Menu() { }
        
        public static void Principal()

        {
            Vendedores V=new Vendedores();
            byte opcion = 1;
            Tipo tip=new Tipo();

            
            do
            {


                Console.Write("1- ");

                Console.WriteLine("Vehiculos");

                Console.Write("2- ");

                Console.WriteLine("Ventas");

                Console.Write("3- ");

                Console.WriteLine("Reportes");

                Console.Write("4- ");

                Console.WriteLine("Salir");

                Console.Write("Digite una opcion: ");
                opcion = byte.Parse(Console.ReadLine());
                Console.Clear();
                Tipo t = new Tipo();
                switch (opcion)
                {
                    case 1: SubMenuVentas(); break;
                   // case 2: SubmenuCajeros(); break;
                    case 3: V.Listado_Vendedores(); tip.Listado(); Vehiculo.Enseñar(); break;
                    case 4:
                        Console.WriteLine("Gracias,  Adios");
                        break;
                    default:
                        break;
                }
            } while (opcion != 4);

        }

        public static void SubMenuVentas()
        {
            byte opcion = 1;
            do
            {

                Console.WriteLine("Usted presiono la opcion de vehiculo");

                Console.Write("1- ");
                Console.WriteLine("Agregar");
                Console.Write("2- ");
                Console.WriteLine("Modificar");
                Console.Write("3- ");
                Console.WriteLine("Consultar");

                Console.Write("4- ");
                Console.WriteLine("Salir");
                Console.WriteLine("<3<3<3<3<3<3<3<3<3<3<3<3<3<3");
                Console.Write("Digite una opcion: ");
                opcion = byte.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1: Vehiculo.AgregarVehiculo("1"); break;
                    case 2: Vehiculo.Modificar("2"); break;
                    case 3: Vehiculo.ConsultarArticulos("3"); break;
                    case 4:
                        Menu.Principal(); break;


                }
            } while (opcion != 7);

        }
       
            }
            }
    















