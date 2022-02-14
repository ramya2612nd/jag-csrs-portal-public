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
    /// Microsoft.Dynamics.CRM.tracelog
    /// </summary>
    public partial class MicrosoftDynamicsCRMtracelog
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMtracelog
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMtracelog()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMtracelog
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMtracelog(bool? canbedeleted = default(bool?), int? collationlevel = default(int?), string traceparameterxml = default(string), int? timezoneruleversionnumber = default(int?), int? traceparameterhash = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string text = default(string), string _regardingobjectowningbusinessunitValue = default(string), int? level = default(int?), string tracedetailxml = default(string), int? utcconversiontimezonecode = default(int?), string _createdonbehalfbyValue = default(string), string _organizationidValue = default(string), int? tracecode = default(int?), string _createdbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string errortypedisplay = default(string), string _modifiedbyValue = default(string), string errordetails = default(string), string tracelogid = default(string), string traceactionxml = default(string), string machinename = default(string), bool? isunique = default(bool?), string _modifiedonbehalfbyValue = default(string), string _regardingobjectidValue = default(string), string _regardingobjectowneridValue = default(string), bool? tracestatus = default(bool?), string _parenttracelogidValue = default(string), MicrosoftDynamicsCRMmailbox regardingobjectidMailbox = default(MicrosoftDynamicsCRMmailbox), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtracelog parenttracelogid = default(MicrosoftDynamicsCRMtracelog), IList<MicrosoftDynamicsCRMtracelog> tracelogParentTracelog = default(IList<MicrosoftDynamicsCRMtracelog>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMemailserverprofile regardingobjectidEmailserverprofile = default(MicrosoftDynamicsCRMemailserverprofile))
        {
            Canbedeleted = canbedeleted;
            Collationlevel = collationlevel;
            Traceparameterxml = traceparameterxml;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Traceparameterhash = traceparameterhash;
            Createdon = createdon;
            Text = text;
            this._regardingobjectowningbusinessunitValue = _regardingobjectowningbusinessunitValue;
            Level = level;
            Tracedetailxml = tracedetailxml;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._organizationidValue = _organizationidValue;
            Tracecode = tracecode;
            this._createdbyValue = _createdbyValue;
            Modifiedon = modifiedon;
            Errortypedisplay = errortypedisplay;
            this._modifiedbyValue = _modifiedbyValue;
            Errordetails = errordetails;
            Tracelogid = tracelogid;
            Traceactionxml = traceactionxml;
            Machinename = machinename;
            Isunique = isunique;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._regardingobjectidValue = _regardingobjectidValue;
            this._regardingobjectowneridValue = _regardingobjectowneridValue;
            Tracestatus = tracestatus;
            this._parenttracelogidValue = _parenttracelogidValue;
            RegardingobjectidMailbox = regardingobjectidMailbox;
            Createdby = createdby;
            Modifiedby = modifiedby;
            Parenttracelogid = parenttracelogid;
            TracelogParentTracelog = tracelogParentTracelog;
            Createdonbehalfby = createdonbehalfby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            RegardingobjectidEmailserverprofile = regardingobjectidEmailserverprofile;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "canbedeleted")]
        public bool? Canbedeleted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "collationlevel")]
        public int? Collationlevel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traceparameterxml")]
        public string Traceparameterxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traceparameterhash")]
        public int? Traceparameterhash { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectowningbusinessunit_value")]
        public string _regardingobjectowningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public int? Level { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tracedetailxml")]
        public string Tracedetailxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tracecode")]
        public int? Tracecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errortypedisplay")]
        public string Errortypedisplay { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errordetails")]
        public string Errordetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tracelogid")]
        public string Tracelogid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traceactionxml")]
        public string Traceactionxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "machinename")]
        public string Machinename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isunique")]
        public bool? Isunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectid_value")]
        public string _regardingobjectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectownerid_value")]
        public string _regardingobjectowneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tracestatus")]
        public bool? Tracestatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parenttracelogid_value")]
        public string _parenttracelogidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_mailbox")]
        public MicrosoftDynamicsCRMmailbox RegardingobjectidMailbox { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parenttracelogid")]
        public MicrosoftDynamicsCRMtracelog Parenttracelogid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tracelog_parent_tracelog")]
        public IList<MicrosoftDynamicsCRMtracelog> TracelogParentTracelog { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_emailserverprofile")]
        public MicrosoftDynamicsCRMemailserverprofile RegardingobjectidEmailserverprofile { get; set; }

    }
}
