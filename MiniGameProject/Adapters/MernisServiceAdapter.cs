using MervisServiceReference;
using MiniGameProject.Abstract;
using MiniGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniGameProject.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool Identifier(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year).GetAwaiter().GetResult();
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
