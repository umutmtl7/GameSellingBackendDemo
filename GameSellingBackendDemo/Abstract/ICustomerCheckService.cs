using GameSellingBackendDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingBackendDemo.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfReal(Customer customer);
    }
}
