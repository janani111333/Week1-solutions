namespace FactoryMethodPatternExample
{
    public class ExcelDocument : Document
    {
        public override void Open() => Console.WriteLine("Opening Excel Document.");
    }
}
