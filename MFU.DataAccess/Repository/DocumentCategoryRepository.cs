using MFU.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MFU.DataAccess.Repository
{
    public class DocumentCategoryRepository : Repository<DocumentCategory>
    {
        public IEnumerable<DocumentCategory> GetAllWithSqlScript()
        {
            using (connectionFactory)
            {
                return connectionFactory.Query<DocumentCategory>(SqlText.DocumentCategory_Select).ToList();
            }
        }

        public IEnumerable<DocumentCategory> GetAllWithSqlScriptByLoadDetail()
        {
            using (connectionFactory)
            {
                var documentCategoryDictionary = new Dictionary<int, DocumentCategory>();
                return connectionFactory.Query<DocumentCategory, Document, DocumentCategory>(
                        SqlText.DocumentCategory_Select_WithDetail,
                        (documentCategory, document) =>
                        {
                            DocumentCategory documentCategoryEntry;

                            if (!documentCategoryDictionary.TryGetValue(documentCategory.Id, out documentCategoryEntry))
                            {
                                documentCategoryEntry = documentCategory;
                                documentCategoryEntry.Documents = new List<Document>();
                                documentCategoryDictionary.Add(documentCategoryEntry.Id, documentCategoryEntry);
                            }

                            if (document != null)
                                documentCategoryEntry.Documents.Add(document);

                            return documentCategoryEntry;
                        },
                        splitOn: "Id")
                    .Distinct()
                    .ToList();
            }
        }

        public DocumentCategory GetWithSqlScriptById(int id)
        {
            using (connectionFactory)
            {
                return connectionFactory.QuerySingle<DocumentCategory>(SqlText.DocumentCategory_Select_ByID,
                    new {DocumentCategoryID = id});
            }
        }
    }
}