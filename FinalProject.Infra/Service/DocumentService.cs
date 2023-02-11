using FinalProject.Core.Data;
using FinalProject.Core.Repository;
using FinalProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Infra.Service
{
    public class DocumentService : IDocumentService
    {
        private readonly IDocumentRepository documentRepository;
        public DocumentService(IDocumentRepository _documentRepository)
        {
            this.documentRepository = _documentRepository;
        }

        public List<Document> GetAlldocument()
        {
            return documentRepository.GetAlldocument();
        }
        public void CREATEdocument(Document document)
        {
            documentRepository.CREATEdocument(document);
        }
        public void UPDATEdocument(int id, Document document)
        {
            documentRepository.UPDATEdocument(id, document);
        }
        public Document GetdocumentById(int id)
        {
            return documentRepository.GetdocumentById(id);
        }
        public void Deletedocument(int id)
        {
            documentRepository.Deletedocument(id);
        }
    }
}
