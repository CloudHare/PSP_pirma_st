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

        public PackageDelivery(DestinationStrategy destSt)
        {
            this.destSt = destSt;
        }

        public double calculatePrice(int weight)
        {
            double price;

            price = destSt.calculatePrice();
            price = price * weight * 0.02;
            price = Math.Round(price, 2);

            return price;
        }

        public string getDestination()
        {
            return destSt.getDestination();
        }
    }
}
