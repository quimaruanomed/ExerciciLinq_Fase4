using System;
using System.Linq;
using System.Collections.Generic;


namespace ExerciciLinq_FaseIV
{
    class Program
    {
        static void Main(string[] args)
        {

            string [] names = {"David", "Sergio", "Maria", "Laura", "Oscar", "Julia", "Oriol"};
           
            List<string> sortedNames = names.OrderByDescending(n => n).ToList(); //Ordenamos el string en orden descendente 
            Console.WriteLine("Array en orden descendente: ");
            Console.WriteLine();

            foreach (string nam in sortedNames) //Mostramos por pantalla el array en orden descendente 
            {
                Console.WriteLine(nam);
            }

            string nSort = "O";
            var findNamesO = (from n in names where n.StartsWith(nSort) select n).ToList(); //Consulta para seleccionar los nombres que empiezan por O
            Console.WriteLine();
            Console.WriteLine("Listado de nombres que empiezan por O: \n");
            for (int i = 0; i < findNamesO.Count; i++) //bucle para listar los nombres que empiezan por O
            {
                Console.WriteLine(findNamesO[i]);
            }

            Console.WriteLine();

            /*Recorremos el array para encontrar las posiciones de los nombres que tienen más de 6 letras e imprimimos 
             * la posición donde se encuentra y el nombre 
            */

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length > 6)
                {
                    Console.WriteLine("Nombre en la posición {0} tiene {1} caracteres", i, names[i].Length);
                    var query = from p in names
                                select names[i];
                    var qList = query.ToArray();
                    Console.WriteLine("Nombre con mas de seis letras : " + qList[0]);

                }

            }
           

        }
    }
}

