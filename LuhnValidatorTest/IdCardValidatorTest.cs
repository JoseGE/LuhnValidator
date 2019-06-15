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
    }
}
