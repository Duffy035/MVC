using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Service
{
    public interface ISupplier
    {
        string GetDataFromSupplier();
    }

    //implementera interfacet med klassen Supplier:
    class Supplier : ISupplier
    {
        public string GetDataFromSupplier()
        {
            return "Tjenixen! Jag kommer från servicen...";
        }
    }


}
