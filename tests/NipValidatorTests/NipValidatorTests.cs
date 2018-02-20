using System;

namespace NipValidatorTests
{
    [TestClass()]
    public class NipValidatorTests
    {
        [DataTestMethod]
        [DataRow("6275273253")]
        [DataRow("3943797120")]
        [DataRow("8784066227")]
        [DataRow("7094711247")]
        [DataRow("8674068337")]
        [DataRow("7140018423")]
        [DataRow("5147857226")]
        [DataRow("8442209706")]
        [DataRow("6539354354")]
        [DataRow("5207812599")]
        public void IsValid_ValidNipsTest(string nip)
        {
            Assert.IsTrue(NipValidator.IsValid(nip));
        }

        [DataTestMethod]
        [DataRow("627527325")]
        [DataRow("39437971")]
        [DataRow("8784066")]
        [DataRow("709471")]
        [DataRow("86740")]
        [DataRow("7140")]
        [DataRow("514")]
        [DataRow("84")]
        [DataRow("6")]
        public void IsValid_TooShortNipsTest(string nip)
        {
            Assert.IsFalse(NipValidator.IsValid(nip));
        }

        [DataTestMethod]
        [DataRow(null)]
        [DataRow("")]
        public void IsValid_EmptyNipsTest(string nip)
        {
            Assert.IsFalse(NipValidator.IsValid(nip));
        }

        [DataTestMethod]
        [DataRow("62752732531")]
        [DataRow("394379712012")]
        [DataRow("8784066227133")]
        [DataRow("70947112471456")]
        public void IsValid_TooLongNipsTest(string nip)
        {
            Assert.IsFalse(NipValidator.IsValid(nip));
        }

        [DataTestMethod]
        [DataRow("          ")]
        [DataRow("         0")]
        [DataRow("0         ")]
        [DataRow("      0   ")]
        [DataRow(";ierhf;adr")]
        [DataRow("0000000000")]
        [DataRow("1111111111")]
        [DataRow("1010101010")]
        [DataRow("0101010101")]
        [DataRow("aaaaaaaaaa")]
        [DataRow(";lizsedujr")]
        [DataRow("9999999999")]
        public void IsValid_MonkeyInvalidNipsTest(string nip)
        {
            Assert.IsFalse(NipValidator.IsValid(nip));
        }
    }
}
