using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternIterator
{
    public abstract class Elemento
    {
        protected string descripcion;
        public Elemento(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public bool palabraClaveValida(string palabraClave)
        {
            return descripcion.IndexOf(palabraClave) != -1;
        }
    }
}
