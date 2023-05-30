using System;
using System.Collections.Generic;
using System.Text;

namespace PatosMexico
{
    class RubberDuck: Pato
    {
        public override void Default()
        {
            vp = new NoVuelo();
            sp = new Squeak();
        }

        public override void Display()
        {
            Console.WriteLine("Soy un pato de goma");
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
