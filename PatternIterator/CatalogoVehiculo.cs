using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternIterator
{
    public class CatalogoVehiculo : Catalogo<Vehiculo, IteradorVehiculo>
    {
        public CatalogoVehiculo()
        {
            contenido.Add(new Vehiculo("vehículo económico"));
            contenido.Add(new Vehiculo("pequeño vehículo económico"));
            contenido.Add(new Vehiculo("vehículo de gran calidad"));

        }
    }
}
