using System;
using NestorAnchundiaA3B.clases;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NestorAnchundiaA3B
{
    class Program
    {
        static void Main(string[] args)
        { 
        int menú;         
            do
            {
                Console.WriteLine("\n>>>>>>>>>>>>MENÚ PRINCIPAL <<<<<<<<<\n" +
                       "1.- Cola\n" +
                       "2.- Pila\n"+
                       "3.- Salir\n");
                Console.WriteLine("Elija una opcion");
                menú = int.Parse(Console.ReadLine());               
                switch (menú)
                {
                    case 1:
                        Cola cola = new Cola();
        int menu;
                        do
                        {
                            Console.WriteLine("\n>>>>>>>>>>MENÚ DE LA COLA<<<<<<<\n" +
                               "1) Insertar\n" +
                               "2) Buscar\n" +
                               "3) Modificar\n" +
                               "4) Eliminar\n" +
                               "5) Desplegar\n" +
                               "6) Salir del menú\n");
                            Console.WriteLine("Elija una de las opción");
                            menu = int.Parse(Console.ReadLine());
                            switch (menu)
                            {
                                case 1:
                                    Console.WriteLine("\nInsertar nodo en la LISTA\n");
                                    cola.InsertarNodo();
                                    break;
                                case 2:
                                    Console.WriteLine("\nBuscar nodo en la LISTA\n");
                                    cola.buscarnodo();
                                    break;
                                case 3:
                                    Console.WriteLine("\nModificar nodo en la LISTA\n");
                                    cola.modificarnodo();
                                    break;
                                case 4:
                                    Console.WriteLine("\nEliminar nodo de la  LISTA\n");
                                    cola.eliminarcola();
                                    break;
                                case 5:
                                    Console.WriteLine("\nDespleglar nodo de la LISTA\n");
                                    cola.desplegarCola();
                                    break;
                                case 6:
                                    Console.WriteLine("\nFin de  COLA\n");
                                    break;
                                default:
                                    Console.WriteLine("\n Por favor ingresar opcion valida \n");
                                    break;
                            }
} while (menu != 6);
                        break;
                    case 2:
                        Pila pil = new Pila();
int menu2;
                        do
                        {
                            Console.WriteLine("\n <+<+<+<+<+<+<+<+MENÚ  PILA>+>+>+>+>+>+>+>+>\n" +
                               "1) Insertar\n" +
                               "2) Buscar\n" +
                               "3) Modificar\n" +
                               "4) Eliminar\n" +
                               "5) Desplegar\n" +
                               "6) Salir del menú\n");
                            Console.WriteLine("Elija una opción");
                            menu2 = int.Parse(Console.ReadLine());
                            switch (menu2)
                            {
                                case 1:
                                    Console.WriteLine("\nInsertar en la Lista\n");
                                    pil.insertarNodoPila();
                                    break;
                                case 2:
                                    Console.WriteLine("\nBuscar en la Lista\n");
                                    pil.BuscarNodoPila();
                                    break;
                                case 3:
                                    Console.WriteLine("\nModificar en la Lista\n");
                                    pil.ModificarNodoPila();
                                    break;
                                case 4:
                                    Console.WriteLine("\nEliminar en la Lista\n");
                                    pil.EliminarNodoPila();
                                    break;
                                case 5:
                                    Console.WriteLine("\nDesplegar en la Lista\n");
                                    pil.DesplegarPila();
                                    break;
                                case 6:
                                    Console.WriteLine("\nFInal  PILA\n");
                                    break;
                                default:
                                    Console.WriteLine("\nPor favor ingresar opcion valida\n");
                                    break;
                            }
                        } while (menu2 != 6);
                        break;
                    case 3:                       
                        break;
                    default:
                        Console.WriteLine("\nPor favor ingresar opcion valida\n");
                        break;
                }                
            } while (menú!= 3);
        }
    }
}
