using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    //Concrete observers
    class Store : IStore
    {
        private string storeName;
        private Vegetable vegetable;
        private double purchasePrice;

        public string StoreName
        {
            get => this.storeName;
            set => this.storeName = value;
        }

        public double PurchasePrice
        {
            get => this.purchasePrice;
            set => this.purchasePrice = value;
        }
        public Store(string storeName, double purchasePrice)
        {
            this.StoreName = storeName;
            this.PurchasePrice = purchasePrice;
        }

        public void Update(Vegetable vegetable)
        {
            Console.WriteLine("Notified {0} about the price change of {1} and the current price is {2}.",this.StoreName,vegetable.GetType().Name,vegetable.CurrentPrice);
            if(vegetable.CurrentPrice < this.PurchasePrice)
            {
                Console.WriteLine("{0} wants to buy {1}!!!!!!",this.storeName,vegetable.GetType().Name);
            }
        }

    }
}
