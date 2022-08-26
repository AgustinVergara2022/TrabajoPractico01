using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    internal class Class08
    {
        static void Main(string[] args)
        {   
            int cantNiveles = int.Parse(args[0]);
            int[,] trianguloDePascal = CrearTrianguloDePascal(cantNiveles);
            MostrarTrianguloDePascal(trianguloDePascal, cantNiveles);
        }

        /*
         * Creamos los niveles, implementando subvectores, de 
         */
        static int[,] CrearTrianguloDePascal(int cantNiveles)
        {
            int[,] triangulo = new int[cantNiveles, cantNiveles];

            //Creamos cada nivel individualmente
           for (int fila = 0; fila < cantNiveles; fila++)
            {
                for (int columna = 0; columna < cantNiveles; columna++)
                {
                    if (columna == 0 || columna == fila)
                    {
                        triangulo[fila, columna] = 1;

                    }
                    else if (columna > fila)
                    {
                        triangulo[fila, columna] = 0;
                    }
                    else
                    {
                        triangulo[fila, columna] = triangulo[fila - 1, columna] + triangulo[fila - 1, columna - 1];
                    }
                }
            }

            return triangulo;
        }

        static void MostrarTrianguloDePascal(int[,] triangulo, int cantNiveles)
        {
            /*
            * Función para mostrar el triangulo de Pascal por pantalla
            */
            for (int fila = 0; fila < cantNiveles; fila++)
            {
                string nivelTriangulo = "";

                for (int columna = 0; columna < cantNiveles; columna++)
                {
                    //La matriz contiene 0s que no queremos mostrar
                    if (triangulo[fila, columna] != 0)
                    {
                        nivelTriangulo += triangulo[fila, columna].ToString() + ' ';
                    }
                }

                Console.WriteLine(nivelTriangulo);
            }
        }
    }
}
