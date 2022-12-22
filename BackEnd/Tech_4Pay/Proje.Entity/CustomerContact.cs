using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Entity
{
    public class CustomerContact
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Email { get; set; }
        public int EvNumara { get; set; }
        public int IsNumara { get; set; }
        public int MobilNumara { get; set; }
    }
}
