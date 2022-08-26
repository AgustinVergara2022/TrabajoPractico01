namespace Borrador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un valor: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            while (valor != 0)
            {
                Console.WriteLine("Ingrese valor: ");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
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
                if (num >= 11)
                    Console.WriteLine("OTROS");
            }
        }
    }

}