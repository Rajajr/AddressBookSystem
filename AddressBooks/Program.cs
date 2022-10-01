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
            Console.WriteLine("Enter the Person details");
            AddressBook.AddPerson();
            AddressBook Person = new AddressBook();
          
        }
        
    }
}
