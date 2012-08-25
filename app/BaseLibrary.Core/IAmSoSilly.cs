namespace BaseLibrary.Core
{
    using System.Diagnostics.Contracts;

    [ContractClass(typeof(IAmSoSillyContract))]
    public interface IAmSoSilly
    {
        bool Add(string entity);

        void Delete(string entity);
    }
}
