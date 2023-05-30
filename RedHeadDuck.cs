using System;
using System.Collections.Generic;
using System.Text;

namespace PatosMexico
{
    class RedHeadDuck: Pato
    {
        public override void Default()
        {
            vp = new VueloConAlas();
            sp = new SinSonido();
        }

        public override void Display()
        {
            Console.WriteLine("Soy un pato de cabeza roja");
        }
        public void ObtenerNuevoSonido()
        {
            CambiarSonido();
        }
        public void ObtenerNuevoVuelo()
        {
            CambiarVuelo();
        }
    }
}
