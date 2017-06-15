using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C_Sharp_ExamplesCode;

namespace C_Sharp_ExamplesCode
{
    [TestClass]
    public class ExamplesTest
    {
        List<Person> listPersons;
        List<Address> listAddresses;
        List<AddressByPerson> listMap;

        [TestInitialize]
        public void Initialize()
        {
            // initialize
            listPersons = Person.GetTestData();
            listAddresses = Address.GetTestData();
            listMap = AddressByPerson.GetTestData();
        }

        [TestMethod]
        public void TestPersonAddress_Join()
        {
            Console.WriteLine("JOIN:");
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

            Assert.IsTrue(res.Count() == 2); // Count of join matched records in "listMap"
        }

        [TestMethod]
        public void TestPersonAddress_LeftOuterJoin()
        {
            var res =
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

            Assert.IsTrue(res.Count() == 6); // Count of all records in "listMap"
        }
    }
}
