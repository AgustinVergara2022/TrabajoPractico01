namespace Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0;
            for (int i = 1852; i <= 2023; i++)
            {
                int ano = Convert.ToInt32(i);
                if (((ano % 4 == 0) && (ano % 100 != 0)) || (ano % 400 == 0))
                {
                    cantidad++;
                    Console.WriteLine(ano + " es bisiesto");      
                }
            }
            Console.WriteLine("Cantidad de años bisiestos entre 1852 y 2023: " + cantidad);
        }
    }
}