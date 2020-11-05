using PSP_pirma_st.Enums;
using System;

namespace PSP_pirma_st
{
    class RygaStrategy : DestinationStrategy
    {
        public double calculatePrice()
        {
            return 20.01;
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

        public string getDestination()
        {
            return "Ryga";
        }
    }
}
