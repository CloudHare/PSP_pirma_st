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
            // Change this for other variations
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

        // For the sake of a nicer interface, has nothing to do with logic
        // Should I delete this and not display Destination in the interface?
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
