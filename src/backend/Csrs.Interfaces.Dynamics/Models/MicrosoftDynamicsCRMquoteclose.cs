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
    /// Microsoft.Dynamics.CRM.quoteclose
    /// </summary>
    public partial class MicrosoftDynamicsCRMquoteclose
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMquoteclose
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMquoteclose()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMquoteclose
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMquoteclose(string category = default(string), string _quoteidValue = default(string), int? importsequencenumber = default(int?), string quotenumber = default(string), string subcategory = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? revision = default(int?), MicrosoftDynamicsCRMinteractionforemail regardingobjectidNewInteractionforemailQuoteclose = default(MicrosoftDynamicsCRMinteractionforemail), MicrosoftDynamicsCRMknowledgebaserecord regardingobjectidKnowledgebaserecordQuoteclose = default(MicrosoftDynamicsCRMknowledgebaserecord), MicrosoftDynamicsCRMlead regardingobjectidLeadQuoteclose = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMbookableresourcebooking regardingobjectidBookableresourcebookingQuoteclose = default(MicrosoftDynamicsCRMbookableresourcebooking), MicrosoftDynamicsCRMbookableresourcebookingheader regardingobjectidBookableresourcebookingheaderQuoteclose = default(MicrosoftDynamicsCRMbookableresourcebookingheader), MicrosoftDynamicsCRMbulkoperation regardingobjectidBulkoperationQuoteclose = default(MicrosoftDynamicsCRMbulkoperation), MicrosoftDynamicsCRMcampaign regardingobjectidCampaignQuoteclose = default(MicrosoftDynamicsCRMcampaign), MicrosoftDynamicsCRMcampaignactivity regardingobjectidCampaignactivityQuoteclose = default(MicrosoftDynamicsCRMcampaignactivity), MicrosoftDynamicsCRMentitlement regardingobjectidEntitlementQuoteclose = default(MicrosoftDynamicsCRMentitlement), MicrosoftDynamicsCRMentitlementtemplate regardingobjectidEntitlementtemplateQuoteclose = default(MicrosoftDynamicsCRMentitlementtemplate), MicrosoftDynamicsCRMincident regardingobjectidIncidentQuoteclose = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMsite regardingobjectidSiteQuoteclose = default(MicrosoftDynamicsCRMsite), MicrosoftDynamicsCRMservice serviceidQuoteclose = default(MicrosoftDynamicsCRMservice), MicrosoftDynamicsCRMopportunity regardingobjectidOpportunityQuoteclose = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMquote regardingobjectidQuoteQuoteclose = default(MicrosoftDynamicsCRMquote), MicrosoftDynamicsCRMaccount regardingobjectidAccountQuoteclose = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMsystemuser createdbyQuoteclose = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMmailbox sendermailboxidQuoteclose = default(MicrosoftDynamicsCRMmailbox), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyidQuoteclose = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMprincipal owneridQuoteclose = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMsystemuser owninguserQuoteclose = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsla slaActivitypointerSlaQuoteclose = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMbusinessunit owningbusinessunitQuoteclose = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticleQuoteclose = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyQuoteclose = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyQuoteclose = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyQuoteclose = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteamQuoteclose = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsla slainvokedidActivitypointerSlaQuoteclose = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMactivitypointer activityidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), IList<MicrosoftDynamicsCRMactivityparty> quotecloseActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMcampaignresponse> campaignResponseQuoteCloses = default(IList<MicrosoftDynamicsCRMcampaignresponse>), IList<MicrosoftDynamicsCRMsyncerror> quoteCloseSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> quoteCloseAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> quotecloseMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> quoteCloseBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> quoteclosePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMannotation> quoteCloseAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), MicrosoftDynamicsCRMquote quoteid = default(MicrosoftDynamicsCRMquote))
        {
            Category = category;
            this._quoteidValue = _quoteidValue;
            Importsequencenumber = importsequencenumber;
            Quotenumber = quotenumber;
            Subcategory = subcategory;
            Overriddencreatedon = overriddencreatedon;
            Revision = revision;
            RegardingobjectidNewInteractionforemailQuoteclose = regardingobjectidNewInteractionforemailQuoteclose;
            RegardingobjectidKnowledgebaserecordQuoteclose = regardingobjectidKnowledgebaserecordQuoteclose;
            RegardingobjectidLeadQuoteclose = regardingobjectidLeadQuoteclose;
            RegardingobjectidBookableresourcebookingQuoteclose = regardingobjectidBookableresourcebookingQuoteclose;
            RegardingobjectidBookableresourcebookingheaderQuoteclose = regardingobjectidBookableresourcebookingheaderQuoteclose;
            RegardingobjectidBulkoperationQuoteclose = regardingobjectidBulkoperationQuoteclose;
            RegardingobjectidCampaignQuoteclose = regardingobjectidCampaignQuoteclose;
            RegardingobjectidCampaignactivityQuoteclose = regardingobjectidCampaignactivityQuoteclose;
            RegardingobjectidEntitlementQuoteclose = regardingobjectidEntitlementQuoteclose;
            RegardingobjectidEntitlementtemplateQuoteclose = regardingobjectidEntitlementtemplateQuoteclose;
            RegardingobjectidIncidentQuoteclose = regardingobjectidIncidentQuoteclose;
            RegardingobjectidSiteQuoteclose = regardingobjectidSiteQuoteclose;
            ServiceidQuoteclose = serviceidQuoteclose;
            RegardingobjectidOpportunityQuoteclose = regardingobjectidOpportunityQuoteclose;
            RegardingobjectidQuoteQuoteclose = regardingobjectidQuoteQuoteclose;
            RegardingobjectidAccountQuoteclose = regardingobjectidAccountQuoteclose;
            CreatedbyQuoteclose = createdbyQuoteclose;
            SendermailboxidQuoteclose = sendermailboxidQuoteclose;
            TransactioncurrencyidQuoteclose = transactioncurrencyidQuoteclose;
            OwneridQuoteclose = owneridQuoteclose;
            OwninguserQuoteclose = owninguserQuoteclose;
            SlaActivitypointerSlaQuoteclose = slaActivitypointerSlaQuoteclose;
            OwningbusinessunitQuoteclose = owningbusinessunitQuoteclose;
            RegardingobjectidKnowledgearticleQuoteclose = regardingobjectidKnowledgearticleQuoteclose;
            ModifiedonbehalfbyQuoteclose = modifiedonbehalfbyQuoteclose;
            CreatedonbehalfbyQuoteclose = createdonbehalfbyQuoteclose;
            ModifiedbyQuoteclose = modifiedbyQuoteclose;
            OwningteamQuoteclose = owningteamQuoteclose;
            SlainvokedidActivitypointerSlaQuoteclose = slainvokedidActivitypointerSlaQuoteclose;
            ActivityidActivitypointer = activityidActivitypointer;
            QuotecloseActivityParties = quotecloseActivityParties;
            CampaignResponseQuoteCloses = campaignResponseQuoteCloses;
            QuoteCloseSyncErrors = quoteCloseSyncErrors;
            QuoteCloseAsyncOperations = quoteCloseAsyncOperations;
            QuotecloseMailboxTrackingFolders = quotecloseMailboxTrackingFolders;
            QuoteCloseBulkDeleteFailures = quoteCloseBulkDeleteFailures;
            QuoteclosePrincipalObjectAttributeAccesses = quoteclosePrincipalObjectAttributeAccesses;
            QuoteCloseAnnotation = quoteCloseAnnotation;
            Quoteid = quoteid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_quoteid_value")]
        public string _quoteidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quotenumber")]
        public string Quotenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subcategory")]
        public string Subcategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "revision")]
        public int? Revision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_new_interactionforemail_quoteclose")]
        public MicrosoftDynamicsCRMinteractionforemail RegardingobjectidNewInteractionforemailQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgebaserecord_quoteclose")]
        public MicrosoftDynamicsCRMknowledgebaserecord RegardingobjectidKnowledgebaserecordQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_lead_quoteclose")]
        public MicrosoftDynamicsCRMlead RegardingobjectidLeadQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebooking_quoteclose")]
        public MicrosoftDynamicsCRMbookableresourcebooking RegardingobjectidBookableresourcebookingQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebookingheader_quoteclose")]
        public MicrosoftDynamicsCRMbookableresourcebookingheader RegardingobjectidBookableresourcebookingheaderQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bulkoperation_quoteclose")]
        public MicrosoftDynamicsCRMbulkoperation RegardingobjectidBulkoperationQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaign_quoteclose")]
        public MicrosoftDynamicsCRMcampaign RegardingobjectidCampaignQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaignactivity_quoteclose")]
        public MicrosoftDynamicsCRMcampaignactivity RegardingobjectidCampaignactivityQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlement_quoteclose")]
        public MicrosoftDynamicsCRMentitlement RegardingobjectidEntitlementQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlementtemplate_quoteclose")]
        public MicrosoftDynamicsCRMentitlementtemplate RegardingobjectidEntitlementtemplateQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_incident_quoteclose")]
        public MicrosoftDynamicsCRMincident RegardingobjectidIncidentQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_site_quoteclose")]
        public MicrosoftDynamicsCRMsite RegardingobjectidSiteQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceid_quoteclose")]
        public MicrosoftDynamicsCRMservice ServiceidQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_opportunity_quoteclose")]
        public MicrosoftDynamicsCRMopportunity RegardingobjectidOpportunityQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_quote_quoteclose")]
        public MicrosoftDynamicsCRMquote RegardingobjectidQuoteQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account_quoteclose")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccountQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby_quoteclose")]
        public MicrosoftDynamicsCRMsystemuser CreatedbyQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sendermailboxid_quoteclose")]
        public MicrosoftDynamicsCRMmailbox SendermailboxidQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid_quoteclose")]
        public MicrosoftDynamicsCRMtransactioncurrency TransactioncurrencyidQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid_quoteclose")]
        public MicrosoftDynamicsCRMprincipal OwneridQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser_quoteclose")]
        public MicrosoftDynamicsCRMsystemuser OwninguserQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_activitypointer_sla_quoteclose")]
        public MicrosoftDynamicsCRMsla SlaActivitypointerSlaQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit_quoteclose")]
        public MicrosoftDynamicsCRMbusinessunit OwningbusinessunitQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgearticle_quoteclose")]
        public MicrosoftDynamicsCRMknowledgearticle RegardingobjectidKnowledgearticleQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby_quoteclose")]
        public MicrosoftDynamicsCRMsystemuser ModifiedonbehalfbyQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby_quoteclose")]
        public MicrosoftDynamicsCRMsystemuser CreatedonbehalfbyQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby_quoteclose")]
        public MicrosoftDynamicsCRMsystemuser ModifiedbyQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam_quoteclose")]
        public MicrosoftDynamicsCRMteam OwningteamQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slainvokedid_activitypointer_sla_quoteclose")]
        public MicrosoftDynamicsCRMsla SlainvokedidActivitypointerSlaQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quoteclose_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> QuotecloseActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignResponse_QuoteCloses")]
        public IList<MicrosoftDynamicsCRMcampaignresponse> CampaignResponseQuoteCloses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuoteClose_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> QuoteCloseSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuoteClose_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> QuoteCloseAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quoteclose_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> QuotecloseMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuoteClose_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> QuoteCloseBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quoteclose_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> QuoteclosePrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuoteClose_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> QuoteCloseAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quoteid")]
        public MicrosoftDynamicsCRMquote Quoteid { get; set; }

    }
}
