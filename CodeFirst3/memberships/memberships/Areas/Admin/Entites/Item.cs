using memberships.Areas.Admin.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace memberships.Areas.Admin.Entites
{
    [Table("Item")]
    public class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public String Title { get; set; }

        [MaxLength(2048)]
        public String Description { get; set; }

        [MaxLength(1024)]

        public String Url { get; set; }

        [MaxLength(1024)]

        public String ImageUrl { get; set; }
        [AllowHtml]
        public String HTML { get; set; }
        [DefaultValue(0)]
        [DisplayName("Wait Days")]
        public int WaitDays { get; set; }


        public String HTMLShort
        {
            get { return HTML == null || HTML.Length < 50 ? HTML : HTML.Substring(0, 50); }
 }
        public int ProductId { get; set; }
        public int ItemTypeId { get; set; }
        public int SectionId { get; set; }
        public int PartId { get; set; }
        public bool IsFree { get; set; }
        [DisplayName("Item Type")]
       public ICollection<ItemType> ItemTypes { get; set; }
        [DisplayName("Sections")]
        public ICollection<Section> Sections { get; set; }
        [DisplayName("Parts")]
        public ICollection<Part> Part { get; set; }

        //public static implicit operator Item(Item v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}