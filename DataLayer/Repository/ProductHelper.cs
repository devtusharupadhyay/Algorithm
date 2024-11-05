using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public static class ProductHelper
    {
        #region ByColor
        public static IEnumerable<Product> ByColor(
            this IEnumerable<Product> query, string color)
        {
            return query.Where(x => x.Color == color);  
        }
        #endregion
    }
}
