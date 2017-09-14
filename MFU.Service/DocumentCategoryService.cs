using MFU.DataAccess.Repository;
using MFU.Models;
using System.Collections.Generic;

namespace MFU.Service
{
    public class DocumentCategoryService
    {
        private DocumentCategoryRepository documentCategoryRepository;
        public DocumentCategoryService()
        {
            documentCategoryRepository = new DocumentCategoryRepository();
        }

        public IEnumerable<DocumentCategory> GetAll()
        {
            //documentCategoryRepository.GetAllWithSqlScript();
            //documentCategoryRepository.GetAll();
            return documentCategoryRepository.GetAllWithSqlScriptByLoadDetail();
        }
        public DocumentCategory GetById(int id)
        {
            //documentCategoryRepository.GetWithSqlScriptById(id);
            return documentCategoryRepository.GetById(id);
        }
    }
}