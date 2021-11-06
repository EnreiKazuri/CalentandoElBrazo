using System;

//24. Find the largest and smallest number in an unsorted integer array
//34. Given two arrays, a domain and a range, determine if they represent a Relation or a Function

namespace CalentandoElBrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("//////Menu//////");
            Console.WriteLine("(1) Mayor o menor en un array");
            Console.WriteLine("(2) Relation es Funcion");
            int desicion = int.Parse(Console.ReadLine());
            switch (desicion)
            {
                case 1:
                    MayorMenorMenu();
                    break;
                case 2:
                    RelacionFuncionMenu();
                    break;
                default:
                    break;
            }
        }
        static void MayorMenorMenu()
        {
            Console.WriteLine("Decida el tamaño del array: ");
            int desicion = int.Parse(Console.ReadLine());

            int[] arrayMayorMenor = new int[desicion];
            for (int i = 0; i < desicion; i++)
            {
                Console.WriteLine("Escriba el numero {0} del arreglo: ", i);
                arrayMayorMenor[i] = int.Parse(Console.ReadLine());
            }
            MayorMenor(arrayMayorMenor);
        }
        static void MayorMenor(int[] array)
        {
            int largest = array[0];
            int smallest = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > largest)
                {
                    largest = array[i];
                }
                if (array[i] < smallest)
                {
                    smallest = array[i];
                }
            }
            Console.WriteLine("Dentro del array de {0} numeros, el menor numero es {1}, mientras que el mayor es {2}", array.Length ,smallest, largest);
        }
        static void RelacionFuncionMenu()
        {
            Console.WriteLine("Decida el tamaño del dominio: ");
            int desicion = int.Parse(Console.ReadLine());

            int[] arrayDominio = new int[desicion];
            for (int i = 0; i < desicion; i++)
            {
                Console.WriteLine("Escriba el numero {0} del dominio: ", i);
                arrayDominio[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("///////////////////////////////////////////////////////////////");
            Console.WriteLine("Decida el tamaño del rango: ");
            desicion = int.Parse(Console.ReadLine());

            int[] arrayRango = new int[desicion];
            for (int i = 0; i < desicion; i++)
            {
                Console.WriteLine("Escriba el numero {0} del rango: ", i);
                arrayRango[i] = int.Parse(Console.ReadLine());
            }
            RelacionFuncion(arrayDominio, arrayRango);
        }
        static void RelacionFuncion(int[] dominio, int[] rango)
        {
            bool igual = dominio.Length == rango.Length;
            if (igual == false)
            {
                Console.WriteLine("Los arrays dados no son una relacion puesto a que son de tamanno diferente");
            }
            else
            {
                bool repetido = false;
                for (int i = 0; i < dominio.Length; i++)
                {
                    for (int j = 0; j < dominio.Length; j++)
                    {
                        if (dominio[i] == dominio[j] && i != j)
                        {
                            repetido = true;
                        }
                    }
                }
                if (repetido)
                {
                    Console.WriteLine("La relacion no es una funcion puesto a que un numero en el dominio se repite");
                }
                else
                {
                    Console.WriteLine("La relacion es una funcion");
                }
            }
        }
    }
}
