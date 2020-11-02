using PSP_pirma_st.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_pirma_st
{
    class RomePriceStrategy : DestinationStrategy
    {
        public double calculatePrice(Destination dest)
        {
            return 40.44;
        }
    }
}
