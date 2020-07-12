namespace SOLID._2_OpenForExtensionClosedForModification
{
    public interface IPriceServiceGood
    {
        public double ComputePrice(double standardPrice);
    }

    public class StandardPriceService: IPriceServiceGood
    {
        public double ComputePrice(double standardPrice)
        {
            return standardPrice;
        }
    }

    public class PrimePriceService : IPriceServiceGood
    {
        public double ComputePrice(double standardPrice, )
        {
            return standardPrice * 0.8;
        }
    }
}
