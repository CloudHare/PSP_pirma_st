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
        public double calculatePrice()
        {
            return 2.11;
        }
        public int calculateIncludedLuggage()
        {
            return 25;
        }

        public string getFlightClass()
        {
            return "Business";
        }
    }
}
