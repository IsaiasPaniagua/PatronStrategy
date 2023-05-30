using System;
using System.Collections.Generic;
using System.Text;

namespace PatosMexico
{
    abstract class Pato
    {
        int op, op1;
        public IVuelo vp { get; set; }
        public ISonido sp { get; set; }
        public abstract void Display();
        public abstract void Default();

        public  void Flotar()
        {
            Console.WriteLine("Estoy flotando!!");
        }

        public void obtenerVuelo()
        {
            vp.Vuelo();
        }
        public void obtenerSonido()
        {
            sp.Soinido();
        }


        public IVuelo CambiarVuelo()
        {
            Console.WriteLine("Tipos de Vuelo:\n1. Vuelo con alas\n2. No puedo Volar\nElige una opcion:");
            op = int.Parse(Console.ReadLine());
            if (op == 1)
            {
                vp = new VueloConAlas();
            }
            else if (op == 2)
            {
                vp = new NoVuelo();
            }
            Console.Clear();
            return vp;
        }

        public ISonido CambiarSonido()
        {
            Console.WriteLine("Tipos de Sonido:\n1. Quack Quack\n2. Squeak Squeak\n3. Mute\nElige una opcion:");
            op1 = int.Parse(Console.ReadLine());
            if (op1 == 1)
            {
                sp = new Quack();
            }
            else if(op1 == 2)
            {
                sp = new Squeak();
            }
            else if(op1 == 3)
            {
                sp = new SinSonido();
            }
            Console.Clear();
            return sp;

        }
    }
}
