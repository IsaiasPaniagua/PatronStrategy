using System;
using System.Collections.Generic;
using System.Text;

namespace PatosMexico
{
    class NoVuelo : IVuelo
    {
        public void Vuelo()
        {
            Console.WriteLine("No puedo Volar");
        }
    }
}
