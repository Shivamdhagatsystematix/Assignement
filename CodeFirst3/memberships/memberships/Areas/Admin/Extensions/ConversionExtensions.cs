using System;
using System.Collections.Generic;
using System.Linq;
using memberships.Areas.Admin.Model;
using System.Threading.Tasks;
using System.Web;
using memberships.Models;
using memberships.Areas.Admin.Entites;
using memberships.Models;
using System.Data.Entity;

namespace memberships.Areas.Admin.Extensions
{
    public static class ConversionExtensions
    {
        public static async Task<IEnumerable<ProductModel>> Convert(
            this IEnumerable<Product> products, ApplicationDbContext db)
        {
            if (products.Count().Equals(0))
                return new List<ProductModel>();

            var texts =  db.ProductLinkTexts.ToList();
            var types =  db.ProductTypes.ToList();
                return from p in products
                       select new ProductModel
                       {
                           Id = p.Id,
                           Title = p.Title,
                           Description = p.Description,
                           ImageUrl = p.ImageUrl,
                           ProductLinkTextId = p.ProductLinkTextId,
                           ProductTypeId = p.ProductTypeId,
                           ProductLinkTexts = texts,
                           ProductTypes = types

};
        }

        public static async Task<ProductModel> Convert(
          this Product product, ApplicationDbContext db)
        {
            var text = db.ProductLinkTexts.FirstOrDefault(
                p =>p.Id.Equals(product.ProductLinkTextId) );
            var type = db.ProductTypes.FirstOrDefault(p => p.Id.Equals(product.ProductTypeId));
            var model= new ProductModel
                  
                   {
                       Id = product.Id,
                       Title = product.Title,
                       Description = product.Description,
                       ImageUrl = product.ImageUrl,
                       ProductLinkTextId = product.ProductLinkTextId,
                       ProductTypeId = product.ProductTypeId,
                       ProductLinkTexts = new List  <ProductLinkText>(),
                       ProductTypes = new List<ProductType>()

            };
            model.ProductLinkTexts.Add(text);
            model.ProductTypes.Add(type);


            return model;
        }
    }
}