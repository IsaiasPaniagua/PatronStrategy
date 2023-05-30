using System;
using System.Collections.Generic;
using System.Text;

namespace PatosMexico
{
    public class Principal
    {
        int op, op1, pm = 1, pr = 1, prh = 1, pato;
        MallarDuck md = new MallarDuck();
        RubberDuck rd = new RubberDuck();
        RedHeadDuck rhd = new RedHeadDuck();
        public void CrearPato()
        {
            Console.Clear();
            Console.WriteLine("Crea un pato\n====================\n1. Pato mallar\n2. Pato de goma\n3. Pato de cabeza roja");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.Clear();
                    MallarP();
                    CambiarCaracteristica();
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    RubberP();
                    CambiarCaracteristica();
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    RedHP();
                    CambiarCaracteristica();
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Clear();
                    MallarP();
                    RubberP();
                    RedHP();
                    Console.WriteLine("Presiona cualquier tecla para regresar al menu");
                    Console.ReadKey();
                    CrearPato();
                    break;
                default:
                    Console.WriteLine("Esta opcion no existe");
                    Console.ReadKey();
                    CrearPato();
                    break;
            }
        }
        private void MallarP()
        {
            pato = 1;
            if (pm == 1)
            {
                md.Default();
                pm++;
            }
            else if(op1 == 1)
            {
                md.ObtenerNuevoVuelo();
            }
            else if(op1 == 2)
            {
                md.ObtenerNuevoSonido();
            }
            md.Display();
            md.obtenerSonido();
            md.obtenerVuelo();
            md.Flotar();
        }
        private void RubberP()
        {
            pato = 2;
            if (pr == 1)
            {
                rd.Default();
                pr++;
            }
            else if (op1 == 1)
            {
                rd.ObtenerNuevoVuelo();
            }
            else if (op1 == 2)
            {
                rd.ObtenerNuevoSonido();
            }
            rd.Display();
            rd.obtenerSonido();
            rd.obtenerVuelo();
            rd.Flotar();
        }
        private void RedHP()
        {
            pato = 3;
            if (prh == 1)
            {
                rhd.Default();
                prh++;
            }
            else if (op1 == 1)
            {
                rhd.ObtenerNuevoVuelo();
            }
            else if (op1 == 2)
            {
                rhd.ObtenerNuevoSonido();
            }
            rhd.Display();
            rhd.obtenerSonido();
            rhd.obtenerVuelo();
            rhd.Flotar();
        }
        private void CambiarCaracteristica()
        {
            Console.WriteLine("-====================-");
            Console.WriteLine("Desea cambiar algo del pato, elige:\n1. Vuelo\n2. Sonido\n3. Menu");
            op1 = int.Parse(Console.ReadLine());
            if (op1 == 3)
            {
                CrearPato();
            }
            else if (pato == 1)
            {
                MallarP();
            }
            else if (pato == 2)
            {
                RubberP();
            }
            else if (pato == 3)
            {
                RedHP();
            }
            Console.Clear();
        }
        
    }
}
