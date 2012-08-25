namespace BaseLibrary.Unittests
{
    using System;

    using BaseLibrary.Common;

    using NUnit.Framework;

    [TestFixture]
    public class BangTests
    {
        [Test]
        public void Shoot_NullArgument_ThrowsException()
        {
            // Arrange
            var bang = new Bang();

            // Act

            // Assert
            Assert.Throws(
                Is.InstanceOf<ArgumentNullException>().And.Message.StringMatching(
                    "Precondition failed: shoot != null  shoot\r\nParameter name: shoot"),
                () => bang.Ouch(null));
        } 
    }
}