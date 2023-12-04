using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    interface ISearchable
    {
        List<Product> SearchByPrice(double price);
        List<Product> SearchByCategory(string category);
        List<Product> SearchByRating(int rating);
    }
}
