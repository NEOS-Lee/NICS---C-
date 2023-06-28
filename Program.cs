using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Transactions;

namespace NonImageClientSetup
{

    public class Program
    {

        static void Main(string[] args) 
        {
            string mainOption;
            
            Console.WriteLine("Hello! Welcome To The NEOS NICS Program");
            Console.WriteLine("Please Choose The Desired Action Below");
            Console.WriteLine();

            //Setup Options Here!
            Console.WriteLine("Option 1: Remove HP Software");
            Console.WriteLine("Option 2: Setup Local Administrator Account");
            Console.WriteLine("Option 3: Install Applications");
            Console.WriteLine("Option 4: Enable Bitlocker");
            Console.WriteLine("Option 5: Begin Windows Update");
            Console.WriteLine("Option 6: Unused");
            Console.WriteLine();
            Console.Write("Enter Desired Option: ");
            mainOption = Console.ReadLine();

            Console.WriteLine("You have Selected Option: " + mainOption);

            //Pauses Program
            Console.ReadLine();

        
        }


    }







}