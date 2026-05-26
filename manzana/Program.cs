namespace manzana;


class Program
{
    static void Main(string[] args)
    {
        Cola cola = new Cola();
        Pila historial = new Pila();
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("===== MENU =====");
            Console.WriteLine("1. Agregar cliente");
            Console.WriteLine("2. Atender cliente");
            Console.WriteLine("3. Mostrar cola");
            Console.WriteLine("4. Ver ultimo atendido");
            Console.WriteLine("5. Mostrar historial");
            Console.WriteLine("6. Salir");
            Console.Write("Opcion: ");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.Write("Nombre cliente: ");
                    string nombre = Console.ReadLine();
                    cola.Encolar(nombre);
                    Console.WriteLine("Cliente agregado");
                    break;
                case 2:
                    if (!cola.Vacia())
                    {
                        string atendido = cola.Desencolar();
                        historial.Push(atendido);
                        Console.WriteLine("Cliente atendido: " + atendido);
                    }
                    else
                    {
                        Console.WriteLine("No hay clientes");
                    }
                    break;
                case 3:
                    Console.WriteLine("COLA:");
                    cola.Mostrar();
                    break;
                case 4:
                    if (!historial.Vacia())
                    {
                        Console.WriteLine("Ultimo atendido: " + historial.Peek());
                    }
                    else
                    {
                        Console.WriteLine("Historial vacio");
                    }
                    break;
                case 5:
                    Console.WriteLine("HISTORIAL:");
                    historial.Mostrar();
                    break;
                case 6:
                    Console.WriteLine("Fin");
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
            Console.WriteLine("\nPresione una tecla...");
            Console.ReadKey();
        } while (opcion != 6);
    }
}
    




