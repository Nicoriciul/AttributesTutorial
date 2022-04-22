using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
   
namespace Contact
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact sarah = new Contact
            {
                FirstName = "Sarah",
                AgeInYears = 42
            };
            var sarahWriter = new ContactConsoleWriter(sarah);
            sarahWriter.Write();
            Read();  
        }
    } 
}
