using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodos
{

    class Program
    {
        static nodo NodoInicial; //Apunta al primer elemento de la lista
        static nodo NodoFinal; //Apunta al ultimo elemento de la lista

        public class nodo
        {
            public int dato;
            public nodo sig;
        }


        static void Agregar(int dato)
        {
            // Creamos un nodo nuevo (dato)
            nodo NodoNuevo = new nodo();
            NodoNuevo.dato = dato;
            NodoNuevo.sig = null;

            // Verificamos si ya existe una lista creada
            if (NodoInicial == null)
            { 
                // Si no existe una lista ya creada,
                // el nodo nuevo sera el primero y ultimo de la lista
                NodoInicial = NodoNuevo;
                NodoFinal = NodoNuevo;
            } else {
                // Ya existe una lista previa con nodos

                // Guardamos el nodo final actual en un nodo temporal
                // para que no se nos pierda
                nodo NodoTmp = NodoFinal;

                // El nodo final actual ahora apuntara al nuevo nodo 
                NodoTmp.sig = NodoNuevo;

                // Ahora el nodo nuevo sera el nodo final
                NodoFinal = NodoNuevo;              
            }

        }
        static void Recorre()
        {
            nodo n1 = NodoInicial;
            while( n1 != null) {
                Console.WriteLine(n1.dato);
                n1 = n1.sig;
            }
        }
        static void Main(string[] args)
        {
            NodoInicial = null;
            NodoFinal = null;

            Console.WriteLine("Nodos");
            Agregar(5);
            Agregar(1);
            Agregar(6);
            Agregar(4);
            Agregar(10);

            Recorre();

            Console.WriteLine("\nPresiona <Enter> para salir");
            Console.ReadLine();

        }
    }
}
