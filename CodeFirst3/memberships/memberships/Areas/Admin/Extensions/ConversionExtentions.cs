using System;
using System.Collections.Generic;
using System.Linq;
using memberships.Areas.Admin.Model;
using System.Threading.Tasks;
using System.Web;
using memberships.Models;
using memberships.Areas.Admin.Entites;
using memberships Models;

namespace memberships.Areas.Admin.Extensions
{
    public static class ConversionExtentions
    {
        public static async Task<IEnumerable<ProductModel>> Convert(
            this IEnumerable<Product> Products, ApplicationDbContext db)
        {
            var texts = await db
        }
    }
}