using Rychusoft.Validators;
using System;
using Xunit;

namespace NipValidatorTests
{
    public class NipValidatorTests
    {
        [Theory]
        [InlineData("6275273253")]
        [InlineData("3943797120")]
        [InlineData("8784066227")]
        [InlineData("7094711247")]
        [InlineData("8674068337")]
        [InlineData("7140018423")]
        [InlineData("5147857226")]
        [InlineData("8442209706")]
        [InlineData("6539354354")]
        [InlineData("5207812599")]
        public void IsValid_ValidNipsTest(string nip)
        {
            Assert.True(NipValidator.IsValid(nip));
        }

        [Theory]
        [InlineData("627527325")]
        [InlineData("39437971")]
        [InlineData("8784066")]
        [InlineData("709471")]
        [InlineData("86740")]
        [InlineData("7140")]
        [InlineData("514")]
        [InlineData("84")]
        [InlineData("6")]
        public void IsValid_TooShortNipsTest(string nip)
        {
            Assert.False(NipValidator.IsValid(nip));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void IsValid_EmptyNipsTest(string nip)
        {
            Assert.False(NipValidator.IsValid(nip));
        }

        [Theory]
        [InlineData("62752732531")]
        [InlineData("394379712012")]
        [InlineData("8784066227133")]
        [InlineData("70947112471456")]
        public void IsValid_TooLongNipsTest(string nip)
        {
            Assert.False(NipValidator.IsValid(nip));
        }

        [Theory]
        [InlineData("          ")]
        [InlineData("         0")]
        [InlineData("0         ")]
        [InlineData("      0   ")]
        [InlineData(";ierhf;adr")]
        [InlineData("0000000000")]
        [InlineData("1111111111")]
        [InlineData("1010101010")]
        [InlineData("0101010101")]
        [InlineData("aaaaaaaaaa")]
        [InlineData(";lizsedujr")]
        [InlineData("9999999999")]
        public void IsValid_MonkeyInvalidNipsTest(string nip)
        {
            Assert.False(NipValidator.IsValid(nip));
        }
    }
}
