using AddressBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace AddressBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book");
            

            AddressBook.AddPerson1deatils();

            AddressBook.Numberofpeople();
            

            Console.ReadLine();
            
          
        }
        
    }
}
