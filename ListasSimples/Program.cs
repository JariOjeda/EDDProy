using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasSimples
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
        public class ListaSimple
        {
            public ListaSimple()
            {
                NodoInicial = null;
                NodoFinal = null;
            }
            public ListaSimple(int valor)
            {
                NodoInicial = null;
                NodoFinal = null;

                this.Agregar(valor);
            }

            public void Agregar(int dato)
            {
                nodo NuevoNodo = new nodo();
                NuevoNodo.dato = dato;
                NuevoNodo.sig = null;

                // Verificamos si ya existe una lista creada
                if (NodoInicial == null)
                {
                    // Si no existe una lista ya creada,
                    // el nodo nuevo sera el primero y ultimo de la lista
                    NodoInicial = NuevoNodo;
                    NodoFinal = NuevoNodo;
                }
                else
                {
                    // Ya existe una lista previa con nodos

                    // Guardamos el nodo final actual en un nodo temporal
                    // para que no se nos pierda
                    nodo NodoTmp = NodoFinal;

                    // El nodo final actual ahora apuntara al nuevo nodo 
                    NodoTmp.sig = NuevoNodo;

                    // Ahora el nodo nuevo sera el nodo final
                    NodoFinal = NuevoNodo;
                }

            }
            public void Recorre()
            {
                nodo n1 = NodoInicial;
                while (n1 != null)
                {
                    Console.WriteLine(n1.dato);
                    n1 = n1.sig;
                }
            }
        }


        static void Main(string[] args)
        {

            Console.WriteLine("Listas Simples");
            //ListaSimple miLista = new ListaSimple(5);
            ListaSimple miLista = new ListaSimple();
            miLista.Agregar(5);
            miLista.Agregar(1);
            miLista.Agregar(6);
            miLista.Agregar(4);
            miLista.Agregar(10);

            miLista.Recorre();

            Console.WriteLine("\nPresiona <Enter> para salir");
            Console.ReadLine();

        }
    }
}
