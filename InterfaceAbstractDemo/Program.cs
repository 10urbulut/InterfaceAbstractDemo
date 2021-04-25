using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;
using MernisServiceReference;
using InterfaceAbstractDemo.Adapter;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth= new DateTime(1993,7,18),
                FirstName="Onur",
                LastName="Bulut",
                NationalityId="30275044219"});

            Console.ReadLine();
        }
    }
}
