using MFU.DataAccess.Repository;
using MFU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFU.Service
{
    public class DocumentCategoryService
    {
        private DocumentCategoryRepository documentCategoryRepository { get; set; }
        public DocumentCategoryService()
        {
            documentCategoryRepository = new DocumentCategoryRepository();
        }

        public IEnumerable<DocumentCategory> GetAll()
        {
            return documentCategoryRepository.GetAll();
        }
        public DocumentCategory GetById(int id)
        {
            return documentCategoryRepository.GetById(id);
        }
    }
}
