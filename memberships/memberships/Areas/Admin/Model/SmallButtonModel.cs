
using System;
using System.Text;

namespace memberships.Areas.Admin.Model
{
    public class SmallButtonModel
    {
        public String Action { get; set; }
        public String Text { get; set; }
        public String Glyph { get; set; }
        public String ButtonType { get; set; }
        public int? Id { get; set; }
        public int? ItemId { get; set; }
        public int? ProductId { get; set; }
        public int? SubscriptionId { get; set; }
        public String ActionParameters { get
            {
                var param = new StringBuilder("?");
                if (Id != null && Id > 0)
                    param.Append(String.Format("{0}={1}&", "Id", Id));
                if (ItemId != null && ItemId > 0)
                    param.Append(String.Format("{0}={1}&", "ItemId", ItemId));
                if (ProductId != null && ProductId > 0)
                    param.Append(String.Format("{0}={1}&", "ProductId", ProductId));
                if (SubscriptionId != null && SubscriptionId > 0)
                    param.Append(String.Format("{0}={1}&", "SubscriptionId", SubscriptionId));
                return param.ToString(0, param.Length - 1);          }  }

    }
}