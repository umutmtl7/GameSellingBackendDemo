using GameSellingBackendDemo.Abstract;
using GameSellingBackendDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameSellingBackendDemo.Concrete
{
    public class CampaignManager : ICampaignService
    {
        List<Campaign> _campaigns;
        public CampaignManager(List<Campaign> campaigns)
        {
            _campaigns = campaigns;
        }
        public void Add(Campaign campaign)
        {
            _campaigns.Add(campaign);
            Console.WriteLine("The new campaign : " + campaign.CampaignName + "  is added");
        }

        public void Delete(int Id)
        {
            Campaign campaignToDelete = _campaigns.SingleOrDefault(camp => camp.CampaignId == Id);
            _campaigns.Remove(campaignToDelete);
        }

        public void Update(int Id)
        {
            Campaign campaignToUpdate = _campaigns.SingleOrDefault(camp => camp.CampaignId == Id);
            string nameUpdated = campaignToUpdate.CampaignName += "+";
            Console.WriteLine("Campaign :" + campaignToUpdate.CampaignName + " is updated. New name of the campaign is : " + nameUpdated);
            campaignToUpdate.CampaignName = nameUpdated;
        }
    }
}
