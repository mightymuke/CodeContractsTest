namespace BaseLibrary.Common
{
    using System;
    using System.Diagnostics.Contracts;

    public class Bang
    {
        public bool Ouch(string shoot)
        {
            Contract.Requires<ArgumentNullException>(shoot != null, "shoot");
            return true;
        }
    }
}
