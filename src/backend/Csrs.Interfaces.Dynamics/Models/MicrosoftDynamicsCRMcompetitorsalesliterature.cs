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
    /// Microsoft.Dynamics.CRM.competitorsalesliterature
    /// </summary>
    public partial class MicrosoftDynamicsCRMcompetitorsalesliterature
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcompetitorsalesliterature class.
        /// </summary>
        public MicrosoftDynamicsCRMcompetitorsalesliterature()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcompetitorsalesliterature class.
        /// </summary>
        public MicrosoftDynamicsCRMcompetitorsalesliterature(string competitorsalesliteratureid = default(string), string name = default(string), int? importsequencenumber = default(int?), string competitorid = default(string), string versionnumber = default(string), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), string salesliteratureid = default(string), IList<MicrosoftDynamicsCRMasyncoperation> competitorsalesliteratureAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> competitorsalesliteratureMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> competitorsalesliteratureBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> competitorsalesliteraturePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>))
        {
            Competitorsalesliteratureid = competitorsalesliteratureid;
            Name = name;
            Importsequencenumber = importsequencenumber;
            Competitorid = competitorid;
            Versionnumber = versionnumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Overriddencreatedon = overriddencreatedon;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Salesliteratureid = salesliteratureid;
            CompetitorsalesliteratureAsyncOperations = competitorsalesliteratureAsyncOperations;
            CompetitorsalesliteratureMailboxTrackingFolders = competitorsalesliteratureMailboxTrackingFolders;
            CompetitorsalesliteratureBulkDeleteFailures = competitorsalesliteratureBulkDeleteFailures;
            CompetitorsalesliteraturePrincipalObjectAttributeAccesses = competitorsalesliteraturePrincipalObjectAttributeAccesses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitorsalesliteratureid")]
        public string Competitorsalesliteratureid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitorid")]
        public string Competitorid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

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
        [JsonProperty(PropertyName = "salesliteratureid")]
        public string Salesliteratureid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitorsalesliterature_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> CompetitorsalesliteratureAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitorsalesliterature_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> CompetitorsalesliteratureMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitorsalesliterature_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> CompetitorsalesliteratureBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitorsalesliterature_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> CompetitorsalesliteraturePrincipalObjectAttributeAccesses { get; set; }

    }
}
