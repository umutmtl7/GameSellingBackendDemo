using GameSellingBackendDemo.Abstract;
using GameSellingBackendDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;
namespace GameSellingBackendDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfReal(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrula(customer.NationalityId, customer.Name.ToUpper(), customer.Surname.ToUpper(), customer.DateOfBirth.Year);
        }
    }
}
