using System;

namespace BaseLibrary.Unittests
{
    using BaseLibrary.Core;

    using NUnit.Framework;

    [TestFixture]
    public class IAmSoSillyTests
    {
        [Test]
        public void Add_NullEntity_ThrowsException()
        {
            // Arrange
            var wai = new WhatAmI();

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
            var wai = new WhatAmI();

            // Act

            // Assert
            Assert.Throws(
                Is.InstanceOf<ArgumentNullException>().And.Message.StringMatching(
                    "Precondition failed: entity != null  entity\r\nParameter name: entity"),
                () => wai.Delete(null));
        }

        public class WhatAmI : IAmSoSilly
        {
            #region Implementation of IAmSoSilly

            public bool Add(string entity)
            {
                throw new NotImplementedException();
            }

            public void Delete(string entity)
            {
                throw new NotImplementedException();
            }

            #endregion
        }
    }
}
