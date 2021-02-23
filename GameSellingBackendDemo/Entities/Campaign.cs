using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingBackendDemo.Entities
{
    public class Campaign
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public decimal Discount { get; set; }
    }
}
