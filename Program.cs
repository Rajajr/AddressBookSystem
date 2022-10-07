using AddressBooks;
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
            //UC-4 Ability To Delete a Person Using Person's Name
            Console.WriteLine("Address Book");

            int option = 0;
            while(option !=2)
            {
                Console.WriteLine("1:To get Futher Choice");
                Console.WriteLine("2:Exit From Address Book");
                option=Convert.ToInt32(Console.ReadLine());
                if(option!=2)
                    AddressBooks.AddPerson1deatils();
                    AddressBooks.Numberofpeople();
            }
            
            Console.WriteLine("You Are Out Of the AddressBook");
            
            Console.ReadLine();
            
          
        }
        
    }
}
