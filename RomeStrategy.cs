using PSP_pirma_st.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_pirma_st
{
    class RomeStrategy : DestinationStrategy
    {
        public double calculatePrice()
        {
            return 40.44;
        }

        public bool goodDocument(Document doc)
        {
            switch (doc)
            {
                case Document.IDCard:
                    return true;

                case Document.Passport:
                    return true;

                default:
                    throw new NotImplementedException("Unknown document"); 
            }
        }
    }
}
