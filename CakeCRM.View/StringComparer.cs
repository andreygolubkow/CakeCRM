using System;
using System.Collections.Generic;
using CakeCRM.Model;

namespace CakeCRM.View
{
    class SellVariantComparer : IComparer<SellVariant>
    {
        private IComparer<String> _comparerImplementation;
        public int Compare(SellVariant x, SellVariant y)
        {
            return _comparerImplementation.Compare(x.ToString(), y.ToString());
        }
    }
}