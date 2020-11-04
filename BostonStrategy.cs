using PSP_pirma_st.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_pirma_st
{
    class BostonStrategy : DestinationStrategy
    {
        public double calculatePrice()
        {
            return 230.12;
        }

        public bool goodDocument(Document doc)
        {
            switch (doc)
            {
                case Document.IDCard:
                    return false;

                case Document.Passport:
                    return true;

                default:
                    throw new NotImplementedException("Unknown document");
            }
        }
    }
}
