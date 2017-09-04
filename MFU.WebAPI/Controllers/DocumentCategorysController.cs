using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MFU.Logger;
using MFU.Models;
using MFU.Service;

namespace MFU.WebAPI.Controllers
{
    public class DocumentCategorysController : ApiController
    {
        private DocumentCategoryService documentCategoryService { get; set; }

        public DocumentCategorysController()
        {
            documentCategoryService = new DocumentCategoryService();
        }

        // GET api/documentCategorys
        public IEnumerable<DocumentCategory> Get()
        {
            return documentCategoryService.GetAll();
        }

        // GET api/documentCategorys/5
        public DocumentCategory Get(int id)
        {
            return documentCategoryService.GetById(id);
        }
    }
}
