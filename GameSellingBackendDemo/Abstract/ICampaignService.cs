using GameSellingBackendDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingBackendDemo.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(int Id);
        void Update(int Id);

    }
}
