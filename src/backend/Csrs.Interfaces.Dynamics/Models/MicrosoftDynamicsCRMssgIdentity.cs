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
    /// Microsoft.Dynamics.CRM.ssg_identity
    /// </summary>
    public partial class MicrosoftDynamicsCRMssgIdentity
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMssgIdentity
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMssgIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMssgIdentity
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMssgIdentity(string _ssgResponsedatasummaryValue = default(string), System.DateTimeOffset? ssgDatadate2 = default(System.DateTimeOffset?), bool? ssgCouldnotlocate = default(bool?), int? statuscode = default(int?), string _ssgResponseidValue = default(string), bool? ssgCpcommentupdated = default(bool?), bool? ssgAddtocp = default(bool?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string ssgAddedtoresponseindicator = default(string), string ssgPersongivenname = default(string), string ssgSupplierrelationtype = default(string), bool? ssgRespcommentupdated = default(bool?), string _ssgNotetemplateValue = default(string), int? utcconversiontimezonecode = default(int?), string _ssgCopycptosrValue = default(string), bool? ssgUpdatedbyagency = default(bool?), string _ssgConfirmedprofileValue = default(string), bool? ssgCopycpcomment = default(bool?), string ssgMothersmaidenname = default(string), int? ssgSuppliedbyuser = default(int?), string ssgSuppliedbytext = default(string), string ssgResponsecomment = default(string), string ssgFiletext = default(string), string ssgDatadatelabel2 = default(string), string ssgAddressline3 = default(string), string _createdbyValue = default(string), string ssgCasenumber = default(string), string ssgPostalcode = default(string), string _owningteamValue = default(string), string ssgCountry = default(string), string ssgProvince = default(string), string ssgAddressline2 = default(string), int? ssgPersonrelationshipcategorytext = default(int?), string _owninguserValue = default(string), System.DateTimeOffset? ssgDatadate = default(System.DateTimeOffset?), int? ssgRecipientorpayor = default(int?), string ssgDescription = default(string), string ssgPersonsurname = default(string), string versionnumber = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? ssgPersondateofbirth = default(System.DateTimeOffset?), string ssgNotes = default(string), string ssgFams2personid = default(string), string _modifiedonbehalfbyValue = default(string), string ssgRelationshipdescription = default(string), string ssgConfirmcomment = default(string), System.DateTimeOffset? ssgPersonbirthdate = default(System.DateTimeOffset?), string ssgIdentityid = default(string), string ssgDatadatelabel = default(string), string _owningbusinessunitValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), int? ssgDatastatus = default(int?), int? timezoneruleversionnumber = default(int?), string _ssgPersonidValue = default(string), string ssgAddressfulltext = default(string), int? importsequencenumber = default(int?), int? ssgPersonsextext = default(int?), int? statecode = default(int?), string ssgPersonthirdgivenname = default(string), string ssgPersonname = default(string), bool? ssgAddtoresponse = default(bool?), string ssgAgencyupdatedescription = default(string), string ssgCity = default(string), System.DateTimeOffset? ssgPersondeathdate = default(System.DateTimeOffset?), int? ssgInformationsourcetext = default(int?), System.DateTimeOffset? ssgAddedtoconfirmedprofileon = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), int? ssgPersoncategorytext = default(int?), string _owneridValue = default(string), string ssgName = default(string), string ssgAddressline1 = default(string), bool? ssgCreatedbyagency = default(bool?), string _ssgSearchrequestValue = default(string), string ssgPersonmiddlename = default(string), string ssgAddedtocpbyuser = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> ssgIdentitySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgIdentityDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgIdentityDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> ssgIdentityAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ssgIdentityMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> ssgIdentityProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> ssgIdentityBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ssgIdentityPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMssgSearchrequest ssgSearchRequest = default(MicrosoftDynamicsCRMssgSearchrequest), MicrosoftDynamicsCRMssgPerson ssgPersonId = default(MicrosoftDynamicsCRMssgPerson), MicrosoftDynamicsCRMssgSearchrequestresponse ssgResponseId = default(MicrosoftDynamicsCRMssgSearchrequestresponse), MicrosoftDynamicsCRMssgNotestemplates ssgNoteTemplate = default(MicrosoftDynamicsCRMssgNotestemplates), IList<MicrosoftDynamicsCRMssgSearchrequestresulttransaction> ssgRelatedpersonResulttransaction = default(IList<MicrosoftDynamicsCRMssgSearchrequestresulttransaction>), MicrosoftDynamicsCRMssgConfirmedprofile ssgConfirmedProfile = default(MicrosoftDynamicsCRMssgConfirmedprofile), MicrosoftDynamicsCRMssgCopysearchrequesttoconfirmedprofilehold ssgCopyCPToSR = default(MicrosoftDynamicsCRMssgCopysearchrequesttoconfirmedprofilehold), MicrosoftDynamicsCRMssgResponsedatasummary ssgResponseDataSummary = default(MicrosoftDynamicsCRMssgResponsedatasummary), IList<MicrosoftDynamicsCRMssgRequestforinformationletter> ssgSsgIdentitySsgRequestforinformationletterTemplateEntityIdentity = default(IList<MicrosoftDynamicsCRMssgRequestforinformationletter>))
        {
            this._ssgResponsedatasummaryValue = _ssgResponsedatasummaryValue;
            SsgDatadate2 = ssgDatadate2;
            SsgCouldnotlocate = ssgCouldnotlocate;
            Statuscode = statuscode;
            this._ssgResponseidValue = _ssgResponseidValue;
            SsgCpcommentupdated = ssgCpcommentupdated;
            SsgAddtocp = ssgAddtocp;
            Overriddencreatedon = overriddencreatedon;
            SsgAddedtoresponseindicator = ssgAddedtoresponseindicator;
            SsgPersongivenname = ssgPersongivenname;
            SsgSupplierrelationtype = ssgSupplierrelationtype;
            SsgRespcommentupdated = ssgRespcommentupdated;
            this._ssgNotetemplateValue = _ssgNotetemplateValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._ssgCopycptosrValue = _ssgCopycptosrValue;
            SsgUpdatedbyagency = ssgUpdatedbyagency;
            this._ssgConfirmedprofileValue = _ssgConfirmedprofileValue;
            SsgCopycpcomment = ssgCopycpcomment;
            SsgMothersmaidenname = ssgMothersmaidenname;
            SsgSuppliedbyuser = ssgSuppliedbyuser;
            SsgSuppliedbytext = ssgSuppliedbytext;
            SsgResponsecomment = ssgResponsecomment;
            SsgFiletext = ssgFiletext;
            SsgDatadatelabel2 = ssgDatadatelabel2;
            SsgAddressline3 = ssgAddressline3;
            this._createdbyValue = _createdbyValue;
            SsgCasenumber = ssgCasenumber;
            SsgPostalcode = ssgPostalcode;
            this._owningteamValue = _owningteamValue;
            SsgCountry = ssgCountry;
            SsgProvince = ssgProvince;
            SsgAddressline2 = ssgAddressline2;
            SsgPersonrelationshipcategorytext = ssgPersonrelationshipcategorytext;
            this._owninguserValue = _owninguserValue;
            SsgDatadate = ssgDatadate;
            SsgRecipientorpayor = ssgRecipientorpayor;
            SsgDescription = ssgDescription;
            SsgPersonsurname = ssgPersonsurname;
            Versionnumber = versionnumber;
            Modifiedon = modifiedon;
            SsgPersondateofbirth = ssgPersondateofbirth;
            SsgNotes = ssgNotes;
            SsgFams2personid = ssgFams2personid;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            SsgRelationshipdescription = ssgRelationshipdescription;
            SsgConfirmcomment = ssgConfirmcomment;
            SsgPersonbirthdate = ssgPersonbirthdate;
            SsgIdentityid = ssgIdentityid;
            SsgDatadatelabel = ssgDatadatelabel;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Createdon = createdon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            SsgDatastatus = ssgDatastatus;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._ssgPersonidValue = _ssgPersonidValue;
            SsgAddressfulltext = ssgAddressfulltext;
            Importsequencenumber = importsequencenumber;
            SsgPersonsextext = ssgPersonsextext;
            Statecode = statecode;
            SsgPersonthirdgivenname = ssgPersonthirdgivenname;
            SsgPersonname = ssgPersonname;
            SsgAddtoresponse = ssgAddtoresponse;
            SsgAgencyupdatedescription = ssgAgencyupdatedescription;
            SsgCity = ssgCity;
            SsgPersondeathdate = ssgPersondeathdate;
            SsgInformationsourcetext = ssgInformationsourcetext;
            SsgAddedtoconfirmedprofileon = ssgAddedtoconfirmedprofileon;
            this._modifiedbyValue = _modifiedbyValue;
            SsgPersoncategorytext = ssgPersoncategorytext;
            this._owneridValue = _owneridValue;
            SsgName = ssgName;
            SsgAddressline1 = ssgAddressline1;
            SsgCreatedbyagency = ssgCreatedbyagency;
            this._ssgSearchrequestValue = _ssgSearchrequestValue;
            SsgPersonmiddlename = ssgPersonmiddlename;
            SsgAddedtocpbyuser = ssgAddedtocpbyuser;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            SsgIdentitySyncErrors = ssgIdentitySyncErrors;
            SsgIdentityDuplicateMatchingRecord = ssgIdentityDuplicateMatchingRecord;
            SsgIdentityDuplicateBaseRecord = ssgIdentityDuplicateBaseRecord;
            SsgIdentityAsyncOperations = ssgIdentityAsyncOperations;
            SsgIdentityMailboxTrackingFolders = ssgIdentityMailboxTrackingFolders;
            SsgIdentityProcessSession = ssgIdentityProcessSession;
            SsgIdentityBulkDeleteFailures = ssgIdentityBulkDeleteFailures;
            SsgIdentityPrincipalObjectAttributeAccesses = ssgIdentityPrincipalObjectAttributeAccesses;
            SsgSearchRequest = ssgSearchRequest;
            SsgPersonId = ssgPersonId;
            SsgResponseId = ssgResponseId;
            SsgNoteTemplate = ssgNoteTemplate;
            SsgRelatedpersonResulttransaction = ssgRelatedpersonResulttransaction;
            SsgConfirmedProfile = ssgConfirmedProfile;
            SsgCopyCPToSR = ssgCopyCPToSR;
            SsgResponseDataSummary = ssgResponseDataSummary;
            SsgSsgIdentitySsgRequestforinformationletterTemplateEntityIdentity = ssgSsgIdentitySsgRequestforinformationletterTemplateEntityIdentity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_responsedatasummary_value")]
        public string _ssgResponsedatasummaryValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datadate2")]
        public System.DateTimeOffset? SsgDatadate2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_couldnotlocate")]
        public bool? SsgCouldnotlocate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_responseid_value")]
        public string _ssgResponseidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_cpcommentupdated")]
        public bool? SsgCpcommentupdated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addtocp")]
        public bool? SsgAddtocp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addedtoresponseindicator")]
        public string SsgAddedtoresponseindicator { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_persongivenname")]
        public string SsgPersongivenname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_supplierrelationtype")]
        public string SsgSupplierrelationtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_respcommentupdated")]
        public bool? SsgRespcommentupdated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_notetemplate_value")]
        public string _ssgNotetemplateValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_copycptosr_value")]
        public string _ssgCopycptosrValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_updatedbyagency")]
        public bool? SsgUpdatedbyagency { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_confirmedprofile_value")]
        public string _ssgConfirmedprofileValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_copycpcomment")]
        public bool? SsgCopycpcomment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_mothersmaidenname")]
        public string SsgMothersmaidenname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_suppliedbyuser")]
        public int? SsgSuppliedbyuser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_suppliedbytext")]
        public string SsgSuppliedbytext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_responsecomment")]
        public string SsgResponsecomment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_filetext")]
        public string SsgFiletext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datadatelabel2")]
        public string SsgDatadatelabel2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addressline3")]
        public string SsgAddressline3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_casenumber")]
        public string SsgCasenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_postalcode")]
        public string SsgPostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_country")]
        public string SsgCountry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_province")]
        public string SsgProvince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addressline2")]
        public string SsgAddressline2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_personrelationshipcategorytext")]
        public int? SsgPersonrelationshipcategorytext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datadate")]
        public System.DateTimeOffset? SsgDatadate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_recipientorpayor")]
        public int? SsgRecipientorpayor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_description")]
        public string SsgDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_personsurname")]
        public string SsgPersonsurname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_persondateofbirth")]
        public System.DateTimeOffset? SsgPersondateofbirth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_notes")]
        public string SsgNotes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_fams2personid")]
        public string SsgFams2personid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_relationshipdescription")]
        public string SsgRelationshipdescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_confirmcomment")]
        public string SsgConfirmcomment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_personbirthdate")]
        public System.DateTimeOffset? SsgPersonbirthdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_identityid")]
        public string SsgIdentityid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datadatelabel")]
        public string SsgDatadatelabel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datastatus")]
        public int? SsgDatastatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_personid_value")]
        public string _ssgPersonidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addressfulltext")]
        public string SsgAddressfulltext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_personsextext")]
        public int? SsgPersonsextext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_personthirdgivenname")]
        public string SsgPersonthirdgivenname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_personname")]
        public string SsgPersonname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addtoresponse")]
        public bool? SsgAddtoresponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_agencyupdatedescription")]
        public string SsgAgencyupdatedescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_city")]
        public string SsgCity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_persondeathdate")]
        public System.DateTimeOffset? SsgPersondeathdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_informationsourcetext")]
        public int? SsgInformationsourcetext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addedtoconfirmedprofileon")]
        public System.DateTimeOffset? SsgAddedtoconfirmedprofileon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_personcategorytext")]
        public int? SsgPersoncategorytext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_name")]
        public string SsgName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addressline1")]
        public string SsgAddressline1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_createdbyagency")]
        public bool? SsgCreatedbyagency { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_searchrequest_value")]
        public string _ssgSearchrequestValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_personmiddlename")]
        public string SsgPersonmiddlename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addedtocpbyuser")]
        public string SsgAddedtocpbyuser { get; set; }

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
        [JsonProperty(PropertyName = "ssg_identity_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SsgIdentitySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_identity_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgIdentityDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_identity_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgIdentityDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_identity_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SsgIdentityAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_identity_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> SsgIdentityMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_identity_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> SsgIdentityProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_identity_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SsgIdentityBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_identity_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> SsgIdentityPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_SearchRequest")]
        public MicrosoftDynamicsCRMssgSearchrequest SsgSearchRequest { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_PersonId")]
        public MicrosoftDynamicsCRMssgPerson SsgPersonId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ResponseId")]
        public MicrosoftDynamicsCRMssgSearchrequestresponse SsgResponseId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_NoteTemplate")]
        public MicrosoftDynamicsCRMssgNotestemplates SsgNoteTemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_relatedperson___resulttransaction")]
        public IList<MicrosoftDynamicsCRMssgSearchrequestresulttransaction> SsgRelatedpersonResulttransaction { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ConfirmedProfile")]
        public MicrosoftDynamicsCRMssgConfirmedprofile SsgConfirmedProfile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_CopyCPToSR")]
        public MicrosoftDynamicsCRMssgCopysearchrequesttoconfirmedprofilehold SsgCopyCPToSR { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ResponseDataSummary")]
        public MicrosoftDynamicsCRMssgResponsedatasummary SsgResponseDataSummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_identity_ssg_requestforinformationletter_TemplateEntity_Identity")]
        public IList<MicrosoftDynamicsCRMssgRequestforinformationletter> SsgSsgIdentitySsgRequestforinformationletterTemplateEntityIdentity { get; set; }

    }
}