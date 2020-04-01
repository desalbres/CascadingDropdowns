using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CascadingDropdowns.Data
{
    public class ProductService
    {
        public List<Products> getProducts
        {
            get {
                return new List<Products> {
                    new Products { Name="Cars",  Brands= new List<string>() {"Volkswagen","Ford","Toyota","Fiat" } },
                    new Products { Name="Motorcycles",  Brands= new List<string>() {"Kawasaki","Yamaha","BMW" }},
                    new Products { Name="Planes",  Brands= new List<string>() {"Airbus","Boieng","ATR" }}
                };
            } 
        }
    }
}
