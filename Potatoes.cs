using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    //This is the concrete subject participant.
    class Potatoes : Vegetable
    {
        public Potatoes(double currentPrice) : base(currentPrice) { }
    }
}
