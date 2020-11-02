using PSP_pirma_st.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_pirma_st
{
    class FlightTicket
    {
        DestinationStrategy destStrategy;
        FlightClassStrategy classStrategy;
        
        public double calculatePrice(Destination dest, FlightClass flightClass)
        {
            double destPrice;
            double classPrice;

            setDestination(dest);

            setFlightClass(flightClass);

            destPrice = destStrategy.calculatePrice(dest);
            classPrice = classStrategy.calculatePrice(flightClass);

            return (destPrice * classPrice);
        }
    
        public int calculateLuggage(FlightClass flightClass)
        {
            int luggage;

            setFlightClass(flightClass);

            luggage = classStrategy.calculateIncludedLuggage(flightClass);

            return luggage;
        }

        public bool isCoffeeIncluded(FlightClass flightClass)
        {
            bool coffee;

            setFlightClass(flightClass);

            coffee = classStrategy.isCoffeeIncluded(flightClass);

            return coffee;
        }

        private void setFlightClass(FlightClass fc)
        {
            switch (fc)
            {
                case FlightClass.Business:
                    classStrategy = new BusinessClassStrategy();
                    break;

                case FlightClass.Economy:
                    classStrategy = new EconomyClassStrategy();
                    break;

                default:
                    throw new NotImplementedException("Unknown flight class");
            }
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
