using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorCollection
{
    public class IteradorDiasInverso : IEnumerator
    {
        readonly ArrayList _coleccion;
        int _posicion;

        public IteradorDiasInverso(ArrayList coleccion)
        {
            _coleccion = coleccion;
            _posicion = _coleccion.Count;
        }

        public object Current { get { return _coleccion[_posicion]; } }

        public bool MoveNext()
        {
            _posicion--;
            return (_posicion >= 0);
        }

        public void Reset() { _posicion = _coleccion.Count; }
    }

}
