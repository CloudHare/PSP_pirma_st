using PSP_pirma_st.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_pirma_st
{
    interface FlightClassStrategy
    {
        double calculatePrice();

        int calculateIncludedLuggage();

        string getFlightClass();
    }
}
