namespace BaseLibrary.Core
{
    using System;
    using System.Diagnostics.Contracts;

    [ContractClassFor(typeof(IAmSoSilly))]
    internal abstract class IAmSoSillyContract : IAmSoSilly
    {
        public void Delete(string entity)
        {
            Contract.Requires<ArgumentNullException>(entity != null, "entity");
        }
    
        public bool Add(string entity)
        {
            Contract.Requires<ArgumentNullException>(entity != null, "entity");
            return default(bool);
        }
    }
}
