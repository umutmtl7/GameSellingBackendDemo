using GameSellingBackendDemo.Abstract;
using GameSellingBackendDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameSellingBackendDemo.Concrete
{
    public class CustomerManager : ICustomerService
    {
        List<Customer> _customers;
        private ICustomerCheckService _customerCheckService;
        public CustomerManager(List<Customer> customer, ICustomerCheckService customerCheckService)
        {
            _customers = customer;
            _customerCheckService = customerCheckService;
        }
        public void Add(Customer customer)
        {
            if (_customerCheckService.CheckIfReal(customer))
            {
                _customers.Add(customer);
                Console.WriteLine("Customer : " + customer.Name + " " + customer.Surname + " is added.");
            }
            else
            {
                Console.WriteLine("Mernis doğrulaması yapılamadı...");
            }

        }

        public void Delete(int Id)
        {
            Customer customerToDelete = _customers.SingleOrDefault(c => c.CustomerId == Id);
            _customers.Remove(customerToDelete);
        }

        public void Update(int Id)
        {
            Customer customerToUpdate = _customers.SingleOrDefault(c => c.CustomerId == Id);
            string nameUpdated = customerToUpdate.Name += "+";
            Console.WriteLine("Customer :" + customerToUpdate.Name + " is updated. New name of the customer is : " + nameUpdated);
            customerToUpdate.Name = nameUpdated;
        }
    }
}
