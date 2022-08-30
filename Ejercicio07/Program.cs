namespace Ejercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Separamos los parámetros
            string firstWord = args[0];
            string secondWord = args[1];

            //Comprobamos si la secondword es un anagrama de firstword
            Boolean anagrama = Anagrama(firstWord, secondWord);

            //Devolvemos el resultado
            if (anagrama)
            {
                Console.WriteLine($"{secondWord} es un anagrama de {firstWord}.");
            }
            else
            {
                Console.WriteLine($"{secondWord} NO es un anagrama de {firstWord}.");
            }


        }

        static Boolean Anagrama(string firstWord, string secondWord)
        {
            if (firstWord.Length == secondWord.Length) //si tienen la misma cantidad de letras, puede ser anagrama
            {
                string auxStr = secondWord;

                //De la primer palabra, tomamos las letras y las eliminamos de la segunda
                for (int i = 0; i < firstWord.Length; i++)
                {
                    for (int j = 0; j < auxStr.Length; j++)
                    {
                        if (auxStr[j] == firstWord[i])
                        {
                            auxStr = auxStr.Remove(j, 1);
                            break;
                        }
                    }

                }

                //Comprobamos si todas las letras de la primera fueron encontradas en la segunda
                if (auxStr.Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else //Sino tiene la misma cantidad de letras, no puede ser anagrama
            {
                return false;
            }

        }
    }
}