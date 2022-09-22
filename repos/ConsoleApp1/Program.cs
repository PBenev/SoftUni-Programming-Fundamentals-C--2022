using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Configuration;

namespace AuditableEntityBlog
{
    class Program
    {
        static void Main(string[] args)
        {
            CrmServiceClient crmServiceClientObj = new CrmServiceClient(ConfigurationManager.ConnectionStrings["CrmOnlineStringFromAppConfig"].ConnectionString);
            if (!crmServiceClientObj.IsReady)
                Console.WriteLine("No Connection was Made.");
            Console.WriteLine("Connected");
            string EntitySchemaName = "account", AttributeSchemaName = "name";
            Guid RecordId = new Guid("6C8A7CF2-64E9-E711-A952-000D3A328908");
            try
            {
                RetrieveAttributeChangeHistoryRequest attributeChangeHistoryRequest = new RetrieveAttributeChangeHistoryRequest
                {
                    Target = new EntityReference(EntitySchemaName, RecordId),
                    AttributeLogicalName = AttributeSchemaName
                };

                RetrieveAttributeChangeHistoryResponse attributeChangeHistoryResponse =
                 (RetrieveAttributeChangeHistoryResponse)crmServiceClientObj.Execute(attributeChangeHistoryRequest);

                foreach (var EachEditRecord in attributeChangeHistoryResponse.AuditDetailCollection.AuditDetails)
                {
                    AttributeAuditDetail attributeDetail = (AttributeAuditDetail)EachEditRecord;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to fetch data. \nReason {0}", e.Message);
            }
            Console.ReadLine();
        }
    }
}