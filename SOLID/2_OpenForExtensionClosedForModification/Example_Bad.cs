namespace SOLID._2_OpenForExtensionClosedForModification
{
    internal class PriceServiceBad
    {
        /// <summary>
        /// If we need to introduce a new order type, we'll need to modify this code.
        /// If we modify this code, there's a chance of introducing a regression.
        /// Since a regression could occur, we'll have to re-test this code as result of modification.
        /// </summary>        
        internal double ComputePrice(double standardPrice, OrderType type)
        {
            double actualPrice;
            if (type == OrderType.Prime)
            {
                actualPrice = standardPrice * 0.8;
                return actualPrice;
            }
            actualPrice = standardPrice;
            return actualPrice;
        }
    }
}
