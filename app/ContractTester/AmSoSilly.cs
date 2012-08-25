namespace ContractTester
{
    using System;

    using BaseLibrary.Core;

    public class AmSoSilly : IAmSoSilly
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
