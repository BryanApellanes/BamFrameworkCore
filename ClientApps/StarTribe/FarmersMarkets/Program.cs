using System;
using Bam.Net;

namespace FarmersMarkets
{
    class Program : CommandLineTool
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scrape all states: https://nfmd.org/wa");
            ExecuteMainOrInteractive(args);
        }
    }
}