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
    /// Collection of ssg_csrsfile
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.ssg_csrsfileCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMssgCsrsfileCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgCsrsfileCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMssgCsrsfileCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgCsrsfileCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMssgCsrsfileCollection(IList<MicrosoftDynamicsCRMssgCsrsfile> value = default(IList<MicrosoftDynamicsCRMssgCsrsfile>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<MicrosoftDynamicsCRMssgCsrsfile> Value { get; set; }

    }
}