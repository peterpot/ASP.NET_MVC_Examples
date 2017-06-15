using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using BLL;

namespace C_Sharp_ExamplesCode
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }

        public static List<Person> GetTestData()
        {
            return new List<Person>() {
                new Person() { PersonId = 1, Name = "Peter" },
                new Person() { PersonId = 2, Name = "Sabina" },
                new Person() { PersonId = 2324, Name = "Fake person" }
            };
        }
    }

    public class Address
    {
        public int AddressId { get; set; }
        public string Poscode { get; set; }        
        public string FullAddress { get; set; }
        public string Country { get; set; }

        public static List<Address> GetTestData()
        {
            return new List<Address>() {
                 new Address { AddressId = 1, Country = "UK" },
                 new Address { AddressId = 2, Country = "Slovenia" },
                 new Address { AddressId = 24566, Country = "Fake country" }
            };
        }
    }
    
    public class AddressByPerson
    {
        public int? AddressId { get; set; }
        public int? PersonId { get; set; }

        public static List<AddressByPerson> GetTestData()
        {
            return new List<AddressByPerson>()
            {
                new AddressByPerson() { AddressId = null, PersonId = null },
                 new AddressByPerson() { AddressId = 1, PersonId = 1 },
                 new AddressByPerson() { AddressId = 1, PersonId = 2 },
                 new AddressByPerson() { AddressId = 99, PersonId = 99 },
                 new AddressByPerson() { AddressId = 99, PersonId = 1 },
                 new AddressByPerson() { AddressId = 2, PersonId = 99 }
             };
        }
    }

    public class HelperAddressAndPerson
    {
        /// <summary>
        /// Formats full address
        /// e.g : abc
        /// </summary>
        public static string FormatFullAddress(string fullAddress, string postcode, string country)
        {
            return $"{fullAddress}, {postcode}, {country}";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {        
            // -----------
            // AGREGGATE:
            // -----------
            var usersIds = new List<int> { 1, 2, 3, 4, 5 };
            string authorids = usersIds.Select(i => i.ToString()).Distinct().Aggregate((s1, s2) => s1 + ", " + s2);
            Console.WriteLine(authorids);

            //-------
            // JOIN:
            // ------
            Console.WriteLine("JOIN:");
            List<Person> listPersons = Person.GetTestData();
            List<Address> listAddresses = Address.GetTestData();
            List<AddressByPerson> listMap = AddressByPerson.GetTestData();

                var res = (from adr in listMap
                           join p in listPersons on adr.PersonId equals p.PersonId
                           join a in listAddresses on adr.AddressId equals a.AddressId
                           where adr.AddressId != 0
                           select new
                           {
                               AddressId = adr.AddressId,
                               Name = p.Name,
                               Country = a.Country
                           });
            foreach (var item in res)
            {
                Console.WriteLine(item.AddressId + " - " + item.Name + ", " + item.Country);
            }

            // ----------------
            // LEFT OUTER JOIN:
            // ----------------
            Console.WriteLine("LEFT OUTER JOIN:");

            var perAddress =
                (from adr in listMap
                 join pg in listPersons on adr.PersonId equals pg.PersonId into groupPersons
                 join ag in listAddresses on adr.AddressId equals ag.AddressId into groupAdresses
                 from p in groupPersons.DefaultIfEmpty()
                 from a in groupAdresses.DefaultIfEmpty()
                 where adr != null
                 select new
                 {
                     AddressId = adr.AddressId,
                     PersonName = p?.Name ?? "n/a",
                     PersonAddress = a?.Country ?? "n/a"
                 });

            foreach (var item in perAddress)
            {
                Console.WriteLine(item.AddressId + " - " + item.PersonName + ", " + item.PersonAddress);
            }

            // -------
            // SELECT:
            // -------
            var listOfPeopleWithAddress = perAddress.Select(address => new 
            {
                FullAddress = $"{address.PersonName}, {address.PersonAddress}"
            });

            var listOfPeopleWithAddress2 =
                (from a in perAddress
                 where a != null
                 select new
                 {
                     FullAddress = $"{a.PersonName}, {a.PersonAddress}"
                 });

            foreach (var item in listOfPeopleWithAddress)
            {
                Console.WriteLine(item.FullAddress);
            }

            foreach (var item in listOfPeopleWithAddress2)
            {
                Console.WriteLine(item.FullAddress);
            }

            // -----------
            // DICTIONARY
            // -----------
            var dict = new Dictionary<string, string>(){
                {"peter", "this is the content of Peter"},
                {"sabina", "this is the content of Sabina"}
            };
            string value = dict.Where(f => f.Key == "sabina").FirstOrDefault().Value;
            Console.WriteLine(value);
            foreach(var record in dict)
            {
                Console.WriteLine(record.Key + " - " + record.Value);
            }

            // ---------------------
            // DEPENDANCY INJECTION:
            // ---------------------
            var persons = new List<IPerson>()
            {
                new Peter(),
                new Sabina()
            };

            foreach(var p in persons)
            {
                p.Train();
            }

            // --------
            // LIBRARY:
            // --------
            foreach (string record in Cars.Names)
            {
                Console.WriteLine(record);
            }

            // -----------
            // EF from BLL
            // -----------
            BLLCareers bllCareers = new BLLCareers();
            Console.WriteLine(bllCareers.GetCareerNameById("0001"));
            Console.WriteLine(bllCareers.GetCareerNameById_FromTable("0001"));

            Console.ReadKey();
        }
    }
}
