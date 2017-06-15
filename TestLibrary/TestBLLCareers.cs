using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using DAL.EF;
using Moq;
using System.Data.Entity;

namespace TestLibrary
{
    [TestClass]
    public class TestBLLCareers
    {
        [TestMethod]
        public void Test_GetCareerNameById()
        {
            var data = new List<CAREER>
            {
                new CAREER { CareerID = "0001", CareerName = "Director" }, // needs to be First, when duplicated!
                new CAREER { CareerID = "0002", CareerName = "ASP.NET Developer" },
                new CAREER { CareerID = null, CareerName = null },
                new CAREER { CareerID = null, CareerName = string.Empty },
                new CAREER { CareerID = string.Empty, CareerName = null },
                new CAREER { CareerID = string.Empty, CareerName = string.Empty },
            }.AsQueryable();

            var mockSet = new Mock<DbSet<CAREER>>();
            mockSet.As<IQueryable<CAREER>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<CAREER>>().Setup(m => m.Expression).Returns(data.Expression);
            //mockSet.As<IQueryable<CAREER>>().Setup(m => m.ElementType).Returns(data.ElementType);
            //mockSet.As<IQueryable<CAREER>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            // var mockContext = new Mock<Salaries_PRODEntities>();
            var mockContext = new Mock<ISalaries_PRODEntities>();
            mockContext.Setup(m => m.CAREERS).Returns(mockSet.Object);

            var careers = new BLLCareers(mockContext.Object); // Fake data - MOQ            
            // BLLCareers careers = new BLLCareers();         // Real database

            Assert.IsTrue(careers.GetCareerNameById_FromTable("0001") == "Director", "Wrong CareerName!");
            Assert.IsTrue(careers.GetCareerNameById_FromTable("0002") == "ASP.NET Developer", "Wrong CareerName!");
            Assert.IsTrue(careers.GetCareerNameById_FromTable("fake_abc") == "", "Wrong CareerName!");
            Assert.IsTrue(careers.GetCareerNameById_FromTable("") == "", "Wrong CareerName!");
            Assert.IsTrue(careers.GetCareerNameById_FromTable(null) == "", "Wrong CareerName!");            
        }

        [TestMethod]
        public void Test_GetCareersALL()
        {
            var data = new List<CAREER>
            {
                new CAREER { CareerID = "0001", CareerName = "Director" },
                new CAREER { CareerID = "0001", CareerName = "Duplicated" },
                new CAREER { CareerID = "0002", CareerName = "ASP.NET Developer" },
                new CAREER { CareerID = null, CareerName = null },
                new CAREER { CareerID = string.Empty, CareerName = string.Empty },
            }.AsQueryable();

            var mockSet = new Mock<DbSet<CAREER>>();
            mockSet.As<IQueryable<CAREER>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<CAREER>>().Setup(m => m.Expression).Returns(data.Expression);
            //mockSet.As<IQueryable<CAREER>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<CAREER>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<Salaries_PRODEntities>();
            mockContext.Setup(m => m.CAREERS).Returns(mockSet.Object);

            var careers = new BLLCareers(mockContext.Object); // Fake data - MOQ            
            //BLLCareers careers = new BLLCareers();         // Real database

            Assert.IsTrue(careers.GetCareersALL().Count == 5, "Wrong career list count!");
        }
    }
}
