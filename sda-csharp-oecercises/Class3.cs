using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_oecercises
{
    class Dog : Animal
    {
        private static readonly string SOUND = "Hau";
        public Dog(string name) : base(name, SOUND)
        {
           
        }

    }
}
