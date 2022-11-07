using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab5
{
    class Printer
    {
        public void Print(string value)
        {
            Console.WriteLine(value);
        }
    }

    class PrinterRed : Printer
    {
        public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            base.Print(value);
        }
    }

    class PrinterGreen : Printer
    {
        public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            base.Print(value);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Print("Приклад 1");

            PrinterRed printerRed = new PrinterRed();
            printerRed.Print("Приклад 2");

            PrinterGreen printerGreen = new PrinterGreen();
            printerGreen.Print("Приклад 3");
        }
    }
}
