namespace Ejercicio02_Solucion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0;
            int suma = 0;
            int maximo = 0;
            int minimo = 0;
            Console.WriteLine("Ingrese un numero: , 0 para salir");
            int num = Convert.ToInt32(Console.ReadLine());
            maximo = num;
            minimo = num;

            while (num != 0)
            {
                cantidad++;
                suma += num;
                if (num > maximo) maximo = num;
                if (num < minimo) minimo = num;

                Console.WriteLine("Ingrese otro numero: , 0 para salir");
                num = Convert.ToInt32(Console.ReadLine());
            }

            if (cantidad != 0)
            {
                double media = (double)suma / (double)cantidad;
            }
            else
            {
                Console.WriteLine("No puedo calcular el promedio");
            }
            Console.WriteLine("La suma es: " + suma);
            Console.WriteLine("El maximo es: "+maximo);
            Console.WriteLine("El minimo es: " + minimo);
        }
    }
}