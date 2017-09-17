using MFU.DataAccess.Repository;
using MFU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFU.Service
{
    public class DocumentService
    {
        private DocumentRepository documentRepository = new DocumentRepository();
        public DocumentService()
        {
        }
        public IEnumerable<Document> GetAll()
        {
            return documentRepository.GetAll();
        }
        public Document GetById(int id)
        {
            return documentRepository.GetById(id);
        }
    }
}
