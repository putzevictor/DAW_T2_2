namespace Linq_DWES_tema2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 0, 1, 2, 3, 4, 5, 6 };
            var pares = from num in numeros
                        where (num % 2) == 0
                        select num;
            foreach(int i in pares)
            {
                Console.WriteLine("{0} es un numero par",i);
            }

            List<Cliente> clientes = new List<Cliente>();
            clientes.Add(new Cliente("Juan", "12345678P","Calle 1 123", 1.75));
            clientes.Add(new Cliente("Pedro", "78791025P", "Calle 2 123", 1.80));
            clientes.Add(new Cliente("Daniel", "12345610P", "Calle 3 123", 1.85));
            clientes.Add(new Cliente("Miguel", "12345620P", "Calle 4 123", 1.70));

            var altos = from cli in clientes
                        where cli.altura > 1.7
                        select new {cli.nombre, cli.altura};
            foreach(var cli in altos)
            {
                Console.WriteLine(cli);
            }
            // Hola amigo
        }
    }

    class Cliente
    {
        public string nombre { get; set; }
        public string DNI { get; set; }
        public string calle { get; set; }
        public double altura { get; set; }

        public Cliente(string p_nombre, string p_Dni, string p_calle, double p_altura)
        {
            nombre = p_nombre;
            DNI = p_Dni;
            calle = p_calle;
            altura = p_altura;
        }
    }
}