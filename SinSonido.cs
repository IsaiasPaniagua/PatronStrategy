using System;
using System.Collections.Generic;
using System.Text;

namespace PatosMexico
{
    class SinSonido : ISonido
    {
        public void Soinido()
        {
            Console.WriteLine("Mute");
        }
    }
}
