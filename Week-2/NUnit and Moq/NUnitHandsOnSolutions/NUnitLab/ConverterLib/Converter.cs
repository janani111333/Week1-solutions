namespace ConverterLib
{
    public class Converter
    {
        private readonly IDollarToEuroExchangeRateFeed _feed;

        public Converter(IDollarToEuroExchangeRateFeed feed)
        {
            _feed = feed;
        }

        public double USDToEuro(double usd)
        {
            double rate = _feed.GetExchangeRate();
            return usd * rate;
        }
    }
}
