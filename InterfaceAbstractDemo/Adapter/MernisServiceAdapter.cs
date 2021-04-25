using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using MernisServiceReference;

namespace InterfaceAbstractDemo.Adapter
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
         KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId),
                                                 customer.FirstName.ToUpper(),
                                                 customer.LastName.ToUpper(),
                                                 customer.DateOfBirth.Year);
            
        }
    }
}
