namespace ContractTester.Unittests
{
    using System;

    using NUnit.Framework;

    [TestFixture]
    public class BangBangTests
    {
        [Test]
        public void Shoot_NullArgument_ThrowsException()
        {
            // Arrange
            var bangbang = new BangBang();

            // Act

            // Assert
            Assert.Throws(
                Is.InstanceOf<ArgumentNullException>().And.Message.StringMatching(
                    "Precondition failed: shoot != null  shoot\r\nParameter name: shoot"),
                () => bangbang.Ouch(null));
        }  
    }
}