namespace ContractTester.Unittests
{
    using System;

    using NUnit.Framework;

    [TestFixture]
    public class AmSoSillyAndFunnyTests
    {
        [Test]
        public void Add_NullEntity_ThrowsException()
        {
            // Arrange
            var wai = new AmSoSillyAndFunny();

            // Act

            // Assert
            Assert.Throws(
                Is.InstanceOf<ArgumentNullException>().And.Message.StringMatching(
                    "Precondition failed: entity != null  entity\r\nParameter name: entity"),
                () => wai.Add(null));
        }

        [Test]
        public void Delete_NullEntity_ThrowsException()
        {
            // Arrange
            var wai = new AmSoSillyAndFunny();

            // Act

            // Assert
            Assert.Throws(
                Is.InstanceOf<ArgumentNullException>().And.Message.StringMatching(
                    "Precondition failed: entity != null  entity\r\nParameter name: entity"),
                () => wai.Delete(null));
        }
    }
}
