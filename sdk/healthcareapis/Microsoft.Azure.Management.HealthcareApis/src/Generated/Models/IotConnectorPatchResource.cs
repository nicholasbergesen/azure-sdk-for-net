// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HealthcareApis.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Iot Connector patch properties
    /// </summary>
    public partial class IotConnectorPatchResource
    {
        /// <summary>
        /// Initializes a new instance of the IotConnectorPatchResource class.
        /// </summary>
        public IotConnectorPatchResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IotConnectorPatchResource class.
        /// </summary>
        /// <param name="tags">Resource tags.</param>
        /// <param name="identity">Setting indicating whether the service has a
        /// managed identity associated with it.</param>
        public IotConnectorPatchResource(IDictionary<string, string> tags = default(IDictionary<string, string>), ServiceManagedIdentityIdentity identity = default(ServiceManagedIdentityIdentity))
        {
            Tags = tags;
            Identity = identity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets setting indicating whether the service has a managed
        /// identity associated with it.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public ServiceManagedIdentityIdentity Identity { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Identity != null)
            {
                Identity.Validate();
            }
        }
    }
}
