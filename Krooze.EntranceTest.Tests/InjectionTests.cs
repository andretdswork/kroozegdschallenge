using System;
using Krooze.EntranceTest.WriteHere.Structure.Implementations;
using Krooze.EntranceTest.WriteHere.Structure.Model;
using Krooze.EntranceTest.WriteHere.Tests.InjectionTests;
using NUnit.Framework;

namespace Krooze.EntranceTest.Tests
{
    public class InjectionTests
    {
        readonly InjectionTest _test = new InjectionTest();

        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void CorrectInjection(int cruiseCompanyCode)
        {
            var result = _test.GetCruises(new CruiseRequestDTO() {CruiseCompanyCode = cruiseCompanyCode});
            
            Assert.IsNotNull(result);
            Assert.AreEqual(cruiseCompanyCode, result.Count);
            Assert.IsTrue(result.TrueForAll(x => x.CruiseCode == $"C{cruiseCompanyCode}"));
            Assert.Pass();
        }

        [Test]
        public void IncorrectInjection()
        {            
            Assert.Throws<Exception>(() => _test.GetCruises(new CruiseRequestDTO() {CruiseCompanyCode = 4}));
        }
    }
}