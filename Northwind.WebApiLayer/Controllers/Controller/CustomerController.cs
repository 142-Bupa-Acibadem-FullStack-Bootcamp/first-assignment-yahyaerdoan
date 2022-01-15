using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Northwind.EntityLayer.Abstract.IBases;
using Northwind.EntityLayer.Concrete.Bases;
using Northwind.EntityLayer.Concrete.Dtos;
using Northwind.EntityLayer.Concrete.Models;
using Northwind.InterfaceLayer.Abstract.ModelService;
using Northwind.WebApiLayer.Controllers.ApiBaseController;

namespace Northwind.WebApiLayer.Controllers.Controller
{
    [Route("api/[controller]s")]
    [ApiController]
    public class CustomerController : BaseController<ICustomerService, Customer, DtoCustomer>
    {
        public CustomerController(ICustomerService service) : base(service)
        {
        }
    }
}
