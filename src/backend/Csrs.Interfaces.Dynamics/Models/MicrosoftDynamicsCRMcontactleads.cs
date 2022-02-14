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
    /// Microsoft.Dynamics.CRM.contactleads
    /// </summary>
    public partial class MicrosoftDynamicsCRMcontactleads
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcontactleads
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcontactleads()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcontactleads
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcontactleads(string versionnumber = default(string), string leadid = default(string), int? utcconversiontimezonecode = default(int?), string name = default(string), string contactid = default(string), string contactleadid = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), int? importsequencenumber = default(int?), IList<MicrosoftDynamicsCRMasyncoperation> contactleadsAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> contactleadsMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> contactleadsBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> contactleadsPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>))
        {
            Versionnumber = versionnumber;
            Leadid = leadid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Name = name;
            Contactid = contactid;
            Contactleadid = contactleadid;
            Overriddencreatedon = overriddencreatedon;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Importsequencenumber = importsequencenumber;
            ContactleadsAsyncOperations = contactleadsAsyncOperations;
            ContactleadsMailboxTrackingFolders = contactleadsMailboxTrackingFolders;
            ContactleadsBulkDeleteFailures = contactleadsBulkDeleteFailures;
            ContactleadsPrincipalObjectAttributeAccesses = contactleadsPrincipalObjectAttributeAccesses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "leadid")]
        public string Leadid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactid")]
        public string Contactid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactleadid")]
        public string Contactleadid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactleads_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ContactleadsAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactleads_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ContactleadsMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactleads_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ContactleadsBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactleads_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ContactleadsPrincipalObjectAttributeAccesses { get; set; }

    }
}
