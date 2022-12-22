using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proje.Bll;
using Proje.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tech_4Pay.EfDbContext;

namespace TechApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerAdressesController : ControllerBase
    {
        private readonly ICustomerAdressService _customerAdressService;

        public CustomerAdressesController(ICustomerAdressService customerAdressService)
        {
            _customerAdressService = customerAdressService;
        }
        [HttpPost("add")]
        public IActionResult Add(CustomerAdress customerAdress)
        {
            _customerAdressService.Add(customerAdress);
            return Ok("Adress Başarı İle Eklendi");
        }
        [HttpGet("")]
        public IActionResult GetList()
        {
            return Ok(_customerAdressService.GetList());
            
            //_customerAdressService.GetList()
        }
        [HttpPut("update")]
        public IActionResult Update(CustomerAdress customerAdress)
        {
            _customerAdressService.Update(customerAdress);
            return Ok("Müşteri Bilgisi Güncellendi.");
        }
    }
}
