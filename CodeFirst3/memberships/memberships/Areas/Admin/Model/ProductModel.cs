using memberships.Areas.Admin.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace memberships.Areas.Admin.Model
{
    public class ProductModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public String Title { get; set; }
        [MaxLength(2048)]
        public String Description { get; set; }
        [MaxLength(1024)]
        [DisplayName("Image Url")]
        public String ImageUrl { get; set; }
        public int ProductLinkTextId { get; set; }
        public int ProductTypeId { get; set; }
      
        [DisplayName("Product Link Text")]
        public ICollection<ProductType> ProductTypes { get; set; }
        [DisplayName("Product Type")]
        public ICollection<ProductLinkText> ProductLinkTexts { get; set; }


        public String ProductType
        { get
            {
                return ProductTypes == null || ProductTypes.Count.Equals(0) ?
                    String.Empty : ProductTypes.First(pt => pt.Id.Equals(ProductTypeId)).Title;
            }
        }
        public String ProductLinkText
        {
            get
            {
                return ProductLinkTexts == null || ProductLinkTexts.Count.Equals(0) ?
                    String.Empty : ProductLinkTexts.First(pt => pt.Id.Equals(ProductLinkTextId)).Title;
            }
        }
    }
}