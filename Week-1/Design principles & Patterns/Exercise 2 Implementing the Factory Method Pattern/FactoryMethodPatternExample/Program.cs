using FactoryMethodPatternExample;

class Program
{
    static void Main(string[] args)
    {
        DocumentFactory wordFactory = new WordDocumentFactory();
        DocumentFactory pdfFactory = new PdfDocumentFactory();
        DocumentFactory excelFactory = new ExcelDocumentFactory();

        Document doc1 = wordFactory.CreateDocument();
        Document doc2 = pdfFactory.CreateDocument();
        Document doc3 = excelFactory.CreateDocument();

        doc1.Open();
        doc2.Open();
        doc3.Open();

        Console.ReadLine();
    }
}
