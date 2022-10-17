using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTicketService11.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.True(calculator.Additional(50, 12) == 62);
        }
        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.True(calculator.Subtraction(43, -12) == 55);
        }
        [Test]
        public void MiltiplicationMustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.True(calculator.Miltiplication(5, 9) == 45);
        }
        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.True(calculator.Division(50, 5) == 10);
        }
        [Test]
        public void DivisionMustReturnDivideByZeroException()
        {
            Calculator calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }
    }
}
