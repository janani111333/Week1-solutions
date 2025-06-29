namespace ConverterLib
{
    public interface IDollarToEuroExchangeRateFeed
    {
        double GetExchangeRate();  // e.g., 1 USD = 0.85 Euro
    }
}
