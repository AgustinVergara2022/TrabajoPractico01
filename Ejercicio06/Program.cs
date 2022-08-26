namespace Ejericio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            double num = Convert.ToDouble(Console.ReadLine());
            double A = Math.PI * (num * num);
            double P = 2 * Math.PI * num;
            Console.WriteLine("El area del circulo es: " + A);
            Console.WriteLine("El perimetro del circulo es: " + P);
        }
    }
}