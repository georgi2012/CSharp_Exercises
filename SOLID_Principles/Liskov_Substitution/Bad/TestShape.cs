using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution.Bad
{
    [TestClass]
    class TestShape
    {
        [TestMethod]
        public void SquareAreaShouldReturnCorrectly()
        {
            Shape shape = new Square() { Height = 4, Width = 5 };
            var area = shape.Area;
            Assert.AreEqual(20, area);
            //fails because its 25 
            // Square does not do the same job as Square and cant replace it
        }
    }
}
