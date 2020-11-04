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
        DestinationStrategy destSt;
        FlightClassStrategy classSt;

        public FlightTicket()
        {
            // Change these for other variations
            destSt = new BostonStrategy();
            classSt = new EconomyClassStrategy();
        }
        
        public double calculatePrice()
        {
            double destPrice;
            double classPrice;
            double fullPrice;

            destPrice = destSt.calculatePrice();
            classPrice = classSt.calculatePrice();
            fullPrice = destPrice * classPrice;
            fullPrice = Math.Round(fullPrice, 2);

            return fullPrice;
        }
    
        public int calculateLuggage()
        {
            int luggage;

            luggage = classSt.calculateIncludedLuggage();

            return luggage;
        }

        public bool goodDocument(Document doc)
        {
            bool goodDoc;

            goodDoc = destSt.goodDocument(doc);

            return goodDoc;
        }

        // For the sake of a nicer interface, has nothing to do with logic
        // Should I delete this and not display Destination and FlightClass in the interface?
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

        public FlightClass getFlightClass()
        {
            if (classSt.GetType() == typeof(BusinessClassStrategy))
            {
                return FlightClass.Business;
            }
            else if (classSt.GetType() == typeof(EconomyClassStrategy))
            {
                return FlightClass.Economy;
            }
            else
            {
                throw new NotImplementedException("Unknown flight class");
            }
        }
    }
}
