using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manzana
{
    internal class Nodo
    {
        public string valor;
        public Nodo siguiente;
        public Nodo anterior;
        public Nodo(string valor)
        {
            this.valor = valor;
            this.siguiente = null;
            this.anterior = null;
        }
    }
}
