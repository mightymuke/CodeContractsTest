namespace ContractTester
{
    using System;

    using BaseLibrary.Core;

    public class AmSoSillyAndFunny : AmSoFunny, IAmSoSillyAndFunny
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
