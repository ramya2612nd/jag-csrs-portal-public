// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Csrs.Interfaces.Dynamics.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.afk_workflowtask
    /// </summary>
    public partial class MicrosoftDynamicsCRMafkWorkflowtask
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMafkWorkflowtask class.
        /// </summary>
        public MicrosoftDynamicsCRMafkWorkflowtask()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMafkWorkflowtask class.
        /// </summary>
        public MicrosoftDynamicsCRMafkWorkflowtask(int? importsequencenumber = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMinteractionforemail regardingobjectidNewInteractionforemailAfkWorkflowtask = default(MicrosoftDynamicsCRMinteractionforemail), MicrosoftDynamicsCRMknowledgebaserecord regardingobjectidKnowledgebaserecordAfkWorkflowtask = default(MicrosoftDynamicsCRMknowledgebaserecord), MicrosoftDynamicsCRMlead regardingobjectidLeadAfkWorkflowtask = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMbookableresourcebooking regardingobjectidBookableresourcebookingAfkWorkflowtask = default(MicrosoftDynamicsCRMbookableresourcebooking), MicrosoftDynamicsCRMbookableresourcebookingheader regardingobjectidBookableresourcebookingheaderAfkWorkflowtask = default(MicrosoftDynamicsCRMbookableresourcebookingheader), MicrosoftDynamicsCRMbulkoperation regardingobjectidBulkoperationAfkWorkflowtask = default(MicrosoftDynamicsCRMbulkoperation), MicrosoftDynamicsCRMcampaign regardingobjectidCampaignAfkWorkflowtask = default(MicrosoftDynamicsCRMcampaign), MicrosoftDynamicsCRMcampaignactivity regardingobjectidCampaignactivityAfkWorkflowtask = default(MicrosoftDynamicsCRMcampaignactivity), MicrosoftDynamicsCRMcontract regardingobjectidContractAfkWorkflowtask = default(MicrosoftDynamicsCRMcontract), MicrosoftDynamicsCRMentitlement regardingobjectidEntitlementAfkWorkflowtask = default(MicrosoftDynamicsCRMentitlement), MicrosoftDynamicsCRMentitlementtemplate regardingobjectidEntitlementtemplateAfkWorkflowtask = default(MicrosoftDynamicsCRMentitlementtemplate), MicrosoftDynamicsCRMincident regardingobjectidIncidentAfkWorkflowtask = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMsite regardingobjectidSiteAfkWorkflowtask = default(MicrosoftDynamicsCRMsite), MicrosoftDynamicsCRMservice serviceidAfkWorkflowtask = default(MicrosoftDynamicsCRMservice), MicrosoftDynamicsCRMinvoice regardingobjectidInvoiceAfkWorkflowtask = default(MicrosoftDynamicsCRMinvoice), MicrosoftDynamicsCRMopportunity regardingobjectidOpportunityAfkWorkflowtask = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMquote regardingobjectidQuoteAfkWorkflowtask = default(MicrosoftDynamicsCRMquote), MicrosoftDynamicsCRMsalesorder regardingobjectidSalesorderAfkWorkflowtask = default(MicrosoftDynamicsCRMsalesorder), MicrosoftDynamicsCRMmsdynPostalbum regardingobjectidMsdynPostalbumAfkWorkflowtask = default(MicrosoftDynamicsCRMmsdynPostalbum), MicrosoftDynamicsCRMssgSearchrequest regardingobjectidSsgSearchrequestAfkWorkflowtask = default(MicrosoftDynamicsCRMssgSearchrequest), MicrosoftDynamicsCRMssgIjssservicerequest regardingobjectidSsgIjssservicerequestAfkWorkflowtask = default(MicrosoftDynamicsCRMssgIjssservicerequest), MicrosoftDynamicsCRMssgIjsscase regardingobjectidSsgIjsscaseAfkWorkflowtask = default(MicrosoftDynamicsCRMssgIjsscase), MicrosoftDynamicsCRMssgCsrsfile regardingobjectidSsgCsrsfileAfkWorkflowtask = default(MicrosoftDynamicsCRMssgCsrsfile), MicrosoftDynamicsCRMssgCsrsrecalculation regardingobjectidSsgCsrsrecalculationAfkWorkflowtask = default(MicrosoftDynamicsCRMssgCsrsrecalculation), MicrosoftDynamicsCRMafkWorkflowelementoption regardingobjectidAfkWorkflowelementoptionAfkWorkflowtask = default(MicrosoftDynamicsCRMafkWorkflowelementoption), MicrosoftDynamicsCRMaccount regardingobjectidAccountAfkWorkflowtask = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMsystemuser createdbyAfkWorkflowtask = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMcontact regardingobjectidContactAfkWorkflowtask = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMmailbox sendermailboxidAfkWorkflowtask = default(MicrosoftDynamicsCRMmailbox), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyidAfkWorkflowtask = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMprincipal owneridAfkWorkflowtask = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMsystemuser owninguserAfkWorkflowtask = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsla slaActivitypointerSlaAfkWorkflowtask = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMbusinessunit owningbusinessunitAfkWorkflowtask = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticleAfkWorkflowtask = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyAfkWorkflowtask = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyAfkWorkflowtask = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyAfkWorkflowtask = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteamAfkWorkflowtask = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsla slainvokedidActivitypointerSlaAfkWorkflowtask = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMactivitypointer activityidAfkWorkflowtask = default(MicrosoftDynamicsCRMactivitypointer), IList<MicrosoftDynamicsCRMactivityparty> afkWorkflowtaskActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMcampaignresponse> campaignResponseAfkWorkflowtasks = default(IList<MicrosoftDynamicsCRMcampaignresponse>), IList<MicrosoftDynamicsCRMactioncard> afkWorkflowtaskActionCards = default(IList<MicrosoftDynamicsCRMactioncard>), IList<MicrosoftDynamicsCRMsyncerror> afkWorkflowtaskSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> afkWorkflowtaskDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> afkWorkflowtaskDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> afkWorkflowtaskAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> afkWorkflowtaskMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> afkWorkflowtaskProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> afkWorkflowtaskBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> afkWorkflowtaskPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMconnection> afkWorkflowtaskConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> afkWorkflowtaskConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMqueueitem> afkWorkflowtaskQueueItems = default(IList<MicrosoftDynamicsCRMqueueitem>), IList<MicrosoftDynamicsCRMannotation> afkWorkflowtaskAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), MicrosoftDynamicsCRMssgRequestforinformationletter regardingobjectidSsgRequestforinformationletterAfkWorkflowtask = default(MicrosoftDynamicsCRMssgRequestforinformationletter), MicrosoftDynamicsCRMssgMspgroup regardingobjectidSsgMspgroupAfkWorkflowtask = default(MicrosoftDynamicsCRMssgMspgroup))
        {
            Importsequencenumber = importsequencenumber;
            Overriddencreatedon = overriddencreatedon;
            RegardingobjectidNewInteractionforemailAfkWorkflowtask = regardingobjectidNewInteractionforemailAfkWorkflowtask;
            RegardingobjectidKnowledgebaserecordAfkWorkflowtask = regardingobjectidKnowledgebaserecordAfkWorkflowtask;
            RegardingobjectidLeadAfkWorkflowtask = regardingobjectidLeadAfkWorkflowtask;
            RegardingobjectidBookableresourcebookingAfkWorkflowtask = regardingobjectidBookableresourcebookingAfkWorkflowtask;
            RegardingobjectidBookableresourcebookingheaderAfkWorkflowtask = regardingobjectidBookableresourcebookingheaderAfkWorkflowtask;
            RegardingobjectidBulkoperationAfkWorkflowtask = regardingobjectidBulkoperationAfkWorkflowtask;
            RegardingobjectidCampaignAfkWorkflowtask = regardingobjectidCampaignAfkWorkflowtask;
            RegardingobjectidCampaignactivityAfkWorkflowtask = regardingobjectidCampaignactivityAfkWorkflowtask;
            RegardingobjectidContractAfkWorkflowtask = regardingobjectidContractAfkWorkflowtask;
            RegardingobjectidEntitlementAfkWorkflowtask = regardingobjectidEntitlementAfkWorkflowtask;
            RegardingobjectidEntitlementtemplateAfkWorkflowtask = regardingobjectidEntitlementtemplateAfkWorkflowtask;
            RegardingobjectidIncidentAfkWorkflowtask = regardingobjectidIncidentAfkWorkflowtask;
            RegardingobjectidSiteAfkWorkflowtask = regardingobjectidSiteAfkWorkflowtask;
            ServiceidAfkWorkflowtask = serviceidAfkWorkflowtask;
            RegardingobjectidInvoiceAfkWorkflowtask = regardingobjectidInvoiceAfkWorkflowtask;
            RegardingobjectidOpportunityAfkWorkflowtask = regardingobjectidOpportunityAfkWorkflowtask;
            RegardingobjectidQuoteAfkWorkflowtask = regardingobjectidQuoteAfkWorkflowtask;
            RegardingobjectidSalesorderAfkWorkflowtask = regardingobjectidSalesorderAfkWorkflowtask;
            RegardingobjectidMsdynPostalbumAfkWorkflowtask = regardingobjectidMsdynPostalbumAfkWorkflowtask;
            RegardingobjectidSsgSearchrequestAfkWorkflowtask = regardingobjectidSsgSearchrequestAfkWorkflowtask;
            RegardingobjectidSsgIjssservicerequestAfkWorkflowtask = regardingobjectidSsgIjssservicerequestAfkWorkflowtask;
            RegardingobjectidSsgIjsscaseAfkWorkflowtask = regardingobjectidSsgIjsscaseAfkWorkflowtask;
            RegardingobjectidSsgCsrsfileAfkWorkflowtask = regardingobjectidSsgCsrsfileAfkWorkflowtask;
            RegardingobjectidSsgCsrsrecalculationAfkWorkflowtask = regardingobjectidSsgCsrsrecalculationAfkWorkflowtask;
            RegardingobjectidAfkWorkflowelementoptionAfkWorkflowtask = regardingobjectidAfkWorkflowelementoptionAfkWorkflowtask;
            RegardingobjectidAccountAfkWorkflowtask = regardingobjectidAccountAfkWorkflowtask;
            CreatedbyAfkWorkflowtask = createdbyAfkWorkflowtask;
            RegardingobjectidContactAfkWorkflowtask = regardingobjectidContactAfkWorkflowtask;
            SendermailboxidAfkWorkflowtask = sendermailboxidAfkWorkflowtask;
            TransactioncurrencyidAfkWorkflowtask = transactioncurrencyidAfkWorkflowtask;
            OwneridAfkWorkflowtask = owneridAfkWorkflowtask;
            OwninguserAfkWorkflowtask = owninguserAfkWorkflowtask;
            SlaActivitypointerSlaAfkWorkflowtask = slaActivitypointerSlaAfkWorkflowtask;
            OwningbusinessunitAfkWorkflowtask = owningbusinessunitAfkWorkflowtask;
            RegardingobjectidKnowledgearticleAfkWorkflowtask = regardingobjectidKnowledgearticleAfkWorkflowtask;
            ModifiedonbehalfbyAfkWorkflowtask = modifiedonbehalfbyAfkWorkflowtask;
            CreatedonbehalfbyAfkWorkflowtask = createdonbehalfbyAfkWorkflowtask;
            ModifiedbyAfkWorkflowtask = modifiedbyAfkWorkflowtask;
            OwningteamAfkWorkflowtask = owningteamAfkWorkflowtask;
            SlainvokedidActivitypointerSlaAfkWorkflowtask = slainvokedidActivitypointerSlaAfkWorkflowtask;
            ActivityidAfkWorkflowtask = activityidAfkWorkflowtask;
            AfkWorkflowtaskActivityParties = afkWorkflowtaskActivityParties;
            CampaignResponseAfkWorkflowtasks = campaignResponseAfkWorkflowtasks;
            AfkWorkflowtaskActionCards = afkWorkflowtaskActionCards;
            AfkWorkflowtaskSyncErrors = afkWorkflowtaskSyncErrors;
            AfkWorkflowtaskDuplicateMatchingRecord = afkWorkflowtaskDuplicateMatchingRecord;
            AfkWorkflowtaskDuplicateBaseRecord = afkWorkflowtaskDuplicateBaseRecord;
            AfkWorkflowtaskAsyncOperations = afkWorkflowtaskAsyncOperations;
            AfkWorkflowtaskMailboxTrackingFolders = afkWorkflowtaskMailboxTrackingFolders;
            AfkWorkflowtaskProcessSession = afkWorkflowtaskProcessSession;
            AfkWorkflowtaskBulkDeleteFailures = afkWorkflowtaskBulkDeleteFailures;
            AfkWorkflowtaskPrincipalObjectAttributeAccesses = afkWorkflowtaskPrincipalObjectAttributeAccesses;
            AfkWorkflowtaskConnections1 = afkWorkflowtaskConnections1;
            AfkWorkflowtaskConnections2 = afkWorkflowtaskConnections2;
            AfkWorkflowtaskQueueItems = afkWorkflowtaskQueueItems;
            AfkWorkflowtaskAnnotations = afkWorkflowtaskAnnotations;
            RegardingobjectidSsgRequestforinformationletterAfkWorkflowtask = regardingobjectidSsgRequestforinformationletterAfkWorkflowtask;
            RegardingobjectidSsgMspgroupAfkWorkflowtask = regardingobjectidSsgMspgroupAfkWorkflowtask;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_new_interactionforemail_afk_workflowtask")]
        public MicrosoftDynamicsCRMinteractionforemail RegardingobjectidNewInteractionforemailAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgebaserecord_afk_workflowtask")]
        public MicrosoftDynamicsCRMknowledgebaserecord RegardingobjectidKnowledgebaserecordAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_lead_afk_workflowtask")]
        public MicrosoftDynamicsCRMlead RegardingobjectidLeadAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebooking_afk_workflowtask")]
        public MicrosoftDynamicsCRMbookableresourcebooking RegardingobjectidBookableresourcebookingAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebookingheader_afk_workflowtask")]
        public MicrosoftDynamicsCRMbookableresourcebookingheader RegardingobjectidBookableresourcebookingheaderAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bulkoperation_afk_workflowtask")]
        public MicrosoftDynamicsCRMbulkoperation RegardingobjectidBulkoperationAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaign_afk_workflowtask")]
        public MicrosoftDynamicsCRMcampaign RegardingobjectidCampaignAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaignactivity_afk_workflowtask")]
        public MicrosoftDynamicsCRMcampaignactivity RegardingobjectidCampaignactivityAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contract_afk_workflowtask")]
        public MicrosoftDynamicsCRMcontract RegardingobjectidContractAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlement_afk_workflowtask")]
        public MicrosoftDynamicsCRMentitlement RegardingobjectidEntitlementAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlementtemplate_afk_workflowtask")]
        public MicrosoftDynamicsCRMentitlementtemplate RegardingobjectidEntitlementtemplateAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_incident_afk_workflowtask")]
        public MicrosoftDynamicsCRMincident RegardingobjectidIncidentAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_site_afk_workflowtask")]
        public MicrosoftDynamicsCRMsite RegardingobjectidSiteAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceid_afk_workflowtask")]
        public MicrosoftDynamicsCRMservice ServiceidAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_invoice_afk_workflowtask")]
        public MicrosoftDynamicsCRMinvoice RegardingobjectidInvoiceAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_opportunity_afk_workflowtask")]
        public MicrosoftDynamicsCRMopportunity RegardingobjectidOpportunityAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_quote_afk_workflowtask")]
        public MicrosoftDynamicsCRMquote RegardingobjectidQuoteAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_salesorder_afk_workflowtask")]
        public MicrosoftDynamicsCRMsalesorder RegardingobjectidSalesorderAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_msdyn_postalbum_afk_workflowtask")]
        public MicrosoftDynamicsCRMmsdynPostalbum RegardingobjectidMsdynPostalbumAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_ssg_searchrequest_afk_workflowtask")]
        public MicrosoftDynamicsCRMssgSearchrequest RegardingobjectidSsgSearchrequestAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_ssg_ijssservicerequest_afk_workflowtask")]
        public MicrosoftDynamicsCRMssgIjssservicerequest RegardingobjectidSsgIjssservicerequestAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_ssg_ijsscase_afk_workflowtask")]
        public MicrosoftDynamicsCRMssgIjsscase RegardingobjectidSsgIjsscaseAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_ssg_csrsfile_afk_workflowtask")]
        public MicrosoftDynamicsCRMssgCsrsfile RegardingobjectidSsgCsrsfileAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_ssg_csrsrecalculation_afk_workflowtask")]
        public MicrosoftDynamicsCRMssgCsrsrecalculation RegardingobjectidSsgCsrsrecalculationAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_afk_workflowelementoption_afk_workflowtask")]
        public MicrosoftDynamicsCRMafkWorkflowelementoption RegardingobjectidAfkWorkflowelementoptionAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account_afk_workflowtask")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccountAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby_afk_workflowtask")]
        public MicrosoftDynamicsCRMsystemuser CreatedbyAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contact_afk_workflowtask")]
        public MicrosoftDynamicsCRMcontact RegardingobjectidContactAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sendermailboxid_afk_workflowtask")]
        public MicrosoftDynamicsCRMmailbox SendermailboxidAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid_afk_workflowtask")]
        public MicrosoftDynamicsCRMtransactioncurrency TransactioncurrencyidAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid_afk_workflowtask")]
        public MicrosoftDynamicsCRMprincipal OwneridAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser_afk_workflowtask")]
        public MicrosoftDynamicsCRMsystemuser OwninguserAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_activitypointer_sla_afk_workflowtask")]
        public MicrosoftDynamicsCRMsla SlaActivitypointerSlaAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit_afk_workflowtask")]
        public MicrosoftDynamicsCRMbusinessunit OwningbusinessunitAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgearticle_afk_workflowtask")]
        public MicrosoftDynamicsCRMknowledgearticle RegardingobjectidKnowledgearticleAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby_afk_workflowtask")]
        public MicrosoftDynamicsCRMsystemuser ModifiedonbehalfbyAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby_afk_workflowtask")]
        public MicrosoftDynamicsCRMsystemuser CreatedonbehalfbyAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby_afk_workflowtask")]
        public MicrosoftDynamicsCRMsystemuser ModifiedbyAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam_afk_workflowtask")]
        public MicrosoftDynamicsCRMteam OwningteamAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slainvokedid_activitypointer_sla_afk_workflowtask")]
        public MicrosoftDynamicsCRMsla SlainvokedidActivitypointerSlaAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_afk_workflowtask")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowtask_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> AfkWorkflowtaskActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignResponse_afk_workflowtasks")]
        public IList<MicrosoftDynamicsCRMcampaignresponse> CampaignResponseAfkWorkflowtasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowtask_ActionCards")]
        public IList<MicrosoftDynamicsCRMactioncard> AfkWorkflowtaskActionCards { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowtask_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AfkWorkflowtaskSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowtask_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AfkWorkflowtaskDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowtask_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AfkWorkflowtaskDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowtask_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AfkWorkflowtaskAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowtask_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AfkWorkflowtaskMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowtask_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> AfkWorkflowtaskProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowtask_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AfkWorkflowtaskBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowtask_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AfkWorkflowtaskPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowtask_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> AfkWorkflowtaskConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowtask_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> AfkWorkflowtaskConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowtask_QueueItems")]
        public IList<MicrosoftDynamicsCRMqueueitem> AfkWorkflowtaskQueueItems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowtask_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> AfkWorkflowtaskAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_ssg_requestforinformationletter_afk_workflowtask")]
        public MicrosoftDynamicsCRMssgRequestforinformationletter RegardingobjectidSsgRequestforinformationletterAfkWorkflowtask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_ssg_mspgroup_afk_workflowtask")]
        public MicrosoftDynamicsCRMssgMspgroup RegardingobjectidSsgMspgroupAfkWorkflowtask { get; set; }

    }
}