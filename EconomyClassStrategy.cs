using PSP_pirma_st.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_pirma_st
{
    class EconomyClassStrategy : FlightClassStrategy

    {
        public int calculateIncludedLuggage(FlightClass flightClass)
        {
            return 15;
        }

        public double calculatePrice(FlightClass flightClass)
        {
            return 1.22;
        }

        public bool isCoffeeIncluded(FlightClass flightClass)
        {
            return false;
        }
    }
}
