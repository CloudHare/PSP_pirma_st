using PSP_pirma_st.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_pirma_st
{
    class BusinessClassStrategy : FlightClassStrategy
    {
        public int calculateIncludedLuggage(FlightClass flightClass)
        {
            return 25;
        }

        public double calculatePrice(FlightClass flightClass)
        {
            return 2.11;
        }

        public bool isCoffeeIncluded(FlightClass flightClass)
        {
            return true;
        }
    }
}
