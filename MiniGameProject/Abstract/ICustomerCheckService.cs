using MiniGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniGameProject.Abstract
{
    public interface ICustomerCheckService
    {
        bool Identifier(Customer customer);
    }
}
