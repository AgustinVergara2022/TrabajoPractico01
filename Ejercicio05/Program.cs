namespace Ejercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, siguiente;
            Console.WriteLine("Ingrese un valor n");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                if (i <= 1)
                {
                    siguiente = i;
                }
                else 
                {
                    siguiente = a + b;
                    a = b;
                    b = siguiente;
                }
                Console.Write(" - "+siguiente);
            }
            
        }
    }
}