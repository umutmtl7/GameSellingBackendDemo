using GameSellingBackendDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingBackendDemo.Abstract
{
    public interface ICustomerService
    {
        void Add(Customer customer);
        void Delete(int Id);
        void Update(int Id);

    }
}
