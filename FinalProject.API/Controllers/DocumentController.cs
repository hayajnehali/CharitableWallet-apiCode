using FinalProject.Core.Data;
using FinalProject.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FinalProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentService documentService;
        public DocumentController(IDocumentService _documentService)
        {
            this.documentService = _documentService;
        }

        [HttpGet("GetAlldocument")]
        public List<Document> GetAlldocument()
        {
            return documentService.GetAlldocument();
        }

        [HttpPost("CREATEdocument")]
        public void CREATEdocument(Document document)
        {
            documentService.CREATEdocument(document);
        }

        [HttpPut("UPDATEdocument/{id}")]
        public void UPDATEdocument(int id, Document document)
        {
            documentService.UPDATEdocument(id, document);
        }

        [HttpGet("GetdocumentById/{id}")]
        public Document GetdocumentById(int id)
        {
            return documentService.GetdocumentById(id);
        }
        [HttpDelete("Deletedocument/{id}")]
        public void Deletedocument(int id)
        {
            documentService.Deletedocument(id);
        }
    }
}
