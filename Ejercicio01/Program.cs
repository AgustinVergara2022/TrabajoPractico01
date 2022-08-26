namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese valor: ");
                int valor = Convert.ToInt32(Console.ReadLine());
                switch (valor)
                {
                    case 1:
                        Console.WriteLine("UNO");
                        break;
                    case 2:
                        Console.WriteLine("DOS");
                        break;
                    case 3:
                        Console.WriteLine("TRES");
                        break;
                    case 4:
                        Console.WriteLine("CUATRO");
                        break;
                    case 5:
                        Console.WriteLine("CINCO");
                        break;
                    case 6:
                        Console.WriteLine("SEIS");
                        break;
                    case 7:
                        Console.WriteLine("SIETE");
                        break;
                    case 8:
                        Console.WriteLine("OCHO");
                        break;
                    case 9:
                        Console.WriteLine("NUEVE");
                        break;
                    case 10:
                        Console.WriteLine("OTROS");
                        break;

                }
                if (valor >= 11)
                    Console.WriteLine("OTROS");

            }
        }
    }
}
