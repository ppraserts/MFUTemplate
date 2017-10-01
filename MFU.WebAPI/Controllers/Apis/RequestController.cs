using MFU.Models;
using MFU.Service;
using System.Collections.Generic;

namespace MFU.WebAPI.Controllers
{
    public class RequestController : BaseApiController
    {
        private RequestService requestService = new RequestService();
        public IEnumerable<Request> Get()
        {
            return requestService.GetAll();
        }

        public Request Get(int id)
        {
            return requestService.GetById(id);
        }
    }
}
