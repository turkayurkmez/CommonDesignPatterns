using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Report report = new Report();
            report.Format = new Pdf();
        }
    }

    public class Report
    {
        public Format Format { get; set; }
    }

    public class HRReport: Report
    {

    }
    public class SalesReport:Report
    {

    }   

    public class Format
    {

    }

    public class Pdf:Format
    {

    }

    public class Excel : Format { }
}
