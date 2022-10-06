using AddressBooks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AddressBooks
{
    public class AddressBooks
    {
        public static List<Contacts> details = new List<Contacts>();
        public static void AddPerson1deatils()
        {
            Contacts contacts = new Contacts();
            int option1 = 0;
            Console.WriteLine("Enter the Number");
            Console.WriteLine("1:Add person\n2:Edit person");
            option1 = Convert.ToInt32(Console.ReadLine());

            switch (option1)
            {
                case 1:
                    Console.WriteLine("Enter the Person1 details");

                    Console.WriteLine("1:Enter the First Name: ");
                    contacts.First_Name = Console.ReadLine();
                    Console.WriteLine("2:Enter the Last Name: ");
                    contacts.Last_Name = Console.ReadLine();
                    Console.WriteLine("3:Enter the state: ");
                    contacts.State = Console.ReadLine();
                    Console.WriteLine("4:Enter the city: ");
                    contacts.City = Console.ReadLine();
                    Console.WriteLine("5:Enter the Address: ");
                    contacts.Address = Console.ReadLine();
                    Console.WriteLine("6:Enter the Zip code: ");
                    contacts.Zip_Code = Console.ReadLine();
                    Console.WriteLine("7:Enter the Phone Number: ");
                    contacts.PhoneNumber = Console.ReadLine();
                    Console.WriteLine("8:Enter the Email-id: ");
                    contacts.Email_id = Console.ReadLine();
                    Console.WriteLine("Thankyou for Adding Person Details");
                    Console.WriteLine("--------------------------------------------------");

                    details.Add(contacts);
                    break;

                case 2:

                    string Name;
                    int option2 = 0;
                    Console.WriteLine("Enter the Name to Edit");
                    Name = Console.ReadLine();
                    for(int i=0;i<details.Count;i++)
                    {
                        Contacts contact=details[i];

                        if (contact.First_Name==Name)
                        {
                            Console.WriteLine("Select The Option to Edit");
                            Console.WriteLine("1:First Name\n2:Last Name\n3:Address\n4:State\n5:City\n6:Zip Code\n7:PhoneNumber\n8:Email-id");
                            option2=Convert.ToInt32(Console.ReadLine());

                            switch(option2)
                            {
                                case 1:
                                    Console.WriteLine("Enter the First Name: ");
                                    contact.First_Name= Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the Last Name: ");
                                    contact.Last_Name = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("Enter the Address: ");
                                    contact.Address = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.WriteLine("Enter the State: ");
                                    contact.State = Console.ReadLine();
                                    break;
                                case 5:
                                    Console.WriteLine("Enter the City: ");
                                    contact.City = Console.ReadLine();
                                    break;
                                case 6:
                                    Console.WriteLine("Enter the Address: ");
                                    contact.Address = Console.ReadLine();
                                    break;
                                case 7:
                                    Console.WriteLine("Enter the Zip Code: ");
                                    contact.Zip_Code = Console.ReadLine();
                                    break;
                                case 8:
                                    Console.WriteLine("Enter the Email-id: ");
                                    contact.Email_id = Console.ReadLine();
                                    break;
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Nothing to Edit");
                        }
                    }
                    break;           
            }
     
        }

        public static void PersonsDteails(Contacts details)
        {
            Console.WriteLine("Person details");

            Console.WriteLine("First_Name:"+details.First_Name);
            Console.WriteLine("Last Name:"+ details.Last_Name);
            Console.WriteLine("State:" + details.State);
            Console.WriteLine("City:" + details.City);
            Console.WriteLine("Address:" + details.Address);
            Console.WriteLine("Zip Code:" + details.Zip_Code);
            Console.WriteLine("PhoneNumber:" + details.PhoneNumber);
            Console.WriteLine("Email-id:" + details.Email_id);
            Console.WriteLine("Thankyou for Adding Person Details");
            Console.WriteLine("--------------------------------------------------");

        } 
        public static void Numberofpeople()
        {
            foreach (var contacts in details)
            {
                PersonsDteails(contacts);
            }
        }
    
     
    }
}
