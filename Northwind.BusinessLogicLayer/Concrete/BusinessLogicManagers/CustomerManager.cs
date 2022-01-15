using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Northwind.BusinessLogicLayer.Concrete.BusinessLogicLayerBase;
using Northwind.BusinessLogicLayer.Concrete.MapperConfiguration;
using Northwind.EntityLayer.Abstract.IBases;
using Northwind.EntityLayer.Concrete.Bases;
using Northwind.EntityLayer.Concrete.Dtos;
using Northwind.EntityLayer.Concrete.Models;
using Northwind.InterfaceLayer.Abstract.ModelService;

namespace Northwind.BusinessLogicLayer.Concrete.BusinessLogicManagers
{
    public class CustomerManager : BusinessLogicBase<Customer, DtoCustomer>, ICustomerService
    {
        public CustomerManager(IServiceProvider service) : base(service)
        {
        }
    }
}
