using System.Collections.Generic;
using System.Linq;
using Krooze.EntranceTest.WriteHere.Structure.Model;
using Krooze.EntranceTest.WriteHere.Tests.LogicTests;
using NUnit.Framework;

namespace Krooze.EntranceTest.Tests
{
    public class LogicTests
    {
        readonly SimpleLogicTest _test = new SimpleLogicTest();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void XML()
        {
            var xmlTest = new XMLTest();
            var result = xmlTest.TranslateXML();
            Assert.IsNotNull(result);
            Assert.AreEqual("BE20210104DXBDXBCRU", result.CruiseCode);
            Assert.AreEqual("MSC BELLISSIMA", result.ShipName);
            Assert.AreEqual(10638m, result.CabinValue);
            Assert.AreEqual(1400m, result.PortCharge);
            Assert.AreEqual(12038m, result.TotalValue);
            Assert.AreEqual(2, result.PassengerCruise.Count);
            Assert.AreEqual(10638m, result.PassengerCruise.Sum(x => x.Cruise.CabinValue));
            Assert.AreEqual(1400m, result.PassengerCruise.Sum(x => x.Cruise.PortCharge));
            Assert.AreEqual(12038m, result.PassengerCruise.Sum(x => x.Cruise.TotalValue));
            Assert.IsTrue(result.PassengerCruise.Any(x => x.PassengerCode == "-9999"),"No passenger -9999");
            Assert.IsTrue(result.PassengerCruise.Any(x => x.PassengerCode == "-9998"),"No passenger -9998");
            Assert.Pass();
        }

        [TestCase(10000, 1000, 12000, ExpectedResult = 1000)]
        [TestCase(10000, 1000, 11000, ExpectedResult = 0)]
        [TestCase(15000, 1000, 20000, ExpectedResult = 4000)]
        [TestCase(5.3, 0.3, 6, ExpectedResult = 0.4)]
        public decimal? OtherTaxes(decimal cabinValue, decimal portCharge, decimal totalValue)
        {
            return _test.GetOtherTaxes(new CruiseDTO()
            {
                CabinValue = cabinValue,
                PortCharge = portCharge,
                TotalValue = totalValue
            });
        }

        [TestCase(1000, 700, ExpectedResult = true)]
        [TestCase(1000, 1000, ExpectedResult = false)]
        [TestCase(1000, 1200, ExpectedResult = false)]
        public bool? Discount(decimal firstPassenger, decimal secondPassenger)
        {
            return _test.IsThereDiscount(new CruiseDTO()
            {
                PassengerCruise = new List<PassengerCruiseDTO>()
                {
                    new PassengerCruiseDTO()
                        {PassengerCode = "1", Cruise = new CruiseDTO() {CabinValue = firstPassenger}},
                    new PassengerCruiseDTO()
                        {PassengerCode = "2", Cruise = new CruiseDTO() {CabinValue = secondPassenger}},
                },
                CabinValue = firstPassenger + secondPassenger
            });
        }
        
        [TestCase(400, ExpectedResult = 2)]
        [TestCase(40000, ExpectedResult = 12)]
        [TestCase(100, ExpectedResult = 1)]
        [TestCase(1000, ExpectedResult = 5)]
        [TestCase(1001, ExpectedResult = 5)]
        public int? Installments(decimal fullPrice)
        {
            return _test.GetInstallments(fullPrice);
        }

    }
}