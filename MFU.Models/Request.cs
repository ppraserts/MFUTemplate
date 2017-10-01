using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFU.Models
{
    public class Request : EntityBase
    {
        public RequestType RequestType { get; set; }
    }
}
