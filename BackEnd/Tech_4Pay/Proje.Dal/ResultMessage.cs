using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Dal
{
    public class ResultMessage<T>
    {
        public string Message { get; set; }
        public T Data { get; set; }
        public bool isTrue { get; set; }
    }
}
