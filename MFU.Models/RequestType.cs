using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFU.Models
{
    public class RequestType : EntityBase
    {
        public string RequestTypeName { get; set; }
        public decimal Price { get; set; }
    }
}
