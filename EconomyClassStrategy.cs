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
        public double calculatePrice()
        {
            return 1.22;
        }
        public int calculateIncludedLuggage()
        {
            return 15;
        }

        public string getFlightClass()
        {
            return "Economy";
        }
    }
}
