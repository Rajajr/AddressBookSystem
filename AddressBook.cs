using AddressBook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AddressBooks
{
    public class AddressBook
    {
        public static List<Person> details = new List<Person>();
        
         public static void AddPerson1deatils()
         {
            Person person = new Person();

            Console.WriteLine("Enter the Person1 Details");

            Console.WriteLine("1:Enter the First Name : ");
            string FirstName = Console.ReadLine();
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

            Console.WriteLine("Thankyou for Adding Person1 Details");
            Console.WriteLine("-----------------------------------------------");

            details.Add(person);

         }

        public static void AddPersons2Dteails(Person details)
        {
            Console.WriteLine("Enter the Person2 details");

            Console.WriteLine("1:Enter the First Name: "); 
            details.FirstName= Console.ReadLine();
            Console.WriteLine("2:Enter the Last Name: ");
            details.FirstName = Console.ReadLine();
            Console.WriteLine("3:Enter the state: ");
            details.FirstName = Console.ReadLine();
            Console.WriteLine("4:Enter the city: ");
            details.FirstName = Console.ReadLine();
            Console.WriteLine("5:Enter the Address: ");
            details.FirstName = Console.ReadLine();
            Console.WriteLine("6:Enter the Zip code: ");
            details.FirstName = Console.ReadLine();
            Console.WriteLine("7:Enter the Phone Number: ");
            details.FirstName = Console.ReadLine();
            Console.WriteLine("8:Enter the Email-id: ");
            details.FirstName = Console.ReadLine();

            Console.WriteLine("Thankyou for Adding Person2 Details");
            Console.WriteLine("--------------------------------------------------");

            
        } 

        public static void Numberofpeople()
        {
            foreach (var person in details)
            {
                
                AddPersons2Dteails(person);
            }
        }
    
     
    }
}
