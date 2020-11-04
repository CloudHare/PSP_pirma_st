using PSP_pirma_st.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_pirma_st
{
    class PackageDelivery
    {
        DestinationStrategy destSt;
        int weight;

        public PackageDelivery()
        {
            // Change this for other variations
            destSt = new BostonStrategy();
        }

        public double calculatePrice()
        {
            double price;

            price = destSt.calculatePrice();
            price = price * this.weight * 0.02;
            price = Math.Round(price, 2);

            return price;
        }

        public void setWeight(int weight)
        {
            this.weight = weight;
        }

        public Destination getDestination()
        {
            if (destSt.GetType() == typeof(RomeStrategy))
            {
                return Destination.Rome;
            }
            else if (destSt.GetType() == typeof(BostonStrategy))
            {
                return Destination.Boston;
            }
            else
            {
                throw new NotImplementedException("Unknown destination");
            }
        }
    }
}
