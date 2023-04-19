namespace GeneGenie.Gedcom.Tester
{
    using GeneGenie.Gedcom.Parser;
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter gedcom file:");
            string gedcomFile = Console.ReadLine();

            GedcomRecordReader gedcomReader = GedcomRecordReader.CreateReader(gedcomFile);
            bool readResult = gedcomReader.ReadGedcom();

            Console.WriteLine(gedcomReader.Database.Individuals[0].Names[0].Name);
            Console.ReadLine();
        }
    }
}
