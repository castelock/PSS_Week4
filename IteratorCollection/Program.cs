
using System;
using System.Collections;

namespace IteratorCollection
{


    class Program
    {
        static void Main(string[] args)
        {
            
            ArrayList coleccion = new ArrayList { "lunes", "martes", "miércoles", "jueves",
                                       "viernes", "sábado", "domingo" };
            Console.WriteLine("\nIterador estándar\n=================");
            foreach (string dia in coleccion)
                Console.WriteLine(dia);

            Console.WriteLine("\nIteradores a petición\nInverso   Directo");
            Console.WriteLine("=====================");

            IEnumerator ed = coleccion.GetEnumerator();
            IteradorDiasInverso ei = new(coleccion);

            for (int i = 0; i < 3; i++)
                if (ei.MoveNext())
                    Console.WriteLine(ei.Current);

            Console.WriteLine("Fin del iterador inverso");    

            while (ed.MoveNext() && ei.MoveNext())
            {
                Console.WriteLine("{0,-9} {1}", ei.Current, ed.Current);
            }

        }


    }
}

