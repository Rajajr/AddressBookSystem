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
            //UC-3 Ability to Edit Existing Contact Person Using Their Name
            Console.WriteLine("Address Book");

            int option = 0;
            while(option !=2)
            {
                Console.WriteLine("1:To get Futher Choice");
                Console.WriteLine("2:Exit From Address Book");
                option=Convert.ToInt32(Console.ReadLine());
                if(option!=2)
                    AddressBook.AddPerson1deatils();
                    AddressBook.Numberofpeople();
            }
            
            Console.WriteLine("You Are Out Of the AddressBook");
            
            Console.ReadLine();
            
          
        }
        
    }
}
