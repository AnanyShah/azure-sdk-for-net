// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.FrontDoor.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Load balancing settings for a backend pool
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class HealthProbeSettingsModel : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the HealthProbeSettingsModel class.
        /// </summary>
        public HealthProbeSettingsModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HealthProbeSettingsModel class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="path">The path to use for the health probe. Default is
        /// /</param>
        /// <param name="protocol">Protocol scheme to use for this probe.
        /// Possible values include: 'Http', 'Https'</param>
        /// <param name="intervalInSeconds">The number of seconds between
        /// health probes.</param>
        /// <param name="resourceState">Resource status. Possible values
        /// include: 'Creating', 'Enabling', 'Enabled', 'Disabling',
        /// 'Disabled', 'Deleting'</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        public HealthProbeSettingsModel(string id = default(string), string path = default(string), string protocol = default(string), int? intervalInSeconds = default(int?), string resourceState = default(string), string name = default(string), string type = default(string))
            : base(id)
        {
            Path = path;
            Protocol = protocol;
            IntervalInSeconds = intervalInSeconds;
            ResourceState = resourceState;
            Name = name;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the path to use for the health probe. Default is /
        /// </summary>
        [JsonProperty(PropertyName = "properties.path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets protocol scheme to use for this probe. Possible values
        /// include: 'Http', 'Https'
        /// </summary>
        [JsonProperty(PropertyName = "properties.protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets the number of seconds between health probes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.intervalInSeconds")]
        public int? IntervalInSeconds { get; set; }

        /// <summary>
        /// Gets or sets resource status. Possible values include: 'Creating',
        /// 'Enabling', 'Enabled', 'Disabling', 'Disabled', 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceState")]
        public string ResourceState { get; set; }

        /// <summary>
        /// Gets or sets resource name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

    }
}
