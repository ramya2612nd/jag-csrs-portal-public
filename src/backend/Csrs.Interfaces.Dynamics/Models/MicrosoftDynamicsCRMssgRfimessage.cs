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
    /// Microsoft.Dynamics.CRM.ssg_rfimessage
    /// </summary>
    public partial class MicrosoftDynamicsCRMssgRfimessage
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMssgRfimessage
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMssgRfimessage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMssgRfimessage
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMssgRfimessage(string ssgName = default(string), int? importsequencenumber = default(int?), string _owneridValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _createdbyValue = default(string), int? statuscode = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _owninguserValue = default(string), string _modifiedonbehalfbyValue = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string versionnumber = default(string), string _owningteamValue = default(string), string _ssgEmailmessageValue = default(string), string _createdonbehalfbyValue = default(string), string _ssgSearchrequestValue = default(string), string _ssgRfiidValue = default(string), string ssgRfimessageid = default(string), int? statecode = default(int?), int? timezoneruleversionnumber = default(int?), int? utcconversiontimezonecode = default(int?), string ssgNotewithattachmentguid = default(string), string _ssgContactcreatedtosendemailValue = default(string), string _owningbusinessunitValue = default(string), string ssgRecipient = default(string), int? ssgChannel = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> ssgRfimessageSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgRfimessageDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgRfimessageDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> ssgRfimessageAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ssgRfimessageMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> ssgRfimessageProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> ssgRfimessageBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ssgRfimessagePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMssgRfimessageevents> ssgSsgRfimessageSsgRfimessageeventsRFIMessage = default(IList<MicrosoftDynamicsCRMssgRfimessageevents>), MicrosoftDynamicsCRMssgRequestforinformationletter ssgRFIId = default(MicrosoftDynamicsCRMssgRequestforinformationletter), IList<MicrosoftDynamicsCRMemail> ssgSsgRfimessageEmailRFIMessage = default(IList<MicrosoftDynamicsCRMemail>), MicrosoftDynamicsCRMcontact ssgContactCreatedToSendEmail = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMemail ssgEmailMessage = default(MicrosoftDynamicsCRMemail), MicrosoftDynamicsCRMssgSearchrequest ssgSearchRequest = default(MicrosoftDynamicsCRMssgSearchrequest))
        {
            SsgName = ssgName;
            Importsequencenumber = importsequencenumber;
            this._owneridValue = _owneridValue;
            Modifiedon = modifiedon;
            this._createdbyValue = _createdbyValue;
            Statuscode = statuscode;
            Overriddencreatedon = overriddencreatedon;
            this._owninguserValue = _owninguserValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            Createdon = createdon;
            Versionnumber = versionnumber;
            this._owningteamValue = _owningteamValue;
            this._ssgEmailmessageValue = _ssgEmailmessageValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._ssgSearchrequestValue = _ssgSearchrequestValue;
            this._ssgRfiidValue = _ssgRfiidValue;
            SsgRfimessageid = ssgRfimessageid;
            Statecode = statecode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            SsgNotewithattachmentguid = ssgNotewithattachmentguid;
            this._ssgContactcreatedtosendemailValue = _ssgContactcreatedtosendemailValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            SsgRecipient = ssgRecipient;
            SsgChannel = ssgChannel;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            SsgRfimessageSyncErrors = ssgRfimessageSyncErrors;
            SsgRfimessageDuplicateMatchingRecord = ssgRfimessageDuplicateMatchingRecord;
            SsgRfimessageDuplicateBaseRecord = ssgRfimessageDuplicateBaseRecord;
            SsgRfimessageAsyncOperations = ssgRfimessageAsyncOperations;
            SsgRfimessageMailboxTrackingFolders = ssgRfimessageMailboxTrackingFolders;
            SsgRfimessageProcessSession = ssgRfimessageProcessSession;
            SsgRfimessageBulkDeleteFailures = ssgRfimessageBulkDeleteFailures;
            SsgRfimessagePrincipalObjectAttributeAccesses = ssgRfimessagePrincipalObjectAttributeAccesses;
            SsgSsgRfimessageSsgRfimessageeventsRFIMessage = ssgSsgRfimessageSsgRfimessageeventsRFIMessage;
            SsgRFIId = ssgRFIId;
            SsgSsgRfimessageEmailRFIMessage = ssgSsgRfimessageEmailRFIMessage;
            SsgContactCreatedToSendEmail = ssgContactCreatedToSendEmail;
            SsgEmailMessage = ssgEmailMessage;
            SsgSearchRequest = ssgSearchRequest;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_name")]
        public string SsgName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_emailmessage_value")]
        public string _ssgEmailmessageValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_searchrequest_value")]
        public string _ssgSearchrequestValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_rfiid_value")]
        public string _ssgRfiidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_rfimessageid")]
        public string SsgRfimessageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_notewithattachmentguid")]
        public string SsgNotewithattachmentguid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_contactcreatedtosendemail_value")]
        public string _ssgContactcreatedtosendemailValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_recipient")]
        public string SsgRecipient { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_channel")]
        public int? SsgChannel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_rfimessage_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SsgRfimessageSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_rfimessage_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgRfimessageDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_rfimessage_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgRfimessageDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_rfimessage_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SsgRfimessageAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_rfimessage_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> SsgRfimessageMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_rfimessage_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> SsgRfimessageProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_rfimessage_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SsgRfimessageBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_rfimessage_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> SsgRfimessagePrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_rfimessage_ssg_rfimessageevents_RFIMessage")]
        public IList<MicrosoftDynamicsCRMssgRfimessageevents> SsgSsgRfimessageSsgRfimessageeventsRFIMessage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_RFIId")]
        public MicrosoftDynamicsCRMssgRequestforinformationletter SsgRFIId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_rfimessage_email_RFIMessage")]
        public IList<MicrosoftDynamicsCRMemail> SsgSsgRfimessageEmailRFIMessage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ContactCreatedToSendEmail")]
        public MicrosoftDynamicsCRMcontact SsgContactCreatedToSendEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_EmailMessage")]
        public MicrosoftDynamicsCRMemail SsgEmailMessage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_SearchRequest")]
        public MicrosoftDynamicsCRMssgSearchrequest SsgSearchRequest { get; set; }

    }
}
