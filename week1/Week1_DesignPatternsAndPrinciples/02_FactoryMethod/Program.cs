using System;

namespace FactoryPatternDemo
{
    // Step 1: Define a common interface for all documents
    public interface IDocument
    {
        void PrintInfo();
    }

    // Step 2: Create concrete implementations
    public class WordDocument : IDocument
    {
        public void PrintInfo()
        {
            Console.WriteLine("Word Document: .docx file opened.");
        }
    }

    public class PdfDocument : IDocument
    {
        public void PrintInfo()
        {
            Console.WriteLine("PDF Document: .pdf file opened.");
        }
    }

    public class ExcelDocument : IDocument
    {
        public void PrintInfo()
        {
            Console.WriteLine("Excel Document: .xlsx file opened.");
        }
    }

    // Step 3: Abstract Factory class
    public abstract class DocumentFactory
    {
        public abstract IDocument CreateDocument();
    }

    // Step 4: Concrete Factory classes
    public class WordFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new WordDocument();
        }
    }

    public class PdfFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new PdfDocument();
        }
    }

    public class ExcelFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new ExcelDocument();
        }
    }

    // Step 5: Client code (test class)
    class Program
    {
        static void Main(string[] args)
        {
            DocumentFactory factory;

            factory = new WordFactory();
            IDocument wordDoc = factory.CreateDocument();
            wordDoc.PrintInfo();

            factory = new PdfFactory();
            IDocument pdfDoc = factory.CreateDocument();
            pdfDoc.PrintInfo();

            factory = new ExcelFactory();
            IDocument excelDoc = factory.CreateDocument();
            excelDoc.PrintInfo();
        }
    }
}
