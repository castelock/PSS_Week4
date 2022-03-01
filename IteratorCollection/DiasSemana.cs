using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorCollection
{
    public class DiasSemana : IEnumerable
    {
        private static string[] dias = { "lunes", "martes", "miércoles",
                              "jueves", "viernes", "sábado", "domingo" };

        public IEnumerator GetEnumerator()
        {
            for (int indice = 0; indice < dias.Length; indice++)
            {
                yield return dias[indice];
            }

        }
    }
}
