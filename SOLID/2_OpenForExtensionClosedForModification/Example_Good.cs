/// <summary>
/// In the code below, we see classes that can compute different types of prices.
/// If we were to need another type of price, we could create a new class that extends the interface,
/// rather than modifying existing code.
/// </summary>
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
        public double ComputePrice(double standardPrice)
        {
            return standardPrice * 0.8;
        }
    }
}