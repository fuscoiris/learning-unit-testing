
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework; 
using ProgettoTestingEDebugging.Service;

namespace TestProject1
{
    public class CFUnitTest
    {
        private CFService cfService;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            cfService = new CFService();
        }

        
        [TestCase("a", true)]
        [TestCase("e", true)]
        [TestCase("i", true)]
        [TestCase("o", true)]
        [TestCase("u", true)]
        [TestCase("c", false)]
        [TestCase("A", true)]
        [TestCase("U", true)]
        [TestCase("C", false)]
        [TestCase("2", false)]
        [TestCase("&", false)]
        public void tdd(char var1, bool var2)
        {
            
            Assert.That(var2, Is.EqualTo(cfService.SeVocale(var1)));
        }
    }
}
