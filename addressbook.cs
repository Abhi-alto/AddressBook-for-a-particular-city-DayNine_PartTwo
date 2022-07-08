using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Addressbook
{
    public class addressBook
    {
         List<contact> add_book = new List<contact>();
        public void create()
        {
            contact Contact = new contact();
            Console.WriteLine("Enter your first name");
            Contact.first_name = Console.ReadLine();
            Console.WriteLine("Enter your second name");
            Contact.s_name = Console.ReadLine();
            Console.WriteLine("Enter your address");
            Contact.address = Console.ReadLine();
            Console.WriteLine("Enter your city");
            Contact.city = Console.ReadLine();
            Console.WriteLine("Enter your state");
            Contact.state = Console.ReadLine();
            Console.WriteLine("Enter your zip code");
            Contact.zip =Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your phone number");
            Contact.phone_no= Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your email");
            Contact.email = Console.ReadLine();
            add_book.Add(Contact);
        }
        public void display()
        {
            foreach(var data in add_book )
            {
                Console.WriteLine("Contact No. - "+data);
                Console.WriteLine("Name - "+data.first_name+" "+data.s_name);
                Console.WriteLine("Address - " + data.address);
                Console.WriteLine("City- " + data.city);
                Console.WriteLine("State - " + data.state);
                Console.WriteLine("Zip - " + data.zip);
                Console.WriteLine("Phone no. - " + data.phone_no);
                Console.WriteLine("Email - " + data.email);
            }
        }
    }
}


