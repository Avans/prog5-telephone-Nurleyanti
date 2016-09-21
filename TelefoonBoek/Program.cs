using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefoonBoek
{
    class Program
    {
        static void Main(string[] args)
        {
            TelephoneBook tp = new TelephoneBook();
            foreach (Person p in tp.SortByLastName())
            {
                Console.WriteLine("Persoon: " + p.Firstname + " " + p.Lastname + " - " + p.TelephoneNumber);
               
            }
            Console.WriteLine(" ");
            foreach (Person p in tp.FirstNameStartsWith("C"))
            {
                Console.WriteLine("Persoon: " + p.Firstname + " " + p.Lastname + " - " + p.TelephoneNumber);
                
            }
            Console.WriteLine(" ");
            foreach (String p in tp.SortByLastNameLongerThan(4))
            {
                Console.WriteLine("Persoon: " + p + " - " );
                
            }
            Console.WriteLine(" ");

            foreach (Person p in tp.SortByLastNameLength())
            {
                Console.WriteLine("Persoon: " + p.Firstname + " " + p.Lastname + " - " + p.TelephoneNumber);
                
            }
            Console.WriteLine(" ");

            tp.AmountInBook();

            Console.ReadLine();
        }
    }
}
