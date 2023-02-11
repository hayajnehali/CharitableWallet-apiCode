using Dapper;
using FinalProject.Core.Common;
using FinalProject.Core.Data;
using FinalProject.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FinalProject.Infra.Repository
{
    public class DocumentRepository : IDocumentRepository
    {
        private readonly IDbContext dbContext;
        public DocumentRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Document> GetAlldocument()
        {
            IEnumerable<Document> users = dbContext.Connection.Query<Document>("document_p.GetAlldocument", commandType: CommandType.StoredProcedure);
            return users.ToList();
        }

        public void CREATEdocument(Document document)
        {
            var p = new DynamicParameters();
            p.Add("DocName1", document.Docname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("doc1", document.Doc, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("userid_fk1", document.UseridFk, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("charityid_fk1", document.CharityidFk, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("document_p.CREATEdocument", p, commandType: CommandType.StoredProcedure);

        }

        public void UPDATEdocument(int id, Document document)
        {
            var p = new DynamicParameters();
            
            p.Add("ID", document.Docid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("DocName1", document.Docname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("doc1", document.Doc, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("userid_fk1", document.UseridFk, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("charityid_fk1", document.CharityidFk, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("document_p.UPDATEdocument", p, commandType: CommandType.StoredProcedure);
        }

        public Document GetdocumentById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Document> users = dbContext.Connection.Query<Document>("document_p.GetdocumentById",p, commandType: CommandType.StoredProcedure);
            return users.FirstOrDefault();
        }


        public void Deletedocument(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("document_p.Deletedocument", p, commandType: CommandType.StoredProcedure);
        }

    }
}
