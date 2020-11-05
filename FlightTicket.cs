using PSP_pirma_st.Enums;
using PSP_pirma_st.Structs;
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

        public FlightTicket(DestinationStrategy destSt, FlightClassStrategy classSt)
        {
            this.destSt = destSt;
            this.classSt = classSt;
        }

        public FlightTicketData getTicket(Document doc)
        {
            FlightTicketData ftd = new FlightTicketData();
            ftd.Price = calculatePrice();
            ftd.Luggage = calculateLuggage();
            ftd.GoodDoc = goodDocument(doc);

            return ftd;
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

        public Destination getDestination()
        {
            return destSt.getDestination();
        }

        public FlightClass getFlightClass()
        {
            return classSt.getFlightClass();
        }
    }
}
