namespace ContractTester.Unittests
{
    using System;

    using NUnit.Framework;

    [TestFixture]
    public class ThisShouldStillWorkTests
    {
        [Test]
        public void GimmieAOne_NullArgument_ThrowsException()
        {
            // Arrange
            var tsw = new ThisShouldStillWork();

            // Act

            // Assert
            Assert.Throws(
                Is.InstanceOf<ArgumentNullException>().And.Message.StringMatching(
                    "Precondition failed: rubbish != null  rubbish\r\nParameter name: rubbish"),
                () => tsw.GimmieAOne(null));
        }  
    }
}