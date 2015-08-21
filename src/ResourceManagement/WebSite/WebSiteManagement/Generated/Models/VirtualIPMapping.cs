// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Class that represents a VIP mapping
    /// </summary>
    public partial class VirtualIPMapping
    {
        /// <summary>
        /// Virtual IP address
        /// </summary>
        [JsonProperty(PropertyName = "virtualIP")]
        public string VirtualIP { get; set; }

        /// <summary>
        /// Internal HTTP port
        /// </summary>
        [JsonProperty(PropertyName = "internalHttpPort")]
        public int? InternalHttpPort { get; set; }

        /// <summary>
        /// Internal HTTPS port
        /// </summary>
        [JsonProperty(PropertyName = "internalHttpsPort")]
        public int? InternalHttpsPort { get; set; }

        /// <summary>
        /// Is VIP mapping in use
        /// </summary>
        [JsonProperty(PropertyName = "inUse")]
        public bool? InUse { get; set; }

    }
}