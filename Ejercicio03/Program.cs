namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, d;
            double suma, termino, pi;

            Console.WriteLine("Ingrese numero para calcular pi: ");
            n = Convert.ToInt32(Console.ReadLine());

            suma = 1;
            d = 3;      //inicializamos la variable en 3 porque el primer termino queda 1/1 = 1

            for (int i = 2; i <= n; i++)
            {
                termino = 1.0 / d;
                if (i % 2 != 0)   //analiza si se debe sumar o restar el termino que le sigue
                {
                    suma += termino;
                    d = d + 2;
                }
                else
                {
                    suma -= termino;
                    d = d + 2; //aumenta en 2 por la fórmula de Leibniz
                }
            }
            pi = suma * 4;  //una vez realizado la fórmula, multiplicamos por 4
            Console.WriteLine("El resultado de pi con el numero ingresado es: " + pi);
            Console.WriteLine("El valor de Pi es: " + System.Math.PI);
            Console.ReadKey();

        }
    }
}

   