using Proje.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechApi
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int TcNo { get; set; }
        public bool Anormal { get; set; }
        public CustomerDTO()
        {
        }
    }

    public static class Extention
    {
        public static CustomerDTO CustomerToDTO(this Customer customer)
        {
            return new CustomerDTO()
            {
                Id = customer.Id,
                Ad=customer.Ad,
                Soyad=customer.Soyad,
                TcNo=customer.TcNo,
                Anormal=customer.Anormal

            };
        }
    }
}
