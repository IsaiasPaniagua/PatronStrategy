using System;
using System.Collections.Generic;
using System.Text;

namespace PatosMexico
{
    class MallarDuck : Pato
    {
        public override void Default()
        {
            vp = new VueloConAlas();
            sp = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("Soy un pato mallar");
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
