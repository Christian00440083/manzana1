using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manzana
{
    internal class Cola
    {
        Nodo inicio = null;
        Nodo fin = null;

        public void Encolar(string dato)
        {
            Nodo nuevo = new Nodo();
            nuevo.dato = dato;
            if (inicio == null)
            {
                inicio = nuevo;
                fin = nuevo;
            }
            else
            {
                fin.siguiente = nuevo;
                fin = nuevo;
            }
        }
        public string Desencolar()
        {
            if (inicio == null)
            {
                return null;
            }
            string dato = inicio.dato;
            inicio = inicio.siguiente;
            if (inicio == null)
            {
                fin = null;
            }
            return dato;
        }
        public void Mostrar()
        {
            if (inicio == null)
            {
                Console.WriteLine("Cola vacia");
                return;
            }
            Nodo aux = inicio;
            while (aux != null)
            {
                Console.WriteLine(aux.dato);
                aux = aux.siguiente;
            }
        }
        public bool Vacia()
        {
            return inicio == null;
        }
    }
}
