// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Version2016_09_01.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Resource name availability request content.
    /// </summary>
    public partial class ResourceNameAvailabilityRequest
    {
        /// <summary>
        /// Initializes a new instance of the ResourceNameAvailabilityRequest
        /// class.
        /// </summary>
        public ResourceNameAvailabilityRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceNameAvailabilityRequest
        /// class.
        /// </summary>
        /// <param name="name">Resource name to verify.</param>
        /// <param name="type">Resource type used for verification. Possible
        /// values include: 'Site', 'Slot', 'HostingEnvironment',
        /// 'PublishingUser', 'Microsoft.Web/sites',
        /// 'Microsoft.Web/sites/slots', 'Microsoft.Web/hostingEnvironments',
        /// 'Microsoft.Web/publishingUsers'</param>
        /// <param name="isFqdn">Is fully qualified domain name.</param>
        public ResourceNameAvailabilityRequest(string name, string type, bool? isFqdn = default(bool?))
        {
            Name = name;
            Type = type;
            IsFqdn = isFqdn;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource name to verify.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets resource type used for verification. Possible values
        /// include: 'Site', 'Slot', 'HostingEnvironment', 'PublishingUser',
        /// 'Microsoft.Web/sites', 'Microsoft.Web/sites/slots',
        /// 'Microsoft.Web/hostingEnvironments',
        /// 'Microsoft.Web/publishingUsers'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets is fully qualified domain name.
        /// </summary>
        [JsonProperty(PropertyName = "isFqdn")]
        public bool? IsFqdn { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
        }
    }
}
