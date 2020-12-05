using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Converters;
using NUnit.Framework.Internal;

namespace NUnitTests
{
    [TestFixture]
    public  class BankingTransactionTest
    {
 
        [Test]
        [TestCase("*")]
        [TestCase("/")]
        [TestCase("-")]
        [TestCase("+")]
        [TestCase("%")]
        [TestCase("")]
        [TestCase(" ")]

        public void UserInputIsValid_IllegalCharacterOrEmptyStringInput_ThrowsException(string amount)
        {
            IProcessing iProcessing = new BankingTransaction();
    
            Assert.That(() => iProcessing.UserInputInputIsValid(amount), Throws.Exception);

        }
    }
        



        }

            

    
