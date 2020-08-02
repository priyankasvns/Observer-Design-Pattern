using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    //This is the observer participant 
    interface IStore
    {
        void Update(Vegetable vegetable);
    }
}
