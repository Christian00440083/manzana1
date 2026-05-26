using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manzana
{
    internal class Pila
    {
        Nodo cima = null;

        public void Push(string dato)
        {
            Nodo nuevo = new Nodo();
            nuevo.dato = dato;
            nuevo.siguiente = cima;
            cima = nuevo;
        }
        public string Pop()
        {
            if (cima == null)
            {
                return null;
            }
            string dato = cima.dato;
            cima = cima.siguiente;

            return dato;
        }
        public string Peek()
        {
            if (cima == null)
            {
                return null;
            }
            return cima.dato;
        }
        public void Mostrar()
        {
            if (cima == null)
            {
                Console.WriteLine("Pila vacia");
                return;
            }
            Nodo aux = cima;
            while (aux != null)
            {
                Console.WriteLine(aux.dato);
                aux = aux.siguiente;
            }
        }
        public bool Vacia()
        {
            return cima == null;
        }
    }
}
