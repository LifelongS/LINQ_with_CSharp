using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_with_CSharp
{
    class Product
    {
        public string Name { get; set; }
        public int Energy { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Energy})";
        }

        internal static object Select(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
