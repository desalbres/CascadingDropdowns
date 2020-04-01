using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CascadingDropdowns.Data
{
    public class Products
    {
        public string Name { get; set; }
        public List<string> Brands { get; set; }
    }
}
