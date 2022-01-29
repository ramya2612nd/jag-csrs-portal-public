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
    /// Microsoft.Dynamics.CRM.ssg_csrsfile
    /// </summary>
    public partial class MicrosoftDynamicsCRMssgCsrsfile
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMssgCsrsfile
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMssgCsrsfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMssgCsrsfile
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMssgCsrsfile(bool? ssgSection7expensesrecalculated = default(bool?), string ssgCourtfilenumber = default(string), string ssgStyleofcauserespondent = default(string), System.DateTimeOffset? ssgDateoforderorwa = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), string _owneridValue = default(string), decimal? ssgIncomeonorderBase = default(decimal?), System.DateTimeOffset? ssgTerminationdate = default(System.DateTimeOffset?), bool? ssgSplitparentingarrangement = default(bool?), decimal? ssgRecipientsincomeonorderBase = default(decimal?), string _ssgDuplicatedfilenumberValue = default(string), int? ssgSection7recipientsproportion = default(int?), System.DateTimeOffset? ssgDateordercommences = default(System.DateTimeOffset?), decimal? ssgSection7payorsamountBase = default(decimal?), string ssgStyleofcauseapplicant = default(string), string ssgAutonumber = default(string), decimal? ssgSection7totalamount = default(decimal?), string ssgPayorssafetyconcerndescription = default(string), System.DateTimeOffset? ssgSubmissiondate = default(System.DateTimeOffset?), int? ssgSection7expenses = default(int?), decimal? ssgOffsetchildsupportamountonorderBase = default(decimal?), bool? ssgSafetyalert = default(bool?), int? ssgAct = default(int?), string ssgFmepfilenumber = default(string), int? importsequencenumber = default(int?), string _owninguserValue = default(string), int? utcconversiontimezonecode = default(int?), string _modifiedbyValue = default(string), string _transactioncurrencyidValue = default(string), int? ssgFileclosedatenrollment = default(int?), int? ssgCourtfiletype = default(int?), string ssgDaysofmonthpayable = default(string), string ssgCsrsfileid = default(string), bool? ssgSharedparenting = default(bool?), decimal? ssgRecipientschildsupportonorder = default(decimal?), decimal? ssgChildsupportonorderBase = default(decimal?), int? ssgFilealreadyexists = default(int?), int? timezoneruleversionnumber = default(int?), decimal? ssgOffsetchildsupportamountonorder = default(decimal?), decimal? ssgIncomeonorder = default(decimal?), bool? ssgSafetyalertpayor = default(bool?), string _ssgPayorValue = default(string), bool? ssgRecalculationorderedbythecourt = default(bool?), int? ssgNumberofrecalculations = default(int?), string ssgCourtlocation = default(string), string ssgSafetyconcerndescription = default(string), string versionnumber = default(string), decimal? ssgRecipientschildsupportonorderBase = default(decimal?), string _modifiedonbehalfbyValue = default(string), decimal? ssgSection7recipientsamountBase = default(decimal?), decimal? ssgSection7payorsamount = default(decimal?), decimal? ssgChildsupportonorder = default(decimal?), string _ssgLatestduplicatefileValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), bool? ssgFmepfileactive = default(bool?), bool? ssgRecipientsincomeneeded = default(bool?), string _ssgRecipientValue = default(string), string ssgFilenumber = default(string), System.DateTimeOffset? ssgSpecialexpenseswithdrawndate = default(System.DateTimeOffset?), System.DateTimeOffset? ssgRegistrationdate = default(System.DateTimeOffset?), string _createdbyValue = default(string), int? statuscode = default(int?), string _ssgBccourtlocationValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _ssgBccourtlevelValue = default(string), decimal? ssgSection7recipientsamount = default(decimal?), string _owningbusinessunitValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? statecode = default(int?), string _owningteamValue = default(string), int? ssgSection7payorsproportion = default(int?), decimal? exchangerate = default(decimal?), decimal? ssgSection7totalamountBase = default(decimal?), int? ssgPartyenrolled = default(int?), decimal? ssgRecipientsincomeonorder = default(decimal?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMactivitypointer> ssgCsrsfileActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMsyncerror> ssgCsrsfileSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgCsrsfileDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgCsrsfileDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMsharepointdocumentlocation> ssgCsrsfileSharePointDocumentLocations = default(IList<MicrosoftDynamicsCRMsharepointdocumentlocation>), IList<MicrosoftDynamicsCRMasyncoperation> ssgCsrsfileAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ssgCsrsfileMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> ssgCsrsfileProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> ssgCsrsfileBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ssgCsrsfilePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMappointment> ssgCsrsfileAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> ssgCsrsfileEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> ssgCsrsfileFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> ssgCsrsfileLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> ssgCsrsfilePhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMtask> ssgCsrsfileTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> ssgCsrsfileRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> ssgCsrsfileSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMannotation> ssgCsrsfileAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMserviceappointment> ssgCsrsfileServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMssgCsrschild> ssgCsrsfileSsgCsrschildChildsFileNumber = default(IList<MicrosoftDynamicsCRMssgCsrschild>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMssgCsrsparty ssgRecipient = default(MicrosoftDynamicsCRMssgCsrsparty), MicrosoftDynamicsCRMssgCsrsparty ssgPayor = default(MicrosoftDynamicsCRMssgCsrsparty), IList<MicrosoftDynamicsCRMssgCsrsrecalculation> ssgCsrsfileSsgCsrsrecalculationFileNumber = default(IList<MicrosoftDynamicsCRMssgCsrsrecalculation>), IList<MicrosoftDynamicsCRMssgCsrsarchivedcourtfile> ssgCsrsfileSsgCsrsarchivedcourtfileFileNumber = default(IList<MicrosoftDynamicsCRMssgCsrsarchivedcourtfile>), IList<MicrosoftDynamicsCRMafkWorkflowtask> ssgCsrsfileAfkWorkflowtasks = default(IList<MicrosoftDynamicsCRMafkWorkflowtask>), MicrosoftDynamicsCRMssgIjssbccourtlocation ssgBCCourtLocation = default(MicrosoftDynamicsCRMssgIjssbccourtlocation), MicrosoftDynamicsCRMssgCsrsbccourtlevel ssgBCCourtLevel = default(MicrosoftDynamicsCRMssgCsrsbccourtlevel), MicrosoftDynamicsCRMssgCsrsfile ssgDuplicatedFileNumber = default(MicrosoftDynamicsCRMssgCsrsfile), IList<MicrosoftDynamicsCRMssgCsrsfile> ssgCsrsfileSsgCsrsfileMasterFileRecord = default(IList<MicrosoftDynamicsCRMssgCsrsfile>), MicrosoftDynamicsCRMssgCsrsfile ssgLatestDuplicateFile = default(MicrosoftDynamicsCRMssgCsrsfile), IList<MicrosoftDynamicsCRMssgCsrsfile> ssgCsrsfileSsgCsrsfileLatestDuplicateFile = default(IList<MicrosoftDynamicsCRMssgCsrsfile>), IList<MicrosoftDynamicsCRMssgCsrscommunicationmessage> ssgSsgCsrsfileSsgCsrscommunicationmessageFile = default(IList<MicrosoftDynamicsCRMssgCsrscommunicationmessage>))
        {
            SsgSection7expensesrecalculated = ssgSection7expensesrecalculated;
            SsgCourtfilenumber = ssgCourtfilenumber;
            SsgStyleofcauserespondent = ssgStyleofcauserespondent;
            SsgDateoforderorwa = ssgDateoforderorwa;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._owneridValue = _owneridValue;
            SsgIncomeonorderBase = ssgIncomeonorderBase;
            SsgTerminationdate = ssgTerminationdate;
            SsgSplitparentingarrangement = ssgSplitparentingarrangement;
            SsgRecipientsincomeonorderBase = ssgRecipientsincomeonorderBase;
            this._ssgDuplicatedfilenumberValue = _ssgDuplicatedfilenumberValue;
            SsgSection7recipientsproportion = ssgSection7recipientsproportion;
            SsgDateordercommences = ssgDateordercommences;
            SsgSection7payorsamountBase = ssgSection7payorsamountBase;
            SsgStyleofcauseapplicant = ssgStyleofcauseapplicant;
            SsgAutonumber = ssgAutonumber;
            SsgSection7totalamount = ssgSection7totalamount;
            SsgPayorssafetyconcerndescription = ssgPayorssafetyconcerndescription;
            SsgSubmissiondate = ssgSubmissiondate;
            SsgSection7expenses = ssgSection7expenses;
            SsgOffsetchildsupportamountonorderBase = ssgOffsetchildsupportamountonorderBase;
            SsgSafetyalert = ssgSafetyalert;
            SsgAct = ssgAct;
            SsgFmepfilenumber = ssgFmepfilenumber;
            Importsequencenumber = importsequencenumber;
            this._owninguserValue = _owninguserValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._modifiedbyValue = _modifiedbyValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            SsgFileclosedatenrollment = ssgFileclosedatenrollment;
            SsgCourtfiletype = ssgCourtfiletype;
            SsgDaysofmonthpayable = ssgDaysofmonthpayable;
            SsgCsrsfileid = ssgCsrsfileid;
            SsgSharedparenting = ssgSharedparenting;
            SsgRecipientschildsupportonorder = ssgRecipientschildsupportonorder;
            SsgChildsupportonorderBase = ssgChildsupportonorderBase;
            SsgFilealreadyexists = ssgFilealreadyexists;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            SsgOffsetchildsupportamountonorder = ssgOffsetchildsupportamountonorder;
            SsgIncomeonorder = ssgIncomeonorder;
            SsgSafetyalertpayor = ssgSafetyalertpayor;
            this._ssgPayorValue = _ssgPayorValue;
            SsgRecalculationorderedbythecourt = ssgRecalculationorderedbythecourt;
            SsgNumberofrecalculations = ssgNumberofrecalculations;
            SsgCourtlocation = ssgCourtlocation;
            SsgSafetyconcerndescription = ssgSafetyconcerndescription;
            Versionnumber = versionnumber;
            SsgRecipientschildsupportonorderBase = ssgRecipientschildsupportonorderBase;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            SsgSection7recipientsamountBase = ssgSection7recipientsamountBase;
            SsgSection7payorsamount = ssgSection7payorsamount;
            SsgChildsupportonorder = ssgChildsupportonorder;
            this._ssgLatestduplicatefileValue = _ssgLatestduplicatefileValue;
            Createdon = createdon;
            SsgFmepfileactive = ssgFmepfileactive;
            SsgRecipientsincomeneeded = ssgRecipientsincomeneeded;
            this._ssgRecipientValue = _ssgRecipientValue;
            SsgFilenumber = ssgFilenumber;
            SsgSpecialexpenseswithdrawndate = ssgSpecialexpenseswithdrawndate;
            SsgRegistrationdate = ssgRegistrationdate;
            this._createdbyValue = _createdbyValue;
            Statuscode = statuscode;
            this._ssgBccourtlocationValue = _ssgBccourtlocationValue;
            Modifiedon = modifiedon;
            this._ssgBccourtlevelValue = _ssgBccourtlevelValue;
            SsgSection7recipientsamount = ssgSection7recipientsamount;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Overriddencreatedon = overriddencreatedon;
            Statecode = statecode;
            this._owningteamValue = _owningteamValue;
            SsgSection7payorsproportion = ssgSection7payorsproportion;
            Exchangerate = exchangerate;
            SsgSection7totalamountBase = ssgSection7totalamountBase;
            SsgPartyenrolled = ssgPartyenrolled;
            SsgRecipientsincomeonorder = ssgRecipientsincomeonorder;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            SsgCsrsfileActivityPointers = ssgCsrsfileActivityPointers;
            SsgCsrsfileSyncErrors = ssgCsrsfileSyncErrors;
            SsgCsrsfileDuplicateMatchingRecord = ssgCsrsfileDuplicateMatchingRecord;
            SsgCsrsfileDuplicateBaseRecord = ssgCsrsfileDuplicateBaseRecord;
            SsgCsrsfileSharePointDocumentLocations = ssgCsrsfileSharePointDocumentLocations;
            SsgCsrsfileAsyncOperations = ssgCsrsfileAsyncOperations;
            SsgCsrsfileMailboxTrackingFolders = ssgCsrsfileMailboxTrackingFolders;
            SsgCsrsfileProcessSession = ssgCsrsfileProcessSession;
            SsgCsrsfileBulkDeleteFailures = ssgCsrsfileBulkDeleteFailures;
            SsgCsrsfilePrincipalObjectAttributeAccesses = ssgCsrsfilePrincipalObjectAttributeAccesses;
            SsgCsrsfileAppointments = ssgCsrsfileAppointments;
            SsgCsrsfileEmails = ssgCsrsfileEmails;
            SsgCsrsfileFaxes = ssgCsrsfileFaxes;
            SsgCsrsfileLetters = ssgCsrsfileLetters;
            SsgCsrsfilePhoneCalls = ssgCsrsfilePhoneCalls;
            SsgCsrsfileTasks = ssgCsrsfileTasks;
            SsgCsrsfileRecurringAppointmentMasters = ssgCsrsfileRecurringAppointmentMasters;
            SsgCsrsfileSocialActivities = ssgCsrsfileSocialActivities;
            SsgCsrsfileAnnotations = ssgCsrsfileAnnotations;
            SsgCsrsfileServiceAppointments = ssgCsrsfileServiceAppointments;
            SsgCsrsfileSsgCsrschildChildsFileNumber = ssgCsrsfileSsgCsrschildChildsFileNumber;
            Transactioncurrencyid = transactioncurrencyid;
            SsgRecipient = ssgRecipient;
            SsgPayor = ssgPayor;
            SsgCsrsfileSsgCsrsrecalculationFileNumber = ssgCsrsfileSsgCsrsrecalculationFileNumber;
            SsgCsrsfileSsgCsrsarchivedcourtfileFileNumber = ssgCsrsfileSsgCsrsarchivedcourtfileFileNumber;
            SsgCsrsfileAfkWorkflowtasks = ssgCsrsfileAfkWorkflowtasks;
            SsgBCCourtLocation = ssgBCCourtLocation;
            SsgBCCourtLevel = ssgBCCourtLevel;
            SsgDuplicatedFileNumber = ssgDuplicatedFileNumber;
            SsgCsrsfileSsgCsrsfileMasterFileRecord = ssgCsrsfileSsgCsrsfileMasterFileRecord;
            SsgLatestDuplicateFile = ssgLatestDuplicateFile;
            SsgCsrsfileSsgCsrsfileLatestDuplicateFile = ssgCsrsfileSsgCsrsfileLatestDuplicateFile;
            SsgSsgCsrsfileSsgCsrscommunicationmessageFile = ssgSsgCsrsfileSsgCsrscommunicationmessageFile;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_section7expensesrecalculated")]
        public bool? SsgSection7expensesrecalculated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_courtfilenumber")]
        public string SsgCourtfilenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_styleofcauserespondent")]
        public string SsgStyleofcauserespondent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_dateoforderorwa")]
        public System.DateTimeOffset? SsgDateoforderorwa { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_incomeonorder_base")]
        public decimal? SsgIncomeonorderBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_terminationdate")]
        public System.DateTimeOffset? SsgTerminationdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_splitparentingarrangement")]
        public bool? SsgSplitparentingarrangement { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_recipientsincomeonorder_base")]
        public decimal? SsgRecipientsincomeonorderBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_duplicatedfilenumber_value")]
        public string _ssgDuplicatedfilenumberValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_section7recipientsproportion")]
        public int? SsgSection7recipientsproportion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_dateordercommences")]
        public System.DateTimeOffset? SsgDateordercommences { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_section7payorsamount_base")]
        public decimal? SsgSection7payorsamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_styleofcauseapplicant")]
        public string SsgStyleofcauseapplicant { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_autonumber")]
        public string SsgAutonumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_section7totalamount")]
        public decimal? SsgSection7totalamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_payorssafetyconcerndescription")]
        public string SsgPayorssafetyconcerndescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_submissiondate")]
        public System.DateTimeOffset? SsgSubmissiondate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_section7expenses")]
        public int? SsgSection7expenses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_offsetchildsupportamountonorder_base")]
        public decimal? SsgOffsetchildsupportamountonorderBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_safetyalert")]
        public bool? SsgSafetyalert { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_act")]
        public int? SsgAct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_fmepfilenumber")]
        public string SsgFmepfilenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_fileclosedatenrollment")]
        public int? SsgFileclosedatenrollment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_courtfiletype")]
        public int? SsgCourtfiletype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_daysofmonthpayable")]
        public string SsgDaysofmonthpayable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsfileid")]
        public string SsgCsrsfileid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_sharedparenting")]
        public bool? SsgSharedparenting { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_recipientschildsupportonorder")]
        public decimal? SsgRecipientschildsupportonorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_childsupportonorder_base")]
        public decimal? SsgChildsupportonorderBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_filealreadyexists")]
        public int? SsgFilealreadyexists { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_offsetchildsupportamountonorder")]
        public decimal? SsgOffsetchildsupportamountonorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_incomeonorder")]
        public decimal? SsgIncomeonorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_safetyalertpayor")]
        public bool? SsgSafetyalertpayor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_payor_value")]
        public string _ssgPayorValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_recalculationorderedbythecourt")]
        public bool? SsgRecalculationorderedbythecourt { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_numberofrecalculations")]
        public int? SsgNumberofrecalculations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_courtlocation")]
        public string SsgCourtlocation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_safetyconcerndescription")]
        public string SsgSafetyconcerndescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_recipientschildsupportonorder_base")]
        public decimal? SsgRecipientschildsupportonorderBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_section7recipientsamount_base")]
        public decimal? SsgSection7recipientsamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_section7payorsamount")]
        public decimal? SsgSection7payorsamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_childsupportonorder")]
        public decimal? SsgChildsupportonorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_latestduplicatefile_value")]
        public string _ssgLatestduplicatefileValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_fmepfileactive")]
        public bool? SsgFmepfileactive { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_recipientsincomeneeded")]
        public bool? SsgRecipientsincomeneeded { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_recipient_value")]
        public string _ssgRecipientValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_filenumber")]
        public string SsgFilenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_specialexpenseswithdrawndate")]
        public System.DateTimeOffset? SsgSpecialexpenseswithdrawndate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_registrationdate")]
        public System.DateTimeOffset? SsgRegistrationdate { get; set; }

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
        [JsonProperty(PropertyName = "_ssg_bccourtlocation_value")]
        public string _ssgBccourtlocationValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_bccourtlevel_value")]
        public string _ssgBccourtlevelValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_section7recipientsamount")]
        public decimal? SsgSection7recipientsamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_section7payorsproportion")]
        public int? SsgSection7payorsproportion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_section7totalamount_base")]
        public decimal? SsgSection7totalamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_partyenrolled")]
        public int? SsgPartyenrolled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_recipientsincomeonorder")]
        public decimal? SsgRecipientsincomeonorder { get; set; }

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
        [JsonProperty(PropertyName = "ssg_csrsfile_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> SsgCsrsfileActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsfile_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SsgCsrsfileSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsfile_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgCsrsfileDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsfile_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgCsrsfileDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsfile_SharePointDocumentLocations")]
        public IList<MicrosoftDynamicsCRMsharepointdocumentlocation> SsgCsrsfileSharePointDocumentLocations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsfile_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SsgCsrsfileAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsfile_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> SsgCsrsfileMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsfile_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> SsgCsrsfileProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsfile_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SsgCsrsfileBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsfile_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> SsgCsrsfilePrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsfile_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> SsgCsrsfileAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsfile_Emails")]
        public IList<MicrosoftDynamicsCRMemail> SsgCsrsfileEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsfile_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> SsgCsrsfileFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsfile_Letters")]
        public IList<MicrosoftDynamicsCRMletter> SsgCsrsfileLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsfile_PhoneCalls")]
        public IList<MicrosoftDynamicsCRMphonecall> SsgCsrsfilePhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsfile_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> SsgCsrsfileTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsfile_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> SsgCsrsfileRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsfile_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> SsgCsrsfileSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsfile_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> SsgCsrsfileAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsfile_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> SsgCsrsfileServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsfile_ssg_csrschild_ChildsFileNumber")]
        public IList<MicrosoftDynamicsCRMssgCsrschild> SsgCsrsfileSsgCsrschildChildsFileNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_Recipient")]
        public MicrosoftDynamicsCRMssgCsrsparty SsgRecipient { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_Payor")]
        public MicrosoftDynamicsCRMssgCsrsparty SsgPayor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsfile_ssg_csrsrecalculation_FileNumber")]
        public IList<MicrosoftDynamicsCRMssgCsrsrecalculation> SsgCsrsfileSsgCsrsrecalculationFileNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsfile_ssg_csrsarchivedcourtfile_FileNumber")]
        public IList<MicrosoftDynamicsCRMssgCsrsarchivedcourtfile> SsgCsrsfileSsgCsrsarchivedcourtfileFileNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsfile_afk_workflowtasks")]
        public IList<MicrosoftDynamicsCRMafkWorkflowtask> SsgCsrsfileAfkWorkflowtasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_BCCourtLocation")]
        public MicrosoftDynamicsCRMssgIjssbccourtlocation SsgBCCourtLocation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_BCCourtLevel")]
        public MicrosoftDynamicsCRMssgCsrsbccourtlevel SsgBCCourtLevel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_DuplicatedFileNumber")]
        public MicrosoftDynamicsCRMssgCsrsfile SsgDuplicatedFileNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsfile_ssg_csrsfile_MasterFileRecord")]
        public IList<MicrosoftDynamicsCRMssgCsrsfile> SsgCsrsfileSsgCsrsfileMasterFileRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_LatestDuplicateFile")]
        public MicrosoftDynamicsCRMssgCsrsfile SsgLatestDuplicateFile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_csrsfile_ssg_csrsfile_LatestDuplicateFile")]
        public IList<MicrosoftDynamicsCRMssgCsrsfile> SsgCsrsfileSsgCsrsfileLatestDuplicateFile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_csrsfile_ssg_csrscommunicationmessage_File")]
        public IList<MicrosoftDynamicsCRMssgCsrscommunicationmessage> SsgSsgCsrsfileSsgCsrscommunicationmessageFile { get; set; }

    }
}