using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefoonBoek
{
    class TelephoneBook
    {

        List<Person> persons;

        public TelephoneBook()
        {
            persons = new List<Person>();
            
            persons.Add(new Person("Nurleyanti", "Sakidin", 0643020278));
            persons.Add(new Person("Char", "Mander", 0612345678));
            persons.Add(new Person("Pika", "Chu", 0677445599));
            persons.Add(new Person("Bulba", "Saur", 0678912345));
            persons.Add(new Person("Chiko", "Rita", 0689234561));
            persons.Add(new Person("Cynda", "Quil", 0623765498));
            persons.Add(new Person("Toto", "Dile", 0652538989));
            persons.Add(new Person("Chari", "Zard", 069834083));
            persons.Add(new Person("Squir", "Tle", 0634987612));
            persons.Add(new Person("Ash", "Ketchum", 0655447684));
        }

        public List<Person> SortByLastName()
        {
            Console.WriteLine("### Sorteren op achternaam ###");
            
            return persons.OrderByDescending(p => p.Lastname).ToList();
    
        }

        public List<Person> FirstNameStartsWith(String letter)
        {
            Console.WriteLine("### Firstname begint met '"+ letter +"' ###");

            return persons.Where(p => p.Firstname.StartsWith(letter)).ToList();
        }
            
        public List<String> SortByLastNameLongerThan(int number)
        {
            Console.WriteLine("###Lastname langer dan " + number + " ###");
            List<String> personStrings = new List<string>();
           personStrings.AddRange(from p in persons
                                   where p.Lastname.Length > number
                                   select p.Lastname);
            return personStrings;

            
        }

        public List<Person> SortByLastNameLength()
        {
            Console.WriteLine("### Sorteren op achternaam lengte ####");
            return persons.OrderBy(p => p.Lastname.Length).ToList();
        }

        public int AmountInBook()
        {
            Console.WriteLine("### Aantal personen in telefoonboekje ###");
            int count = 0;
            count = persons.Sum(p => p.Firstname.Count());
            Console.WriteLine(count);
            return count;
            
            }
        }


    
}
