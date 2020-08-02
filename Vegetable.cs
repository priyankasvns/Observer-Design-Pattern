using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    //This is the subject participant 
    class Vegetable
    {
        private double currentPrice;

        List<IStore> stores = new List<IStore>();

        public double CurrentPrice
        {
            get => this.currentPrice;
            set
            {
                if (currentPrice != value)
                {
                    this.currentPrice = value;
                    Notify();
                }
            }
        }

        public Vegetable(double vegetablePrice)
        {
            this.currentPrice = vegetablePrice;
        }

        public void Attach(IStore store)
        {
            stores.Add(store);
        }

        public void Detach(IStore store)
        {
            stores.Remove(store);
        }

        public void Notify()
        {
            foreach (IStore s in stores)
            {
                s.Update(this);
            }
        }



    }
}
