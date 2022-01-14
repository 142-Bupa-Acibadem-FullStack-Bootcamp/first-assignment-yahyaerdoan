using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Northwind.EntityLayer.Concrete.Dtos;
using Northwind.EntityLayer.Concrete.Models;
using Northwind.InterfaceLayer.Abstract.ModelService;
using Northwind.WebApiLayer.Controllers.ApiBaseController;

namespace Northwind.WebApiLayer.Controllers.Controller
{
    [Route("api/[controller]s")]
    [ApiController]
    public class OrderController : BaseController<IOrderService, Order, DtoOrder>
    {
        public OrderController(IOrderService service) : base(service)
        {
        }
    }
}
