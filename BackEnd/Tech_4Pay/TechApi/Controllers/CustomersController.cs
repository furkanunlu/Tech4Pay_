using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proje.Bll;
using Proje.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TechApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpPost("add")]
        public IActionResult Add(Customer customer)
        {
            _customerService.Add(customer);
            return Ok("Müşteri özel bilgileri kaydedildi.");
        }
        [HttpPut("update")]
        public IActionResult Update(Customer customer)
        {
           
            _customerService.Add(customer);
            return Ok("Müşteri özel bilgileri kaydedildi.");
        }
        [HttpGet("")]
        public IActionResult GetList()
        {
            List<CustomerDTO> customerDTOs = new List<CustomerDTO>();
            _customerService.GetList().ForEach((customer) => customerDTOs.Add(customer.CustomerToDTO() ));
            return Ok(customerDTOs);
        }
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            
            Expression<Func<Customer, bool>> filter = customer => customer.Id == id;
            var get=_customerService.Get(filter).Data.CustomerToDTO();
            return Ok(get);

        }

    }
}
