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
        DestinationStrategy destStrategy;
        int weight;

        public double calculateDeliveryPrice(Destination dest, int weight)
        {
            double price;

            setDestination(dest);

            price = destStrategy.calculatePrice(dest);
            price = price * 0.02 * weight;

            return price;
        }

        private void setDestination(Destination dest)
        {
            switch (dest)
            {
                case Destination.Boston:
                    destStrategy = new BostonPriceStrategy();
                    break;

                case Destination.Rome:
                    destStrategy = new RomePriceStrategy();
                    break;

                default:
                    throw new NotImplementedException("Unknown destination");
            }
        }
    }
}
