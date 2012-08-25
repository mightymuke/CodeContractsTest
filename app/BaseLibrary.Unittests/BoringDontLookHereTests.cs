namespace BaseLibrary.Unittests
{
    using System;

    using BaseLibrary.ToMerge;

    using NUnit.Framework;

    [TestFixture]
    public class BoringDontLookHereTests
    {
        [Test]
        public void MakeMeBig_NullArgument_ThrowsException()
        {
            // Arrange
            var bdlh = new BoringDontLookHere();

            // Act

            // Assert
            Assert.Throws(
                Is.InstanceOf<NullReferenceException>().And.Message.StringMatching(
                    "Object reference not set to an instance of an object"),
                () => bdlh.MakeMeBig(null));
        } 
    }
}