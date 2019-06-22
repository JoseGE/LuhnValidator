using LuhnValidator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LuhnTest
{
    [TestClass]
    public class IdCardValidatorTest
    {
        [TestMethod]
        public void ValidateIdCard_RealIdCard_True()
        {
            var card = "79927398713";

            var luhn = new IdCardValidator();
            var result = luhn.ValidateIdCard(card);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidateIdCard_FalseIdCard_False()
        {
            var card = "79927398710";

            var luhn = new IdCardValidator();
            var result = luhn.ValidateIdCard(card);

            Assert.IsTrue(!result);
        }

        [TestMethod]
        public void ValidateCreditCard_RealCreditCard_True()
        {
            var card = "4895-5862-5767-7086";

            var luhn = new IdCardValidator();
            var result = luhn.ValidateCreditCard(card);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidateCreditCard_InvalidCreditCard_False()
        {
            var card = "8360-7135-3409-0648";

            var luhn = new IdCardValidator();
            var result = luhn.ValidateCreditCard(card);

            Assert.IsTrue(!result);
        }

        [TestMethod]
        public void ValidateIdCard_RealIdCardDominicanRepublic_True()
        {
            var card = "79927398713";

            var luhn = new IdCardValidator();
            var result = luhn.ValidateIdCard(card, "DO");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidateIdCard_InvalidIdCardDominicanRepublic_True()
        {
            var card = "79927398712";

            var luhn = new IdCardValidator();
            var result = luhn.ValidateIdCard(card, "DO");

            Assert.IsTrue(!result);
        }
    }
}
