namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maximo = 0;
            int minimo = 0;
            Console.WriteLine("Ingresa limite superior: ");
            int limSuperior = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa limite inferior: ");
            int limInferior = Convert.ToInt32(Console.ReadLine());
            int suma = 0;
            int cantidad = 0;
            minimo = limInferior;
            maximo = limSuperior;
            for (int i = limInferior; i <= limSuperior; i++)
            {
                
                suma += i;
                cantidad++;
            }
            double promedio = (double)suma / (double)cantidad;
            Console.WriteLine("La suma es " + suma);
            Console.WriteLine("El promedio es " + promedio);
            Console.WriteLine("El maximo es " + maximo);
            Console.WriteLine("El minimo es " + minimo);
        }
    }
}