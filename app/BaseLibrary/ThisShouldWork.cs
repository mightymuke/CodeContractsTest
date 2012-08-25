namespace BaseLibrary
{
    using System;
    using System.Diagnostics.Contracts;

    public class ThisShouldWork
    {
        public string GimmieAOne(string rubbish)
        {
            Contract.Requires<ArgumentNullException>(rubbish != null, "rubbish");
            return "One";
        }
    }
}