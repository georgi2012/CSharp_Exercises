using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion.GoodGreeting
{
    class GreetingTest
    {
        [TestClass]
        class TestShape
        {
            [TestMethod]
            public void GreetShouldReturnGoodMorningWhen10AM()
            {
                var greeter = new Greeting(new DateTime(2022, 1, 1, 10, 0, 0));
                string name = "Gosho";
                string receivedMessage = greeter.Greet(name);
                Assert.AreEqual("Good morning, " + name, receivedMessage);
            }
        }
    }
}
