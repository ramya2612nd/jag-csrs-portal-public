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
    /// Microsoft.Dynamics.CRM.contractdetail
    /// </summary>
    public partial class MicrosoftDynamicsCRMcontractdetail
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcontractdetail class.
        /// </summary>
        public MicrosoftDynamicsCRMcontractdetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcontractdetail class.
        /// </summary>
        public MicrosoftDynamicsCRMcontractdetail(int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _uomscheduleidValue = default(string), string _productidValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string versionnumber = default(string), int? allotmentsused = default(int?), int? lineitemorder = default(int?), decimal? discountBase = default(decimal?), int? importsequencenumber = default(int?), int? initialquantity = default(int?), int? servicecontractunitscode = default(int?), string _uomidValue = default(string), decimal? netBase = default(decimal?), decimal? rateBase = default(decimal?), string _modifiedbyValue = default(string), string _createdbyValue = default(string), System.DateTimeOffset? activeon = default(System.DateTimeOffset?), string _owningteamValue = default(string), int? allotmentsremaining = default(int?), string title = default(string), int? statuscode = default(int?), int? contractstatecode = default(int?), string _serviceaddressValue = default(string), int? allotmentsoverage = default(int?), decimal? price = default(decimal?), string effectivitycalendar = default(string), decimal? rate = default(decimal?), string _owningbusinessunitValue = default(string), int? statecode = default(int?), int? totalallotments = default(int?), string _customeridValue = default(string), decimal? net = default(decimal?), string _owneridValue = default(string), int? utcconversiontimezonecode = default(int?), string _transactioncurrencyidValue = default(string), string _createdonbehalfbyValue = default(string), string _contractidValue = default(string), decimal? discountpercentage = default(decimal?), string _owninguserValue = default(string), string _accountidValue = default(string), string contractdetailid = default(string), decimal? priceBase = default(decimal?), string _contactidValue = default(string), decimal? discount = default(decimal?), decimal? exchangerate = default(decimal?), string _modifiedonbehalfbyValue = default(string), string productserialnumber = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.DateTimeOffset? expireson = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMsyncerror> contractDetailSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> contractDetailAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> contractdetailMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> contractDetailProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> contractDetailBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> contractdetailPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMannotation> contractDetailAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), MicrosoftDynamicsCRMaccount customeridAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMcontact customeridContact = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMcontract contractid = default(MicrosoftDynamicsCRMcontract), IList<MicrosoftDynamicsCRMincident> contractDetailCases = default(IList<MicrosoftDynamicsCRMincident>), MicrosoftDynamicsCRMcustomeraddress serviceaddress = default(MicrosoftDynamicsCRMcustomeraddress), MicrosoftDynamicsCRMproduct productid = default(MicrosoftDynamicsCRMproduct), MicrosoftDynamicsCRMuom uomid = default(MicrosoftDynamicsCRMuom), MicrosoftDynamicsCRMuomschedule uomscheduleid = default(MicrosoftDynamicsCRMuomschedule))
        {
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Overriddencreatedon = overriddencreatedon;
            this._uomscheduleidValue = _uomscheduleidValue;
            this._productidValue = _productidValue;
            Modifiedon = modifiedon;
            Versionnumber = versionnumber;
            Allotmentsused = allotmentsused;
            Lineitemorder = lineitemorder;
            DiscountBase = discountBase;
            Importsequencenumber = importsequencenumber;
            Initialquantity = initialquantity;
            Servicecontractunitscode = servicecontractunitscode;
            this._uomidValue = _uomidValue;
            NetBase = netBase;
            RateBase = rateBase;
            this._modifiedbyValue = _modifiedbyValue;
            this._createdbyValue = _createdbyValue;
            Activeon = activeon;
            this._owningteamValue = _owningteamValue;
            Allotmentsremaining = allotmentsremaining;
            Title = title;
            Statuscode = statuscode;
            Contractstatecode = contractstatecode;
            this._serviceaddressValue = _serviceaddressValue;
            Allotmentsoverage = allotmentsoverage;
            Price = price;
            Effectivitycalendar = effectivitycalendar;
            Rate = rate;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Statecode = statecode;
            Totalallotments = totalallotments;
            this._customeridValue = _customeridValue;
            Net = net;
            this._owneridValue = _owneridValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._contractidValue = _contractidValue;
            Discountpercentage = discountpercentage;
            this._owninguserValue = _owninguserValue;
            this._accountidValue = _accountidValue;
            Contractdetailid = contractdetailid;
            PriceBase = priceBase;
            this._contactidValue = _contactidValue;
            Discount = discount;
            Exchangerate = exchangerate;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Productserialnumber = productserialnumber;
            Createdon = createdon;
            Expireson = expireson;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            ContractDetailSyncErrors = contractDetailSyncErrors;
            ContractDetailAsyncOperations = contractDetailAsyncOperations;
            ContractdetailMailboxTrackingFolders = contractdetailMailboxTrackingFolders;
            ContractDetailProcessSessions = contractDetailProcessSessions;
            ContractDetailBulkDeleteFailures = contractDetailBulkDeleteFailures;
            ContractdetailPrincipalobjectattributeaccess = contractdetailPrincipalobjectattributeaccess;
            Transactioncurrencyid = transactioncurrencyid;
            ContractDetailAnnotation = contractDetailAnnotation;
            CustomeridAccount = customeridAccount;
            CustomeridContact = customeridContact;
            Contractid = contractid;
            ContractDetailCases = contractDetailCases;
            Serviceaddress = serviceaddress;
            Productid = productid;
            Uomid = uomid;
            Uomscheduleid = uomscheduleid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_uomscheduleid_value")]
        public string _uomscheduleidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_productid_value")]
        public string _productidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allotmentsused")]
        public int? Allotmentsused { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lineitemorder")]
        public int? Lineitemorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discount_base")]
        public decimal? DiscountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "initialquantity")]
        public int? Initialquantity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "servicecontractunitscode")]
        public int? Servicecontractunitscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_uomid_value")]
        public string _uomidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "net_base")]
        public decimal? NetBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rate_base")]
        public decimal? RateBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activeon")]
        public System.DateTimeOffset? Activeon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allotmentsremaining")]
        public int? Allotmentsremaining { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contractstatecode")]
        public int? Contractstatecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_serviceaddress_value")]
        public string _serviceaddressValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allotmentsoverage")]
        public int? Allotmentsoverage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price")]
        public decimal? Price { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effectivitycalendar")]
        public string Effectivitycalendar { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rate")]
        public decimal? Rate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalallotments")]
        public int? Totalallotments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_customerid_value")]
        public string _customeridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "net")]
        public decimal? Net { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_contractid_value")]
        public string _contractidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discountpercentage")]
        public decimal? Discountpercentage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_accountid_value")]
        public string _accountidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contractdetailid")]
        public string Contractdetailid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price_base")]
        public decimal? PriceBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_contactid_value")]
        public string _contactidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discount")]
        public decimal? Discount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productserialnumber")]
        public string Productserialnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expireson")]
        public System.DateTimeOffset? Expireson { get; set; }

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
        [JsonProperty(PropertyName = "ContractDetail_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ContractDetailSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContractDetail_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ContractDetailAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contractdetail_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ContractdetailMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContractDetail_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> ContractDetailProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContractDetail_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ContractDetailBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contractdetail_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ContractdetailPrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContractDetail_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> ContractDetailAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customerid_account")]
        public MicrosoftDynamicsCRMaccount CustomeridAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customerid_contact")]
        public MicrosoftDynamicsCRMcontact CustomeridContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contractid")]
        public MicrosoftDynamicsCRMcontract Contractid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contract_detail_cases")]
        public IList<MicrosoftDynamicsCRMincident> ContractDetailCases { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceaddress")]
        public MicrosoftDynamicsCRMcustomeraddress Serviceaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productid")]
        public MicrosoftDynamicsCRMproduct Productid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uomid")]
        public MicrosoftDynamicsCRMuom Uomid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uomscheduleid")]
        public MicrosoftDynamicsCRMuomschedule Uomscheduleid { get; set; }

    }
}
