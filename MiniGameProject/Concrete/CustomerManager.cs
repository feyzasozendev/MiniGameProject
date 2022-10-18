using MiniGameProject.Abstract;
using MiniGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniGameProject.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public void Add(Customer customer)
        {
            if (_customerCheckService.Identifier(customer))
            {
                Console.WriteLine("Başarıyla kayıt oldu.");
            }
            else
            {
                throw new Exception("Bilgiler doğru değil! Kayıt başarısız.");
            }
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
