using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBooks
{
    public class AddressBook
    {
        public static void AddPerson()
        {
            Console.WriteLine("1:Enter the First Name : ");
            string FirstName=Console.ReadLine();
            Console.WriteLine("2:Enter the Last Name : ");
            string LastName = Console.ReadLine();
            Console.WriteLine("3:Enter the State : ");
            string State = Console.ReadLine();
            Console.WriteLine("4:Enter the City : ");
            string City = Console.ReadLine();
            Console.WriteLine("5:Enter the Address : ");
            string Address = Console.ReadLine();
            Console.WriteLine("6:Enter the Zip Code : ");
            string ZipCode = Console.ReadLine();
            Console.WriteLine("7:Enter the PhoneNo : ");
            string PhoneNumber = Console.ReadLine();
            Console.WriteLine("8:Enter the Email-id : ");
            string Email_id = Console.ReadLine();


        }
    }
}
