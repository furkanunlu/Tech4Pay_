using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proje.Bll;
using Proje.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerContactsController : ControllerBase
    {
        private readonly ICustomerContactService _customerContactService;
        public CustomerContactsController(ICustomerContactService customerContactService)
        {
            _customerContactService = customerContactService;
        }
        [HttpPost("add")]
        public IActionResult Add(CustomerContact customerContact)
        {
            _customerContactService.Add(customerContact);
            return Ok("İletişim Bilgileri Başarı İle Eklendi.");
        }
        [HttpGet("")]
        public IActionResult GetList()
        {
            return Ok(_customerContactService.GetList());
        }
        [HttpPut("update")]
        public IActionResult Update(CustomerContact customerContact)
        {
            _customerContactService.Update(customerContact);
            return Ok("Müşteri özel bilgileri kaydedildi.");
        }
    }
}
